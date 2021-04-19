using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicoDos.Exceptions;

namespace EjercicoDos
{
    public class Logic
    {
        public static void CustomEdadNoValida(int edad)
        {
            if(edad >= 18 && edad <= 99)
            {
                Console.WriteLine($"Bienvenido que disfrute su estadia");
            }
            else
            {
                throw new EdadNoValidaException();
            }
        }

        public static void EdadNoValida(int numero)
        {
            if (numero >= 18 && numero <= 99)
            {
                Console.WriteLine($"Bienvenido que disfrute su estadia");
            }
            else
            {
                throw new FormatException();
            }
        }
    }
}
