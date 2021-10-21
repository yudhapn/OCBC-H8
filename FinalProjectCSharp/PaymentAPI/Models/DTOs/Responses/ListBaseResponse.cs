using System.Collections.Generic;

namespace PaymentAPI.Models.DTOs.Responses
{
    public class ListBaseResponse
    {
        public bool status { get; set; }
        public string message { get; set; }
        public List<PaymentDetail> data { get; set; }

    }
}
