using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Support;

namespace Selenium.Pages
{
    public class HomePage : TestPage
    {
        public HomePage(ChromeDriver webDriver)
        {
            Setup(webDriver);
            Name = PageName.Home;
            Url = "http://sitekit.net";
        }

    }
}
