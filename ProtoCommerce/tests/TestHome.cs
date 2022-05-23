using NUnit.Framework;
using ProtoCommerce.pageObjects;
using ProtoCommerce.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoCommerce.tests
{
    internal class TestHome : Base
    {
        [Test]
        public void login()
        {
            Home homeObj = new Home(getDriver());

            homeObj.getUserName().SendKeys("Gerardo");
            homeObj.getUserEmail().SendKeys("ger@gmail.com");
            homeObj.getUserPassword().SendKeys("pass");
            homeObj.getUserGender().SendKeys("Male");
            homeObj.getUserBirthDay().SendKeys("1967-15-04");
            homeObj.getButton().Click();

            //assertion
            string actualText = homeObj.getSuccessMessage().Text;
            Assert.IsTrue(actualText.Contains("Success! The Form has been submitted successfully!."));
            

        }
    }
}
