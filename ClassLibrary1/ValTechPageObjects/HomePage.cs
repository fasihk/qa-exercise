using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;


namespace ValTechPageObjectModel

{
    public class HomePage
    {
        private IWebDriver webDriverObj;

        [FindsBy(How = How.Name, Using = "recent blogs")]
        public IWebElement RecentBlogsSection { get; set; }

        [FindsBy(How = How.LinkText, Using = "The future for DevOps")]
        public IWebElement FirstBlogListingItem { get; set; }

    }

}
