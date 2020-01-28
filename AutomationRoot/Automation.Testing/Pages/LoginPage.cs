using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Testing.Pages
{
    public class LoginPage : BasePage, ILogin
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }

        public void ClickOnResetPassword()
        {
            throw new NotImplementedException();
        }

        public void ClickOnSignUp()
        {
            throw new NotImplementedException();
        }

        public void Login(string username, string password)
        {
            var usernameElement = Driver.FindElement(By.XPath("//input[@id='email']"));
            usernameElement.SendKeys(username);

            var passwordElement = Driver.FindElement(By.XPath("//input[@id='pass']"));
            passwordElement.SendKeys(password);
            // Click a button
            Driver.FindElement(By.XPath("//input[@id='u_0_b']")).Click();
        }
    }
}
