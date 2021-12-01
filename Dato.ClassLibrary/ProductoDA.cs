using System.Collections.Generic;
using Entidad.ClassLibrary;

namespace Dato.ClassLibrary
{
   public class ProductoDatos
    {
        //Crea los primeros productos
        public List<ProductoEntidad> ObtenerProducto()
        {
            List<ProductoEntidad> listaProductos = new List<ProductoEntidad>
            {
                new ProductoEntidad(){Id=0,IdCategoria=1, Nombre="L-Cranberry-100ml", Descripcion="cranberry 250ml", Portada='1', Stock=24 ,  UrlSeo="Licor_de_Uva_250ml",Precio=6.90,Imagen="/Licores/L-Cranberry-100ml.jpg"},
                new ProductoEntidad(){Id=1,IdCategoria=1, Nombre="L-FourLokoGold-470ml", Descripcion="L-FourLokoGold-470ml, hecho en México", Portada='0', Stock=34 ,  UrlSeo="Licor_de_Mango_250ml",Precio=9.90,Imagen="/Licores/L-FourLokoGold-470ml.jpg"},
                new ProductoEntidad(){Id=1,IdCategoria=1, Nombre="L-FourLokoSandia-470ml", Descripcion="L-FourLokoSandia-470ml, hecho en México", Portada='0', Stock=34 ,  UrlSeo="Licor_de_Mango_250ml",Precio=9.90,Imagen="/Licores/L-FourLokoSandia-470ml.jpg"},
                new ProductoEntidad(){Id=2,IdCategoria=1, Nombre="L-MikeHardLemonade-250ml", Descripcion="mike-hard-lemonade de 250ml, hecho en Perú", Portada='0', Stock=14 ,  UrlSeo="Licor_de_Guanábana_250ml",Precio=5.00, Imagen="/Licores/L-MikeHardLemonade-250ml.jpg"},
                new ProductoEntidad(){Id=3,IdCategoria=1, Nombre="L-Naranja-200ml", Descripcion="L-Naranja-200ml de 250ml, hecho en Perú", Portada='0', Stock=22 ,  UrlSeo="Licor_de_Aguaje_250ml",Precio=6.00, Imagen="/Licores/L-Naranja-200ml.jpg"},
                new ProductoEntidad(){Id=4,IdCategoria=1, Nombre="L-PiñaMenta-195ml", Descripcion="L-PiñaMenta-195ml 250ml, hecho en Perú", Portada='0', Stock=24 ,  UrlSeo="Licor_de_Arroz_250ml",Precio=6.00, Imagen="/Licores/L-PiñaMenta-195ml.jpg"},
                new ProductoEntidad(){Id=5,IdCategoria=1, Nombre="L-Rose-245ml", Descripcion="L-Rose-245ml 250ml, hecho en Perú", Portada='0', Stock=14 ,  UrlSeo="Licor_de_Pera_250ml",Precio=6.00, Imagen="/Licores/L-Rose-245ml.jpg"},
                new ProductoEntidad(){Id=6,IdCategoria=1, Nombre="L-TropialOrange-15g", Descripcion="L-TropialOrange-15g, hecho en Perú", Portada='0', Stock=4 ,  UrlSeo="Licor_de_Manzana_250ml",Precio=7.00,Imagen="/Licores/L-TropialOrange-15g.jpg"},
                
                new ProductoEntidad(){Id=8,IdCategoria=2, Nombre="C-LuckiStrikeBigChill-10uni", Descripcion="C-LuckiStrikeBigChill-10uni, paquete de 10 unidades", Portada='1', Stock=24 ,  UrlSeo="Cigarro_Luky_Strike_menta_20_unidades",Precio=10.00, Imagen="/Cigarros/C-LuckiStrikeBigChill-10uni.jpg"},
                new ProductoEntidad(){Id=9,IdCategoria=2, Nombre="C-LuckiStrikeCrush-10uni", Descripcion="C-LuckiStrikeCrush-10uni, paquete de 10 unidades", Portada='0', Stock=24 ,  UrlSeo="Cigarro_Hamiltom_natural_20_unidades",Precio=10.00, Imagen="/Cigarros/C-LuckiStrikeCrush-10uni.jpg"},
                new ProductoEntidad(){Id=10,IdCategoria=2, Nombre="C-LuckiStrikeFreshTwist-10uni", Descripcion="C-LuckiStrikeFreshTwist-10uni, paquete de 10 unidades", Portada='0', Stock=24 ,  UrlSeo="Cigarro_Malboro_menta_20_unidades",Precio=9.50, Imagen="/Cigarros/C-LuckiStrikeFreshTwist-10uni.jpg"},
                new ProductoEntidad(){Id=11,IdCategoria=2, Nombre="C-LuckiStrikeWildMix-10uni", Descripcion="C-LuckiStrikeWildMix-10uni, paquete de 10 unidades", Portada='0', Stock=24 ,  UrlSeo="Cigarro_Pall_Mall_menta_20_unidades",Precio=10.50, Imagen="/Cigarros/C-LuckiStrikeWildMix-10uni.jpg"},

                new ProductoEntidad(){Id=16,IdCategoria=3, Nombre="C-Cerveza Pilsen Callao", Descripcion="Cerveza Pilsen Callao de 450ml", Portada='1', Stock=24 ,  UrlSeo="Cerveza_Pilsen_Callao_de_450ml",Precio=5.50, Imagen="/Cervezas/C-cerveza1.jpg"},
                new ProductoEntidad(){Id=17,IdCategoria=3, Nombre="C-Cerveza Cusqueña", Descripcion="Cerveza Cusqueña de 450ml", Portada='0', Stock=24 ,  UrlSeo="Cerveza_Cusqueña_de_450ml",Precio=6.00,Imagen="/Cervezas/C-cerveza2.jpg"},
                new ProductoEntidad(){Id=18,IdCategoria=3, Nombre="C-Cerveza Cristal", Descripcion="Cerveza Cristal de 450ml", Portada='0', Stock=24 ,  UrlSeo="Cerveza_Cristal_de_450ml",Precio=4.50,Imagen="/Cervezas/C-cerveza3.jpg"},
                new ProductoEntidad(){Id=19,IdCategoria=3, Nombre="C-Cerveza Brahma", Descripcion="Cerveza Brahma de 450ml", Portada='0', Stock=24 ,  UrlSeo="Cerveza_Brahma_de_450ml",Precio=3.50,Imagen="/Cervezas/C-cerveza4.jpg"},
                new ProductoEntidad(){Id=20,IdCategoria=3, Nombre="C-Cerveza Heineken", Descripcion="Cerveza Heineken de 450ml", Portada='0', Stock=24 ,  UrlSeo="Cerveza_Heineken_de_450ml",Precio=5.50,Imagen="/Cervezas/C-cerveza5.jpg"},
                new ProductoEntidad(){Id=21,IdCategoria=3, Nombre="C-Cerveza Tres Cruces", Descripcion="Cerveza Snow de 450ml", Portada='0', Stock=24 ,  UrlSeo="Cerveza_Snow_de_450ml",Precio=3.50,Imagen="/Cervezas/C-cerveza6.jpg"},
                new ProductoEntidad(){Id=22,IdCategoria=3, Nombre="C-Cerveza Estella", Descripcion="Cerveza Bud Light de 450ml", Portada='0', Stock=24 ,  UrlSeo="Cerveza_Bud_Light_de_450ml",Precio=5.00,Imagen="/Cervezas/C-cerveza7.jpg"},
                new ProductoEntidad(){Id=23,IdCategoria=3, Nombre="C-Cerveza Budweiser", Descripcion="Cerveza Budweiser de 450ml", Portada='0', Stock=24 ,  UrlSeo="Cerveza_Budweiser_de_450ml",Precio=6.00,Imagen="/Cervezas/C-cerveza8.jpg"},

                new ProductoEntidad(){Id=24,IdCategoria=4, Nombre="S-CanchaChulpi-140g", Descripcion="Cancha Chulpi 360gr, de la Sierra", Portada='1', Stock=24 ,  UrlSeo="Papas_Lays_paquete_de_360gr",Precio=2.50,Imagen="/Snacks/S-CanchaChulpi-140g.jpg"},
                new ProductoEntidad(){Id=25,IdCategoria=4, Nombre="S-Lays-360g", Descripcion="Papas Lays 360gr", Portada='0', Stock=24 ,  UrlSeo="Doritos_paquete_de_360gr",Precio=2.50,Imagen="/Snacks/S-Lays-360g.jpg"},
                new ProductoEntidad(){Id=26,IdCategoria=4, Nombre="S-Piqueo-280g", Descripcion="Piqueo 280gr", Portada='0', Stock=24 ,  UrlSeo="Cheese_Trees_paquete_de_360gr",Precio=3.00,Imagen="/Snacks/S-Piqueo-280g.jpg"},
                new ProductoEntidad(){Id=27,IdCategoria=4, Nombre="S-Pringles-37g", Descripcion="Pringles 37gr", Portada='0', Stock=24 ,  UrlSeo="M&M_paquete_de_360gr",Precio=3.50,Imagen="/Snacks/S-Pringles-37g.jpg"}
            };
            return listaProductos; 
        }
    }
}
