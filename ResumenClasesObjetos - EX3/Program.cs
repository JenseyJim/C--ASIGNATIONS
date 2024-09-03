class Saludador
{
    public void Saludar(string nombre)
    {
        Console.WriteLine("Hola, " + nombre);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Saludador saludador = new Saludador();
        saludador.Saludar("Jensey");
        Console.ReadKey();
    }
}
