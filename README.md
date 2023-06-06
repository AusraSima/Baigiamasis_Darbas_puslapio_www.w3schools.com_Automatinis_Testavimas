# Final Work of Automated Testing Course
## [tested website www.w3schools.com](https://www.w3schools.com)

**Preconditions: The User already has an account for Log In.**

Test Data: 
<ul>
<li>Browser: Chrome Version 109.0.5414.141</li>
<li>Operating System: Windows 8.1</li>
</ul>

Test Environment:
<ul>
<li>Selenium WebDriver version 4.9.0</li>
</ul>

Abbreviations:
<ul>
<li>TS - Test scenario</li>
<li>TC - Test case</li>
</ul>

###Test steps
<ul>
<li>TS01. Verification of Homepage buttons and links
	<ul>
	      <li>TC01. Open Homepage, maximize window and Accept Cookies
		      <ul>
			        <li>TC01.01. Navigate to Homepage.</li>
					<li>TC01.02. Maximize the window.</li>
					<li>TC01.03. Accept cookies.</li>
					             Expected result: The Homepage is opened, maximized, and the cookies are accepted.
			  </ul>
		  </li>
		  <li>TC02. Verify Tutorials Menu
		      <ul>
			        <li>TC02.01. Verify the text of the Tutorials button.</li>
					             Expected result: Tutorials button text matches the expected value.
					<li>TC02.02. Click Tutorials button.</li>
					             Expected result: Tutorials dropdown menu is displayed.
					<li>TC02.03. Verify the text of the Tutorials dropdown menu.</li>
					             Expected result: Tutorials dropdown menu text matches the expected value.
			  </ul>
		  </li>
		  <li>TC03. Verify References Menu
		      <ul>
			        <li>TC03.01. Verify the text of the References button.</li>
								 Expected result: References button text matches the expected value.
					<li>TC03.02. Click References button.</li>
								 Expected result: References dropdown menu is displayed.
					<li>TC03.03. Verify the text of the References dropdown menu.</li>
					             Expected result: References dropdown menu text matches the expected value.
			  </ul>
		  </li>
		  <li>TC04. Verify Exercises Menu
		      <ul>
			        <li>TC04.01. Verify the text of the Exercises button.</li>
								 Expected result: Exercises button text matches the expected value.
					<li>TC04.02. Click Exercises button.</li>
								 Expected result: Exercises dropdown menu is displayed.
					<li>TC04.03. Verify the text of the Exercises dropdown menu.</li>
								 Expected result: Exercises dropdown menu text matches the expected value.
			  </ul>
		  </li>
		  <li>TC05. Verify Bootcamps Menu
		      <ul>
			        <li>TC05.01. Verify the text of the Bootcamps button.</li>
					             Expected result: Bootcamps button text matches the expected value.
					<li>TC05.02. Click Bootcamps button.</li>
								 Expected result: Bootcamps page is displayed.
					<li>TC05.03. Verify the text of the Bootcamps page.</li>
								 Expected result: Bootcamps page text matches the expected value.
			  </ul>
		  </li>
		  <li>TC06. Verify Videos Menu
		      <ul>
					<li>TC06.01. Verify the text of the Videos button.</li>
								 Expected result: Videos button text matches the expected value.
					<li>TC06.02. Click Videos button.</li>
								 Expected result: Videos page is displayed.
					<li>TC06.03. Verify the text of the Videos page.</li>
								 Expected result: Videos page text matches the expected value.
			  </ul>
		  </li>
		  <li>TC07. Verify Upgrade Menu
		      <ul>
			        <li>TC07.01. Verify the text of the Upgrade button.</li>
								 Expected result: Upgrade button text matches the expected value.
					<li>TC07.02. Click Upgrade button.</li>
								 Expected result: Upgrade page is displayed
					<li>TC07.03. Verify the text of the Upgrade page.</li>
								 Expected result: Upgrade page text matches the expected value.
			  </ul>
		  </li>
		  <li>TC08. Verify Get Certified Menu
		      <ul>
					<li>TC08.01. Verify the text of the Get Certified button.</li>
								 Expected result: Get Certified button text matches the expected value.
					<li>TC08.02. Click Get Certified button.</li>
								 Expected result: Get Certified page is displayed
					<li>TC08.03. Verify the text of the Get Certified page.</li>
								 Expected result: Get Certified page text matches the expected value.
			  </ul>
		  </li>
		  <li>TC09. Verify Create Website Menu
		      <ul>
					<li>TC09.01. Verify the text of the Create Website button.</li>
								 Expected result: Create Website button text matches the expected value.
					<li>TC09.02. Click Create Website button.</li>
								 Expected result: Create Website page is displayed
					<li>TC09.03. Verify the text of the Create Website page.</li>
								 Expected result: Create Website page text matches the expected value.
			  </ul>
		  </li>
		  <li>TC10. Verify Sign Up Menu
		      <ul>
					<li>TC10.01. Verify the text of the Sign Up button.</li>
								 Expected result: Sign Up button text matches the expected value.
					<li>TC10.02. Click Sign Up button.</li>
								 Expected result: Sign Up page is displayed
					<li>TC10.03. Verify the text of the Sign Up page.</li>
								 Expected result: Sign Up page text matches the expected value.
			  </ul>
		  </li>
		  <li>TC11. Verify Log In Menu
		      <ul>
					<li>TC11.01. Verify the text of the Log In button.</li>
								 Expected result: Log In  button text matches the expected value.
					<li>TC11.02. Click Log In button.</li>
								 Expected result: Log In page is displayed
					<li>TC11.03. Verify the text of the Log In page.</li>
								 Expected result: Log In page text matches the expected value.
			  </ul>
		  </li>
		  <li>TC12. Verify Dark Mode Menu
		      <ul>
					<li>TC12.01. Verify the text of the Dark Mode button.</li>
					             Expected result: Dark Mode button text matches the expected value.
					<li>TC12.02. Verify the text of the Dark Code button.</li>
								 Expected result: Dark Code button text matches the expected value.					
			  </ul>
		  </li>
		  <li>TC13. Verify Language Menu
		      <ul>
					<li>TC13.01. Click Globe button.</li>
					             Expected result: A Pasirinkti kalbą selection button is displayed
					<li>TC13.02. Click Pasirinkti kalbą button.</li>
								 Expected result: A lisl of languages is displayed
					<li>TC13.03. Click lietuvių in the list of languages.</li>
								 Expected result: Navigates to Homepage translated into Lithuanian.
					<li>TC13.04. Verify if the text of the Homepage is translated.</li>
					             Expected result: Homepage text matches the expected value.					
			  </ul>
		  </li>
		  <li>TC14. Verify Search Menu functionality
		      <ul>
					<li>TC14.01. Click Search button.</li>
					             Expected result: A search field is displayed
					<li>TC14.02. Enter phrase Tutorials in the search field.</li>
					<li>TC14.03. Click Search icon.</li>
								 Expected result: A list of tutorials is displayed.
					<li>TC14.04. Verify if the search result contains a search phrase.</li>
					             Expected result: Search result contains the search phrase.					
			  </ul>
		  </li>
		  <li>TC15. Verify the field Search functionality
		      <ul>
					<li>TC15.01. Enter the search phrase "html" in the search field.</li>
					<li>TC15.02. Click Search button.</li>
								 Expected result: A list HTML tutorials is displayed.
					<li>TC15.03. Verify if the search result contains a search phrase.</li>
					             Expected result: Search result text matches the expected value.					
			  </ul>
		  </li>
		  <li>TC16. Verify the "Not Sure Where To Begin?" link
		      <ul>
					<li>TC16.01. Verify the text of the "Not Sure Where To Begin?" link.</li>
					             Expected result: "Not Sure Where To Begin?" link text matches the expected value.					
			  </ul>
		  </li>
		  <li>TC17. Play the Code Game
		      <ul>
					<li>TC17.01. Click Play Game button.</li>
								 Expected result: Navigates to game page.					
					<li>TC17.02. Click Go Forward button twice.</li>
					<li>TC17.03. Click Play code button.</li>
								 Expected result: Lynx moves forward.
					<li>TC17.04. Click Play Next Level button.</li>
								 Expected result: Next level page is displayed.	
					<li>TC17.05. Click Go Forward button 4 times.</li>
					<li>TC17.06. Click Play code button.</li>
					             Expected result: Lynx moves forward.					
			  </ul>
		  </li>
	</ul>
</li>
<li>TS02. Verification of HTML Tutorials page.
	<ul>
		  <li>TC18. Open HTML Tutorials page, maximize window and Accept Cookies
		      <ul>
			        <li>TC18.01. Navigate to HTML Tutorials page.</li>
					<li>TC18.02. Maximize the window.</li>
					<li>TC18.03. Accept cookies.</li>
					             Expected result: HTML Tutorials page is opened, maximized, and the cookies are accepted.
			  </ul>
		  </li>
		  <li>TC19. Verify Watch Our Video Tutorial Field
		      <ul>
			        <li>TC19.01. Verify the text of the Watch Our Video Tutorial button.</li>
					             Expected result: Watch Our Video Tutorial button text matches the expected value.
					<li>TC19.02. Click Tutorials button.</li>
					             Expected result: Navigates to Video Tutorial page.
					<li>TC19.03. Verify the text of the Video play button.</li>
					             Expected result: Video play button text matches the expected value.
			  </ul>
		  </li>
		  <li>TC20. Verify Try It Yourself Field
		      <ul>
			        <li>TC20.01. Click Try It Yourself button</li>
								 Expected result: Navigates to Try It page.
					<li>TC20.02. Enter "Tai tik pavadinimas" as heading.</li>
					<li>TC20.03. Enter "Tai tik paragrafas" as paragraph.</li>
					<li>TC20.04. Click Run button.</li>
					             Expected result: Heading and paragraph indicate the phrases entered.
			  </ul>
		  </li>
		  <li>TC21. Verify Test Yourself With Exercises Field
		      <ul>
			        <li>TC21.01. Click Start the Exercise button.</li>
								 Expected result: Navigates to Exercise page.
					<li>TC21.02. Enter "title" into empty field.</li>
					<li>TC21.03. Click Submit Answer button.</li>
					<li>TC21.04. Verify the text of answer.</li>
					             Expected result: Answer text matches the expected value.
			  </ul>
		  </li>
	</ul>
</li>
<li>TS03. Verification of Log In page.
	<ul>
		  <li>TC22. Open Log In page amd maximize window
		      <ul>
			        <li>TC22.01. Navigate to Log In page.</li>
					<li>TC22.02. Maximize the window.</li>
					             Expected result: Log In page is opened and maximized.
			  </ul>
		  </li>
		  <li>TC23. Verify Login With Invalid Data
		      <ul>
			        <li>TC23.01. Enter "rob@handleride.com" as email.</li>
					<li>TC23.02. Enter "159AbCd" as password.</li>
					<li>TC23.03. Click Log in button.</li>
								 Expected result: Message "A user with this email does not exist" is displayed.
					<li>TC23.04. Verify the text of the message.</li>
								 Expected result: The message text matches the expected value.					
			  </ul>
		  </li>
		  <li>TC24. Verify Login Without Password
		      <ul>
			        <li>TC24.01. Enter "avasims@handleride.com" as email.</li>
					<li>TC24.02. Click Log in button.</li>
								 Expected result: Message "Make sure you type your email and password correctly. Both your password and email are case-sensitive." is displayed.
					<li>TC24.03. Verify the text of the message.</li>
								 Expected result: The message text matches the expected value.					
			  </ul>
		  </li>
		  <li>TC25. Verify Login Without Email
		      <ul>
			        <li>TC25.01. Enter "QijHRYEc15#" as password.</li>
					<li>TC25.02. Click Log in button.</li>
								 Expected result: Message "Please enter an email" is displayed.
					<li>TC25.03. Verify the text of the message.</li>
								 Expected result: The message text matches the expected value.					
			  </ul>
		  </li>
		   <li>TC26. Verify Login With Valid Data
		      <ul>
			        <li>TC26.01. Enter "avasims@handleride.com" as email.</li>
					<li>TC26.02. Enter "QijHRYEc15#" as password.</li>
					<li>TC26.03. Click Log in button.</li>
								 Expected result: Navigates to My learning page.
					<li>TC26.04. Verify the text of My learning page.</li>
								 Expected result: My learning page text matches the expected value.
					<li>TC26.05. Click Log out button.</li>
								 Expected result: Navigates to Log In page.
					<li>TC23.04. Verify the text of Log In page.</li>
								 Expected result: Log In page text matches the expected value.					
			  </ul>
		  </li>
	</ul>
</li>
</ul>