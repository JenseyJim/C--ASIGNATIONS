class Program
{
    static void Main(string[] args)
    {
        Alumno al = new Alumno();
        al.calcularPromedio([10, 20]);
        al.mostrarInformacion("Stevens", "2023-1800", "Software");
        Console.ReadKey();
    }
}