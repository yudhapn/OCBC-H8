using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using PaymentAPI.Models;
using PaymentAPI.Models.DTOs.Responses;
using PaymentAPI.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace PaymentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PaymentDetailController : ControllerBase
    {
        private readonly IPaymentDetailService _service;

        #region Constructor
        public PaymentDetailController(IPaymentDetailService service)
        {
            _service = service;
        }
        #endregion

        [HttpGet]
        public async Task<IActionResult> GetPaymentDetails()
        {
            var paymentDetails = await _service.GetPaymentDetails();
            return Ok(new ListBaseResponse() { 
                status = true,
                message = "Success!",
                data = paymentDetails
            });
        }

        [HttpPost]
        public async Task<IActionResult> CreatePaymentDetail(PaymentDetail data)
        {
            if (ModelState.IsValid)
            {
                var result = await _service.CreatePaymentDetail(data);
                if (result > 0)
                {
                    return CreatedAtAction(nameof(GetPaymentDetailById), new { data.paymentDetailId }, data);
                }
            }
            return new JsonResult("Something went wrong") { StatusCode = StatusCodes.Status500InternalServerError };
        }

        [HttpGet("{paymentDetailId}")]
        public async Task<IActionResult> GetPaymentDetailById(int paymentDetailId)
        {
            var paymentDetail = await _service.GetPaymentDetailById(paymentDetailId);

            if (paymentDetail == null)
            {
                return NotFound(new BaseResponse()
                {
                    status = false,
                    message = $"Failed! id: {paymentDetailId} is not found!",
                    data = null
                });
            }
            return Ok(new BaseResponse()
            {
                status = true,
                message = "Success!",
                data = paymentDetail
            }); ;
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePaymentDetail(int id, PaymentDetail paymentDetail) { 
            if (id != paymentDetail.paymentDetailId)
            {
                return BadRequest(new BaseResponse()
                {
                    status = false,
                    message = $"Update failed! param id: {id} and body id: {paymentDetail.paymentDetailId} is not match",
                    data = null
                });
            }

            var result = await _service.UpdatePaymentDetail(id, paymentDetail);
            if (result > 0)
                {
                return NoContent();
            }
            return new JsonResult("Something went wrong") { StatusCode = StatusCodes.Status500InternalServerError };
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaymentDetail(int id) {
            var existPaymentDetail = await _service.GetPaymentDetailById(id);

            if (existPaymentDetail == null)
            {
                return NotFound(new BaseResponse()
                {
                    status = false,
                    message = $"Failed! id: {id} is not found!",
                    data = null
                });
            }

            var result = await _service.DeletePaymentDetail(existPaymentDetail);
            if (result > 0)
            {
                return Ok(new BaseResponse()
                {
                    status = true,
                    message = "Success! Data has been deleted!",
                    data = existPaymentDetail
                });
            }
            return new JsonResult("Something went wrong") { StatusCode = StatusCodes.Status500InternalServerError };
        }
    }
}
