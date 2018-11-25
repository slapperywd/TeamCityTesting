namespace TeamCityTesting
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;

        public UnitTest1()
        {
            this.driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
            this.driver.Navigate().GoToUrl("https://www.jetbrains.com/");
        }

        [TestMethod]
        public void JetBrainsTitleTest()
            => Assert.IsTrue(this.driver.Title.Equals("JetBrains: Developer Tools for Professionals and Teams"));

        [TestMethod]
        public void JetBrainsLogoShouldBeDisplayedOnHomePage() 
            => Assert.IsTrue(this.driver.FindElement(By.ClassName("header-logo")).Displayed);

        [TestCleanup]
        public void TestCleanUp()
        {
            this.driver.Quit();
        }
    }
}
