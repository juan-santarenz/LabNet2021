using Lab.TpEF.Entities;
using Lab.TpEF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.TpEF.Presentation
{
    public class CategoriesMethods : IMetodos
    {
        private CategoriesLogic categories;

        public CategoriesLogic GetCategories()
        {
            return categories;
        }
        public CategoriesMethods(CategoriesLogic categories)
        {
            this.categories = categories;
        }

        public void Mostrar()
        {
            Console.WriteLine($"----------Categories------------");
            foreach (var item in categories.GetAll())
            {
                Console.WriteLine($"{item.CategoryID} - {item.CategoryName} - {item.Description}");
            }
            Console.WriteLine();
        }

        public void MenuAdd(int id, string name, string description)
        {
            categories.Add(new Categories
            {
                CategoryID = id,
                CategoryName = name,
                Description = description
            });
        }

        public void MuneUpdate(string description, int id)
        {
            categories.Update(new Categories
            {
                Description = description,
                CategoryID = id
            });
        }

        public void MenuDelete(int id)
        {
            categories.Delete(id);
        }
    }
}
