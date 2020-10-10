using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationUC;
namespace UserRegistrationMSUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        RegexValidation validation = new RegexValidation();

        [TestMethod]
        public void GivenFirstName_Validate_ShouldTrue()
        {
            bool result = validation.FirstNameValidation("Sumit");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenLastName_Validate_ShouldTrue()
        {
            bool result = validation.LastNameValidation("Pandit");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenEmail_Validate_ShouldTrue()
        {
            bool result = validation.EmailValidation("sumitpandit178@gmail.com");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenMobileNumber_Validate_ShouldTrue()
        {
            bool result = validation.MobileValidation("91 8013229710");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenPassword_Validate_ShouldTrue()
        {
            bool result = validation.PasswordValidation("Sumit08@9");
            Assert.IsTrue(result);
        }
    }
}
