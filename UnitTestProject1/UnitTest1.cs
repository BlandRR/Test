using System;
using System.Drawing;
using System.Threading;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using excel = Microsoft.Office.Interop.Excel;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        public ExtentReports extent;
        IWebDriver driver;

    [SetUp]
        public void Setup()
        {
            extent = new ExtentReports();
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualpath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectpath = new Uri(actualpath).LocalPath;
            string reportPath = projectpath + "Reports\\OwnReport.html";
            driver = new ChromeDriver();
            Console.WriteLine("Set Up");
            extent.AttachReporter(new ExtentHtmlReporter(reportPath));
        }

        [Test]
        public void Draggable()
        {
            driver.Navigate().GoToUrl("http://demoqa.com/draggable/");

            var drag = new DraggableItems();
            PageFactory.InitElements(driver, drag);
            Actions builder = new Actions(driver);

            drag.ClickBox();

           int start = drag.draggablebox.Location.X;
            Thread.Sleep(1000);
           builder.ClickAndHold(drag.draggablebox).MoveByOffset(50, 10).Release().Build().Perform();
            Thread.Sleep(1000);
            int currentlocation = drag.draggablebox.Location.X;
            int expectedlocation = start + 50;
            
            Assert.AreEqual(expectedlocation, currentlocation);

        }

        [Test]
        public void spreadsheet()
        {
            excel.Application x1Appl = new excel.Application();


            //Creates excel workbook object for specified file
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualpath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectpath = new Uri(actualpath).LocalPath;
            string reportPath = projectpath + "Data\\TestData.xlsx";

            excel.Workbook x1WorkBook = x1Appl.Workbooks.Open(reportPath);


            //Creates excel work sheet object for sheet 1

            excel._Worksheet x1WorkSheet = x1WorkBook.Sheets[1];


            //Gets used range of excel file(here range is 3)

            excel.Range x1Range = x1WorkSheet.UsedRange;



            int xlRowCnt = 0;

            String Username;

            String Password;



            for (xlRowCnt = 1; xlRowCnt <= x1Range.Rows.Count; xlRowCnt++)

            {

                Username = (string)(x1Range.Cells[xlRowCnt, 1] as excel.Range).Value2;

                Password = (string)(x1Range.Cells[xlRowCnt, 2] as excel.Range).Value2;

                ExtentTest test4 = extent.CreateTest("URL");
                test4.Log(Status.Info, "First");
                test4.Log(Status.Debug, "Go to URl");
                driver.Navigate().GoToUrl("http://thedemosite.co.uk");

                var homePage = new HomePage();
                PageFactory.InitElements(driver, homePage);
                test4.Log(Status.Debug, "Go to create new user");
                homePage.ClickCreateUser();

                var createUser = new CreateElements();
                PageFactory.InitElements(driver, createUser);
                test4.Log(Status.Debug, "Create Usernamer");
                createUser.setUser(Username);
                test4.Log(Status.Debug, "Create Password");
                createUser.setPass(Password);
                test4.Log(Status.Debug, "Create New User");
                createUser.ClickSubmit();

                test4.Log(Status.Debug, "Login Page");
                homePage.ClickLogin();

                var login = new LoginPage();
                PageFactory.InitElements(driver, login);
                test4.Log(Status.Debug, "Enter Username");
                login.EnterUser(Username);
                test4.Log(Status.Debug, "Enter Password");
                login.EnterPass(Password);
                test4.Log(Status.Debug, "Check Login");
                Thread.Sleep(1000);

                login.ClickTestLogin();
                try
                {
                    Assert.AreEqual("**Successful Login**", login.getLoginCheck());
                    test4.Log(Status.Pass, "Pass");
                }
                catch (AssertionException e)
                {
                    test4.Log(Status.Fail, "Failed");
                    Assert.Fail();
                }
            }
            x1WorkBook.Close();

            x1Appl.Quit();
        }


        [Test]
        public void TestURLSuccessful()
        {
            ExtentTest test1 = extent.CreateTest("URL");
            test1.Log(Status.Info, "First");
            test1.Log(Status.Debug, "Go to URl");
            driver.Navigate().GoToUrl("http://thedemosite.co.uk");
            Assert.AreEqual("http://thedemosite.co.uk/", driver.Url);
            test1.Log(Status.Pass, "");
        }


        [Test]
        public void TestCreateUserSuccessful()
        {
            ExtentTest test2 = extent.CreateTest("Create");
            test2.Log(Status.Info, "First");
            test2.Log(Status.Debug, "Go to URl");
            driver.Navigate().GoToUrl("http://thedemosite.co.uk");
           
            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            test2.Log(Status.Debug, "Go to create new user");
            homePage.CreateUserButton.Click();

            var createUser = new CreateElements();
            PageFactory.InitElements(driver, createUser);
            test2.Log(Status.Debug, "About to create username");
            createUser.setUser("Testing");
            test2.Log(Status.Debug, "About to create Password");
            createUser.setPass("Test123");
            test2.Log(Status.Debug, "Create New User");
            createUser.ClickSubmit();
      
            try
            {
                Assert.AreEqual("The username: Testing\r\nThe password: Test123", createUser.getverifyUser());
                test2.Log(Status.Pass, "Pass"); 
            } catch (AssertionException e)
            {
                test2.Log(Status.Fail, "Fail");
                Assert.Fail();
            }            
        }



        [Test]
        public void TestLogin()
        {
            ExtentTest test3 = extent.CreateTest("Login");
            test3.Log(Status.Info, "First");
            test3.Log(Status.Debug, "Go to URl");
            driver.Navigate().GoToUrl("http://thedemosite.co.uk");
            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            test3.Log(Status.Debug, "Go to create new user");
            homePage.ClickCreateUser();

            var createUser = new CreateElements();
            PageFactory.InitElements(driver, createUser);
            test3.Log(Status.Debug, "Create Usernamer");
            createUser.setUser("Testing");
            test3.Log(Status.Debug, "Create Password");
            createUser.setPass("Test123");
            test3.Log(Status.Debug, "Create New User");
            createUser.ClickSubmit();

            test3.Log(Status.Debug, "Login Page");
            homePage.ClickLogin();

            var login = new LoginPage();
            PageFactory.InitElements(driver, login);
            test3.Log(Status.Debug, "Enter Username");
            login.EnterUser("Testing");
            test3.Log(Status.Debug, "Enter Password");
            login.EnterPass("Test123");
            test3.Log(Status.Debug, "Check Login");
            login.ClickTestLogin();
            try
            {
                Assert.AreEqual("**Successful Login**", login.getLoginCheck());
                test3.Log(Status.Pass, "Pass");
            } catch (AssertionException e)
            {
                test3.Log(Status.Fail, "Failed");
                Assert.Fail();
            }
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
            extent.Flush();
            Console.WriteLine("Tear Down");
        }
    }
}
