using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUnoPOO
{
    public class Avion : Transporte
    {

        private int id;
        public Avion(int pasajeros, int id) : base(pasajeros)
        {
            this.id = id;
        }
        public int getId()
        {
            return id;
        }

        public override string Avanzar()
        {
            return $"El avion {id}, despega con {getPasajeros()} pasajeros.";
        }

        public override string Detenerse()
        {
            return $"El avion {id}, desciende y aterriza satisfactoriamente.";
        }

        public override string Mostrar()
        {
            return $"Avion {id}: {getPasajeros()} pasajeros";
        }




    }
}
