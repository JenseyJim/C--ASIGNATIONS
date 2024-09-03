class CuentaBancaria
{
    private decimal saldo;

    public decimal Saldo
    {
        get { return saldo; }
        set
        {
            if (value >= 0)
                saldo = value;
        }
    }

    public void Depositar(decimal cantidad)
    {
        Saldo += cantidad;
    }
}

class Program
{
    static void Main(string[] args)
    {
        CuentaBancaria cuenta = new CuentaBancaria();
        cuenta.Depositar(500);
        Console.WriteLine("El saldo es: " + cuenta.Saldo);
        Console.ReadKey();
    }
}
