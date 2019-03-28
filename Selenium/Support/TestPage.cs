using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.Support
{
    public abstract class TestPage
    {
        public PageName Name { get; protected set; }
        protected ChromeDriver WebDriver;
        public string Url { get; protected set; }

        protected void Setup(ChromeDriver webDriver)
        {
            WebDriver = webDriver;
        }

    }
}
