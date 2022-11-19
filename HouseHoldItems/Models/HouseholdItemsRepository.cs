using HouseHoldItems.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HouseHoldItems.Models
{
    public class HouseholdItemsRepository : IHouseholdItems
    {
        private readonly AppDbContext _context;

        //Dbcontext class to store and retrieve data from the db
        public HouseholdItemsRepository(AppDbContext context)
        {
            this._context = context;
        }
        public Products AddProduct(Products newProduct)
        {
            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return newProduct;
        }

        public Products DeleteProduct(int id)
        {
            Products product = _context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product!=null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            return product;
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return _context.Products;
        }
        public Products GetProductbyId(int id)
        {
            return _context.Products.Find(id);
        }
        public Products Update(Products updatedProducts)
        {
            var product = _context.Products.Attach(updatedProducts);
            product.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return updatedProducts;
        }
    }
}
