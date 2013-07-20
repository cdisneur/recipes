using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Recipes_application.Models
{
    public class ProductStoreModel
    {
        [DisplayName]
        public string Price { get; set; }

        public Guid ProductId { get; set; }

        [DisplayName]
        public short Quantity { get; set; }

        public Guid StoreId { get; set; }
    }
}