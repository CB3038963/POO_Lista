using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo(10);
            retangulo.Calcular();
            Console.WriteLine(retangulo.GetArea());
        }
    }
}
