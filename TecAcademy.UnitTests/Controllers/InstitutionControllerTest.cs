using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Shouldly;
using TecAcademy.Presentation.Controllers;
using TecAcademy.Services.Contracts;
using TecAcademy.Services.Contracts.Institutions;
using TecAcademy.Services.Implemetations;
using TecAcademy.Services.Interfaces;
using Xunit;


namespace TecAcademy.UnitTests.Controllers
{
    public class InstitutionControllerTest
    {
        private Mock<IInstitutionService> _mockInstitutionService;
        private Mock<ILogger<InstitutionController>> _mockLoggerService;
        private InstitutionCreateReqValidator _validator;

        public InstitutionControllerTest()
        {
            _mockInstitutionService = new Mock<IInstitutionService>();
            _mockLoggerService = new Mock<ILogger<InstitutionController>>();
            _validator = new InstitutionCreateReqValidator();
        }

        [Fact]
        public void InstitutionCreate_ValidInput_ShouldPass()
        {
            //Arrange
            _mockInstitutionService.Setup(m => m.Create(It.IsAny<InstitutionCreateReq>()))
            .Returns(new InstitutionRsp<InstitutionDto>
            {
                Code = "200",
                Result = new InstitutionDto
                {

                }
            });

            var institutionController = new InstitutionController(
                _mockInstitutionService.Object,
                _validator,
                _mockLoggerService.Object
                );

            var instituionReq = new InstitutionCreateReq
            {
                City = "Owerri",
                Country = "Nigeria",
                Name = "FUTO",
                State = "Imo"
            };


            //Act
            var result = institutionController.Create(instituionReq);

            //Assert
            result.ShouldBeOfType<ActionResult<BaseResponse>>();
            
        }

        [Fact]
        public void InstitutionCreate_InValidInput_ShouldFail()
        {
            //Arrange
            _mockInstitutionService.Setup(m => m.Create(It.IsAny<InstitutionCreateReq>()))
            .Returns(new InstitutionRsp<InstitutionDto>
            {
                Code = "200",
                Result = new InstitutionDto
                {

                }
            });

            var institutionController = new InstitutionController(
                _mockInstitutionService.Object,
                _validator,
                _mockLoggerService.Object
                );

            var instituionReq = new InstitutionCreateReq
            {
                City = "Owerri",
                Country = "Nigeria",
                Name = "",
                State = "Imo"
            };

            //Act
            var result = institutionController.Create(instituionReq);

            //Assert
            result.ShouldBeOfType<ActionResult<BaseResponse>>();
            (result as ActionResult<BaseResponse>).ShouldNotBeAssignableTo<Ok>();
        }
    }
}
