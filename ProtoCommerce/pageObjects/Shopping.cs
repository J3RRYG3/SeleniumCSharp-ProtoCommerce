using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoCommerce.pageObjects
{
    public class Shopping
    {
        //variables
       private IWebDriver driver;

       //Since this is a webElements list we need to do it this way since page refactoring doesn't work
       By cardTitle = By.CssSelector(".card-title a");
        

        //constructor
        public Shopping(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //factory objects

       

        [FindsBy(How = How.LinkText, Using = "Shop")]
        private IWebElement shopLink;

        //selecting the devices name
        [FindsBy(How = How.CssSelector, Using = ".card-title")]
        private IList<IWebElement> deviceNames;

       /* public void waitForPageDisplay()
        {
            //explicit wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.PartialLinkText("Checkout")));
        }*/

       /* public IList<IWebElement> getCards()
        {
            return cards;
        }
        public By getCardTitle()
        {
            return cardTitle;
        }*/
        public IWebElement getShopButton()
        {
            return shopLink;
        }
        //this method will return a by locator
        public By getCards()
        {
            return cardTitle;
        }
        public IList<IWebElement> getDeviceNames()
        {
            return deviceNames;
        }
    }
}
