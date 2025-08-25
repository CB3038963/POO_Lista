using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Ex3
{
    internal class Retangulo
    {
        int d , area;

        //Construtores
        public Retangulo()
        { this.d = 0;  this.area=0;}

        public Retangulo(int d)
        {this.d = d;}

        //Set void
        public void SetDiagonal(int d)
        { this.d = d; }
        //Get
        public int GetArea()
        {return this.area;}

        public int GetDiagonal()
        { return this.d; }

        //Calcular
        public void Calcular()
        {this.area = this.d * this.d / 2;}



    }
}
