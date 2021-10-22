using Moq;
using System.Collections.Generic;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using PaymentAPI.Services;
using PaymentAPI.Models;
using PaymentAPI.Controllers;
using PaymentAPI.Models.DTOs.Responses;

namespace PaymentUnitTesting
{
    public class UnitTest1
    {
        #region Property
        private Mock<IPaymentDetailService> mock = new Mock<IPaymentDetailService>();
        #endregion
        private List<PaymentDetail> list = new List<PaymentDetail>();
        private PaymentDetail paymentDetail;

        public static void Main(string[] args) { }

        private void initPaymentDetailList()
        {
            list.Add(new PaymentDetail() {
                paymentDetailId = 1,
                cardOwnerName = "testing",
                cardNumber = "testing",
                expirationDate = "testing",
                securityCode = "testing"
            });
        }

        private void initPaymentDetail() {
            paymentDetail = new PaymentDetail() { 
                paymentDetailId= 1,
                cardOwnerName = "testing", 
                cardNumber = "testing",
                expirationDate = "testing",
                securityCode = "testing" 
            };
        }

        [Fact]
        public async void GetPaymentDetails_Not_Null()
        {
            // Arrange
            initPaymentDetailList();
            mock.Setup(p => p.GetPaymentDetails()).ReturnsAsync(list);
            PaymentDetailController controller = new PaymentDetailController(mock.Object);

            // Act
            var result = await controller.GetPaymentDetails();

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async void GetPaymentDetails_Is_Result_Ok()
        {
            // Arrange
            initPaymentDetailList();
            mock.Setup(p => p.GetPaymentDetails()).ReturnsAsync(list);
            PaymentDetailController controller = new PaymentDetailController(mock.Object);

            // Act
            var result = await controller.GetPaymentDetails();
            var objectResult = result as ObjectResult;

            // Assert
            Assert.Equal(objectResult.StatusCode, StatusCodes.Status200OK);
        }

        [Fact]
        public async void GetPaymentDetails_Is_Equals_Expected_Result()
        {
            // Arrange
            initPaymentDetailList();
            mock.Setup(p => p.GetPaymentDetails()).ReturnsAsync(list);
            PaymentDetailController controller = new PaymentDetailController(mock.Object);

            // Act
            var result = await controller.GetPaymentDetails();
            var objectResult = result as ObjectResult;

            // Assert
            Assert.Equal(list, (objectResult.Value as ListBaseResponse).data);
        }

        [Fact]
        public async void GetPaymentDetailById_Not_Null()
        {
            // Arrange
            initPaymentDetail();
            mock.Setup(p => p.GetPaymentDetailById(1)).ReturnsAsync(paymentDetail);
            PaymentDetailController controller = new PaymentDetailController(mock.Object);

            // Act
            var result = await controller.GetPaymentDetailById(1);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async void GetPaymentDetailById_Is_Result_Ok()
        {
            // Arrange
            initPaymentDetail();
            mock.Setup(p => p.GetPaymentDetailById(1)).ReturnsAsync(paymentDetail);
            PaymentDetailController controller = new PaymentDetailController(mock.Object);

            // Act
            var result = await controller.GetPaymentDetailById(1);
            var objectResult = result as ObjectResult;

            // Assert
            Assert.Equal(objectResult.StatusCode, StatusCodes.Status200OK);
        }

        [Fact]
        public async void GetPaymentDetailById_Is_Equals_Expected_Result()
        {
            // Arrange
            initPaymentDetail();
            mock.Setup(p => p.GetPaymentDetailById(1)).ReturnsAsync(paymentDetail);
            PaymentDetailController controller = new PaymentDetailController(mock.Object);

            // Act
            var result = await controller.GetPaymentDetailById(1);
            var objectResult = result as ObjectResult;

            // Assert
            Assert.Equal(paymentDetail, (objectResult.Value as BaseResponse).data);
        }

        [Fact]
        public async void GetPaymentDetailById_Is_Result_Not_Found()
        {
            // Arrange
            initPaymentDetail();
            mock.Setup(p => p.GetPaymentDetailById(1)).ReturnsAsync(paymentDetail);
            PaymentDetailController controller = new PaymentDetailController(mock.Object);

            // Act
            var result = await controller.GetPaymentDetailById(3);
            var objectResult = result as ObjectResult;

            // Assert
            Assert.Equal(objectResult.StatusCode, StatusCodes.Status404NotFound);
        }

        [Fact]
        public async void CreatePaymentDetail_Is_Result_Created()
        {
            // Arrange
            initPaymentDetail();
            mock.Setup(p => p.CreatePaymentDetail(paymentDetail)).ReturnsAsync(1);
            PaymentDetailController controller = new PaymentDetailController(mock.Object);

            // Act
            var result = await controller.CreatePaymentDetail(paymentDetail);
            var createdAtActionResult = result as CreatedAtActionResult;

            // Assert
            Assert.Equal(createdAtActionResult.StatusCode, StatusCodes.Status201Created);
        }

        [Fact]
        public async void CreatePaymentDetail_Is_Equals_Expected_Result()
        {
            // Arrange
            initPaymentDetail();
            mock.Setup(p => p.CreatePaymentDetail(paymentDetail)).ReturnsAsync(1);
            PaymentDetailController controller = new PaymentDetailController(mock.Object);

            // Act
            var result = await controller.CreatePaymentDetail(paymentDetail);
            var createdAtActionResult = result as CreatedAtActionResult;

            // Assert
            Assert.Equal(paymentDetail, createdAtActionResult.Value);
        }

        [Fact]
        public async void UpdatePaymentDetail_Is_Result_Resource_Updated()
        {
            // Arrange
            initPaymentDetail();
            mock.Setup(p => p.UpdatePaymentDetail(1, paymentDetail)).ReturnsAsync(1);
            PaymentDetailController controller = new PaymentDetailController(mock.Object);

            // Act
            var result = await controller.UpdatePaymentDetail(1, paymentDetail);
            var statusCodeResult = result as StatusCodeResult;

            // Assert
            Assert.Equal(statusCodeResult.StatusCode, StatusCodes.Status204NoContent);
        }

        [Fact]
        public async void UpdatePaymentDetail_Is_Result_Bad_Request_ParamId_And_BodyId_Not_Same()
        {
            // Arrange
            initPaymentDetail();
            mock.Setup(p => p.UpdatePaymentDetail(3, paymentDetail)).ReturnsAsync(1);
            PaymentDetailController controller = new PaymentDetailController(mock.Object);

            // Act
            var result = await controller.UpdatePaymentDetail(3, paymentDetail);
            var objectResult = result as ObjectResult;

            // Assert
            Assert.Equal(objectResult.StatusCode, StatusCodes.Status400BadRequest);
        }

        [Fact]
        public async void DeletePaymentDetail_Is_Result_Ok()
        {
            // Arrange
            initPaymentDetail();
            mock.Setup(p => p.GetPaymentDetailById(1)).ReturnsAsync(paymentDetail);
            mock.Setup(p => p.DeletePaymentDetail(paymentDetail)).ReturnsAsync(1);
            PaymentDetailController controller = new PaymentDetailController(mock.Object);

            // Act
            var result = await controller.DeletePaymentDetail(1);
            var objectResult = result as ObjectResult;

            // Assert
            Assert.Equal(objectResult.StatusCode, StatusCodes.Status200OK);
        }

        [Fact]
        public async void DeletePaymentDetail_Is_Result_Id_Not_Found()
        {
            // Arrange
            initPaymentDetail();
            mock.Setup(p => p.GetPaymentDetailById(1)).ReturnsAsync(paymentDetail);
            mock.Setup(p => p.DeletePaymentDetail(paymentDetail)).ReturnsAsync(1);
            PaymentDetailController controller = new PaymentDetailController(mock.Object);

            // Act
            var result = await controller.DeletePaymentDetail(2);
            var objectResult = result as ObjectResult;

            // Assert
            Assert.Equal(objectResult.StatusCode, StatusCodes.Status404NotFound);
        }

    }
}
