using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using ValtechPages.ValTechPageObjects;


namespace ValtechPages.ValTechPageObjects
{
    public class ServicesPage
    {
        IWebDriver driver = new ChromeDriver();
        public IWebElement ServicesPageHeading;

        //Locate elements on the page that the tests have to interact with 
        readonly By ServicesPageHeadingLocator = By.XPath("//hgroup[@class='masthead-secondary__hgroup']//following::h1");
        
        public ServicesPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public ServicesPage FindServicesPageHeading()
        {
            ServicesPageHeading =  driver.FindElement(ServicesPageHeadingLocator);
            return this;
        }
    }
}
