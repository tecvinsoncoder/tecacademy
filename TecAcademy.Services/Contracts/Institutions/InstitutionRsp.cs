namespace TecAcademy.Services.Contracts.Institutions
{
    public class InstitutionRsp<T> : BaseResponse
    {
        public T? Result {set; get;}
    }
}