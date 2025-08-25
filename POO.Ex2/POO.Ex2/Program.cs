using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo(5);
            retangulo.Calcular();
            Console.WriteLine(retangulo.GetArea());
        }
    }
}
