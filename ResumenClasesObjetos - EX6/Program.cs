class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        ModificarValor(x);
        Console.WriteLine("Valor de x después de modificar: " + x);

        Persona persona = new Persona { Nombre = "Maria" };
        ModificarReferencia(persona);
        Console.WriteLine("Nombre después de modificar: " + persona.Nombre);
        Console.ReadKey();
    }

    static void ModificarValor(int valor)
    {
        valor = 20;
    }

    static void ModificarReferencia(Persona p)
    {
        p.Nombre = "Jensey";
    }

}
class Persona
{
    public string Nombre { get; set; }

}

