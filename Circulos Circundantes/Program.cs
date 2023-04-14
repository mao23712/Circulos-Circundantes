using EJERCICIO_3;
using System;

namespace EJERCICIO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedimos al usuario que ingrese los datos de las circunferencias
            Console.WriteLine("Ingrese los datos de la primera circunferencia:");
            Console.Write("Centro X: ");
            double c1_x = double.Parse(Console.ReadLine());
            Console.Write("Centro Y: ");
            double c1_y = double.Parse(Console.ReadLine());
            Console.Write("Radio: ");
            double c1_radio = double.Parse(Console.ReadLine());
            Circunferencia c1 = new Circunferencia(c1_x, c1_y, c1_radio);

            Console.WriteLine("Ingrese los datos de la segunda circunferencia:");
            Console.Write("Centro X: ");
            double c2_x = double.Parse(Console.ReadLine());
            Console.Write("Centro Y: ");
            double c2_y = double.Parse(Console.ReadLine());
            Console.Write("Radio: ");
            double c2_radio = double.Parse(Console.ReadLine());
            Circunferencia c2 = new Circunferencia(c2_x, c2_y, c2_radio);

            // Verificamos si los círculos son circundantes
            if (c1.EsCircundante(c2))
            {
                Console.WriteLine("Los círculos son circundantes.");
                // Calculamos el punto de encuentro
                Punto puntoEncuentro = c1.PuntoEncuentro(c2);
                Console.WriteLine("El punto de encuentro de las circunferencias es ({0}, {1})", puntoEncuentro.X, puntoEncuentro.Y1);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Los círculos no son circundantes.");
                Console.ReadLine();
            }
        }
    }
}

