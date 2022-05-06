using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenger5Ejer4
{
    internal class Coche : IVehiculo
    {

        public int nafta { get; set; }
        public Coche(int nafta)
        {
            this.nafta = nafta;
        }

        public void Conducir()
        {
            if (nafta > 0)
            {
                Console.WriteLine("El coche esta conduciendo");
            }
            else
            {
                Console.WriteLine("No tiene nafta");
            }
        }

        public bool CargarNafta(int cantidad)
        {
            nafta += cantidad;
            return true;
        }
    }
}
