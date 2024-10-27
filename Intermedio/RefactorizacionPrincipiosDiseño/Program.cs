using RefactorizacionPrincipiosDiseño;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Inventario inventario = new Inventario();

        // aca creo productos iniciales
        inventario.CrearProducto(1, "Laptop", 1500m, 10);
        inventario.CrearProducto(2, "Mouse", 20m, 100);

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Mostrar productos");
            Console.WriteLine("2. Buscar producto por nombre");
            Console.WriteLine("3. Actualizar precio de producto");
            Console.WriteLine("4. Agregar nuevo producto");
            Console.WriteLine("5. Salir");

            Console.Write("Opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    inventario.MostrarProductos();
                    break;

                case "2":
                    Console.Write("Ingrese el nombre del producto a buscar: ");
                    string nombreProducto = Console.ReadLine();
                    var productosEncontrados = inventario.BuscarProductosPorNombre(nombreProducto);

                    if (productosEncontrados.Count > 0)
                    {
                        Console.WriteLine("Productos encontrados:");
                        foreach (var producto in productosEncontrados)
                        {
                            Console.WriteLine($"ID: {producto.ID}, Nombre: {producto.Nombre}, Precio: {producto.Precio:C}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron productos con ese nombre.");
                    }
                    break;

                case "3":
                    Console.Write("Ingrese el ID del producto a actualizar: ");
                    if (int.TryParse(Console.ReadLine(), out int idProducto))
                    {
                        Console.Write("Ingrese el nuevo precio: ");
                        if (decimal.TryParse(Console.ReadLine(), NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal nuevoPrecio))
                        {
                            inventario.ActualizarPrecioProducto(idProducto, nuevoPrecio);
                        }
                        else
                        {
                            Console.WriteLine("Precio inválido.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ID inválido.");
                    }
                    break;

                case "4":
                    Console.Write("Ingrese el ID del nuevo producto: ");
                    if (int.TryParse(Console.ReadLine(), out int nuevoId))
                    {
                        Console.Write("Ingrese el nombre del nuevo producto: ");
                        string nuevoNombre = Console.ReadLine();
                        Console.Write("Ingrese el precio del nuevo producto: ");
                        if (decimal.TryParse(Console.ReadLine(), NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal nuevoPrecioProducto))
                        {
                            Console.Write("Ingrese la cantidad en stock del nuevo producto: ");
                            if (int.TryParse(Console.ReadLine(), out int nuevaCantidadStock))
                            {
                                inventario.CrearProducto(nuevoId, nuevoNombre, nuevoPrecioProducto, nuevaCantidadStock);
                            }
                            else
                            {
                                Console.WriteLine("Cantidad en stock inválida.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Precio inválido.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ID inválido.");
                    }
                    break;

                case "5":
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opcion invalida.");
                    break;
            }
        }
    }
}