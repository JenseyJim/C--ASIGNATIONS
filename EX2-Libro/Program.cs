class Program
{
    static void Main (string[] args)
    {
        Libro lb = new Libro();
        lb.cargaInfo();
        lb.EsLargo();
        lb.mostrarInformacion();
        
        Console.ReadKey();

    }

}
