using TecAcademy.Services.Contracts.Institutions;
using FluentValidation.TestHelper;
using Xunit;

namespace TecAcademy.UnitTests.Validators
{
    public class InstitutionCreateReqValidatorTest
    {
        private InstitutionCreateReqValidator _validator;

        public InstitutionCreateReqValidatorTest()
        {
            _validator = new InstitutionCreateReqValidator();
        }

        [Fact]
        public void NameValiator_EmptyTest_Should_Fail()
        {
            //Arrange
            var instituion = new InstitutionCreateReq
            {
                City = "Owerri",
                Country = "Nigeria",
                Name = string.Empty,
                State = "Imo"
            };

            //Act
            var result = _validator.TestValidate(instituion);

            //Assert
            result.ShouldHaveValidationErrorFor(m => m.Name);
        }
        [Fact]
        public void NameValiator_NotEmptyTest_Should_Pass()
        {
            //Arrange
            var instituion = new InstitutionCreateReq
            {
                City = "Owerri",
                Country = "Nigeria",
                Name = "FUTO",
                State = "Imo"
            };

            //Act
            var result = _validator.TestValidate(instituion);

            //Assert
            result.ShouldNotHaveValidationErrorFor(m => m.Name);
        }

        [Fact]
        public void CityValiator_EmptyTest_Should_Fail()
        {
            //Arrange
            var instituion = new InstitutionCreateReq
            {
                City = "",
                Country = "Nigeria",
                Name = "FUTO",
                State = "Imo"
            };

            //Act
            var result = _validator.TestValidate(instituion);

            //Assert
            result.ShouldHaveValidationErrorFor(m => m.City);
        }
        [Fact]
        public void CityValiator_NotEmptyTest_Should_Pass()
        {
            //Arrange
            var instituion = new InstitutionCreateReq
            {
                City = "Owerri",
                Country = "Nigeria",
                Name = "FUTO",
                State = "Imo"
            };

            //Act
            var result = _validator.TestValidate(instituion);

            //Assert
            result.ShouldNotHaveValidationErrorFor(m => m.City);
        }
    }
}

