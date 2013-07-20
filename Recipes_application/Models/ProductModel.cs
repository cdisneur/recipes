using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Recipes_application.Models
{
    public class ProductModel
    {
        public Guid Id { get; set; }

        [DisplayName]
        public string Quantity { get; set; }

        [DisplayName]
        public string Title { get; set; }

    }

}