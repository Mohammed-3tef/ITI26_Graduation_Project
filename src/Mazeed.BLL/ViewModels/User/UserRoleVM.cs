namespace Mazeed.BLL.ViewModels.User
{
    public class UserRoleVM
    {
        public string UserId { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public List<string> AssignedRoles { get; set; } = new();
        public List<string> AllRoles { get; set; } = new();
    }
}
