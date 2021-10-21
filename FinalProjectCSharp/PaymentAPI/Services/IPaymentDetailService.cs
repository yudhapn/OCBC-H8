using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PaymentAPI.Models;

namespace PaymentAPI.Services
{
    public interface IPaymentDetailService
    {
        public Task<List<PaymentDetail>> GetPaymentDetails();

        public Task<PaymentDetail> GetPaymentDetailById(int paymentDetailId);
        public Task<int> CreatePaymentDetail(PaymentDetail data);
        public Task<int> UpdatePaymentDetail(int id, PaymentDetail paymentDetail);
        public Task<int> DeletePaymentDetail(PaymentDetail existPaymentDetail);
    }
}
