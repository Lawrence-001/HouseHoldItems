using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace HouseHoldItems.Models
{
    public interface IHouseholdItems
    {
       
        public Products GetProductbyId(int id);
        public Products AddProduct(Products products);
        public IEnumerable<Products> GetAllProducts();
        public Products Update(Products updatedProducts);
        public Products DeleteProduct(int id);

      
    }
}
