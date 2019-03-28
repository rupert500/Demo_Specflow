﻿using NUnit.Framework;
using Selenium.Pages;
using Selenium.Support;
using TechTalk.SpecFlow;

namespace SpecFlow.Steps
{
    [Binding]
    public class SpecFlowSeleniumSampleSteps
    {
        private AutomationTestSite automationTestSite;
       // private User user;

        public SpecFlowSeleniumSampleSteps(AutomationTestSite automationTestSite)
        {
            this.automationTestSite = automationTestSite;
          //  this.user = user;
        }

        [Given(@"I have navigated to my test site")]
        public void GivenIHaveNavigatedToMyTestSite()
        {
            automationTestSite.GoTo();
        }

        [When(@"I click the Contact Link")]
        public void WhenIClickTheContactLink()
        {
            automationTestSite.ClickLink(PageName.Home, "contact");
        }

        [Then(@"The contact details has the correct number")]
        public void ThenTheContactDetailsHasTheCorrectNumber()
        {
            Assert.IsTrue(automationTestSite.ConfirmTextPresent(PageName.Home, "0845"));
        }

        [Then(@"The correct offices are shown")]
        public void ThenTheCorrectOfficesAreShown()
        {
            Assert.IsTrue(automationTestSite.ConfirmTextPresent(PageName.Home, "Oxford"));
            Assert.IsTrue(automationTestSite.ConfirmTextPresent(PageName.Home, "London"));
        }
    }
}

