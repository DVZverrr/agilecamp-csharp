namespace AFT
{
    using NUnit.Framework;
    using OpenQA.Selenium.Chrome;

    // PageObjects pattern https://code.google.com/p/selenium/wiki/PageObjects

    public class LoginUiTest
    {
        [Test]
        public void IfEmailAddressIsNotValid_ShowValidationMessage()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:49333/Account/Login");

                var loginErrorMessage1 = driver.FindElementsByXPath("//*[@id='loginForm']/form/div[1]/div/span/span");
                Assert.AreEqual(0, loginErrorMessage1.Count);

                driver.FindElementByXPath("//*[@id='loginForm']/form/div[4]/div/input").Click();

                var loginErrorMessage = driver.FindElementByXPath("//*[@id='loginForm']/form/div[1]/div/span/span");

                Assert.True(loginErrorMessage.Displayed);
            }
        }
    }
}