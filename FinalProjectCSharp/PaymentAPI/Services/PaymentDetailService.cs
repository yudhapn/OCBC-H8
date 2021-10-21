using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PaymentAPI.Models;
using PaymentAPI.Data;

namespace PaymentAPI.Services
{
    public class PaymentDetailService : IPaymentDetailService
    {
        #region Property
        private readonly PaymentApiDbContext _context;
        #endregion
        
        public PaymentDetailService(PaymentApiDbContext context)
        {
            _context = context;
        }

        #region Property
        public async Task<List<PaymentDetail>> GetPaymentDetails()
        {
            var paymentDetails = await _context.PaymentDetails.ToListAsync();
            return paymentDetails;
        }
        #endregion
        public async Task<PaymentDetail> GetPaymentDetailById(int paymentDetailId)
        {
            var paymentDetail = await _context.PaymentDetails.FirstOrDefaultAsync(x => x.paymentDetailId == paymentDetailId);
            return paymentDetail;
        }
        public async Task<int> CreatePaymentDetail(PaymentDetail data)
        {
            await _context.PaymentDetails.AddAsync(data);
            var result = await _context.SaveChangesAsync();
            return result;
        }
        
        public async Task<int> UpdatePaymentDetail(int id, PaymentDetail paymentDetail)
        {
            var existPaymentDetail = await _context.PaymentDetails.FirstOrDefaultAsync(paymentDetail => paymentDetail.paymentDetailId == id);

            existPaymentDetail.cardOwnerName = paymentDetail.cardOwnerName;
            existPaymentDetail.cardNumber = paymentDetail.cardNumber;
            existPaymentDetail.expirationDate = paymentDetail.expirationDate;
            existPaymentDetail.securityCode = paymentDetail.securityCode;

            var result = await _context.SaveChangesAsync();
            return result;
        }

        public async Task<int> DeletePaymentDetail(PaymentDetail existPaymentDetail)
        {
            _context.PaymentDetails.Remove(existPaymentDetail);
            var result = await _context.SaveChangesAsync();
            return result;
        }

    }
}
