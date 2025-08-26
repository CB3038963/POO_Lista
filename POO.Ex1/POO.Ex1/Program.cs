using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcular calcular = new Calcular(10,5);
            calcular.CalcularA();
            Console.WriteLine(calcular.GetArea());
        }
    }
}
