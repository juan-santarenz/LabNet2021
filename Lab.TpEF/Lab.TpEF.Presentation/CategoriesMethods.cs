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
        
        CategoriesLogic categories = new CategoriesLogic();

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
            try
            {
                categories.Add(new Categories
                {
                    CategoryID = id,
                    CategoryName = name,
                    Description = description
                });
            }
            catch (Exception)
            {

                Console.WriteLine("\nLa categoria no pudo ser guardada por que algun dato no es correcto... presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        public void MuneUpdate(string description, int id)
        {
            try
            {
                categories.Update(new Categories
                {
                    CategoryID = id,
                    Description = description
                });
            }
            catch (NullReferenceException)
            {

                Console.WriteLine("\nEl ID ingresado no corresponde a una categoria... presione una tecla para continuar");
                Console.ReadKey();
            }
           
        }

        public void MenuDelete(int id)
        {
            try
            {
                categories.Delete(id);
            }
            catch (InvalidOperationException)
            {
                
                Console.WriteLine($"\nEl ID ingresado no corresponde a una categoria... precione una tecla para continuar");
                Console.ReadKey();
            }
            
        }
    }
}
