using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SmallPlanetsTestSelenium
{
    [TestClass]
    public class CaptainsLogTests
    {
        [TestMethod]
        public void Captains_Log_Is_Displayed()
        {
            IWebDriver driver = CreateDriver();
            driver = NavigateToSolarSystem(driver);
            driver = NavigateToCaptainsLog(driver);
            Thread.Sleep(3000);
            Assert.AreEqual(true, driver.FindElement(By.Id("log_modal")).Displayed);
        }

        [TestMethod]
        public void Captains_Log_Is_Closed()
        {
            IWebDriver driver = CreateDriver();
            driver = NavigateToSolarSystem(driver);
            driver = NavigateToCaptainsLog(driver);
            Thread.Sleep(3000);
            driver.FindElement(By.Id("button_log_close")).Click();
            Thread.Sleep(3000);
            Assert.AreEqual(false, driver.FindElement(By.Id("log_modal")).Displayed);
        }

        [TestMethod]
        public void Clear_Log()
        {
            IWebDriver driver = CreateDriver();
            Populate_Log_With_Planets();
            driver = NavigateToSolarSystem(driver);
            driver = NavigateToCaptainsLog(driver);
            Thread.Sleep(3000);
            IfEnabledClickClearLogButtonInJavascript(driver);
            Thread.Sleep(3000);
            driver = NavigateToCaptainsLog(driver);
            Thread.Sleep(3000);
            int rowCount = GetAmountOfRowsInLog(driver);

            Assert.AreEqual(0, rowCount);

        }

        [TestMethod]
        public void Populate_Log_With_Planets()
        {
            IWebDriver driver = CreateDriver();
            driver = NavigateToSolarSystem(driver);
            driver = NavigateToCaptainsLog(driver);
            IfEnabledClickClearLogButtonInJavascript(driver);

            driver.Manage().Window.Maximize();

            VisitPlanet("mercury", driver);
            VisitPlanet("venus", driver);
            VisitPlanet("earth", driver);
            VisitPlanet("mars", driver);
            VisitPlanet("jupiter", driver);
            VisitPlanet("saturn", driver);
            VisitPlanet("uranus", driver);
            VisitPlanet("neptune", driver);
            VisitPlanet("pluto", driver);
            Thread.Sleep(1000);
            driver = NavigateToCaptainsLog(driver);

            int rowCount = GetAmountOfRowsInLog(driver);
            Assert.AreEqual(9, rowCount);
        }

        private void IfEnabledClickClearLogButtonInJavascript(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("button_clear"));

            if (element.Enabled)
            {
                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                executor.ExecuteScript("arguments[0].click();", element);
            }
            else
            {
                Thread.Sleep(1000);
                driver.FindElement(By.Id("button_log_close")).Click();
            }

        }

        private int GetAmountOfRowsInLog(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("span_empty_log_message"));

            if (element.Displayed)
            {
                return 0;
            }

            return driver.FindElements(By.XPath("//*[@id='log_table']/tbody/tr/tr")).Count;
        }

        private void VisitPlanet(string planetXPath, IWebDriver driver)
        {

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            driver.FindElement(By.ClassName(planetXPath)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("button_close_planet")).Click();
            Thread.Sleep(1000);
        }

        private IWebDriver NavigateToCaptainsLog(IWebDriver driver)
        {
            driver.FindElement(By.Id("button_captains_log")).Click();
            return driver;
        }

        private IWebDriver NavigateToSolarSystem(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://localhost:4657/");
            return driver;
        }

        private IWebDriver CreateDriver()
        {
            return new ChromeDriver();
        }
    }
}
