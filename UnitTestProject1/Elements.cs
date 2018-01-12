using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;



namespace UnitTestProject1
{
    class CreateElements 
    {
        private IWebDriver driver;

        [FindsBy(How = How.Name, Using = "username")]
        public IWebElement MakeUsername { get; set; }


        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement MakePassword { get; set; }


        [FindsBy(How = How.Name, Using = "FormsButton2")]
        public IWebElement Submit { get; set; }


        [FindsBy(How = How.CssSelector, Using = "body > table > tbody > tr > td.auto-style1 > blockquote > blockquote:nth-child(2) > blockquote")]
        public IWebElement Verify { get; set; }
        

        public void setUser(String name)
        {
            MakeUsername.SendKeys(name);
        }

        public void setPass(String pass)
        {
            MakePassword.SendKeys(pass);
        }

        public void ClickSubmit()
        {
            Submit.Click();
        }

        public String getverifyUser()
        {
            return Verify.Text;
        }


    }
}
