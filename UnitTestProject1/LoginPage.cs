using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class LoginPage
    {
        [FindsBy(How = How.Name, Using = "username")]
        public IWebElement EnterUsername { get; set; }


        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement EnterPassword { get; set; }

        [FindsBy(How = How.Name, Using = "FormsButton2")]
        public IWebElement TestLoginButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > table > tbody > tr > td.auto-style1 > big > blockquote > blockquote > font > center > b")]
        public IWebElement SuccessCheck { get; set; }

        


        public void EnterUser(String name)
        {
            EnterUsername.SendKeys(name);
        }

        public void EnterPass(String pass)
        {
            EnterPassword.SendKeys(pass);
        }

        public void ClickTestLogin()
        {
            TestLoginButton.Click();
        }

        public String getLoginCheck()
        {
            return SuccessCheck.Text;
        }
    }
}
