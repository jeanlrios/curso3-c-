using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimoDesafio.FormaGeometrica
{
    internal class Retangulo : IForma
    {
        public void CalcularForma(double a, double b)
        {
            double A = a * b;
            double P = 2 * (a + b);
            Console.WriteLine($"O perimetro do circulo é {P} e a area é {A}\n");
        }
    }
}
