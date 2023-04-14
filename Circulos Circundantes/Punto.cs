using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_3
{
    class Punto
    {
        private double x;
        private double Y;

        public Punto(double x, double y)
        {
            this.X = x;
            Y1 = y;
        }

        public double X { get => x; set => x = value; }
        public double Y1 { get => Y; set => Y = value; }
    }
}
