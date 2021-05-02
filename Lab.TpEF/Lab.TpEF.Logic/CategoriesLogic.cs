using Lab.TpEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.TpEF.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories>
    {
        public void Add(Categories newItem)
        {
            context.Categories.Add(newItem);

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var elementoAEliminar = context.Categories.First(r => r.CategoryID == id);

            context.Categories.Remove(elementoAEliminar);

            context.SaveChanges();
        }

        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public void Update(Categories updateItem)
        {
            var update = context.Categories.Find(updateItem.CategoryID);

            update.Description = updateItem.Description;

            context.SaveChanges();
        }
    }
}
