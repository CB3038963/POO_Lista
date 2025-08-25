using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Ex2
{
    internal class Retangulo
    {
        int aresta, area;

        //Construtores
        public Retangulo()
        {this.aresta = 0;this.area = 0;}

        public Retangulo(int aresta)
        {this.aresta = aresta;}

        //Set void
        public void SetAresta(int aresta)
        {this.aresta = aresta;}

        //Get int
        public int GetArea()
        {return this.area;}
        public int GetAresta()
        {return this.aresta;}

        //Calcular void
        public void Calcular()
        { this.area = this.aresta * this.aresta; }

    }
}
