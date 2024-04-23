namespace DecimoDesafio.FormaGeometrica
{
    internal class Circulo : IForma
    {
        public void CalcularForma(double a, double b)
        {
            double r = a / 2;           
            double pi = 3.14;
            double A = pi * (r * r);
            double P = (pi * 2) * r;
            Console.WriteLine($"O perimetro do circulo é {P} e a area é {A}\n");
        }
    }
}