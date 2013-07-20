using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recipes_application.Models;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace Recipes_application.Tests
{
    [TestClass]
    public class IngredientModelTest
    {
 
        [TestMethod]
        public void IngredientsQuantityIsRequired()
        {
            PropertyInfo quantity = typeof(IngredientModel).GetProperty("Quantity");
            Attribute required = quantity.GetCustomAttribute(typeof(RequiredAttribute));
            Assert.IsNotNull(required);
        }
        
        [TestMethod]
        public void IngredientsTitleIsRequired()
        {
            PropertyInfo title = typeof(IngredientModel).GetProperty("Title");
            Attribute required = title.GetCustomAttribute(typeof(RequiredAttribute));
            Assert.IsNotNull(required);
        }

    }
}