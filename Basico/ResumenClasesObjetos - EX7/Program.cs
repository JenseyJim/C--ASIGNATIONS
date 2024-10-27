class Rectangulo
{
    public double Largo { get; }
    public double Ancho { get; }

    public Rectangulo(double largo, double ancho)
    {
        Largo = largo;
        Ancho = ancho;
    }

    public double CalcularArea()
    {
        return Largo * Ancho;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangulo rect = new Rectangulo(5.0, 3.0);
        Console.WriteLine("Área del rectángulo: " + rect.CalcularArea());
        Console.ReadKey ();
    }
}
