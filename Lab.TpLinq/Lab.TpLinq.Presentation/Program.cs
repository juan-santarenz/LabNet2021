using Lab.TpLinq.Entites;
using Lab.TpLinq.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.TpLinq.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomersQuery customerQuerys = new CustomersQuery();
            ProductsQuerys productsQuerys = new ProductsQuerys();

            Console.WriteLine("2. Query para devolver todos los productos sin stock\n");
            MostrarProducts(productsQuerys.EjercicoDos());
            Console.WriteLine("\nEnter para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 porunidad\n");
            MostrarProducts(productsQuerys.EjercicioTres());
            Console.WriteLine("\nEnter para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("4. Query para devolver todos los customers de Washington\n");
            MostrarCustomers(customerQuerys.EjercicioCuatro());
            Console.WriteLine("\nEnter para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789\n");
            var idNulo = productsQuerys.EjercicioCinco();

            if (idNulo == null) Console.WriteLine("sin datos");

            Console.WriteLine("\nEnter para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.\n");
            
            foreach (var item in customerQuerys.EjercicioSeis())
            {
                Console.WriteLine($"ID: {item.CustomerID} - Nombre en MAYUSCULAS: {item.ContactName.ToUpper()} - Nombre en minusculas: {item.ContactName.ToLower()}");
            }

            Console.WriteLine("\nEnter para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("8. Query para devolver los primeros 3 Customers de Washington\n");
            MostrarCustomers(customerQuerys.EjercicioOcho());
            Console.WriteLine("\nEnter para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("9. Query para devolver lista de productos ordenados por nombre\n");
            MostrarProducts(productsQuerys.EjercicioNueve());
            Console.WriteLine("\nEnter para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.\n");
            MostrarProducts(productsQuerys.EjercicioDiez());
            Console.WriteLine("\nEnter para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("12. Query para devolver el primer elemento de una lista de productos\n");
            MostrarProducts(productsQuerys.EjercicioDoce());
            Console.WriteLine("\nEnter para continuar...");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Fin");
            Console.ReadLine();

        }

        static void MostrarProducts(List<Products> products)
        {
            foreach (var item in products)
            {
                Console.WriteLine($"{item.ProductID} - {item.ProductName} - {item.UnitPrice}");
            }
        }
        static void MostrarCustomers(List<Customers> customers)
        {
            foreach (var item in customers)
            {
                Console.WriteLine($"{item.CustomerID} - {item.ContactName} - {item.Region}");
            }
        }
    }
}
