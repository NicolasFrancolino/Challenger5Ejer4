using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenger5Ejer4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche = new Coche(0);
            int gasolina = int.Parse(Console.ReadLine());
            if (coche.CargarNafta(gasolina))
            {
                coche.Conducir();
            }
            
            Console.ReadKey(); 
        }
    }
}
