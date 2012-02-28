using System;
using OpenQA.Selenium;

namespace Specs.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver Browser { get; set; }

        protected string Url { get; set; }

        protected BasePage(IWebDriver browser)
        {
            Browser = browser;
        }

        public void Navigate()
        {
            if (String.IsNullOrEmpty(Url))
            {
                throw new ArgumentNullException("Url", "Pages must set their Url for the Navigate function to work");
            }

            Browser.Navigate().GoToUrl(Url);
        }
    }
}
