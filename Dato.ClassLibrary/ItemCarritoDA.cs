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

            ItemsDelCarrito = new List<ItemCarritoBE> { };            
        }

        //Método para retornar todos los items carrito
        public static List<ItemCarritoBE> GetAll()
        {
            return ItemsDelCarrito;
        }

        
        
        //Método para agregar un item al carrito
        public static void Add(ItemCarritoBE item)
        {            
            ItemsDelCarrito.Add(item);            
        }
        
        
        //Método para borrar un item del carrito
        public static void Delete(ItemCarritoBE itemEliminar)
        {
            ItemsDelCarrito.Remove(itemEliminar);            
        }



        //Actualizar cantidad
        public static void Update(ItemCarritoBE item)
        {
            var index = ItemsDelCarrito.FindIndex(p => p.Id == item.Id);
            ItemsDelCarrito[index] = item;           
        }

        
    }
}
