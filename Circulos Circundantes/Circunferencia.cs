using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_3
{
    class Circunferencia
    {
        private Punto centro;
        private double radio;

        public Punto Centro { get => centro; set => centro = value; }
        public double Radio { get => radio; set => radio = value; }

        public Circunferencia(double x, double y, double radio)
        {
            this.Centro = new Punto(x, y);
            this.Radio = radio;
        }
        public bool EsCircundante(Circunferencia otraCircunferencia)
        {
            // Calculamos la distancia entre los centros de las circunferencias
            double distancia = Math.Sqrt(Math.Pow(otraCircunferencia.centro.X - this.centro.X, 2) + Math.Pow(otraCircunferencia.centro.Y1 - this.centro.Y1, 2));
            // Verificamos si los círculos son circundantes
            if (distancia == this.radio + otraCircunferencia.radio)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Punto PuntoEncuentro(Circunferencia otraCircunferencia)
        {
            // Calculamos la distancia entre los centros de las circunferencias
            double distancia = Math.Sqrt(Math.Pow(otraCircunferencia.centro.X - this.centro.X, 2) + Math.Pow(otraCircunferencia.centro.Y1 - this.centro.Y1, 2));
            // Calculamos el punto de encuentro
            double x = (Math.Pow(this.radio, 2) - Math.Pow(otraCircunferencia.radio, 2) + Math.Pow(distancia, 2)) / (2 * distancia);
            double y = Math.Sqrt(Math.Pow(this.radio, 2) - Math.Pow(x, 2));
            Punto puntoEncuentro = new Punto(this.centro.X + x * (otraCircunferencia.centro.X - this.centro.X) / distancia, this.centro.Y1 + x * (otraCircunferencia.centro.Y1 - this.centro.Y1) / distancia);

            return puntoEncuentro;
        }
    }
}
