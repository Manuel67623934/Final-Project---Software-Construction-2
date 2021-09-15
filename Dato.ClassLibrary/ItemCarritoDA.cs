using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad.ClassLibrary;

namespace Dato.ClassLibrary
{
    public class ItemCarritoDA
    {
        static List<ItemCarritoBE> ItemsDelCarrito { get; }
        static int nextId = 1;
        
        //Método para crear items en el carrito
        static ItemCarritoDA()
        {
            ProductoDA productos = new ProductoDA();
            List<ProductoBE> producto = productos.getProducto();  

            ItemsDelCarrito = new List<ItemCarritoBE>
            {
                new ItemCarritoBE{Id=0, Producto = producto[0], ProductoNombre=producto[0].Nombre, ProductoPrecio = producto[0].Precio, Cantidad=00, Subtotal=000, Total=0000} 
            };
        }

        //Método para retornar todos los items carrito
        public static List<ItemCarritoBE> GetAll()
        {
            return ItemsDelCarrito;
        }

        
        
        //Método para agregar un item al carrito
        public static void Add(ItemCarritoBE item)
        {
            item.Id = nextId++;
            ItemsDelCarrito.Add(item);

            ItemsDelCarrito.Last().Total = CalculaTotal();
        }
        
        
        //Método para borrar un item del carrito
        public static void Delete(int id)
        {
            ItemCarritoBE itemEliminar = ItemsDelCarrito.FirstOrDefault(elegirItem => elegirItem.Id==id);
            ItemsDelCarrito.Remove(itemEliminar);

            ItemsDelCarrito.Last().Total = CalculaTotal();
        }



        //Actualizar cantidad
        public static void Update(ItemCarritoBE item)
        {
            int itemActualizar = ItemsDelCarrito.FindIndex(elegirItem => elegirItem.Id == item.Id);
            ItemsDelCarrito[itemActualizar] = item;

            ItemsDelCarrito.Last().Total = CalculaTotal();
        }



        //suma de subtotales
        public static double CalculaTotal()
        {
            double subtotal =0.0;
            double total = 0.0;

            for (int i = 0; i < ItemsDelCarrito.Count(); i++)
            {
                subtotal = ItemsDelCarrito[i].Subtotal;
                total = total + subtotal;
            }

            return total;
        }

        
    }
}
