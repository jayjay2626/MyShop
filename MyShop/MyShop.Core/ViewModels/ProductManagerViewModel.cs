using MyShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.ViewModels
{
    public class ProductManagerViewModel
    {
        // A view model is a special kind of model that use just the view
        // it is more of a concept than an actual thing
        // In development it is simply another class.
        // View models contains data but the data is NOT saved.
        // View models is simply to transport data between the controller
        // and the view. Data still have to be manually put in and taken out
        // each time. We could do this either statically or by copying 
        // the data through a normal data driven model.

        public Product Product { get; set; }

        public IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}
