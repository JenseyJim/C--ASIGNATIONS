class Calculadora
{
    public int Sumar(int a, int b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        int resultado = calc.Sumar(5, 7);
        Console.WriteLine("Resultado: " + resultado);
        Console.ReadKey();
    }
}
