using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUnoPOO
{
    public abstract class Transporte
    {
        private int pasajeros;
        //Sprivate int id;

        public Transporte(int pasajeros/*, int id*/)
        {
            this.pasajeros = pasajeros;
            //this.id = id;
        }

        public int getPasajeros()
        {
            return pasajeros;
        }
       /* public int getId()
        {
            return id;
        }*/

        public abstract string Avanzar();

        public abstract string Detenerse();

        public abstract string Mostrar();
    }
}
