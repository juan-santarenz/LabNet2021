using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUnoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transporte> transportes = new List<Transporte>
            {
                new Avion(100, 1),
                new Avion(50, 2),
                new Avion(45, 3),
                new Avion(300, 4),
                new Avion(15, 5),
                new Automovil(1, 1),
                new Automovil(2, 2),
                new Automovil(3, 3),
                new Automovil(4, 4),
                new Automovil(5, 5)
            };

            foreach(var i in transportes)
            {
                Console.WriteLine(i.Mostrar());
            }

            Console.WriteLine("\n");

            Console.WriteLine(transportes[2].Avanzar());
            Console.WriteLine(transportes[2].Detenerse());

            Console.WriteLine("\n");

            Console.WriteLine(transportes[9].Avanzar());
            Console.WriteLine(transportes[9].Detenerse());



            Console.ReadLine();
        }
    }
}
