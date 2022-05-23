using NUnit.Framework;
using OpenQA.Selenium;
using ProtoCommerce.pageObjects;
using ProtoCommerce.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoCommerce.tests
{
    internal class TestShopping:Base
    {
        [Test]
        public void selectItems()
        {
            //creating a expected Products list
            String[] expectedProducts = { "iphone X", "Blackberry" };
            String[] actualProducts = new String[2];

            Shopping shoppingObj = new Shopping(getDriver());


            //click on shop button
            shoppingObj.getShopButton().Click();


            //creating  a list of webElements containing the products
            IList<IWebElement> products = (IList<IWebElement>)shoppingObj.getCards();
            

            //iteration through all the products names
            foreach(IWebElement product in products)
            {
                if (expectedProducts.Contains(product.FindElement((By)shoppingObj.getDeviceNames()).Text))
                {
                    product.FindElement(By.CssSelector(".card-footer button")).Click();
                }
                TestContext.Progress.WriteLine(product.FindElement(By.CssSelector(".card-title a")));
            }
            
        }
    }
}
