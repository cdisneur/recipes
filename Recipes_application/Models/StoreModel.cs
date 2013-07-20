using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Recipes_application.Models
{
    public class StoreModel
    {
        [Required]
        [DisplayName]
        public string City { get; set; }

        public Guid Id { get; set; }

        [Required]
        [DisplayName]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[0-9]{10}$|^00[0-9]{11,13}$")]
        [DisplayName]
        public string Phone { get; set; }
    }
}