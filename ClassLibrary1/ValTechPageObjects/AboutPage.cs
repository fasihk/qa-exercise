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
    public class AboutPage
    {
        private ChromeDriver driver ;
        public IWebElement AboutPageHeading;

        //Locate the About Page Heading
        readonly By AboutPageHeadingLocator = By.XPath("//div[@class='site-chapter__box']//following::h1");
        
        public AboutPage(ChromeDriver driver)
        {
            this.driver = driver;
        }

        public AboutPage FindAboutPageHeading()
        {
            //const String attributeName = "class";
            AboutPageHeading = driver.FindElement(AboutPageHeadingLocator);
           
            return this;
        }
    }
}
