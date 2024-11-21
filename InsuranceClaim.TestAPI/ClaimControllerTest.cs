
using InsuranceClaim.Server.Controllers;
using InsuranceClaim.Server.Data.Entities;
using InsuranceClaim.Server.Model.DTOs;
using InsuranceClaim.Server.Model.Enum;
using InsuranceClaim.Server.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Net;
using System.Net.Http.Json;

namespace InsuranceClaim.TestAPI
{
    [TestFixture]
    public class ClaimControllerTest
    {
        private Mock<IClaimsService> _mockService;
        private ClaimsController _controller;

        [SetUp]
        public void Setup()
        {
            _mockService = new Mock<IClaimsService>();
            _controller = new ClaimsController(_mockService.Object);
        }

        [Test]
        public async Task SubmitClaim_ShouldReturnCreatedClaim()
        {
            // Arrange
            var claim = new Claim { CustomerName = "John Doe", ClaimAmount = 1000m };
            var claimDto = new ClaimSubmissionDto { CustomerName = "John Doe", ClaimAmount = 1000m };
            _mockService.Setup(repo => repo.AddClaimAsync(claim));

            // Act
            var result = _controller.SubmitClaim(claimDto);

            // Assert
            Assert.AreEqual(claim, result);
        }

        [TestCase]
        public async Task Get_AllClaims_ShouldReturnAllClaims()
        {
            // Arrange
            var claims = _mockService.Setup(service => service.GetAllAsync());
            // Act
            var result = _controller.GetAllClaims();

            // Assert
            var okResult = result.Result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
            Assert.AreEqual(claims, okResult.Value);
        }

        [TestCase]
        public async Task Get_ClaimStatus_ShouldReturnAllClaimsHaveThatStatus()
        {
            // Arrange
            var claims = _mockService.Setup(repo => repo.GetClaimsByStatusAsync(EnumStatus.Approved));

            // Act
            var result = _controller.RetrieveClaims(EnumStatus.Approved);

            // Assert
            Assert.AreEqual(claims, result);
        }
    }
}