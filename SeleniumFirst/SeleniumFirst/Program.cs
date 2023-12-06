using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of ChromeDriver
            IWebDriver driver = new ChromeDriver();

            // Navigate to the Google page
            driver.Navigate().GoToUrl("http://www.google.com");

            // Find the search input element by its name attribute
            IWebElement element = driver.FindElement(By.Name("q"));

            // Type "executeautomation" into the search box
            element.SendKeys("facebook");

            // Submit the form (press Enter)
            element.Submit();

            // Wait for a while to see the results (you might want to use WebDriverWait for more robust waiting)
            System.Threading.Thread.Sleep(5000);

            // Close the browser
            driver.Close();
        }
    }
}
