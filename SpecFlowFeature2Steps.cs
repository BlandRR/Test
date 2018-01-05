using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Threading;
namespace GuruSele
{
    [Binding]
    public class SpecFlowFeature2Steps
    {
        RemoteWebDriver driver;
        

        [Given(@"I open browser firefox")]
        public void GivenIOpenBrowserFirefox()
        {
            driver = new FirefoxDriver(Environment.CurrentDirectory + "\\..\\GuruSele");
        }
        
        [Given(@"I go to URL  (.*)")]
        public void GivenIGoToURLHttpWww_Demo_Guru_ComV(String URL)
        {
            driver.Url = URL;
        }
        
        [When(@"I enter the username ""(.*)""")]
        public void WhenIEnterTheUsername(string p0)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement usr = wait.Until(driver => driver.FindElement(By.Name("uid")));
            usr.SendKeys(p0);
        }
        
        [When(@"I enter the password ""(.*)""")]
        public void WhenIEnterThePassword(string p0)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement pass = wait.Until(driver => driver.FindElement(By.XPath("/html/body/form/table/tbody/tr[2]/td[2]/input")));
            pass.SendKeys(p0);
            IWebElement login = wait.Until(driver => driver.FindElement(By.Name("btnLogin")));
            login.Click();
        }
        
        [When(@"I click new customer")]
        public void WhenIClickNewCustomer()
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement newuser = wait.Until(driver => driver.FindElement(By.XPath(" / html / body / div[2] / div / ul / li[2] / a")));
            newuser.Click();
          
        }
        
        [When(@"I enter a blank name")]
        public void WhenIEnterABlankName()
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement customername = wait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[4]/td[2]/input")));
            customername.SendKeys("");
            IWait<IWebDriver> addresswait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement address = addresswait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[7]/td[2]/textarea")));
            address.SendKeys("");
        }
        
        [When(@"I enter name (.*)")]
        public void WhenIEnterNameBilly(String name)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement customername = wait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[4]/td[2]/input")));
            customername.SendKeys(name);
            IWait<IWebDriver> addresswait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement address = addresswait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[7]/td[2]/textarea")));
            address.SendKeys("");
        }

        /**
      // doesnt work on firefox!
        [When(@"I enter date of birth (.*)")]
        public void WhenIEnterDateOfBirth(String d)
        { 
            IWebElement dateBox = driver.FindElement(By.CssSelector("#dob"));
            dateBox.Click();
            dateBox.SendKeys(d);
         
            //dateBox.SendKeys(Keys.Tab);
            //  dateBox.Click();
            TimeSpan interval = new TimeSpan(0, 0, 10);
            Thread.Sleep(interval);
        }
         **/

        [When(@"I enter blankaddress")]
        public void WhenIEnterBlankaddress()
        { 
            IWait<IWebDriver> addresswait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement address = addresswait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[7]/td[2]/textarea")));
            address.SendKeys("");
            IWait<IWebDriver> Citywait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement city = Citywait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[8]/td[2]/input")));
            city.SendKeys("");
        
        }


        [When(@"I enter address (.*)")]
        public void WhenIEnterAddressBakerStreet(String addressstring)
        {
            IWait<IWebDriver> addresswait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement address = addresswait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[7]/td[2]/textarea")));
            address.SendKeys(addressstring);
            IWait<IWebDriver> Citywait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement city = Citywait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[8]/td[2]/input")));
            city.SendKeys("");
        }


        [When(@"I enter BlankCity")]
        public void WhenIEnterBlankCity()
        {
            IWait<IWebDriver> Citywait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement city = Citywait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[8]/td[2]/input")));
            city.SendKeys("");
            IWait<IWebDriver> statewait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement state = statewait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[9]/td[2]/input")));
            state.SendKeys("");
        }


        [When(@"I enterCity (.*)")]
        public void WhenIEnterCityNewYork(String citystring)
        {
            IWait<IWebDriver> Citywait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement city = Citywait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[8]/td[2]/input")));
            city.SendKeys(citystring);
            IWait<IWebDriver> statewait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement state = statewait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[9]/td[2]/input")));
            state.SendKeys("");
        }

        [When(@"I enterState (.*)")]
        public void WhenIEnterState(String statestring)
        {
            IWait<IWebDriver> statewait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement state = statewait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[9]/td[2]/input")));
            state.SendKeys(statestring);
            IWait<IWebDriver> pinwait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement pin = pinwait.Until(driver => driver.FindElement(By.XPath("/ html / body / table / tbody / tr / td / table / tbody / tr[10] / td[2] / input")));
            pin.SendKeys("");
        }


        [When(@"I blankState")]
        public void WhenIBlankState()
        {
            IWait<IWebDriver> statewait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement state = statewait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[9]/td[2]/input")));
            state.SendKeys("");

            IWait<IWebDriver> pinwait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement pin = pinwait.Until(driver => driver.FindElement(By.XPath("/ html / body / table / tbody / tr / td / table / tbody / tr[10] / td[2] / input")));
            pin.SendKeys("");

        }


        [When(@"I enterpin (.*)")]
        public void WhenIEnterpinP(String pinstring)
        {
            
            IWait<IWebDriver> pinwait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement pin = pinwait.Until(driver => driver.FindElement(By.XPath("/ html / body / table / tbody / tr / td / table / tbody / tr[10] / td[2] / input")));
            pin.SendKeys(pinstring);

            IWait<IWebDriver> mobilewait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement mobile = mobilewait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[11]/td[2]/input")));
            mobile.SendKeys("");
        }


        [When(@"I blankpin")]
        public void WhenIBlankpin()
        {
            IWait<IWebDriver> pinwait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement pin = pinwait.Until(driver => driver.FindElement(By.XPath("/ html / body / table / tbody / tr / td / table / tbody / tr[10] / td[2] / input")));
            pin.SendKeys("");
            IWait<IWebDriver> mobilewait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement mobile = mobilewait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[11]/td[2]/input")));
            mobile.SendKeys("");
        }

        [When(@"I enterBlankTelephone")]
        public void WhenIEnterBlankTelephone()
        {
            IWait<IWebDriver> mobilewait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement mobile = mobilewait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[11]/td[2]/input")));
            mobile.SendKeys("");

            IWait<IWebDriver> emailwait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement email = emailwait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[12]/td[2]/input")));
            email.SendKeys("");
        }


        [When(@"I enterTelephone (.*)")]
        public void WhenIEnterTelephone(String error)
        {
            IWait<IWebDriver> mobilewait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement mobile = mobilewait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[11]/td[2]/input")));
            mobile.SendKeys(error);

            IWait<IWebDriver> emailwait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement email = emailwait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[12]/td[2]/input")));
            email.SendKeys("");
        }


        [When(@"I enterBlankEmail")]
        public void WhenIEnterBlankEmail()
        {
            IWait<IWebDriver> emailwait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement email = emailwait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[12]/td[2]/input")));
            email.SendKeys("");

            IWait<IWebDriver> passwordwait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement password = passwordwait.Until(driver => driver.FindElement(By.XPath("/ html / body / table / tbody / tr / td / table / tbody / tr[13] / td[2] / input")));
            password.SendKeys("");
            
        }


        [When(@"I enteremail (.*)")]
        public void WhenIEnteremailBilly(String emailstring)
        {
            IWait<IWebDriver> emailwait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement email = emailwait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[12]/td[2]/input")));
            email.SendKeys(emailstring);

            IWait<IWebDriver> passwordwait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement password = passwordwait.Until(driver => driver.FindElement(By.XPath("/ html / body / table / tbody / tr / td / table / tbody / tr[13] / td[2] / input")));
            password.SendKeys("");
        }


        [When(@"I enterBlankPassword")]
        public void WhenIEnterBlankPassword()
        {
            IWait<IWebDriver> passwordwait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement password = passwordwait.Until(driver => driver.FindElement(By.XPath("/ html / body / table / tbody / tr / td / table / tbody / tr[13] / td[2] / input")));
            password.SendKeys("");

            IWait<IWebDriver> emailwait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement email = emailwait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[12]/td[2]/input")));
            email.SendKeys("");
        }


        [When(@"I enterPassword (.*)")]
        public void WhenIEnterPasswordBilly(String passwordstring)
        {
            IWait<IWebDriver> passwordwait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement password = passwordwait.Until(driver => driver.FindElement(By.XPath("/ html / body / table / tbody / tr / td / table / tbody / tr[13] / td[2] / input")));
            password.SendKeys(passwordstring);
        }



        [Then(@"CustomerCreationSuccessful (.*)")]
        public void ThenCustomerCreationSuccessful(String success)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement submit = wait.Until(driver => driver.FindElement(By.XPath("/ html / body / table / tbody / tr / td / table / tbody / tr[14] / td[2] / input[1]")));
            submit.Click();

            IWait<IWebDriver> text = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement textstring = text.Until(driver => driver.FindElement(By.XPath("#  customer > tbody > tr:nth-child(1) > td > p")));


           Assert.AreEqual(textstring.Text, success);
        }





        [Then(@"InvalidPassword error (.*)")]
        public void ThenInvalidPasswordErrorPasswordMustNotBeBlank(String error)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement visualtext = wait.Until(driver => driver.FindElement(By.Id("message18")));
            string actualtext = visualtext.Text;
            Assert.AreEqual(actualtext, error);
        }

        
        [Then(@"InvalidEmail error (.*)")]
        public void ThenInvalidEmailErrorEmail_IDIsNotValid(String error)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement visualtext = wait.Until(driver => driver.FindElement(By.Id("message9")));
            string actualtext = visualtext.Text;
            Assert.AreEqual(actualtext, error);
        }

        
        [Then(@"TelephoneBlank error (.*)")]
        public void ThenTelephoneBlankErrorMobileNoMustNotBeBlank(String error)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement visualtext = wait.Until(driver => driver.FindElement(By.Id("message7")));
            string actualtext = visualtext.Text;
            Assert.AreEqual(actualtext, error);
        }



        [Then(@"pinblank error (.*)")]
        public void ThenPinblankErrorPINCodeMustNotBeBlank(String error)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement visualtext = wait.Until(driver => driver.FindElement(By.Id("message6")));
            string actualtext = visualtext.Text;
            Assert.AreEqual(actualtext, error);
        }


        [Then(@"StateNumber error (.*)")]
        public void ThenStateNumberErrorStateMustNotBeBlank(String p0)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement visualtext = wait.Until(driver => driver.FindElement(By.Id("message5")));
            string actualtext = visualtext.Text;
            Assert.AreEqual(actualtext, p0);
        }




        [Then(@"CityBlank error (.*)")]
        public void ThenCityBlankErrorCityFieldMustNotBeBlank(String p0)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement visualtext = wait.Until(driver => driver.FindElement(By.Id("message4")));
            string actualtext = visualtext.Text;
            Assert.AreEqual(actualtext, p0);
        }



        [Then(@"I should be successfully logged in shown greeting (.*)")]
        public void ThenIShouldBeSuccessfullyLoggedInShownGreetingWelcomeToManagerSPageOfGuruBank(String p0)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement visualtext = wait.Until(driver => driver.FindElement(By.XPath("/html/body/table/tbody/tr/td/table/tbody/tr[2]/td/marquee")));
            string actualtext = visualtext.Text;
            Assert.AreEqual(actualtext, p0);
        }

   

        [Then(@"an error message should appear (.*)")]
        public void ThenAnErrorMessageShouldAppearCustomerNameMustNotBeBlank(String blank)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement visualtext = wait.Until(driver => driver.FindElement(By.Id("message")));
            string actualtext = visualtext.Text;
            Assert.AreEqual(actualtext, blank);
        }


        [Then(@"Incorrect (.*)")]
        public void ThenIncorrectAddressFieldMustNotBeBlank(String error)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            IWebElement visualtext = wait.Until(driver => driver.FindElement(By.Id("message3")));
            string actualtext = visualtext.Text;
            Assert.AreEqual(actualtext, error);
        }

        [Then(@"I clean test environment")]
        public void ThenICleanTestEnvironment()
        {
            driver.Close();
        }
    }
}
