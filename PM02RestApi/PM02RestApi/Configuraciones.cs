using System;
using System.Collections.Generic;
using System.Text;


namespace PM02RestApi
{
    public class Configuraciones
    {
        public const String IDFoursquare = "HR4HDOM0YPFEORMEFHTYHY5GZUWI5K2VKDT1VCQBPZW3IRTU";
        public const String SecretFoursquare = "UB1O0POYIDCT2GUZTAG5L2CGG4LKLPNXLOGEI3R2S4TBT4Y4";
        public const String apifoursquare = "https://api.foursquare.com/v2/venues/search?ll={0},{1}&client_id={2}&client_secret={3}&v={4}";
    }

    public static class Sitios
    {
        public static String getUrl(Double latitud, Double longitud)
        {
            return String.Format (
                Configuraciones.apifoursquare, 
                latitud, 
                longitud, 
                Configuraciones.IDFoursquare, 
                Configuraciones.SecretFoursquare, 
                DateTime.Now.ToString("yyyyMMdd"));
        }
    }
}
