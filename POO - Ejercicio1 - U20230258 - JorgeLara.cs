using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_Tarea1_U20230258_JorgeLara
{
    public class Producto
    {
        public int ProductoId { get; set; }

        public string ProductoNombre { get; set; }

        public static void AgregarProducto(List<Inventario> inventarys)
        {

            Console.WriteLine("Listado de productos general");

            Inventario.VerListadoDeProductos(inventarys);

            Console.Write("Seleccione un ID de inventario para agregar producto: ");
            int productoId = Convert.ToInt32(Console.ReadLine());

            Inventario inventario = inventarys.Find(u => u.InventarioId == productoId);


            if (inventario != null)
            {
                Producto producto = new Producto();

                Console.Write("Ingrese el nombre del Producto: ");
                producto.ProductoNombre = Console.ReadLine();

                producto.ProductoId = inventario.Productos.Count + 1;
                inventario.Productos.Add(producto);

                Console.WriteLine("Producto agregado exitosamente!");

            }
            else
            {
                Console.WriteLine("No se encontro el Producto");
            }

        }



        public static void EliminarProducto(List<Inventario> inventarys)
        {

            Console.WriteLine("Listado de Productos general");
            Inventario.VerListadoDeProductos(inventarys);

            Console.Write("Seleccione un producto para eliminar la inventario: ");
            int productoId = Convert.ToInt32(Console.ReadLine());

            Inventario inventario = inventarys.Find(u => u.InventarioId == productoId);


            if (inventario != null)
            {
                Console.Write("Ingrese el Id del producto a eliminar: ");
                int productoId = Convert.ToInt32(Console.ReadLine());

                Producto facultad = inventario.Productos.Find(d => d.ProductoId == productoId);

                if (producto != null)
                {
                    inventario.Productos.Remove(producto);
                    Console.WriteLine("Producto eliminado exitosamente!");
                }
                else
                {
                    Console.WriteLine("Producto no encontrado.");
                }
            }

        }



        public static void EditarProducto(List<Inventario> inventarys)
        {

            Console.WriteLine("Listado de productos general");
            Inventario.VerListadoDeProductos(inventarys);

            Console.Write("Seleccione una inventario para editar el producto: ");
            int productoId = Convert.ToInt32(Console.ReadLine());

            Inventario inventario = inventarys.Find(u => u.InventarioId == productoId);


            if (inventario != null)
            {
                Console.Write("Ingrese el Id del producto a editar: ");
                int facultadId = Convert.ToInt32(Console.ReadLine());

                Producto producto = inventario.Productos.Find(d => d.ProductoId == productoId);

                if (producto != null)
                {
                    Console.WriteLine("Ingrese el nuevo nombre del producto: ");
                    producto.ProductoNombre = Console.ReadLine();

                    Console.WriteLine("Producto editado exitosamente!");
                }
                else
                {
                    Console.WriteLine("Producto no encontrado.");
                }
            }

        }

    }

}
