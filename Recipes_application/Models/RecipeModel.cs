using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Recipes_application.Models
{
    public class RecipeModel
    {
        [DisplayName]
        public short CookingTime { get; set; }

        public Guid Id { get; set; }

        [Required]
        [DisplayName]
        public List<IngredientModel> Ingredients { get; set; }
        
        [DisplayName]
        public short PreparationTime { get; set; }
        
        [DisplayName]
        public string Steps { get; set; }

        [Required]
        [DisplayName]
        public string Title { get; set; }
    }
}