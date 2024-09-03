class Persona
{
    private string nombre;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public void Saludar()
    {
        Console.WriteLine("Hola, mi nombre es " + Nombre);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Persona persona1 = new Persona();
        persona1.Nombre = "Jensey";
        persona1.Saludar();
        Console.ReadKey();
    }
}
