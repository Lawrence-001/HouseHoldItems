using Microsoft.EntityFrameworkCore;

namespace HouseHoldItems.Models
{
    public static class DbInitializer
    {
        //creating an extesnion method for modelbuilder class in appdbcontext
        //(to have seed data rather than in the appdbcontext)
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(
               new Products
               {
                   ProductId = 1,
                   Name = "Plastic chair",
                   Description = "plastic chair",
                   ProductCategory = ProductCategory.Furniture,
                   Cost = 500
               },
                  new Products
                  {
                      ProductId = 2,
                      Name = "Office chair",
                      Description = "Office chair",
                      ProductCategory = ProductCategory.Furniture,
                      Cost = 5000
                  },
                   new Products
                   {
                       ProductId = 3,
                       Name = "Hp Laptop",
                       Description = "Laptop",
                       ProductCategory = ProductCategory.Electronics,
                       Cost = 50000
                   },
                    new Products
                    {
                        ProductId = 4,
                        Name = "Pressure cooker",
                        Description = "Utensils",
                        ProductCategory = ProductCategory.kitchen,
                        Cost = 5000
                    },
                     new Products
                     {
                         ProductId = 5,
                         Name = "Cooking gas",
                         Description = "Cooking gas",
                         ProductCategory = ProductCategory.kitchen,
                         Cost = 2500
                     },
                      new Products
                      {
                          ProductId = 6,
                          Name = "Carpet",
                          Description = "Carpet",
                          ProductCategory = ProductCategory.Other,
                          Cost = 3000
                      },
                       new Products
                       {
                           ProductId = 7,
                           Name = "Samsung Galaxy",
                           Description = "Mobile phone",
                           ProductCategory = ProductCategory.Electronics,
                           Cost = 25000
                       }
               );
        }
    }
}
