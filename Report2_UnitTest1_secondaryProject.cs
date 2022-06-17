
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public object ExpectedConditions { get; private set; }

        [TestMethod]
        [TestCategory("Submit_Form")]
        public void TestCase_001()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/automation-practice-form";

            driver.FindElement(By.Id("firstName")).SendKeys("Hammad");
            driver.FindElement(By.Id("lastName")).SendKeys("Mughal");
            driver.FindElement(By.Id("userEmail")).SendKeys("hamu11281@gmail.com");
            driver.FindElement(By.CssSelector("div#genderWrapper > div:nth-of-type(2) > div > label")).Click();
            driver.FindElement(By.CssSelector("input#userNumber")).SendKeys("3232117832");

            IWebElement education = driver.FindElement(By.CssSelector("input#dateOfBirthInput"));
            education.Click();

            education = driver.FindElement(By.CssSelector("div#dateOfBirth > div:nth-of-type(2) > div:nth-of-type(2) > div > div > div:nth-of-type(2) > div > div:nth-of-type(2) > div > select"));
            education.Click();

            var selectElement = new SelectElement(education);
            selectElement.SelectByText("Dec");
            education.Click();

            education = driver.FindElement(By.CssSelector("div#dateOfBirth > div:nth-of-type(2) > div:nth-of-type(2) > div > div > div:nth-of-type(2) > div > div:nth-of-type(2) > div:nth-of-type(2) > select"));
            education.Click();
            selectElement = new SelectElement(education);
            selectElement.SelectByText("1998");
            education.Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,500)");
            education = driver.FindElement(By.CssSelector("div#dateOfBirth > div:nth-of-type(2) > div:nth-of-type(2) > div > div > div:nth-of-type(2) > div:nth-of-type(2) > div > div:nth-of-type(5)"));
            education.Click();


            driver.FindElement(By.CssSelector("div#subjectsContainer > div > div")).Click();
            //education.SendKeys("Physics");

            driver.FindElement(By.CssSelector("div#hobbiesWrapper > div:nth-of-type(2) > div")).Click();
            driver.FindElement(By.CssSelector("div#hobbiesWrapper > div:nth-of-type(2) > div:nth-of-type(2) > label")).Click();
            driver.FindElement(By.CssSelector("div#hobbiesWrapper > div:nth-of-type(2) > div:nth-of-type(3) > label")).Click();

            IWebElement chooseFile = driver.FindElement(By.CssSelector("input#uploadPicture"));
            chooseFile.SendKeys("C:/Users/hammad/Desktop/project/1.jpg");


            driver.FindElement(By.Id("currentAddress")).SendKeys("Abc street , Karachi, Pakistan");

            education = driver.FindElement(By.CssSelector("div#state > div > div"));
            education.Click();
            education = driver.FindElement(By.CssSelector("div#react-select-3-option-1"));
            education.Click();

            education = driver.FindElement(By.CssSelector("div#city > div > div"));
            education.Click();
            education = driver.FindElement(By.CssSelector("div#react-select-4-option-1"));
            education.Click();

            driver.FindElement(By.Id("submit")).Click();

        }

        [TestMethod]
        public void TextBox()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,200)");

            driver.FindElement(By.CssSelector("div#app > div > div > div:nth-of-type(2) > div > div > div > div:nth-of-type(3) > h5")).Click();
            driver.FindElement(By.CssSelector("li#item-0")).Click();

            driver.FindElement(By.Id("userName")).SendKeys("Anas Siddiqui");
            driver.FindElement(By.Id("userEmail")).SendKeys("anasaziz@gmail.com");
            driver.FindElement(By.Id("currentAddress")).SendKeys("Johar, Block 8");
            driver.FindElement(By.Id("permanentAddress")).SendKeys("Karachi");

            js.ExecuteScript("window.scrollBy(0,200)");
            driver.FindElement(By.Id("submit")).Click();
        }

        [TestMethod]
        public void CheckBox()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/checkbox";


            driver.FindElement(By.CssSelector("div#tree-node > ol > li > span > button > svg")).Click();

            driver.FindElement(By.CssSelector("div#tree-node > ol > li > ol > li > span > button > svg")).Click();
            driver.FindElement(By.CssSelector("div#tree-node > ol > li > ol > li > ol > li > span > label > span > svg")).Click();
            driver.FindElement(By.CssSelector("div#tree-node > ol > li > ol > li > ol > li:nth-of-type(2) > span > label > span > svg")).Click();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,300)");
            driver.FindElement(By.CssSelector("div#tree-node > ol > li > ol > li:nth-of-type(2) > span > button > svg")).Click();
            driver.FindElement(By.CssSelector("div#tree-node > ol > li > ol > li:nth-of-type(2) > ol > li > span > button > svg")).Click();
            driver.FindElement(By.CssSelector("div#tree-node > ol > li > ol > li:nth-of-type(2) > ol > li > ol > li > span > label > span > svg")).Click();
            driver.FindElement(By.CssSelector("div#tree-node > ol > li > ol > li:nth-of-type(2) > ol > li > ol > li:nth-of-type(2) > span > label > span > svg")).Click();
            driver.FindElement(By.CssSelector("div#tree-node > ol > li > ol > li:nth-of-type(2) > ol > li > ol > li:nth-of-type(3) > span > label > span > svg")).Click();
            driver.FindElement(By.CssSelector("div#tree-node > ol > li > ol > li:nth-of-type(2) > ol > li:nth-of-type(2) > span > label > span > svg")).Click();
            driver.FindElement(By.CssSelector("div#tree-node > ol > li > ol > li:nth-of-type(3) > span > label > span > svg")).Click();
        }

        [TestMethod]
        public void radiobutton()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/radio-button";
            driver.FindElement(By.CssSelector("div#app > div > div > div:nth-of-type(2) > div:nth-of-type(2) > div > div:nth-of-type(3) > label")).Click();
        }

        [TestMethod]
        public void web_tables()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/webtables";

            driver.FindElement(By.Id("addNewRecordButton")).Click();

            driver.FindElement(By.Id("firstName")).SendKeys("Hassan");
            driver.FindElement(By.Id("lastName")).SendKeys("Salman");
            driver.FindElement(By.Id("userEmail")).SendKeys("hassansalman@yahoo.com");
            driver.FindElement(By.Id("age")).SendKeys("22");
            driver.FindElement(By.Id("salary")).SendKeys("80000");
            driver.FindElement(By.Id("department")).SendKeys("Computer Science");

            driver.FindElement(By.Id("submit")).Click();
        }


        [TestMethod]
        public void buttons()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/buttons";

            Actions actions = new Actions(driver);
            WebElement elementLocator = (WebElement)driver.FindElement(By.Id("doubleClickBtn"));
            actions.DoubleClick(elementLocator).Perform();

            elementLocator = (WebElement)driver.FindElement(By.Id("rightClickBtn"));
            actions.ContextClick(elementLocator).Perform();
        }

        [TestMethod]
        public void api_calls()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/links";

            driver.FindElement(By.Id("simpleLink")).Click(); Thread.Sleep(1500);

            driver.SwitchTo().Window(driver.WindowHandles[1]).Close();

            driver.SwitchTo().Window(driver.WindowHandles[0]);

            driver.FindElement(By.Id("dynamicLink")).Click(); Thread.Sleep(1500);
            driver.SwitchTo().Window(driver.WindowHandles[1]).Close();

            driver.SwitchTo().Window(driver.WindowHandles[0]);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,200)");

            driver.FindElement(By.Id("created")).Click();


            driver.FindElement(By.Id("no-content")).Click();


            driver.FindElement(By.Id("moved")).Click();

            driver.FindElement(By.Id("bad-request")).Click();

            driver.FindElement(By.Id("unauthorized")).Click();

            driver.FindElement(By.Id("forbidden")).Click();

            driver.FindElement(By.Id("invalid-url")).Click();
        }

        [TestMethod]
        public void upload_download()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com";

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,200)");

            driver.FindElement(By.CssSelector("div#app > div > div > div:nth-of-type(2) > div > div > div > div")).Click();
            js.ExecuteScript("window.scrollBy(0,200)");

            driver.FindElement(By.CssSelector("li#item-7")).Click();

            driver.FindElement(By.Id("downloadButton")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.CssSelector("input#uploadFile")).SendKeys("C:/Users/Hammad/Desktop/STProject/6.jpg");
        }

        [TestMethod]
        public void dynamic_properties()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/dynamic-properties";

            Thread.Sleep(5000);
            driver.FindElement(By.Id("visibleAfter")).Click();
        }
        [TestMethod]
        public void browser_windows()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/browser-windows";

            driver.FindElement(By.Id("tabButton")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            string actualText = driver.FindElement(By.Id("sampleHeading")).Text;
            Assert.AreEqual("This is a sample page", actualText, "Message not Found");


            driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            driver.FindElement(By.Id("windowButton")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            actualText = driver.FindElement(By.Id("sampleHeading")).Text;
            Assert.AreEqual("This is a sample page", actualText, "Message not Found");

            driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);


            driver.FindElement(By.Id("messageWindowButton")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        [TestMethod]
        public void Alerts()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/alerts";

            driver.FindElement(By.Id("alertButton")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();

            driver.FindElement(By.Id("timerAlertButton")).Click();
            Thread.Sleep(5000);
            driver.SwitchTo().Alert().Accept();

            driver.FindElement(By.Id("confirmButton")).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Dismiss();
            string actualText = driver.FindElement(By.CssSelector("span#confirmResult")).Text;
            Assert.AreEqual("You selected Cancel", actualText, "Message not Found");

            driver.FindElement(By.Id("promtButton")).Click(); Thread.Sleep(1000);
            driver.SwitchTo().Alert().SendKeys("Hammad Tahseen"); Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();

        }
        [TestMethod]
        public void Modal_Dialog()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("Headless");

            IWebDriver driver = new ChromeDriver(chromeOptions);

            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/modal-dialogs";

            driver.FindElement(By.Id("showSmallModal")).Click(); Thread.Sleep(2000);
            driver.FindElement(By.Id("closeSmallModal")).Click();

            driver.FindElement(By.Id("showLargeModal")).Click(); Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("html > body > div:nth-of-type(4) > div > div > div > button > span")).Click();
        }
        [TestMethod]
        public void Widgets()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/accordian";


            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,200)");
            IWebElement Element = driver.FindElement(By.Id("section2Heading"));

            Element.Click();

            js.ExecuteScript("window.scrollBy(0,200)");
            Element = driver.FindElement(By.Id("section3Heading"));
            Element.Click();


        }

        [TestMethod]
        public void Auto_Complete()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/auto-complete";

            IWebElement education = driver.FindElement(By.CssSelector("div#autoCompleteMultipleContainer > div > div"));
            education.Click();
            education.SendKeys("Magenta"); Thread.Sleep(2000);
            education.SendKeys(Keys.ArrowDown); Thread.Sleep(2000);
            education.SendKeys(Keys.Enter);
        }

        [TestMethod]
        public void Date_Picker()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/date-picker";

            IWebElement datepicker = driver.FindElement(By.Id("datePickerMonthYearInput"));
            datepicker.Click();

            datepicker = driver.FindElement(By.CssSelector("div#datePickerMonthYear > div:nth-of-type(2) > div:nth-of-type(2) > div > div > div:nth-of-type(2) > div > div:nth-of-type(2) > div > select"));
            datepicker.Click();

            var selectElement = new SelectElement(datepicker);
            selectElement.SelectByText("Dec");
            datepicker.Click();

            datepicker = driver.FindElement(By.CssSelector("div#datePickerMonthYear > div:nth-of-type(2) > div:nth-of-type(2) > div > div > div:nth-of-type(2) > div > div:nth-of-type(2) > div:nth-of-type(2) > select"));
            datepicker.Click();
            selectElement = new SelectElement(datepicker);
            selectElement.SelectByText("1998");
            datepicker.Click();


            datepicker = driver.FindElement(By.CssSelector("div#datePickerMonthYear > div:nth-of-type(2) > div:nth-of-type(2) > div > div > div:nth-of-type(2) > div:nth-of-type(2) > div > div:nth-of-type(5)"));
            datepicker.Click();

            datepicker = driver.FindElement(By.Id("dateAndTimePickerInput"));
            datepicker.Click();
            datepicker.SendKeys(Keys.Control + "a"); Thread.Sleep(2000);
            datepicker.SendKeys(Keys.Backspace); Thread.Sleep(2000);
            datepicker.SendKeys("June 10, 2022 22:15 PM");

            datepicker = driver.FindElement(By.ClassName("main-header"));
            datepicker.Click();

        }
        [TestMethod]
        public void Sliders()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/slider";

            IWebElement slider = driver.FindElement(By.CssSelector("div#sliderContainer > div > span > input"));

            Actions action = new Actions(driver);
            action.ClickAndHold(slider);
            action.MoveByOffset(0, 20).Build().Perform();
        }
        [TestMethod]
        public void Progress_Bar()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/progress-bar";

            IWebElement bar = driver.FindElement(By.Id("startStopButton"));
            bar.Click();
            Thread.Sleep(7000);
            bar.Click();
        }

        [TestMethod]
        public void Tabs()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/tabs";

            IWebElement tab = driver.FindElement(By.Id("demo-tab-origin")); tab.Click();
            tab = driver.FindElement(By.Id("demo-tab-use")); tab.Click();
        }
        [TestMethod]
        public void tool_tips()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/tool-tips";

            IWebElement hover = driver.FindElement(By.Id("toolTipButton"));
            Actions action = new Actions(driver);
            action.MoveToElement(hover).Perform();

            hover = driver.FindElement(By.Id("toolTipTextField"));
            action.MoveToElement(hover).Perform();

        }
        [TestMethod]
        public void menu()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/menu#";

            IWebElement hover = driver.FindElement(By.CssSelector("ul#nav > li:nth-of-type(2) > a"));
            Actions action = new Actions(driver);
            action.MoveToElement(hover).Perform();


            hover = driver.FindElement(By.CssSelector("ul#nav > li:nth-of-type(2) > ul > li:nth-of-type(3) > a"));
            action = new Actions(driver);
            action.MoveToElement(hover).Perform();


            hover = driver.FindElement(By.CssSelector("ul#nav > li:nth-of-type(2) > ul > li:nth-of-type(3) > ul > li:nth-of-type(2) > a"));
            action = new Actions(driver);
            action.MoveToElement(hover).Perform();

            hover = driver.FindElement(By.CssSelector("ul#nav > li:nth-of-type(3) > a"));
            action = new Actions(driver);
            action.MoveToElement(hover).Perform();
        }

        [TestMethod]
        public void select_menu()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/select-menu";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            IWebElement select_value = driver.FindElement(By.ClassName("css-19bqh2r"));
            select_value.Click();

            select_value = driver.FindElement(By.CssSelector("div#react-select-2-option-0-1"));
            select_value.Click();

            driver.FindElement(By.CssSelector("div#selectMenuContainer")).Click();
            IWebElement occupation = driver.FindElement(By.CssSelector("div#selectOne > div > div"));
            occupation.Click();
            //driver.FindElement(By.CssSelector("div#react-select-3-option-0-1")).Click();
            occupation = driver.FindElement(By.CssSelector("div#react-select-3-option-0-0"));
            occupation.Click();

            IWebElement oldmenu = driver.FindElement(By.Id("oldSelectMenu"));
            oldmenu.Click();
            var selectElement = new SelectElement(oldmenu);
            selectElement.SelectByText("Indigo");
            oldmenu.Click();
            js.ExecuteScript("window.scrollBy(0,200)");



            IWebElement multiselect = driver.FindElement(By.Id("cars"));
            selectElement = new SelectElement(multiselect);

            multiselect.SendKeys(Keys.Control);
            selectElement.SelectByText("Volvo");

            selectElement.SelectByText("Saab");
            selectElement.SelectByText("Audi");

        }


    }

}