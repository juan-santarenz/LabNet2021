using Lab.TpEF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.TpEF.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
           CategoriesMethods categoriesmethods = new CategoriesMethods();
          
            ProductMethods productMethods = new ProductMethods();

            categoriesmethods.Mostrar();
            productMethods.Mostrar();

            int dato;
            do
            {
                try
                {
                    Console.WriteLine($"1- Uno para agregar una nueva categoria\n2- Dos para modificar una categoria\n3- Tres para eliminar una categoria");
                    int operation = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (operation)
                    {
                        case 1:
                            Console.Clear();
                            categoriesmethods.Mostrar();
                            Console.WriteLine($"Ingrese el ID de la categoria:");
                            int idAdd = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Ingrese nombre de categoria:");
                            string nameAdd = Convert.ToString(Console.ReadLine());
                            Console.WriteLine($"Ingrese una breve descripcion:");
                            string descriptionAdd = Convert.ToString(Console.ReadLine());
                            categoriesmethods.MenuAdd(idAdd, nameAdd, descriptionAdd);
                            Console.Clear();
                            categoriesmethods.Mostrar();
                            break;
                        case 2:
                            Console.Clear();
                            categoriesmethods.Mostrar();
                            Console.WriteLine($"Ingrese el ID de la categoria a modificar:");
                            int idUpdate = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Ingrese una breve descripcion");
                            string descriptionUpdate = Convert.ToString(Console.ReadLine());
                            categoriesmethods.MuneUpdate(descriptionUpdate, idUpdate);
                            Console.Clear();
                            categoriesmethods.Mostrar();
                            break;
                        case 3:
                            Console.Clear();
                            categoriesmethods.Mostrar();
                            Console.WriteLine("Ingrese el ID de la categoria a eliminar:");
                            int idDelete = Convert.ToInt32(Console.ReadLine());
                            categoriesmethods.MenuDelete(idDelete);
                            Console.Clear();
                            categoriesmethods.Mostrar();
                            break;
                        default:
                            Console.WriteLine($"Ingrese un valor correcto");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine($"El campo esta vacio o ingreso un caracter");
                }
                Console.WriteLine();
                Console.WriteLine($"1- Uno para continuar\n0- Cero para salir");
                dato = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (dato != 0);
        }

    }
}
