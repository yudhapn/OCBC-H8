namespace PaymentAPI.Models.DTOs.Responses
{
    public class BaseResponse
    {
        public bool status { get; set; }
        public string message { get; set; }
        public PaymentDetail data { get; set; }

    }
}
