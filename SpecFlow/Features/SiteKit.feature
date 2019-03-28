Feature: Sitekit test in specflow

Scenario: Contact Phone Number
	Given I have navigated to my test site
	When I click the Contact Link
	Then The contact details has the correct number

	Scenario: Offices
	Given I have navigated to my test site
	When I click the Contact Link
	Then The correct offices are shown

