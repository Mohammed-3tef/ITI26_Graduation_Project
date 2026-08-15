namespace Mazeed.BLL.Responses
{
    public class ServiceResponse<T>
    {
        public bool Succeeded { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }

        public static ServiceResponse<T> SuccessResponse(T data, string? message = null)
        {
            return new ServiceResponse<T>
            {
                Succeeded = true,
                Message = message ?? "Request successful",
                Data = data
            };
        }

        public static ServiceResponse<T> FailureResponse(string message)
        {
            return new ServiceResponse<T>
            {
                Succeeded = false,
                Message = message
            };
        }
    }
}
