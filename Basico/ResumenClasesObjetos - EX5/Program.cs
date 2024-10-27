class Producto
{
    private string nombre;
    private decimal precio;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public decimal Precio
    {
        get { return precio; }
        set
        {
            if (value > 0)
                precio = value;
        }
    }
    public void MostrarInfo()
    {
        Console.WriteLine("Producto: " + Nombre);
        Console.WriteLine("Precio: $" + Precio);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Producto prod = new Producto();
        prod.Nombre = "Laptop";
        prod.Precio = 999.99m;
        prod.MostrarInfo();
        Console.ReadKey ();
    }
}
