using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad.ClassLibrary;

namespace Dato.ClassLibrary
{
    public class ItemCarritoDatos
    {
        static List<ItemCarritoEntidad> ItemsDelCarrito { get; }        

        // Método para crear items en el carrito.
        static ItemCarritoDatos()
        {
            // ProductoDatos recibeProductos = new ProductoDatos();
            // List<ProductoEntidad> producto = recibeProductos.GetProducto();
            ItemsDelCarrito = new List<ItemCarritoEntidad> { };
        }

        // Método para retornar todos los items carrito.
        public static List<ItemCarritoEntidad> ObtenerTodo()
        {
            return ItemsDelCarrito;
        }

        // Método para agregar un item al carrito.
        public static void Agregar(ItemCarritoEntidad item)
        {
            ItemsDelCarrito.Add(item);
        }

        // Método para borrar un item del carrito.
        public static void Eliminar(ItemCarritoEntidad itemEliminar)
        {
            ItemsDelCarrito.Remove(itemEliminar);
        }

        // Actualizar cantidad.
        public static void Actualizar(ItemCarritoEntidad item)
        {
            var index = ItemsDelCarrito.FindIndex(p => p.Id == item.Id);
            ItemsDelCarrito[index] = item;
        }

        // Limpiar el carrito una vez que el usuario cierre su sesion.
        public static void LimpiarCarrito()
        {
            List<ItemCarritoEntidad> itemsEliminar = ItemCarritoDatos.ObtenerTodo();            
            int cantidadItemsActual = itemsEliminar.Count;
            while (ItemsDelCarrito.Count > 0)
            {
                ItemsDelCarrito.Remove(itemsEliminar[cantidadItemsActual - 1]);
                cantidadItemsActual--;
            }
        }
    }
}
