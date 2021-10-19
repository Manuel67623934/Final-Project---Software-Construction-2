using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad.ClassLibrary;
using Dato.ClassLibrary;


namespace Logica.ClassLibrary
{
    
    public class ItemCarritoBL 
    {
        static int nextId = 0;
        public static List<ItemCarritoBE> GetAll()
        {
            return ItemCarritoDA.GetAll();
        }

        public static void Add(ItemCarritoBE item)
        {
            item.Id = nextId++;
            item.Subtotal = CalculaSubtotal(item);
            ItemCarritoDA.Add(item);
        }

        public static void Update(ItemCarritoBE item)
        {
            item.Subtotal = CalculaSubtotal(item);
            ItemCarritoDA.Update(item);
        }


        public static void Delete(int idEliminar)
        {
            ItemCarritoBE itemEliminar = ItemCarritoDA.GetAll().FirstOrDefault(elegirItem => elegirItem.Id == idEliminar);
            ItemCarritoDA.Delete(itemEliminar);
        }



        public static double CalculaSubtotal(ItemCarritoBE item)
        {
            double subtotal = 0.0;            
            return subtotal = item.Cantidad * item.Producto.Precio;
        }

        public static double CalculaTotal()
        {
            double subtotal = 0.0;
            double total = 0.0;

            for (int i = 0; i < ItemCarritoDA.GetAll().Count(); i++)
            {
                subtotal = ItemCarritoDA.GetAll()[i].Subtotal;
                total = total + subtotal;
            }

            return total;
        }


        public static void AumentaCantidad(int id)
        {   
            int cantidad_actual = 0;
            int cantidad_incrementada = 0;
            ItemCarritoBE item = ItemCarritoDA.GetAll().FirstOrDefault(elegirItem => elegirItem.Id == id);
            cantidad_actual = item.Cantidad;            
            cantidad_incrementada = cantidad_actual + 1;
            item.Cantidad = cantidad_incrementada;            
            ItemCarritoBL.Update(item);
        }

        public static void DisminuyeCantidad(int id)
        {
            ItemCarritoBE item = ItemCarritoDA.GetAll().FirstOrDefault(elegirItem => elegirItem.Id == id);
            if (item.Cantidad > 0)
            {
                item.Cantidad = item.Cantidad - 1;
                ItemCarritoBL.Update(item);
            }
            else
            {

            }
            
        }


        public static void CrearItem(string cantidad, int idProducto)
        {
            ProductoBE producto = ProductoBL.RetornaProducto(idProducto);
            ItemCarritoBE nuevoItem = new ItemCarritoBE();
            nuevoItem.Producto = producto;
            nuevoItem.ProductoNombre = producto.Nombre;
            nuevoItem.ProductoPrecio = producto.Precio;
            nuevoItem.Id = 0;
            nuevoItem.Cantidad = int.Parse(cantidad);
            nuevoItem.Subtotal = nuevoItem.ProductoPrecio * nuevoItem.Cantidad;
            nuevoItem.Total = 0;

            ItemCarritoBL.Add(nuevoItem);
        }


        public static void ActualizarCarrito(string cantidad, int idItem)
        {
            ItemCarritoBE item = ItemCarritoDA.GetAll().FirstOrDefault(elegirItem => elegirItem.Id == idItem);
            item.Cantidad = int.Parse(cantidad);
            ItemCarritoBL.Update(item);
        }



    }
}
