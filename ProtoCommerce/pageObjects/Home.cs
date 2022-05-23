using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoCommerce.pageObjects
{
    internal class Home
    {
        private IWebDriver driver;

        public Home(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver, this);
        }

        //we are using Page Object Factory

        [FindsBy(How = How.CssSelector, Using = ".form-group input[name='name']")]
        private IWebElement uName;

        [FindsBy(How = How.CssSelector, Using = "input[name='email']")]
        private IWebElement email;

        [FindsBy(How = How.Id, Using = "exampleInputPassword1")]
        private IWebElement pswrd;

        [FindsBy(How = How.Id, Using = "exampleFormControlSelect1")]
        private IWebElement gender;

        [FindsBy(How = How.XPath, Using = "//*[@name='bday']")]
        private IWebElement birthDay;

        [FindsBy(How = How.CssSelector, Using = ".btn-success")]
        private IWebElement btn;
        [FindsBy(How = How.CssSelector, Using = ".alert-success")]
        private IWebElement msg;
       
        public IWebElement getUserName()
        {
           return uName;
        }
        public IWebElement getUserEmail()
        {
            return email;
        }
        public IWebElement getUserPassword()
        {
            return pswrd;
        }
        public IWebElement getUserGender()
        {
            return gender;
        }
        public IWebElement getUserBirthDay()
        {
            return birthDay;
        }
        public IWebElement getButton()
        {
            return btn;
        }
        public IWebElement getSuccessMessage()
        {
            return msg;
        }


    }
}
