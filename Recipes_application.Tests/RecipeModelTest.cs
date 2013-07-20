using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recipes_application.Models;
using System.Collections.Generic;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace Recipes_application.Tests
{
    [TestClass]
    public class RecipeModelTest
    {
        [TestMethod]
        public void RecipesIngredientsIsRequired()
        {
            PropertyInfo ingredients = typeof(RecipeModel).GetProperty("Ingredients");
            Attribute required = ingredients.GetCustomAttribute(typeof(RequiredAttribute));
            Assert.IsNotNull(required);
        }

        [TestMethod]
        public void RecipesTitleIsRequired()
        {
            PropertyInfo title = typeof(RecipeModel).GetProperty("Title");
            Attribute required = title.GetCustomAttribute(typeof(RequiredAttribute));
            Assert.IsNotNull(required); 
        }
    }
}
