# Final Work
## www.w3schools.com Automatic Testing

Preconditions: The User should have an account

TS - Test scenario
TC - Test case

TS01. Verification of Homepage
	TC01. Verify if Menu buttons work properly
		TC01.01. Navigate to Homepage of www.w3schools.com, accept the cookies and maximize he window.
				 Expected result: Homepage is opened and maximized.
		TC01.02. Click Tutorials button.			 	
				 Expected result: Tutorials dropdown menu is displayed.
		TC01.03. Click References button.
				 Expected result: References dropdown menu is displayed.
		TC01.04. Click Exercices button.
				 Expected result: Exercices dropdown menu is displayed.
		TC01.05. Click Bootcamps button.
				 Expected result: Navigates to Bootcamps page.
		TC01.06. Click Logo button.
				 Expected result: Navigates to Homepage
		TC01.07. Click Videos button.
				 Expected result: Navigates to Videos page.
		TC01.08. Click Logo button.
				 Expected result: Navigates to Homepage
		TC01.09. Click Upgrade button.
				 Expected result: Navigates to Upgrade page.
		TC01.10. Click Logo button.
				 Expected result: Navigates to Homepage
		TC01.11. Click Get Certified button.
				 Expected result: Opens Get Certified page in a new window.
		TC01.12. Return to the first window.
				 Expected result: Upgrade page is displayed.
		TC01.13. Click Create Website button.
				 Expected result: Navigates to Create Website page.
		TC01.14. Click Logo button.
				 Expected result: Navigates to Homepage
		TC01.15. Click Sign Up button.
				 Expected result: Navigates to Sign Up page.
		TC01.16. Click Logo button.
				 Expected result: Navigates to Homepage
		TC01.17. Click Log In button.
				 Expected result: Navigates to Log In page.
		TC01.18. Click "x" button.
				 Expected result: Navigates to Homepage.
	TC02. Verify Right corner menu.
		TC02.01. Click Dark mode button.
				 Expected result: Dark mode dropdown menu dropsdow and Dark mode is turned on.
		TC02.02. Click Globe button.
				 Expected result: A field "Pasirinkti kalbą" is displayed.
		TC02.03. Click "Pasirinkti kalbą" field.
				 Expected result: An iframe with list of languages is displayed.
		TC02.04. Click on language "lietuvių".
				 Expected result: Homepage text is displayed in Lithuanian and Main menu remains in English.
		TC02.05. Click Logo button.
				 Expected result: Navigates to Homepage.
		TC02.06. Click Search button.
				 Expected result: Search field is displayed.
		TC02.07. Enter "Tutorials" in the search field.
		TC02.08. Click search icon.
				 Expected result: A tab with a list of w3schools's tutiorials is displayed.
		TC02.09. Click "x" button.
				 Expected result: Navigates to Homepage.
	TC03. Verify Search our tutorials link.
		TC03.01. Enter "HTML" in the Search our tutorials field.
				 Expected result: Dropdown search menu is displayed.
		TC03.02. Click search icon.
				 Expected result: Navigates to HTML Tutorials page.
		TC03.03. Click Click Logo button.
				 Expected result: Navigates to Homepage.
	TC04. Verify Not sure link.
		TC04.01. Click Not Sure Where To Begin? link.
				 Expected result: Navigates to Where To Start page.
		TC04.02. Click Click Logo button.
				 Expected result: Navigates to Homepage.
	TC05. Verify Code Game.
		TC05.01. Click Play game button.
				 Expected result: Code game is opened in a new window.
		TC05.02. Click Go Forward arrow 2 times.
				 Expected result: Two blue arrows appear in empty marked fields.
		TC05.03. Click Play code button.
				 Expected result: The lynx in the picture moves forward and a cone disapears, then a button Play next level is displayed.
		TC05.04. Click Play next level button.
				 Expected result: New picture with the lynx in primal position is displayed.
		TC05.05. Click Go Forward arrow 4 times.
				 Expected result: Four blue arrows appear in empty marked fields.
		TC05.06. Click Play code button.
				 Expected result: The lynx in the picture moves forward and a cone dispears, then a button Play next level is displayed.	
TS02. Verification of HTML Tutorials page.
	TC06. Verify Watch our Video Tutorial link
		TC06.01. Navigate to HTML Tutorials page of www.w3schools.com, accept the cookies and maximize he window.
				 Expected result: Homepage is opened and maximized.
		TC06.02. Click Watch our Video Tutorial button.
				 Expected result: Navigates to HTML Video Tutorial page.
		TC06.03. Click Play button in HTML Video Tutorial page.
				 Expected result: Video starts palying.
		TC06.04. Return to HTML Tutorials page.
				 Expected result: Navigates to HTML Tutorials page
	TC07. Verify Try It Yourself field.
		TC07.01. Click Try It Yourself button.
				 Expected result: A Try it page is opened in a new window.
		TC07.02. Enter "Tai tik pavadinimas" instead "This is a Heading".
		TC07.03. Enter "Tai tik paragrafas" instead of "This is a paragraph".
		TC07.04. Click Run button.
				 Expected result: The right side displays "Tai tik pavadinimas" and "Tai tik paragrafas".
		TC07.05. Switch to the first window.
				 Expected result: HTML Tutorials page is displayed.
	TC08. Verify Start the Exercise link.
		TC08.01. Click Start the Exercise link.
				 Expected result: An Exercise page is opened in a new window.
		TC08.02. Enter "title" in the blank field.
		TC08.03. Click Submit Answer button.
				 Expected result: The page indicates "Correct!".
TS03. Verification of Log In page
	TC09. Verify registration with invalid data.
		TC09.01. Navigate to Log In page of www.w3schools.com, accept the cookies and maximize he window.
				 Expected result: Log In is opened and maximized.
		TC09.02. Enter invalid email in the email field.
		TC09.03. Enter invalid pasword in the password field.
		TC09.04. Click Log in button.
				 Expected result: A message "A user with this email does not exist" is displayed.
	TC10. Verify registration without password
		TC10.01. Enter an email in the email field.
		TC10.02  Click Log in button.
				 Expected result: A message "Make sure you type your email and password correctly. Both your password and email are case-sensitive." is displayed.
	TC11. Verify registration without email
		TC11.01. Enter a pasword in the password field.
		TC11.02  Click Log in button.
				 Expected result: A message "Please enter an email" is displayed.
	TC12. Verify registration with valid data
		TC12.01. Enter a valid email in the email field.
		TC12.02. Enter a valid pasword in the password field.
		TC12.03. Click Log in button.
				 Expected result: Navigates to My Learning page.	
	TC13. Verify Log Out
		TC13.01. Click Log Out button on menu.
				 Expected result: Navigates to Log In page.