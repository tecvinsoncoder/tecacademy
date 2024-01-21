namespace TecAcademy.Services.Contracts
{
    public class BaseResponse
    {
        public string Code { set; get; } = string.Empty;
        public string? Messgae { set; get; }
    }
}
