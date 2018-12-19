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
        IWebDriver driver = new ChromeDriver();
        public IWebElement WorkPageHeading;

        //Locate elements on the page that the tests have to interact with 
        readonly By LorealWorkLocator = By.XPath("//*[@id='valtech-wrapper']/div/main/div[3]/div/div/div/div[1]/div/a");

        public WorkPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public WorkPage FindWorkPageHeading()
        {
            WorkPageHeading = driver.FindElement(LorealWorkLocator);
            return this;
        }
    }
}
