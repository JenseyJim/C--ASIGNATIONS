using System;
/* Crea una clase Libro con las propiedades Titulo, Autor y Paginas.

Implementa un método MostrarInformacion que imprima la información del libro.
Implementa un método EsLargo que devuelva true si el libro tiene más de 500 páginas, o false en caso contrario. 
*/

public class Libro
{
	string Titulo = "";
    string Autor = "";
    int Paginas = 0;
    bool chequeo;

    public void cargaInfo()
    {
        try
        {
            Console.Write("Ingrese el Titulo del libro: ");
            Titulo = Console.ReadLine();

            Console.Write("Ingrese el Autor del libro: ");
            Autor = Console.ReadLine();

            Console.Write("Ingrese la cantidad de paginas del libro: ");
            Paginas = int.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocurrio un error inesperado: " + ex.Message);
        }
        
    }
 
    public bool EsLargo()
    {
        
        if (Paginas > 500)
        {
            chequeo = true;
        }
        else
        {
            chequeo = false;
        }
        return chequeo;
    }

    public void mostrarInformacion()
    {
        Console.WriteLine("");
        Console.WriteLine("-----------INFO-----------");
        Console.WriteLine("El Titulo del libro es: " + Titulo);
        Console.WriteLine("El Autor es: " + Autor);
        Console.WriteLine("La cantidad de paginas es: " + Paginas);
        Console.WriteLine(chequeo);
    }





}
