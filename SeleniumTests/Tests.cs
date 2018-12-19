using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using ValtechPages;
using ValtechPages.ValTechPageObjects;
using System;


namespace SeleniumTests
{
    [TestClass]
    public class Tests
    {
        public ChromeDriver driver;
        public ValtechPages.ValTechPageObjects.MainNavigation mainNav;
        public ValtechPages.ValTechPageObjects.AboutPage aboutPage;
        public ValtechPages.ValTechPageObjects.ServicesPage servicesPage;
        public ValtechPages.ValTechPageObjects.WorkPage workPage;
        ChromeOptions chromeOptions = new ChromeOptions();


        [TestInitialize]
        public void TestInitialize()
        {
            //Instantiate the object for the Webdriver and the Page Object class called MaingNavigation

            chromeOptions.AddArgument("disable-infobars");
            driver = new ChromeDriver(chromeOptions);
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(30);
            mainNav = new MainNavigation(driver: driver);

            //Open the Valtech homepage in Chrome and maximise the window
            driver.Navigate().GoToUrl("https://www.valtech.co.uk");
            driver.Manage().Window.Maximize();

            //Click 'Accept cookies' button on the banner displayed on the homepage
            mainNav = mainNav.AcceptCookies();
        }


        [TestMethod]
        public void Excercises()
        {


            //About Page Test
            mainNav = mainNav.OpenMainNav();
            aboutPage = mainNav.OpenAboutPage();

            //verify that the H1 tag is displayed correctly in the About page
            aboutPage = aboutPage.FindAboutPageHeading();
            Assert.AreEqual(expected: "h1", actual: aboutPage.AboutPageHeading.TagName);


            //Services Page Test
            mainNav = mainNav.OpenMainNav();
            servicesPage = mainNav.OpenServicesPage();
            //verify that the H1 tag is displayed correctly in the Services page

            servicesPage = servicesPage.FindServicesPageHeading();
            Assert.AreEqual(expected: "Our Services", actual: servicesPage.ServicesPageHeading.Text);

            //Work Page Test



            driver.Quit();
           /*
            //Verify that the Recent Blogs section is present on the Home Page
            //IWebElement recentBlogs = mainNav.FindRecentBlogsSection();
            // Assert.AreEqual("Recent Blogs", recentBlogs);
            //Open the first blog
            //mainNav.ClickFirstBlogItem();
            
        
            [TestCleanup]

        public void TestCleanup() => driver.Quit(); */

    }

    }
}
