using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicoDos.Extensions
{
    public static class DivisionExtensions
    {
        public static double Division(this double divisor, double dividendo)
        {
            if (dividendo == 0)
            {
                int divisorInt = (int)Math.Floor(divisor);
                int dividendoInt = (int)Math.Floor(dividendo);
                return divisorInt / dividendoInt;
            }
            else
            {
               return divisor / dividendo;
               
            }
        }
    }
}
