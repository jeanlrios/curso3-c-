namespace QuintoDesafio.FormaGeometrica
{
    internal class FormaGeometrica
    {
        public virtual void CalcularQuadrado(double lado)
        {
            double P = 4 * lado;
            double A = lado * lado;
            Console.WriteLine($"O perimetro do quadrado é {P} e a area é {A}\n");
        }
        public virtual void CalcularTriangulo(double a, double b, double c)
        {
            double h = (a + b + c) / 2;
            double A = (b * h) / 2;
            double P = a + b + c;
            Console.WriteLine($"O perimetro do triângulo é {P} e a area é {A}\n");
        }
        public virtual void CalcularCirculo(double d)
        {
            double r = d / 2;
            double A = 3.14 * (r * r);
            double P = (3.14 * 2) * r;
            Console.WriteLine($"O perimetro do circulo é {P} e a area é {A}\n");
        }
    }
}
