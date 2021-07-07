using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using static PM02RestApi.Countries;
using Newtonsoft.Json;
using PM02RestApi;
using System.Diagnostics;


namespace PM02RestApi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnRestApi_Clicked(object sender, EventArgs e)
        {
            var coordenadas = Plugin.Geolocator.CrossGeolocator.Current;
            var posicion = await coordenadas.GetPositionAsync();

            list.ItemsSource = await AppClass.Metodos.getSites(posicion.Latitude, posicion.Longitude);


            #region test
            //var urlfq = Sitios.getUrl(platitud, plongitud);
            //Debug.WriteLine(urlfq);

            //var url = "https://restcountries.eu/rest/v2/region/europe";
            //var urlfq = Sitios.getUrl(14.55, -88.05);

            //using (HttpClient cliente = new HttpClient())
            //{
            //    var Respuesta = await cliente.GetAsync(url);

            //    if (Respuesta.IsSuccessStatusCode)
            //    {
            //        var json = Respuesta.Content.ReadAsStringAsync().Result;
            //        await DisplayAlert("Respuesta", json, "Ok");
            //        var Paises = JsonConvert.DeserializeObject<List<CountriesREst>>(json);
            //    }
            //}
            #endregion
        }
    }
}
