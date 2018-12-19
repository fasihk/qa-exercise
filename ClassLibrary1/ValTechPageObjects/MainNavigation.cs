using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using ValtechPages.ValTechPageObjects;

namespace ValtechPages.ValTechPageObjects

{
    public class MainNavigation
    {
        private ChromeDriver driver;
        
        //Locate elements on the page that the tests have to interact with 
        By AcceptCookieButton = By.Id("CybotCookiebotDialogBodyButtonAccept");
        By MainNavIcon = By.XPath("/html/body/nav/div[1]/button[1]");
        By MainNavContactUsLink = By.XPath("/html/body/nav/div[2]/div[1]/div[3]/div/ul[2]/ul/li[3]/a");
        By AboutMenuItem = By.XPath("/html/body/nav/div[2]/div[1]/div[3]/div/ul[1]/li[5]/button");
        By AboutMenuItemButton = By.XPath("/html/body/nav/div[2]/div[1]/div[2]/div/div[5]/div[2]/a");
        By ServicesMenuItem = By.XPath("/html/body/nav/div[2]/div[1]/div[3]/div/ul[1]/li[2]/button");
        By ServicesMenuItemButton = By.XPath("/html/body/nav/div[2]/div[1]/div[2]/div/div[2]/div[2]/a");
        By WorkMenuItem = By.XPath("/html/body/nav/div[2]/div[1]/div[3]/div/ul[1]/li[1]/button");
        By WorkMenuItemButton = By.XPath("/html/body/nav/div[2]/div[1]/div[2]/div/div[1]/div[2]/a");

        public MainNavigation (ChromeDriver driver)
        {
            this.driver = driver;    
        }

        public MainNavigation AcceptCookies()
        {
            driver.FindElement(AcceptCookieButton).Click();
            return this;
        }

        public MainNavigation OpenMainNav()
        {
           driver.FindElement(MainNavIcon).Click();
           return this; 
        }

        public AboutPage OpenAboutPage()
        {
            driver.FindElement(AboutMenuItem).Click();
            driver.FindElement(AboutMenuItemButton).Click();
            return new AboutPage(driver);
        }

        public ServicesPage OpenServicesPage()
        {
            driver.FindElement(ServicesMenuItem).Click();
            driver.FindElement(ServicesMenuItemButton).Click();
            return new ServicesPage(driver);
        }

        public WorkPage OpenWorkPage()
        {
            driver.FindElement(WorkMenuItem).Click();
            driver.FindElement(WorkMenuItemButton).Click();
            return new WorkPage(driver);
        }

        public ContactPage OpenContactUsPage()
        {
            driver.FindElement(MainNavContactUsLink).Click();
            return new ContactPage(driver);
        }

        /*
        By recentBlogs = By.Name("recent blogs");
        By FirstBlogListingItem = By.LinkText("The future for DevOps");
        */

        /* public IWebElement FindRecentBlogsSection()
         {
            return driver.FindElement(recentBlogs);
         }

         public void ClickFirstBlogItem ()
         {
             driver.FindElement(FirstBlogListingItem).Click();

         }*/

    }

}
