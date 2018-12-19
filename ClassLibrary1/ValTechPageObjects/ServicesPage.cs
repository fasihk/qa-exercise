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
        private IWebDriver driver;
        public IWebElement ServicesPageHeading;

        //Locate elements on the page that the tests have to interact with 
        public By ServicesPageHeadingLocator = By.XPath("//div[@class='site-chapter__box']//following::h1");
        
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
