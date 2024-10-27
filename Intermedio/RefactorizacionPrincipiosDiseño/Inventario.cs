
namespace RefactorizacionPrincipiosDiseño
{
    public class Inventario
    {
        private List<Producto> productos = new List<Producto>();

        // creamos un nuevo producto
        public void CrearProducto(int id, string nombre, decimal precio, int cantidadStock)
        {
            productos.Add(new Producto { ID = id, Nombre = nombre, Precio = precio, CantidadStock = cantidadStock });
            Console.WriteLine("Producto añadido exitosamente.");
        }

        // aca muestro la lista de productos
        public void MostrarProductos()
        {
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos en el inventario.");
                return;
            }

            Console.WriteLine("Lista de Productos:");
            foreach (var producto in productos)
            {
                MostrarDetalleProducto(producto);
            }
        }

        // con este metodo pmostramos los detalles de un producto
        private void MostrarDetalleProducto(Producto producto)
        {
            Console.WriteLine($"ID: {producto.ID}, Nombre: {producto.Nombre}, Precio: {producto.Precio:C}, Stock: {producto.CantidadStock}");
        }

        // aca buscamos los productos por nombre
        public List<Producto> BuscarProductosPorNombre(string nombre)
        {
            return productos
                .Where(p => p.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        // aca actualizamos el precio del producto
        public void ActualizarPrecioProducto(int id, decimal nuevoPrecio)
        {
            var producto = productos.FirstOrDefault(p => p.ID == id);
            if (producto != null)
            {
                producto.Precio = nuevoPrecio;
                Console.WriteLine($"El precio del producto con ID {id} ha sido actualizado a {nuevoPrecio:C}.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
    }
}

