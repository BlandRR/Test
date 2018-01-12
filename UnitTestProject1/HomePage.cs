using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject1
{
    class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "body > div > center > table > tbody > tr:nth-child(2) > td > div > center > table > tbody > tr > td:nth-child(2) > p > small > a:nth-child(6)")]
        public IWebElement CreateUserButton { get; set; }



        [FindsBy(How = How.CssSelector, Using = "body > div > center > table > tbody > tr:nth-child(2) > td > div > center > table > tbody > tr > td:nth-child(2) > p > small > a:nth-child(7)")]
        public IWebElement LoginButton { get; set; }




        public void ClickCreateUser()
        {
            CreateUserButton.Click();
        }


        public void ClickLogin()
        {
            LoginButton.Click();
        }


    }
}
