Feature: Makemytriplogin
verify that the login page functionalties are working as expected

Scenario: verify that a registered user is able to login
Given I am a registered makemytrip user
When I open the login page
And enter valid credentials
Then i will be able to login successfully