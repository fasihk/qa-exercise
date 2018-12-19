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
    public class ContactPage
    {
        private IWebDriver driver;
        public String noOfOfficesString;

        //Locate elements on the page that the tests have to interact with 
        readonly By noOfOfficesStringLocator = By.XPath("//*[@id='valtech-wrapper']/div/main/vue/div/div[2]/div/div[1]/h3");
        
        public ContactPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public ContactPage FindNoOfOfficesString()
        {
            noOfOfficesString = driver.FindElement(noOfOfficesStringLocator).Text;
            return this;
        }
    }
}
