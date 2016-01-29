using OpenQA.Selenium;

namespace AFT
{
    using NUnit.Framework;
    using OpenQA.Selenium.Chrome;

    // PageObjects pattern https://code.google.com/p/selenium/wiki/PageObjects

    public class LoginUiTest
    {
       private const string InvalidEmail = "abc";
       private const string ValidEmail = "abc@yandex.ru";
      private const string ValidPass = "Qwerty123#";
      private const string InvalidErrorEmailMessage = "Поле Email не содержит допустимый адрес электронной почты.";

       [Test]
        public void IfEmailAddressIsNotValid_ShowValidationMessage()
        {
            using (var driver = new ChromeDriver())
            {
               var loginErrorMessageDisplayed = new LoginPage(driver)
                  .Navigate()
                  .SubmitButton()
                  .EmailErrorMessage()
                  .Displayed;

               Assert.True(loginErrorMessageDisplayed);
            }
        }


      [Test]
      public void IfEmailAddressIsNotValid_ShowLoginErrorMessage()
      {
         using (var driver = new ChromeDriver())
         {
            var lp = new LoginPage(driver)
               .Navigate()
               .EmailInput(InvalidEmail)
               .SubmitButton();

            var loginErrorMessage = lp.EmailErrorMessage();
            
            Assert.AreEqual(loginErrorMessage.Text, InvalidErrorEmailMessage);
         }
      }

       
       [Test]
      public void IfEmailAddressIsValid_NotShowLoginErrorMessage()
      {
         using (var driver = new ChromeDriver())
         {

            var lp = new LoginPage(driver)
               .Navigate()
               .EmailInput(ValidEmail)
               .SubmitButton();

            Assert.Throws<NoSuchElementException>(
               () => lp.EmailErrorMessage());
         }
      }

      [Test]
      public void IfPasswordIsValid_NotShowLoginErrorMessage()
      {
         using (var driver = new ChromeDriver())
         {

            var lp = new LoginPage(driver)
               .Navigate()
               .PasswordInput(ValidPass)
               .SubmitButton();

            Assert.Throws<NoSuchElementException>(
               () => lp.PasswordErrorMessage());
         }
      }
   }
}