using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Recipes_application.Models
{
    public class IngredientModel
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        [Required]
        [DisplayName]
        public short? Quantity { get; set; }

        [Required]
        [DisplayName]
        public string Title { get; set; }

        
    }
}