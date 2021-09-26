using System.Collections.Generic;
using Entidad.ClassLibrary;

namespace Dato.ClassLibrary
{
   public class ProductoDA
    {
        public List<ProductoBE> getProducto()
        {
            List<ProductoBE> listaProductos = new List<ProductoBE>
            {
                new ProductoBE(){Id=0,id_categoria=1, Nombre="Licor de Uva", Descripcion="Licor de Uva de 250ml, hecho en Chanchamayo", portada='1', Stock=24 ,  UrlSeo="Licor_de_Uva_250ml",Precio=22.50,imagen="licor.png"},
                new ProductoBE(){Id=1,id_categoria=1, Nombre="Licor de Mango", Descripcion="Licor de Mango de 250ml, hecho en Chanchamayo", portada='0', Stock=34 ,  UrlSeo="Licor_de_Mango_250ml",Precio=20,imagen="licor.png"},
                new ProductoBE(){Id=2,id_categoria=1, Nombre="Licor de Guanábana", Descripcion="Licor de Guanábana de 250ml, hecho en Chanchamayo", portada='0', Stock=14 ,  UrlSeo="Licor_de_Guanábana_250ml",Precio=32.50, imagen="licor.png"},
                new ProductoBE(){Id=3,id_categoria=1, Nombre="Licor de Aguaje", Descripcion="Licor de Aguaje de 250ml, hecho en Chanchamayo", portada='0', Stock=22 ,  UrlSeo="Licor_de_Aguaje_250ml",Precio=24.50, imagen="licor.png"},
                new ProductoBE(){Id=4,id_categoria=1, Nombre="Licor de Arroz", Descripcion="Licor de Arroz de 250ml, hecho en Chanchamayo", portada='0', Stock=24 ,  UrlSeo="Licor_de_Arroz_250ml",Precio=25.50, imagen="licor.png"},
                new ProductoBE(){Id=5,id_categoria=1, Nombre="Licor de Pera", Descripcion="Licor de Pera de 250ml, hecho en Chanchamayo", portada='0', Stock=14 ,  UrlSeo="Licor_de_Pera_250ml",Precio=12.50, imagen="licor.png"},
                new ProductoBE(){Id=6,id_categoria=1, Nombre="Licor de Manzana", Descripcion="Licor de Manzana de 250ml, hecho en Chanchamayo", portada='0', Stock=4 ,  UrlSeo="Licor_de_Manzana_250ml",Precio=22.50,imagen="licor.png"},
                new ProductoBE(){Id=7,id_categoria=1, Nombre="Licor de Aguaymanto", Descripcion="Licor de Aguaymanto de 250ml, hecho en Chanchamayo", portada='0', Stock=9 ,  UrlSeo="Licor_de_Aguaymanto_250ml",Precio=32.50, imagen="licor.png"},
                
                new ProductoBE(){Id=8,id_categoria=2, Nombre="Cigarro Luky Strike", Descripcion="Cigarro Luky Strike de menta , paquete de 20 unidades", portada='1', Stock=24 ,  UrlSeo="Cigarro_Luky_Strike_menta_20_unidades",Precio=22.50, imagen="cigarro.jpg"},
                new ProductoBE(){Id=9,id_categoria=2, Nombre="Cigarro Hamilton", Descripcion="Cigarro Hamilton natural , paquete de 20 unidades", portada='0', Stock=24 ,  UrlSeo="Cigarro_Hamiltom_natural_20_unidades",Precio=20.50, imagen="cigarro.jpg"},
                new ProductoBE(){Id=10,id_categoria=2, Nombre="Cigarro Malboro", Descripcion="Cigarro Malboro de menta , paquete de 20 unidades", portada='0', Stock=24 ,  UrlSeo="Cigarro_Malboro_menta_20_unidades",Precio=21.50, imagen="cigarro.jpg"},
                new ProductoBE(){Id=11,id_categoria=2, Nombre="Cigarro Pall Mall", Descripcion="Cigarro Pall Mall de  menta , paquete de 20 unidades", portada='0', Stock=24 ,  UrlSeo="Cigarro_Pall_Mall_menta_20_unidades",Precio=18.50, imagen="cigarro.jpg"},
                new ProductoBE(){Id=12,id_categoria=2, Nombre="Cigarro Luky Strike", Descripcion="Cigarro Luky Strike de mora , paquete de 20 unidades", portada='0', Stock=24 ,  UrlSeo="Cigarro_Luky_Strike_mora_20_unidades",Precio=22.50, imagen="cigarro.jpg"},
                new ProductoBE(){Id=13,id_categoria=2, Nombre="Cigarro Luky Strike", Descripcion="Cigarro Luky Strike de naranja , paquete de 20 unidades", portada='0', Stock=24 ,  UrlSeo="Cigarro_Luky_Strike_naranja_20_unidades",Precio=22.50, imagen="cigarro.jpg"},
                new ProductoBE(){Id=14,id_categoria=2, Nombre="Cigarro Luky Strike", Descripcion="Cigarro Luky Strike natural , paquete de 20 unidades", portada='0', Stock=24 ,  UrlSeo="Cigarro_Luky_Strike_natural_20_unidades",Precio=22.50, imagen="cigarro.jpg"},
                new ProductoBE(){Id=15,id_categoria=2, Nombre="Cigarro Luky Strike", Descripcion="Cigarro Luky Strike de mora  , paquete de 10 unidades", portada='0', Stock=24 ,  UrlSeo="Cigarro_Luky_Strike_mora_10_unidades",Precio=12.50, imagen="cigarro.jpg"},

                new ProductoBE(){Id=16,id_categoria=3, Nombre="Cerveza Pilsen Callao", Descripcion="Cerveza Pilsen Callao de 450ml", portada='1', Stock=24 ,  UrlSeo="Cerveza_Pilsen_Callao_de_450ml",Precio=4.50, imagen="cerveza.jpg"},
                new ProductoBE(){Id=17,id_categoria=3, Nombre="Cerveza Cusqueña", Descripcion="Cerveza Cusqueña de 450ml", portada='0', Stock=24 ,  UrlSeo="Cerveza_Cusqueña_de_450ml",Precio=4.50,imagen="cerveza.jpg"},
                new ProductoBE(){Id=18,id_categoria=3, Nombre="Cerveza Cristal", Descripcion="Cerveza Cristal de 450ml", portada='0', Stock=24 ,  UrlSeo="Cerveza_Cristal_de_450ml",Precio=4.50,imagen="cerveza.jpg"},
                new ProductoBE(){Id=19,id_categoria=3, Nombre="Cerveza Brahma", Descripcion="Cerveza Brahma de 450ml", portada='0', Stock=24 ,  UrlSeo="Cerveza_Brahma_de_450ml",Precio=3.50,imagen="cerveza.jpg"},
                new ProductoBE(){Id=20,id_categoria=3, Nombre="Cerveza Heineken", Descripcion="Cerveza Heineken de 450ml", portada='0', Stock=24 ,  UrlSeo="Cerveza_Heineken_de_450ml",Precio=5.50,imagen="cerveza.jpg"},
                new ProductoBE(){Id=21,id_categoria=3, Nombre="Cerveza Snow", Descripcion="Cerveza Snow de 450ml", portada='0', Stock=24 ,  UrlSeo="Cerveza_Snow_de_450ml",Precio=5.50,imagen="cerveza.jpg"},
                new ProductoBE(){Id=22,id_categoria=3, Nombre="Cerveza Bud Light", Descripcion="Cerveza Bud Light de 450ml", portada='0', Stock=24 ,  UrlSeo="Cerveza_Bud_Light_de_450ml",Precio=5.50,imagen="cerveza.jpg"},
                new ProductoBE(){Id=23,id_categoria=3, Nombre="Cerveza Budweiser", Descripcion="Cerveza Budweiser de 450ml", portada='0', Stock=24 ,  UrlSeo="Cerveza_Budweiser_de_450ml",Precio=6.50,imagen="cerveza.jpg"},

                new ProductoBE(){Id=24,id_categoria=4, Nombre="Papas Lays", Descripcion="Papas Lays paquete de 360gr", portada='1', Stock=24 ,  UrlSeo="Papas_Lays_paquete_de_360gr",Precio=22.50,imagen="snacks.jpg"},
                new ProductoBE(){Id=25,id_categoria=4, Nombre="Doritos", Descripcion="Doritos paquete de 360gr", portada='0', Stock=24 ,  UrlSeo="Doritos_paquete_de_360gr",Precio=22.50,imagen="snacks.jpg"},
                new ProductoBE(){Id=26,id_categoria=4, Nombre="Cheese Trees", Descripcion="Cheese Trees paquete de 360gr", portada='0', Stock=24 ,  UrlSeo="Cheese_Trees_paquete_de_360gr",Precio=22.50,imagen="snacks.jpg"},
                new ProductoBE(){Id=27,id_categoria=4, Nombre="M&M", Descripcion="M&M paquete de 360gr", portada='0', Stock=24 ,  UrlSeo="M&M_paquete_de_360gr",Precio=22.50,imagen="snacks.jpg"},
                new ProductoBE(){Id=28,id_categoria=4, Nombre="Karinto", Descripcion="Karinto paquete de 360gr", portada='0', Stock=24 ,  UrlSeo="Karinto_paquete_de_360gr",Precio=22.50,imagen="snacks.jpg"},
                new ProductoBE(){Id=29,id_categoria=4, Nombre="Pringles", Descripcion="Pringles paquete de 360gr", portada='0', Stock=24 ,  UrlSeo="Pringles_paquete_de_360gr",Precio=22.50,imagen="snacks.jpg"},
                new ProductoBE(){Id=30,id_categoria=4, Nombre="Cuates", Descripcion="Cuates paquete de 360gr", portada='0', Stock=24 ,  UrlSeo="Cuates_paquete_de_360gr",Precio=22.50,imagen="snacks.jpg"},
                new ProductoBE(){Id=31,id_categoria=4, Nombre="Chizitos", Descripcion="Chizitos paquete de 360gr", portada='0', Stock=24 ,  UrlSeo="Chizitos_paquete_de_360gr",Precio=22.50,imagen="snacks.jpg"},

            };
            return listaProductos; 
        }
    }
}
