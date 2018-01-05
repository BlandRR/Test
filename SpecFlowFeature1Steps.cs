using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace GuruSele
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        RemoteWebDriver driver;
  
        [Given(@"I open firefox")]
        public void GivenIOpenFirefox()
        {
           driver = new FirefoxDriver(Environment.CurrentDirectory + "\\..\\GuruSele");
        }

        [Given(@"I go to  (.*)")]
        public void GivenIGoToHttpWww_Demo_Guru_ComV(String URL)
        {
            driver.Url = URL;
        }

        [When(@"I enter the username of ""(.*)""")]
        public void WhenIEnterTheUsernameOfMngr(String username)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement usr = wait.Until(driver => driver.FindElement(By.Name("uid")));
            usr.SendKeys(username);
        }
        
        [When(@"I enter the password of ""(.*)""")]
        public void WhenIEnterThePasswordOfUgAjuty(String password)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement pass = wait.Until(driver => driver.FindElement(By.XPath("/html/body/form/table/tbody/tr[2]/td[2]/input")));
            pass.SendKeys(password);
            IWebElement login = wait.Until(driver => driver.FindElement(By.Name("btnLogin")));
            login.Click();
        }

        [Then(@"I should be successfully logged in with a greeting (.*)")]
        public void ThenIShouldBeSuccessfullyLoggedInWithAGreetingWelcomeToManagerSPageOfGuruBank(String expected)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement visualtext = wait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[2]/td/marquee")));
            string actualtext = visualtext.Text;
            Assert.AreEqual(actualtext, expected);
        }

        // need to handle the pop up window 
        [Then(@"I should recieve failed logged in with a message and be on the same URL ""(.*)""")]
        public void ThenIShouldRecieveFailedLoggedInWithAMessage(String expected)
        {
            if (driver.Url != "http://www.demo.guru99.com/V4/manager/Managerhomepage.php")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

          



        }


        [Then(@"I clean the test environment")]
        public void ThenICleanTheTestEnvironment()
        {
            driver.Close();
        }
    }
}
