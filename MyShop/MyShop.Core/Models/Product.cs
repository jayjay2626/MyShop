using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Product
    {
        // ID is of type string because we 
        // want to put alpha numerical GUID
        // auto-generated randomly
        public string  Id { get; set; }

        // validation
        [StringLength(20)]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Range(0, 1000)]
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }


        public Product()
        {
            // every time a new product is created
            // we are automatically generating a new ID.
            // Instead of letting the database to create it
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
