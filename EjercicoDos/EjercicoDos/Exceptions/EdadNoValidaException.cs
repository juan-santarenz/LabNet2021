using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicoDos.Exceptions
{
    class EdadNoValidaException : Exception
    {
        public EdadNoValidaException() : base($"Debe ser mayo de edad para ingresar") { }
    }
}
