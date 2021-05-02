using Lab.TpEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.TpEF.Logic
{
    public class ProductsLogic : BaseLogic, IABMLogic<Products>
    {
        public void Add(Products newItem)
        {
            context.Products.Add(newItem);

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var elementoAEliminar = context.Products.First(r => r.ProductID == id);
            
            context.Products.Remove(elementoAEliminar);
            
            context.SaveChanges();
        }

        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public void Update(Products updateItem)
        {
            var update = context.Products.Find(updateItem.ProductID);

            update.UnitPrice = updateItem.UnitPrice;

            context.SaveChanges();
        }
    }
}
