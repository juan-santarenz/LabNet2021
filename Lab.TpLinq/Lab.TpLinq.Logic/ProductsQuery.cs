using Lab.TpLinq.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.TpLinq.Logic
{
    public class ProductsQuerys : BaseLogic
    {
        public List<Products> EjercicoDos()
        {
            var query = from products in context.Products
                        where products.UnitsInStock == 0
                        select products;

            return query.ToList();

        }

        public List<Products> EjercicioTres()
        {
            var query = from products in context.Products
                        where products.UnitsInStock > 0 && products.UnitPrice > 3
                        select products;

            return query.ToList();
        }

        public Products EjercicioCinco()
        {
            var query = context.Products.FirstOrDefault(p => p.ProductID == 789);

            return query;
        }

        public List<Products> EjercicioNueve()
        {
            var query = from products in context.Products
                        orderby products.ProductName
                        select products;

            return query.ToList();
        }

        public List<Products> EjercicioDiez()
        {
            var query = context.Products.OrderByDescending(p => p.UnitsInStock);

            return query.ToList();
        }

        public List<Products> EjercicioDoce()
        {
            var query = (from products in context.Products
                         select products).Take(1);

            return query.ToList();
        }
    }
}
