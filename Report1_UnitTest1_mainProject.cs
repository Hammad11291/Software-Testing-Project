using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;

namespace test2
{
    [TestClass]
    public class UnitTest1
    {
        static int count = 0;
        const int numberOfTestCases = 4;
        static ExtentV3HtmlReporter htmlReporter = new ExtentV3HtmlReporter(@"E:\Report.html");
        static ExtentReports extentReport = new ExtentReports();
        [TestMethod, Owner("Hammad")]  //attribute
        [TestCategory("Smoke"), TestCategory("Inventory")]  //these are category to assign test case Knowledge
        [DataRow("Test Case 1", "standard_user", "secret_sauce", "Hammmad", "Mughal", "11111")]
        [DataRow("Test Case 2", "locked_out_user", "secret_sauce", "Anas", "Siddqui", "11111")]
        [DataRow("Test Case 3", "problem_user", "secret_sauce", "Haris", "khan", "11111")]
        [DataRow("Test Case 4", "performance_glitch_user", "secret_sauce", "pope", "Vatican", "11111")]

        public void TestCase(string testCase, string user, string pass, string fname, string lname, string pcode)
        {

            count++;
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.saucedemo.com/";

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
      
            extentReport.AttachReporter(htmlReporter);
            var feature = extentReport.CreateTest<Feature>(testCase);
            //-------------------------------------------------------------
            //Entering Text fields
            driver.FindElement(By.Id("user-name")).SendKeys(user);
            driver.FindElement(By.Id("password")).SendKeys(pass);


            var scenario1 = feature.CreateNode<Scenario>("Log In (User:" + user + "password:" + pass +")");
            
            Thread.Sleep(2000);
            //Logging 
            driver.FindElement(By.Id("login-button")).Click();

            try
            {
                driver.FindElement(By.ClassName("title"));
                scenario1.CreateNode<Given>("Navigated to Merchandise Feed");
            }
            catch (NoSuchElementException)
            {

                scenario1.Fail("Failed");
                feature.Fail("Failed");

                if (count == numberOfTestCases)
                {
                    extentReport.Flush();
                    htmlReporter.Stop();
                }

                driver.Close();
                return;
            }
            //-------------------------------------------------------------

            //-------------------------------------------------------------
            //getting the text of element
            string productText = driver.FindElement(By.ClassName("title")).Text;
            

            Assert.AreEqual(expected: "PRODUCTS", productText, message: "The Data does not matched");
            
            Thread.Sleep(2000);

            driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            driver.FindElement(By.ClassName("shopping_cart_badge")).Click();
            var scenario2 = feature.CreateNode<Scenario>("Adding Merchandise to cart");
            scenario2.CreateNode<Given>("Navigated to YOUR CART");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("checkout")).Click();
            var scenario3 = feature.CreateNode<Scenario>("Check Out");
            scenario3.CreateNode<Given>("Navigated to CHECKOUT: YOUR INFORMATION");
            Thread.Sleep(2000);
            //-------------------------------------------------------------



            //-------------------------------------------------------------
            driver.FindElement(By.Id("first-name")).SendKeys(fname);
            driver.FindElement(By.Id("last-name")).SendKeys(lname);
            driver.FindElement(By.Id("postal-code")).SendKeys(pcode);
            
            Thread.Sleep(2000);

            driver.FindElement(By.Id("continue")).Click();
            var scenario4 = feature.CreateNode<Scenario>("continue (first-name:" + fname + "last-name:" + lname + "postal-code" + pcode + ")");
            Thread.Sleep(2000);

            try
            {
                driver.FindElement(By.Id("finish"));
                scenario4.CreateNode<Given>("Navigated to Checkout: Overview");
            }
            catch (NoSuchElementException)
            {

                scenario4.Fail("Failed");
                if (count == numberOfTestCases)
                {
                    extentReport.Flush();
                    htmlReporter.Stop();
                }
                driver.Close();
                return;
            }

            //-------------------------------------------------------------

            driver.FindElement(By.Id("finish")).Click();
            var scenario5 = feature.CreateNode<Scenario>("Finish");
            scenario5.CreateNode<Given>("Successful");
            //-------------------------------------------------------------



            feature.Pass("Pass");

            if (count == numberOfTestCases)
            {
                extentReport.Flush();
                htmlReporter.Stop();
            }

            driver.Close();

        }

        [TestMethod]   //this thing is necessary 
        public void TestCase_002()
        {


        }
    }

    internal class JavascriptExecutor
    {
        internal void executeScript(string v)
        {
            throw new NotImplementedException();
        }
    }

    internal class IwebDriver
    {
    }
}



