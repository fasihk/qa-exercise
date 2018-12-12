using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//this references the class library ValTechPageObjects.dll

namespace ValTechAutomationFramework

{
    public class HomePage
    {
        IWebDriver driver = new ChromeDriver();
        public HomePage (IWebDriver driver)
        {
            this.driver = driver;
        }
        //Locate elements on the page that the tests have to interact with 

        By AcceptCookieButton = By.Id("CybotCookiebotDialogBodyButtonAccept");
        By recentBlogs = By.Name("recent blogs");
        By FirstBlogListingItem = By.LinkText("The future for DevOps");


        public void AcceptCookies()
        {
            driver.FindElement(AcceptCookieButton).Click();
        }

        public IWebElement FindRecentBlogsSection()
        {
           return driver.FindElement(recentBlogs);
        }

        public void ClickFirstBlogItem ()
        {
            driver.FindElement(FirstBlogListingItem).Click();

        }

    }

}
