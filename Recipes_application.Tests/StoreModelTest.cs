using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recipes_application.Models;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace Recipes_application.Tests
{
    [TestClass]
    public class StoreModelTest
    {
 
         [TestMethod]
        public void StoresPhoneIsInvalid()
        {
            string phone = "095643";
            PropertyInfo phoneRegex = typeof(StoreModel).GetProperty("Phone");
            RegularExpressionAttribute regex = (RegularExpressionAttribute)phoneRegex.GetCustomAttribute(typeof(RegularExpressionAttribute));
            Assert.IsFalse(regex.IsValid(phone));
        }

        [TestMethod]
        public void StorePhoneIsValid()
        {
            string phone = "0987564326";
            PropertyInfo phoneRegex = typeof(StoreModel).GetProperty("Phone");
            RegularExpressionAttribute regex = (RegularExpressionAttribute)phoneRegex.GetCustomAttribute(typeof(RegularExpressionAttribute));
            Assert.IsTrue(regex.IsValid(phone));
        }

        [TestMethod]
        public void StoresCityIsRequired()
        {
            PropertyInfo city = typeof(StoreModel).GetProperty("City");
            Attribute required = city.GetCustomAttribute(typeof(RequiredAttribute));
            Assert.IsNotNull(required);
        }

        [TestMethod]
        public void StoresNameIsRequired()
        {
            PropertyInfo name = typeof(StoreModel).GetProperty("Name");
            Attribute required = name.GetCustomAttribute(typeof(RequiredAttribute));
            Assert.IsNotNull(required);
        }

        [TestMethod]
        public void StoresPhoneIsRequired()
        {
            PropertyInfo phone = typeof(StoreModel).GetProperty("Phone");
            Attribute required = phone.GetCustomAttribute(typeof(RequiredAttribute));
            Assert.IsNotNull(required);
        }
    }
}
