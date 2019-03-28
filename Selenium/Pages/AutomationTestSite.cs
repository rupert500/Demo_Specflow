using System;
using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium.Support;

namespace Selenium.Pages
{
    public class AutomationTestSite
    {
        public PageName PageName;
        public string BaseUrl;
        private ChromeDriver WebDriver;
        private Collection<TestPage> Pages;

        public AutomationTestSite()
        {
            //WebDriver = new ChromeDriver(@"C:\Users\rupertf\Desktop\chromedriver");
            WebDriver = new ChromeDriver();
            BaseUrl = "https://www.sitekit.net/";
            Pages = InitializePages();
        }

        private Collection<TestPage> InitializePages()
        {
            return new Collection<TestPage>
            {
				new HomePage(WebDriver),

            };
        }

        public void GoTo()
        {
            WebDriver.Navigate().GoToUrl(BaseUrl);
        }

        public bool PageLoaded()
        {
            try
            {
                var waitForDocumentReady = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
                waitForDocumentReady.Until((wdriver) =>
                    (WebDriver as IJavaScriptExecutor).ExecuteScript("return document.readyState").Equals("complete"));
                return true;
            }
            catch (TimeoutException timeoutException)
            {
                return false;
            }
        }

        public TestPage GetPage(PageName pageName)
        {
            return Pages.FirstOrDefault(page => page.Name.Equals(pageName));
        }

        async public void ClickLink(PageName pageName, String link)
        {
            //var locator = GetPage(pageName).GetLocator(element);
            WebDriver.FindElement(By.LinkText(link)).Click();
            System.Threading.Thread.Sleep(5000);
        }

        public bool ConfirmTextPresent(PageName pageName, string text)
        {
            return WebDriver.FindElement(By.Id("contact")).Text.Contains(text);
          
        }

        public void Dispose()
        {
            WebDriver.Dispose();
        }
    }
}
