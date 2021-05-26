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
            try
            {
                context.Categories.Add(newItem);

                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public void Delete(int id)
        {
            try
            {
                var elementoAEliminar = context.Categories.First(r => r.CategoryID == id);

                context.Categories.Remove(elementoAEliminar);

                context.SaveChanges();
            }
            catch (InvalidOperationException)
            {

                throw;
            }

        }

        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public void Update(Categories updateItem) // revisar
        {
            try
            {
                var update = context.Categories.Find(updateItem.CategoryID);

                update.Description = updateItem.Description;

                context.SaveChanges();
            }
            catch (NullReferenceException)
            {

                throw;
            }
        }

        public Categories GetOne(int id)
        {
            return context.Categories.Find(id);
        }
    }
}
