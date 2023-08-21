using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._5_Koe
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Constructor(Id, Name, Price, Parametrinen Constructor.
        public Product(int id, string name, decimal price)
        {

            Id = id;
            Name = name;
             Price = price;
        }





        public decimal Discount { get; set; }

        public decimal CalculateDiscountedPrice(decimal discountPercentage)
        {
            decimal discountAmount = Price * (Discount / 100);

            decimal discountedPrice = Price - discountAmount;

            return discountedPrice;

        }




    }
}   
       




            





    





    
        


                       

    
    
    
    
    
    

