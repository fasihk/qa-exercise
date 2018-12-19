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
    public class WorkPage
    {
         private IWebDriver driver;
        public IWebElement WorkPageHeading;

        //Locate elements on the page that the tests have to interact with 
        
        public By WorkPageHeadingLocator = By.XPath("//h1[@class='site-chapter__box__title']");

        //alternative element XPath could be //*[@id="valtech-wrapper"]/div/main/div[1]/div/div[2]/h1
        //or "//h1[@class='site-chapter__box__title']"
        // or //hgroup[@class='masthead-secondary__hgroup']//following::h2

        public WorkPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public WorkPage FindWorkPageHeading()
        {
            WorkPageHeading = driver.FindElement(WorkPageHeadingLocator);
            return this;
        }
        
    }
}
