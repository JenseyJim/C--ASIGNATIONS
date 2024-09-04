using System;
/*Desarrollar una clase que represente un punto en el plano y tenga los siguientes métodos: 
 * cargar los valores de x e y, imprimir en que cuadrante se encuentra dicho punto (concepto matemático, 
 * primer cuadrante si x e y son positivas, si x<0 e y>0 segundo cuadrante, etc.*/

class planoCART
{
    #region"metodo"

    public void calcularCuadrante()
    {
        try
        {
            int punto_x = 0;
            int punto_y = 0;

            Console.Write("Ingrese el valor de X: ");
            punto_x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de Y: ");
            punto_y = int.Parse(Console.ReadLine());

            if (punto_x > 0 && punto_y > 0)
            {
                Console.WriteLine("LOS DATOS INGRESADOS PERTENECEN AL PRIMER CUADRANTE");
            }
            if (punto_x < 0 && punto_y > 0)
            {
                Console.WriteLine("LOS DATOS INGRESADOS PERTENECEN AL SEGUNDO CUADRANTE");
            }
            if (punto_x < 0 && punto_y < 0)
            {
                Console.WriteLine("LOS DATOS INGRESADOS PERTENECEN AL TERCER CUADRANTE");
            }
            if (punto_x > 0 && punto_y < 0)
            {
                Console.WriteLine("LOS DATOS INGRESADOS PERTENECEN AL CUARTO CUADRANTE");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocurrio un error inesperado: " + ex.Message);
        }
        
    }
    #endregion
}
