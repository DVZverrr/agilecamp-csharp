using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AFT
{
   public class LoginPage
   {
      private readonly ChromeDriver _driver;

      public LoginPage(ChromeDriver driver)
      {
         this._driver = driver;
      }

      public IWebElement EmailErrorMessage()
      {
         return _driver.FindElementByXPath("//*[@id='loginForm']/form/div[1]/div/span/span");
      }

      public LoginPage EmailInput(string text)
      {
         _driver.FindElementByXPath("//*[@id='loginForm']/form/div[1]/div/input").SendKeys(text);
         return this;
      }

      public LoginPage SubmitButton()
      {
         _driver.FindElementByXPath("//*[@id='loginForm']/form/div[4]/div/input").Click();
         return this;
      }

      public LoginPage Navigate()
      {
         _driver.Navigate().GoToUrl("http://localhost:49333/Account/Login");
         return this;
      }

      public LoginPage PasswordInput(string text)
      {
         _driver.FindElementByXPath("//*[@id='loginForm']/form/div[2]/div/input").SendKeys(text);
         return this;
      }

      public IWebElement PasswordErrorMessage()
      {
         return _driver.FindElementByXPath("//*[@id='loginForm']/form/div[2]/div/span/span");
      }
   }
}