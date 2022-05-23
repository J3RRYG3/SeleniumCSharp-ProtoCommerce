using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Configuration;
using WebDriverManager.DriverConfigs.Impl;

namespace ProtoCommerce.utilities
{
    internal class Base
    {
       public IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            string browserName = ConfigurationManager.AppSettings["browser"];
            initBrowser(browserName);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/angularpractice/";


        }

        public void initBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;
                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;
            }
        }


       public IWebDriver getDriver()
        {
            return driver;
        }

        /*[TearDown]
        public void afterTest()
        {
            driver.Quit();
        }*/
    }
}
