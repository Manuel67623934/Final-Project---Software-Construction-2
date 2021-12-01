using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad.ClassLibrary;
using Dato.ClassLibrary;


namespace Logica.ClassLibrary
{
    
    public class ItemCarritoLogica 
    {
        static int __nextId = 0;

        /// <summary>
        /// Retorna todos los items del carrito de compra.
        /// </summary>

        public static List<ItemCarritoEntidad> ObtenerTodo()
        {
            return ItemCarritoDatos.ObtenerTodo();
        }

        // Agregar un nuevo item al carrito de compra.
        public static void Agregar(ItemCarritoEntidad item)
        {
            item.Id = __nextId++;
            item.Subtotal = CalculaSubtotal(item);
            ItemCarritoDatos.Agregar(item);
        }

        // Actualiza un item del carrito de compra.
        public static void Actualizar(ItemCarritoEntidad item)
        {
            item.Subtotal = CalculaSubtotal(item);
            ItemCarritoDatos.Actualizar(item);
        }

        // Elimina un item del carrito de compra.
        public static void Eliminar(int idEliminar)
        {
            ItemCarritoEntidad itemEliminar = ItemCarritoDatos.ObtenerTodo().FirstOrDefault(elegirItem => elegirItem.Id == idEliminar);
            ItemCarritoDatos.Eliminar(itemEliminar);
        }

        // Calcular cantidad de producto * precio del producto, acumula este resultado en la subtotal.
        public static double CalculaSubtotal(ItemCarritoEntidad item)
        {
            double subtotal = item.Cantidad * item.Producto.Precio;            
            return subtotal;
        }

        // Calcular la suma de todos los subtotales y retorna la suma (total).
        public static double CalculaTotal()
        {
            double subtotal = 0.0;
            double total = 0.0;
            for (int i = 0; i < ItemCarritoDatos.ObtenerTodo().Count; i++)
            {
                subtotal = ItemCarritoDatos.ObtenerTodo()[i].Subtotal;
                total = total + subtotal;
            }
            return total;
        }

        // Incrementa la cantidad del item.
        public static void AumentaCantidad(int id)
        {   
            int cantidadActual = 0;
            int cantidadIncrementada = 0;
            ItemCarritoEntidad item = ItemCarritoDatos.ObtenerTodo().FirstOrDefault(elegirItem => elegirItem.Id == id);
            cantidadActual = item.Cantidad;            
            cantidadIncrementada = cantidadActual + 1;
            item.Cantidad = cantidadIncrementada;            
            ItemCarritoLogica.Actualizar(item);
        }

        // Disminuye la cantidad del item.
        public static void DisminuyeCantidad(int id)
        {
            ItemCarritoEntidad item = ItemCarritoDatos.ObtenerTodo().FirstOrDefault(elegirItem => elegirItem.Id == id);
            if (item.Cantidad > 0)
            {
                item.Cantidad = item.Cantidad - 1;
                ItemCarritoLogica.Actualizar(item);
            }   
        }

        // Extrae los datos de un producto de la capa de Datos y crea un nuevo item del carrito de compra.
        public static void CrearItem(string cantidad, int idProducto)
        {
            ProductoEntidad producto = ProductoBL.RetornaProducto(idProducto);
            ItemCarritoEntidad nuevoItem = new ItemCarritoEntidad();
            nuevoItem.Producto = producto;
            nuevoItem.ProductoNombre = producto.Nombre;
            nuevoItem.ProductoPrecio = producto.Precio;
            nuevoItem.Id = 0;
            nuevoItem.Cantidad = int.Parse(cantidad);
            nuevoItem.Subtotal = nuevoItem.ProductoPrecio * nuevoItem.Cantidad;
            nuevoItem.Total = 0;
            ItemCarritoLogica.Agregar(nuevoItem);
        }

        // Extrae los items actualizados del carrito de compra desde la capa de Datos.
        public static void ActualizarCarrito(string cantidad, int idItem)
        {
            ItemCarritoEntidad item = ItemCarritoDatos.ObtenerTodo().FirstOrDefault(elegirItem => elegirItem.Id == idItem);
            item.Cantidad = int.Parse(cantidad);
            ItemCarritoLogica.Actualizar(item);
        }

        // Limpia los datos del carrito, llama a la función de la capa de Datos.
        public static void LimpiarCarrito()
        {
            ItemCarritoDatos.LimpiarCarrito();
        }

        // Genera la lista de productos del carrito para ser enviado al API de wsp.
        public static string ListaProductos()
        {
            string listaProductos;
            string listaProductosTotal = "";
            for (int i = 0; i < ItemCarritoLogica.ObtenerTodo().Count; i++)
            {
                listaProductos = ItemCarritoLogica.ObtenerTodo()[i].Cantidad + " --- " + ItemCarritoLogica.ObtenerTodo()[i].ProductoNombre + " --- " + ItemCarritoLogica.ObtenerTodo()[i].ProductoPrecio + " --- " + ItemCarritoLogica.ObtenerTodo()[i].Subtotal + "\n";
                listaProductosTotal = listaProductosTotal + listaProductos;
            }
            return listaProductosTotal;
        }
    }
}
