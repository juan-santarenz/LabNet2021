using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUnoPOO
{
    public class Automovil : Transporte
    {
        private int id;
        public Automovil(int pasajeros, int id) : base(pasajeros)
        {
            this.id = id;
        }

        public override string Avanzar()
        {
            return $"El auto {id}, arranca con {getPasajeros()} pasajeros arriba.";
        }

        public override string Detenerse()
        {
            return $"El auto {id}, se detiene y descienden {getPasajeros()} pasajeros, quedando con {getPasajeros() - getPasajeros()} pasajeros.";
        }

        public override string Mostrar()
        {
            return $"Automovil {id}: {getPasajeros()} pasajeros";
        }
    }
}
