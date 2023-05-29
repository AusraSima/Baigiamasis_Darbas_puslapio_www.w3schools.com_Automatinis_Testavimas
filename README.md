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
<li>TS01. Verification of Homepage
	<ul>
	  <li>TC01. Verify if Menu buttons work properly
		  <ul>
	  	    <li>TC01.01. Navigate to Homepage of www.w3schools.com, accept the cookies and maximize he window.</li>
				         Expected result: Homepage is opened and maximized.
		    <li>TC01.02. Click Tutorials button.</li>
				         Expected result: Tutorials dropdown menu is displayed.
		    <li>TC01.03. Click References button.</li>
				         Expected result: References dropdown menu is displayed.
		    <li>TC01.04. Click Exercices button.</li>
				         Expected result: Exercices dropdown menu is displayed.
		    <li>TC01.05. Click Bootcamps button.</li>
				         Expected result: Navigates to Bootcamps page.
		    <li>TC01.06. Click Logo button.</li>
				         Expected result: Navigates to Homepage
		    <li>TC01.07. Click Videos button.</li>
				         Expected result: Navigates to Videos page.
		    <li>TC01.08. Click Logo button.</li>
			   	         Expected result: Navigates to Homepage
		    <li>TC01.09. Click Upgrade button.</li>
				         Expected result: Navigates to Upgrade page.
		    <li>TC01.10. Click Logo button.</li>
			  	         Expected result: Navigates to Homepage
		    <li>TC01.11. Click Get Certified button.</li>
				         Expected result: Opens Get Certified page in a new window.
		    <li>TC01.12. Return to the first window.</li>
				         Expected result: Upgrade page is displayed.
		    <li>TC01.13. Click Create Website button.</li>
				         Expected result: Navigates to Create Website page.
		    <li>TC01.14. Click Logo button.</li>
				         Expected result: Navigates to Homepage
		    <li>TC01.15. Click Sign Up button.</li>
				         Expected result: Navigates to Sign Up page.
		    <li>TC01.16. Click Logo button.</li>
				         Expected result: Navigates to Homepage
		    <li>TC01.17. Click Log In button.</li>
				         Expected result: Navigates to Log In page.
		    <li>TC01.18. Click "x" button.</li>
				         Expected result: Navigates to Homepage.
	      </ul>
	  </li>
      <li>TC02. Verify if Right corner menu buttons work properly.
	      <ul>
		    <li>TC02.01. Click Dark mode button.</li>
				         Expected result: Dark mode dropdown menu dropsdow and Dark mode is turned on.
		    <li>TC02.02. Click Globe button.</li>
				         Expected result: A field "Pasirinkti kalbą" is displayed.
		    <li>TC02.03. Click "Pasirinkti kalbą" field.</li>
				         Expected result: An iframe with list of languages is displayed.
		    <li>TC02.04. Click on language "lietuvių".</li>
				         Expected result: Homepage text is displayed in Lithuanian and Main menu remains in English.
		    <li>TC02.05. Click Logo button.</li>
				         Expected result: Navigates to Homepage.
		    <li>TC02.06. Click Search button.</li>
				         Expected result: Search field is displayed.
		    <li>TC02.07. Enter "Tutorials" in the search field.</li>
		    <li>TC02.08. Click search icon.</li>
				         Expected result: A tab with a list of w3schools's tutiorials is displayed.
		    <li>TC02.09. Click "x" button.</li>
			 	         Expected result: Navigates to Homepage.
	      </ul>
	  </li>
	  <li>TC03. Verify if Search our tutorials link works properly.
	      <ul>
		    <li>TC03.01. Enter "HTML" in the Search our tutorials field.</li>
				         Expected result: Dropdown search menu is displayed.
		    <li>TC03.02. Click search icon.</li>
			  	         Expected result: Navigates to HTML Tutorials page.
		    <li>TC03.03. Click Click Logo button.</li>
				         Expected result: Navigates to Homepage.
	      </ul>
	  </li> 
	  <li>TC04. Verify if Not sure link works properly.
	      <ul>
		    <li>TC04.01. Click Not Sure Where To Begin? link.</li>
				         Expected result: Navigates to Where To Start page.
		    <li>TC04.02. Click Click Logo button.</li>
				         Expected result: Navigates to Homepage.
	      </ul>
	  </li>	  
	  <li>TC05. Verify if Code Game works properly.
	      <ul>
		    <li>TC05.01. Click Play game button.</li>
			  	         Expected result: Code game is opened in a new window.
		    <li>TC05.02. Click Go Forward arrow 2 times.</li>
				         Expected result: Two blue arrows appear in empty marked fields.
		    <li>TC05.03. Click Play code button.</li>
				         Expected result: The lynx in the picture moves forward and a cone disapears, then a button Play next level is displayed.
		    <li>TC05.04. Click Play next level button.</li>
				         Expected result: New picture with the lynx in primal position is displayed.
		    <li>TC05.05. Click Go Forward arrow 4 times.</li>
				         Expected result: Four blue arrows appear in empty marked fields.
		    <li>TC05.06. Click Play code button.</li>
				         Expected result: The lynx in the picture moves forward and a cone dispears, then a button Play next level is displayed.	
	      </ul>
	  </li>
   </ul>	  
</li>
<li>TS02. Verification of HTML Tutorials page.
	<ul>
	  <li>TC06. Verify Watch our Video Tutorial link
	     <ul>
		    <li>TC06.01. Navigate to HTML Tutorials page of www.w3schools.com, accept the cookies and maximize he window.</li>
				         Expected result: Homepage is opened and maximized.
		    <li>TC06.02. Click Watch our Video Tutorial button.</li>
				         Expected result: Navigates to HTML Video Tutorial page.
		    <li>TC06.03. Click Play button in HTML Video Tutorial page.</li>
				         Expected result: Video starts palying.
		    <li>TC06.04. Return to HTML Tutorials page.</li>
				         Expected result: Navigates to HTML Tutorials page
	      </ul>
	  </li>		  
	  <li>TC07. Verify Try It Yourself field.
	     <ul>
		    <li>TC07.01. Click Try It Yourself button.</li>
				         Expected result: A Try it page is opened in a new window.
		    <li>TC07.02. Enter "Tai tik pavadinimas" instead "This is a Heading".</li>
		    <li>TC07.03. Enter "Tai tik paragrafas" instead of "This is a paragraph".</li>
		    <li>TC07.04. Click Run button.</li>
				         Expected result: The right side displays "Tai tik pavadinimas" and "Tai tik paragrafas".
		    <li>TC07.05. Switch to the first window.</li>
				         Expected result: HTML Tutorials page is displayed.
	  	  </ul>
	  </li>	
	  <li>TC08. Verify Start the Exercise link.
	     <ul>
		    <li>TC08.01. Click Start the Exercise link.</li>
				         Expected result: An Exercise page is opened in a new window.</li>
		    <li>TC08.02. Enter "title" in the blank field.
		    <li>TC08.03. Click Submit Answer button.</li>
				         Expected result: The page indicates "Correct!".
	  	  </ul>
	  </li>
    </ul>
</li>
<li>TS03. Verification of Log In page
	<ul>
	  <li>TC09. Verify registration with invalid data.
	     <ul>
		    <li>TC09.01. Navigate to Log In page of www.w3schools.com, accept the cookies and maximize he window.</li>
				         Expected result: Log In is opened and maximized.
		    <li>TC09.02. Enter invalid email in the email field.</li>
		    <li>TC09.03. Enter invalid pasword in the password field.</li>
		    <li>TC09.04. Click Log in button.</li>
				         Expected result: A message "A user with this email does not exist" is displayed.
	  	  </ul>
	  </li>	  
	  <li>TC10. Verify registration without password
	     <ul>
		    <li>TC10.01. Enter an email in the email field.</li>
		    <li>TC10.02  Click Log in button.</li>
				         Expected result: A message "Make sure you type your email and password correctly. Both your password and email are case-sensitive." is displayed.
         </ul>
	  </li>		  
	  <li>TC11. Verify registration without email
	     <ul>
		    <li>TC11.01. Enter a pasword in the password field.</li>
		    <li>TC11.02  Click Log in button.</li>
				      Expected result: A message "Please enter an email" is displayed.
         </ul>
	  </li>		  
	  <li>TC12. Verify registration with valid data
	     <ul>
		    <li>TC12.01. Enter a valid email in the email field.</li>
		    <li>TC12.02. Enter a valid pasword in the password field.</li>
		    <li>TC12.03. Click Log in button.</li>
				      Expected result: Navigates to My Learning page.	
	    	<li>TC12.04. Click Log Out button on menu.</li>
				      Expected result: Navigates to Log In page.
         </ul>
	  </li>
    </ul>
</li>
</ul>