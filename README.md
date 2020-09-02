# Selenium Sample
Run Selenium tests with Visual Studio

## Setup
* Download:
  * Mozilla GeckoDriver (geckodriver.exe) from here: [https://www.selenium.dev/documentation/en/getting_started_with_webdriver/third_party_drivers_and_plugins/](https://www.selenium.dev/documentation/en/getting_started_with_webdriver/third_party_drivers_and_plugins/)
    * I chose `latest`
  * Chrome driver (chromedriver.exe) from here: [https://www.selenium.dev/documentation/en/getting_started_with_webdriver/third_party_drivers_and_plugins/](https://www.selenium.dev/documentation/en/getting_started_with_webdriver/third_party_drivers_and_plugins/)
    * Make sure the driver version matches the Chrome version exactly (e.g. Chrome version 85.0.4183.83 with chromedriver.exe version 85.0.4183.83)
* Place drivers into any folder on hard drive (e.g. `C:\Portables\WebDriver\bin`)
* Add driver folder to system environment variable path
![image](https://user-images.githubusercontent.com/504505/92044762-cad08680-ed33-11ea-9064-c7ab657f171a.png)
* Run `Test_Google_Search` NUnit test from Visual Studio
