using System;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace AgileTravelUITests
{
    [TestClass]
    public class UnitTest1
    {
        
 

        [TestMethod]
        public void TestSearchFireFox()
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                // And now ist this to visit Google
                driver.Navigate().GoToUrl("http://www.google.com");

                // Find the text input element by its name
                IWebElement element = driver.FindElement(By.Name("q"));

                // Enter something to search for
                element.SendKeys("Hello Selenium WebDriver!");

                // Now submit the form
                element.Submit();



                System.Threading.Thread.Sleep(1000);
            }
        }

        [TestMethod]
        [Obsolete]
        public void TestSearchChrome()
        {
            using (IWebDriver driver = new ChromeDriver())
            {

                

                // And now ist this to visit Google

                driver.Navigate().GoToUrl("http://www.google.com");


                // Find the text input element by its name
                IWebElement element = driver.FindElement(By.Name("q"));

                // Enter something to search for
                element.SendKeys("Hello Selenium WebDriver!");

                // Now submit the form
                element.Submit();

                System.Threading.Thread.Sleep(3000);


                // Sign in
                /*
                String currentURL = driver.Url;
                String NewWindowUrl = driver.FindElement(By.LinkText("Sign in")).GetAttribute("href");
                driver.Navigate().GoToUrl(NewWindowUrl);

                IWebElement user_email = driver.FindElement(By.Id("identifierId"));
                user_email.SendKeys("lester.serdenia@gmail.com");

                driver.FindElement(By.Id("identifierNext")).Click();
                
                
                
                
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0,0,10));
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//input[@name='password']")));
                IWebElement user_password = driver.FindElement(By.XPath("//input[@name='password']"));
                user_password.SendKeys("xxxxxx");
                

                driver.FindElement(By.Id("passwordNext")).Click();
                */


            }
        }


        [TestMethod]
        public void TestSearchIE()
        {
            using (IWebDriver driver = new InternetExplorerDriver())
            {
                // And now ist this to visit Google
                driver.Navigate().GoToUrl("http://www.google.com");

                // Find the text input element by its name
                IWebElement element = driver.FindElement(By.Name("q"));

                // Enter something to search for
                element.SendKeys("Hello Selenium WebDriver!");

                // Now submit the form
                element.Submit();
                System.Threading.Thread.Sleep(3000);
            }
        }
    }
}
