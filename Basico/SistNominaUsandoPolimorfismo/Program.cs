class Program
{
    static void Main(string[] args)
    {
        Empleado[] empleados = new Empleado[]
        {
            new EmpleadoAsalariado("Jensey", "Jimenez", "001-157-005", 850.00m),
            new EmpleadoPorHoras("Euris", "Ulloa", "78-111-444", 25.00m, 45),
            new EmpleadoPorComision("Denzel", "Washignton", "232-55-472", 0.10m, 5000.00m),
            new EmpleadoBaseMasComision("Angel", "Reyes", "208-80-404", 0.05m, 8500.00m, 300.00m)
        };

        foreach (Empleado empleado in empleados)
        {
            Console.WriteLine(empleado);
            Console.WriteLine($"Ingresos: {empleado.Ingresos():C}\n");
        }
        Console.ReadKey();
    }
}