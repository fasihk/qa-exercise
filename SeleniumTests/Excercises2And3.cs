using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using ValTechAutomationFramework;

namespace SeleniumTests
{
    [TestClass]
    public class Exercises2And3
    {
        
        [TestMethod]
        public void Excercise2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.valtech.co.uk");
            driver.Manage().Window.Maximize();
            

            //Instantiate the object for the HomePage POM class
            HomePage homePage = new HomePage(driver);

            //Click 'Accept cookies' button on banner displayed on the homepage
            homePage.AcceptCookies();
            
            //Verify that the Recent Blogs section is present on the Home Page
            //IWebElement recentBlogs = homePage.FindRecentBlogsSection();
            // Assert.AreEqual("Recent Blogs", recentBlogs);

             //homePage.ClickFirstBlogItem();

        
            driver.Close();
            driver.Quit();



        }
    }
}
