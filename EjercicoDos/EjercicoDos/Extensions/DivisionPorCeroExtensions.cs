using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicoDos.Extensions
{
    public static class DivisionPorCeroExtensions
    {
        public static int DividirPorCero(this int divisor)
        {
            return divisor / 0;
        }
    }
}
