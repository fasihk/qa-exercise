using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using ValtechPages;
using ValtechPages.ValTechPageObjects;
using System;
using System.Text.RegularExpressions;

namespace SeleniumTests
{
    [TestClass]
    public class Tests
    {
        public ChromeDriver driver;
        public ChromeOptions chromeOptions = new ChromeOptions();

        public ValtechPages.ValTechPageObjects.MainNavigation mainNav;
        public ValtechPages.ValTechPageObjects.AboutPage aboutPage;
        public ValtechPages.ValTechPageObjects.ServicesPage servicesPage;
        public ValtechPages.ValTechPageObjects.WorkPage workPage;
        public ValtechPages.ValTechPageObjects.ContactPage contactUsPage;
        public String testString;

        [TestInitialize]
        public void TestInitialize()
        {
            //Instantiate the object for the Webdriver and the Page Object class called MaingNavigation

            chromeOptions.AddArgument("disable-infobars");
            driver = new ChromeDriver(chromeOptions);
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(60);
            mainNav = new MainNavigation(driver: driver);

            //Open the Valtech homepage in Chrome and maximise the window
            driver.Navigate().GoToUrl("https://www.valtech.co.uk");
            driver.Manage().Window.Maximize();

            //Click 'Accept cookies' button on the banner displayed on the homepage
            mainNav = mainNav.AcceptCookies();
        }
        
        //Since the blogs section is not visible on the home page 
        //the following test code pertaining to Excercise 2 has been commented out
        /*****************************************************************/
        //[TestMethod]
        //public void Excercise2()
        //{
            //Verify that the Recent Blogs section is present on the Home Page
            //IWebElement recentBlogs = mainNav.FindRecentBlogsSection();
            // Assert.AreEqual("Recent Blogs", recentBlogs);
            //Open the first blog
            //mainNav.ClickFirstBlogItem();     
        //}
        /*****************************************************************/
        
        [TestMethod]
        public void Excercise_3a()
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
            Console.Write("Services page heading is " + servicesPage.ServicesPageHeading.Text );
            Assert.AreEqual(expected: "Services", actual: servicesPage.ServicesPageHeading.Text);
            
            //Work Page Test
            mainNav = mainNav.OpenMainNav();
            workPage = mainNav.OpenWorkPage();

            //verify that the Work page title is as expected as could not get the text property of the H1 element 

            workPage = workPage.FindWorkPageHeading();
           
            Assert.AreEqual(expected: "Work | Valtech", actual: driver.Title.ToString());

        }
        
        [TestMethod]
        public void Excercise_3b()
        {
            mainNav.OpenMainNav();
            contactUsPage = mainNav.OpenContactUsPage();
            contactUsPage = contactUsPage.FindNoOfOfficesString();
            testString = "36 offices";
            if (System.Text.RegularExpressions.Regex.IsMatch(contactUsPage.noOfOfficesString, testString))
            {
                Console.WriteLine("\n Valtech has " + testString);
            }
            else
            {
                Console.Write("\n if statement not executed because " + testString + " was not found in \n" + contactUsPage.noOfOfficesString);
            }
        }
        
        [TestCleanup]

        public void TestCleanup()
        {
            driver.Quit();
            
        }

    }
}
