using Mazeed.BLL.Responses;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;

namespace Mazeed.BLL.Services.Implementation
{
    public class DiscountService : IDiscountService
    {
        private static readonly string[] ValidDiscountTypes = { "Percentage", "Fixed" };

        private readonly IUnitOfWork _unitOfWork;
        private readonly IDiscountRuleRepository _discountRuleRepository;

        public DiscountService(IUnitOfWork unitOfWork, IDiscountRuleRepository discountRuleRepository)
        {
            _unitOfWork = unitOfWork;
            _discountRuleRepository = discountRuleRepository;
        }

        public async Task<ServiceResponse<IEnumerable<DiscountRuleVM>>> GetAllDiscountRulesAsync()
        {
            var rules = await _unitOfWork.Repository<DiscountRule>().GetAllAsync();
            var vms = rules.Where(r => !r.IsDeleted).Select(MapToVM);

            return ServiceResponse<IEnumerable<DiscountRuleVM>>.SuccessResponse(vms, "Discount rules retrieved successfully.");
        }

        public async Task<ServiceResponse<DiscountRuleVM>> GetDiscountRuleByIdAsync(long id)
        {
            var rule = await _unitOfWork.Repository<DiscountRule>().GetByIdAsync(id);
            if (rule == null || rule.IsDeleted)
                return ServiceResponse<DiscountRuleVM>.FailureResponse("Discount rule not found.");

            return ServiceResponse<DiscountRuleVM>.SuccessResponse(MapToVM(rule), "Discount rule retrieved successfully.");
        }

        public async Task<ServiceResponse<DiscountRuleVM>> CreateDiscountRuleAsync(CreateDiscountRuleVM model, string createdBy)
        {
            if (!ValidDiscountTypes.Contains(model.DiscountType))
                return ServiceResponse<DiscountRuleVM>.FailureResponse("DiscountType must be 'Percentage' or 'Fixed'.");

            if (model.EndDate <= model.StartDate)
                return ServiceResponse<DiscountRuleVM>.FailureResponse("EndDate must be after StartDate.");

            if (!string.IsNullOrWhiteSpace(model.PromotionCode))
            {
                var existingCode = await _discountRuleRepository.GetByPromoCodeAsync(model.PromotionCode);
                if (existingCode != null)
                    return ServiceResponse<DiscountRuleVM>.FailureResponse("This promotion code is already in use.");
            }

            var rule = new DiscountRule
            {
                DiscountType = model.DiscountType,
                DiscountValue = model.DiscountValue,
                SpendThreshold = model.SpendThreshold,
                PromotionCode = model.PromotionCode,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                IsActive = model.IsActive,
                CreatedBy = createdBy
            };

            await _unitOfWork.Repository<DiscountRule>().AddAsync(rule);
            await _unitOfWork.CompleteAsync();

            return ServiceResponse<DiscountRuleVM>.SuccessResponse(MapToVM(rule), "Discount rule created successfully.");
        }

        public async Task<ServiceResponse<DiscountRuleVM>> UpdateDiscountRuleAsync(long id, UpdateDiscountRuleVM model, string updatedBy)
        {
            var rule = await _unitOfWork.Repository<DiscountRule>().GetByIdAsync(id);
            if (rule == null || rule.IsDeleted)
                return ServiceResponse<DiscountRuleVM>.FailureResponse("Discount rule not found.");

            if (model.DiscountType != null && !ValidDiscountTypes.Contains(model.DiscountType))
                return ServiceResponse<DiscountRuleVM>.FailureResponse("DiscountType must be 'Percentage' or 'Fixed'.");

            if (!string.IsNullOrWhiteSpace(model.PromotionCode) &&
                !string.Equals(model.PromotionCode, rule.PromotionCode, StringComparison.OrdinalIgnoreCase))
            {
                var existingCode = await _discountRuleRepository.GetByPromoCodeAsync(model.PromotionCode);
                if (existingCode != null && existingCode.Id != id)
                    return ServiceResponse<DiscountRuleVM>.FailureResponse("This promotion code is already in use.");
            }

            rule.DiscountType = model.DiscountType ?? rule.DiscountType;
            rule.DiscountValue = model.DiscountValue ?? rule.DiscountValue;
            rule.SpendThreshold = model.SpendThreshold ?? rule.SpendThreshold;
            rule.PromotionCode = model.PromotionCode ?? rule.PromotionCode;
            rule.StartDate = model.StartDate ?? rule.StartDate;
            rule.EndDate = model.EndDate ?? rule.EndDate;
            rule.IsActive = model.IsActive ?? rule.IsActive;
            rule.UpdatedBy = updatedBy;
            rule.UpdatedAt = DateTime.UtcNow;

            if (rule.EndDate <= rule.StartDate)
                return ServiceResponse<DiscountRuleVM>.FailureResponse("EndDate must be after StartDate.");

            _unitOfWork.Repository<DiscountRule>().Update(rule);
            await _unitOfWork.CompleteAsync();

            return ServiceResponse<DiscountRuleVM>.SuccessResponse(MapToVM(rule), "Discount rule updated successfully.");
        }

        public async Task<ServiceResponse<bool>> DeleteDiscountRuleAsync(long id, string deletedBy)
        {
            var rule = await _unitOfWork.Repository<DiscountRule>().GetByIdAsync(id);
            if (rule == null || rule.IsDeleted)
                return ServiceResponse<bool>.FailureResponse("Discount rule not found.");

            rule.IsDeleted = true;
            rule.DeletedBy = deletedBy;
            rule.DeletedAt = DateTime.UtcNow;

            _unitOfWork.Repository<DiscountRule>().Update(rule);
            await _unitOfWork.CompleteAsync();

            return ServiceResponse<bool>.SuccessResponse(true, "Discount rule deleted successfully.");
        }

        public async Task<ServiceResponse<DiscountResultVM>> ValidateAndApplyAsync(ApplyPromoCodeVM model)
        {
            if (model.CartSubtotal <= 0)
                return ServiceResponse<DiscountResultVM>.FailureResponse("Cart subtotal must be greater than 0.");

            var now = DateTime.UtcNow;

            if (!string.IsNullOrWhiteSpace(model.PromotionCode))
            {
                var rule = await _discountRuleRepository.GetByPromoCodeAsync(model.PromotionCode);

                if (rule == null || !rule.IsActive)
                    return ServiceResponse<DiscountResultVM>.FailureResponse("Invalid or inactive promo code.");

                if (now < rule.StartDate || now > rule.EndDate)
                    return ServiceResponse<DiscountResultVM>.FailureResponse("This promo code is not currently valid.");

                if (rule.SpendThreshold.HasValue && model.CartSubtotal < rule.SpendThreshold.Value)
                    return ServiceResponse<DiscountResultVM>.FailureResponse(
                        $"Spend at least {rule.SpendThreshold.Value:0.00} to use this code.");

                return ServiceResponse<DiscountResultVM>.SuccessResponse(
                    BuildResult(rule, model.CartSubtotal), "Promo code applied successfully.");
            }

            // No code provided — look for the best automatic spend-threshold discount.
            var autoRules = await _discountRuleRepository.GetActiveAutoDiscountsAsync(now);
            var eligible = autoRules
                .Where(r => r.SpendThreshold.HasValue && model.CartSubtotal >= r.SpendThreshold.Value)
                .ToList();

            if (!eligible.Any())
                return ServiceResponse<DiscountResultVM>.SuccessResponse(
                    new DiscountResultVM
                    {
                        Applied = false,
                        DiscountAmount = 0,
                        Subtotal = model.CartSubtotal,
                        FinalTotal = model.CartSubtotal,
                        Message = "No discount applied."
                    }, "No eligible discount found.");

            var best = eligible
                .Select(r => new { Rule = r, Amount = ComputeDiscountAmount(r, model.CartSubtotal) })
                .OrderByDescending(x => x.Amount)
                .First();

            return ServiceResponse<DiscountResultVM>.SuccessResponse(
                BuildResult(best.Rule, model.CartSubtotal), "Discount applied automatically.");
        }

        private static decimal ComputeDiscountAmount(DiscountRule rule, decimal subtotal)
        {
            var amount = rule.DiscountType.Equals("Percentage", StringComparison.OrdinalIgnoreCase)
                ? Math.Round(subtotal * (rule.DiscountValue / 100m), 2)
                : rule.DiscountValue;

            return Math.Min(amount, subtotal);
        }

        private static DiscountResultVM BuildResult(DiscountRule rule, decimal subtotal)
        {
            var discountAmount = ComputeDiscountAmount(rule, subtotal);

            return new DiscountResultVM
            {
                Applied = true,
                DiscountRuleId = rule.Id,
                PromotionCode = rule.PromotionCode,
                DiscountType = rule.DiscountType,
                DiscountValue = rule.DiscountValue,
                DiscountAmount = discountAmount,
                Subtotal = subtotal,
                FinalTotal = subtotal - discountAmount,
                Message = "Discount applied."
            };
        }

        private static DiscountRuleVM MapToVM(DiscountRule rule)
        {
            return new DiscountRuleVM
            {
                Id = rule.Id,
                DiscountType = rule.DiscountType,
                DiscountValue = rule.DiscountValue,
                SpendThreshold = rule.SpendThreshold,
                PromotionCode = rule.PromotionCode,
                StartDate = rule.StartDate,
                EndDate = rule.EndDate,
                IsActive = rule.IsActive
            };
        }
    }
}