using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicoDos.Extensions;
using EjercicoDos.Exceptions;

namespace EjercicoDos
{
    class Program
    {
        static void Main(string[] args)
        {
            // PUNTO UNO

            Console.WriteLine($"----- PUNTO UNO -----");
            Console.WriteLine(Environment.NewLine);
            try
            {
                int divisor = 10;
                

                Console.WriteLine(divisor.DividirPorCero());
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine($"La operacion finalizo");
            }
            Console.WriteLine(Environment.NewLine);

            //PUNTO DOS
            
            Console.WriteLine($"----- PUNTO DOS -----");
            Console.WriteLine(Environment.NewLine);
            try
            {
                Console.Write($"Ingrese un divisor: ");
                double divisor = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Ingrese un dividendo: ");
                double dividendo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El resultado es "+divisor.Division(dividendo));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Solo un macho pelo en pecho lomo plateado puede dividir por cero");
                
            }
            catch (FormatException)
            {
                Console.WriteLine($"Seguro ingreso una letra o no ingreso nada!");
            }
            finally
            {
                Console.WriteLine($"La operacion finalizo");
            }
            Console.WriteLine(Environment.NewLine);
            
            //PUNTO TRES

            Console.WriteLine($"----- PUNTO TRES -----");
            Console.WriteLine(Environment.NewLine);
            try
            {
                Logic.EdadNoValida(4);
            }
            catch (FormatException e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }
            Console.WriteLine(Environment.NewLine);
            
            //PUNTO CUATRO

            Console.WriteLine($"----- PUNTO CUATRO -----");
            Console.WriteLine(Environment.NewLine);
            try
            {
                Console.Write($"Ingrese su edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());
                Logic.CustomEdadNoValida(edad);
            }
            catch (EdadNoValidaException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine($"El campo esta vacio o ingreso un caracter");
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"----- FIN -----");
            Console.ReadLine();
        }
    }
}
