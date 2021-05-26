using Lab.TpEF.Entities;
using Lab.TpEF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.TpEF.Presentation
{
    public class ProductMethods
    {
        ProductsLogic products = new ProductsLogic();
        
        public void Mostrar()
        {
            Console.WriteLine($"----------Products-------------");
            foreach (var item in products.GetAll())
            {
                Console.WriteLine($"{item.ProductID} - {item.ProductName} - {item.UnitPrice}");
            }
            Console.WriteLine();

        }
    }
}
