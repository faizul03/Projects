Feature: Inquiry Form
	As a user of Jackson Hewitt Website 
	I want to be able to sign up for Jackson Hewitt preparation
	So that I can become a tav preparer 


@regression
@Browser: Chrome


Scenario Outline: Inquiry
Given that I am a Web user 
When I navigate to the become a tax preparer link from the home page
Then I should be able to complete and submit inquiry  by providing the following information <FirstName>and<lastName>and<StreetAddress>and<City>and<ZipCode>and<State>and<ContactNumber>and<Email>and<ReEnterEmail>and<AboutJacksonHewitt>and<Specify>and<InterestInJacksonHewitt>
And I should be shown the thank you page

Examples: 

| FirstName | lastName | StreetAddress		| City        | ZipCode | State | ContactNumber | Email                 | ReEnterEmail          | AboutJacksonHewitt | Specify | InterestInJacksonHewitt |
| Peter     | Parker   | 501 N Cattleman Rd | Little Rock | 72211   | AR    | 9243130150    | faizul.islam@jtax.com | faizul.islam@jtax.com | Trade Show         | Expo    | Other                   |
#| Adam      | Smith    | 7721 Front St      | New York    | 72211   | AR    | 5555555555    | adamamith@gnail.com   | adam.smith@gnail.com  | Other              |         | TV                      |
#| Tor       | Hulk     | 8140 North Ave     | Garden City | 32331   | NY    | 2122345679    | tor.hulk@gnail.com    | tor.hulk@gnail.com    | Expo               |         | tv                      |

 

