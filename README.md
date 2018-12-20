![Valtech logo](http://i.imgur.com/32Oipl4.png "Valtech logo")

QA exercise
==============================

Overview
--------

We are interested in your approach to the following problems.

Please do the test in Selenium with a proper Object Oriented Programming
language using automated testing best practices. This is expected to
take no more than 1 hour. 

Getting started
---------------
Fork this project.

Commit each exercise once you've finished with it.

Exercise #1
-----------
Create Page Object Model framework for www.valtech.co.uk to do the exercise 2 & 3 
  
Exercise #2
-----------
Navigate to www.valtech.co.uk HOME PAGE
- a. Assert that the “Recent Blogs” section is displaying
- b. Click on the first blog article & then assert that the page title is present

Exercise #3
-----------
- a. Navigate to ABOUT, SERVICES and WORK pages via top navigation and assert that H1 tag in each page is displaying the relevant page name. Ex H1 tag in Services page is displaying as “Services”

- b. Navigate to Contact page (/about/contact-us) and output how many Valtech offices in total

Exercise #4
-----------
README file - Include instructions on how to set up and execute your tests on a clean install of Windows/MacOS

Finish up
---------
Once you're finished, commit & push your changes, send us a link to your fork.

===================================================
Notes on how to set up and run the tests implemented in response to the Excercise
---------------------------------------------------------------------------------

Framework Archietecture
-----------------------
The framework has been developed using Selenium Webdriver as the browser automation tool and C# as the programming language in  MS Visual Studio Enterprise 2017 as the IDE. 
The key components of the framework include:

1. A C# class libarary implementing the PO Model for valtech.co.uk as asked in Excercise 1. The class library is referenced by another project which contains the test code. The C# project name for this class library is: 'ValTechPages'.
2 - Selenium WebDriver tests implemented as C# unit tests in a separate C# Unit Test Project. The unit test project name containing the  tests is: 'SeleniumTests'
3 - The .Net packages used in the framework are: MSTest.TestAdapter.1.4.0, MSTest.TestFramework.1.4.0, Selenium.Support.3.1.141.0, Selenium.WebDriver.3.141.0, WebDriver.ChromeDriver.26.14.313457.1. The first two packages are only needed for the unit test project where as the last three are needed by both the projects.

Set Up
------
1 - Download or clone the repo from: https://github.com/fasihk/qa-exercise
2 - Open the ValtechQAETechTest.sln file in MS Visual Studio.
3 - Ensure that the unit test project called 'SeleniumTests' is set as the Startup project (Project name emphasized in Solution Explorer) for the solution.If it is not, then this can be done by right clicking the project name and selecting the option 'Set as StartUp Project' from the context menu.
4 - Build the solution. This will also retrieve the NuGet packages referenced in the respective package.config files of both the projects.

Running the Tests
-----------------
1 - Open the Test Explorer window from Test->Windows->Test Explorer menu. The 'Test Explorer' window will list the tests in the solution so that they can be run. The two tests displayed will be: 'Excercise_3a' and 'Excercise_3b'.
1.1 - Note: - If the test are greyed out please then reinstall the Nuget Packages (listed about) from the NuGet Package Manager(IN VS go to: Tools->NuGet Package Manager->Manage NuGet Packages for Solution...)
2 - The tests can be run either by using the 'Rull All' or by right clicking a test and selecting the option 'Run Selected Tests'

Note Regarding Excercise 2: 
--------------------------
Since the 'Recent Blogs' section is not available on the home page anymore, the tests and relevant page objects pertaining to Excercise 2 have been commented out in the framework. 
