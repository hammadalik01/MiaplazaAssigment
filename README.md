# AutomationProject

## Overview

This project automates testing for the MiaPrep Online High School application form using Selenium and NUnit.

## Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [ChromeDriver](https://sites.google.com/a/chromium.org/chromedriver/) (Ensure it's in your PATH)

## Setup

1. Clone the repository:
    ```sh
    git clone https://github.com/hammadalik01/MiaplazaAssigment.git
    cd MiaplazaAssigment/AutomationProject
    ```

2. Restore dependencies:
    ```sh
    dotnet restore
    ```

3. Ensure ChromeDriver is installed and accessible in your PATH.

4. Project Structure

   Tests.cs: Contains test cases.

   BaseTest.cs: Sets up and tears down WebDriver.

   ConfigurationHelper.cs: Reads config values from config.json.

   HelperMethods.cs: Utility methods for Selenium actions.

   Locators.cs: Element locators used in tests.

   config.json: Configuration file with test data.



5. Dependencies

   Selenium WebDriver

   NUnit

   SeleniumExtras.WaitHelpers

   Newtonsoft.Json


## Configuration

Edit `config.json` to include required values:

```json
{
  "ApplicationSettings": {
    "Url": "https://miacademy.co/#/"
  },
  "ParentInformation": {
    "FirstName": "Hammad Ali",
    "LastName": "Khan",
    "Email": "hammadalik01@gmail.com",
    "PhoneNumber": "1234567890"
  },
  "StudentInformation": {
    "FirstName": "Jhon",
    "LastName": "King",
    "Nickname": "Jhoni",
    "Email": "jhontw@mailinator.com",
    "PhoneNumber": "+49123456789",
    "Birthdate": "16-04-1992",
    "Gender": "Male",
    "MiaPrepAccountOption": "No",
    "StudentType": "Homeschool",
    "Interest": "Performing Arts",
    "LearningNeedsOption": "No"
  }
}




