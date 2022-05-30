using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Myproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //open Chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //launch the turn up portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //identify username and enter the user name.
            driver.FindElement(By.Id("UserName")).SendKeys("hari");

            //identify password and enter the password.
            driver.FindElement(By.Id("Password")).SendKeys("123123");

            //identify login button and click on it.
            IWebElement login = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            login.Click();

            //Check if the user was able to login
            IWebElement element = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            
            if( element.Text== "Hello hari!")
            {
                Console.WriteLine("logged in sucessfully");
            }
            else
            {
                Console.WriteLine("login failed");
            }

           

        }
    }
}

