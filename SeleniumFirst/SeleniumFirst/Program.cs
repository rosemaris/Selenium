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
            driver.Navigate().GoToUrl("https://www.facebook.com/");

            // Find the search input element by its name attribute
            IWebElement emailElement = driver.FindElement(By.Name("email"));
            IWebElement passwordElement = driver.FindElement(By.Name("pass"));

            // Type "executeautomation" into the search box
            emailElement.SendKeys("gulayrosemaris@gmail.com");
            passwordElement.SendKeys("iloveyoumaris");

            //

            // Submit the form (press Enter)
            passwordElement.Submit();

            // Wait for a while to see the results (you might want to use WebDriverWait for more robust waiting)
            System.Threading.Thread.Sleep(10000);
            driver.Navigate().GoToUrl("https://www.facebook.com/richard.tinampay.50");
            System.Threading.Thread.Sleep(30000);

            // Play the video (replace 'play_button_selector' with the actual selector)
           // var playButtonSelector = "your_play_button_selector";
           // var playButton = driver.FindElement(By.CssSelector(playButtonSelector));
            //playButton.Click();

            // Wait for the video to play (adjust the sleep duration as needed)
          //  Thread.Sleep(10000);


            // Close the browser
            driver.Close();
        }
    }
}
