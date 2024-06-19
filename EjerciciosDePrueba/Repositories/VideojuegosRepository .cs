using EjerciciosDePrueba.Models;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Text;

namespace EjerciciosDePrueba.Repositories
{
    public class VideojuegosRepository
    {
        string urlApi = "https://juegosplaypoint-60a4.restdb.io/rest/juegos";
        HttpClient client = new HttpClient();

        public VideojuegosRepository()
        {
            //configuramos que trabajará con respuestas JSON
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("apikey", "a56ffe4d10576e115a6c17818a119bf7bb92f");
        }
        public async Task<ObservableCollection<Videojuego>?> ObtenerVideojuegoAsync()
        {

            var response = await client.GetStringAsync(urlApi);
            return JsonConvert.DeserializeObject<ObservableCollection<Videojuego>>(response);

        }

        public async Task<Videojuego?> AgregarAsync(string nombre, string portada_url, string descripcion, string genero)
        {
            //creamos un objeto del tipo Libro con los parámetros que llegan
            Videojuego videojuego = new Videojuego()
            {
                nombre = nombre,
                portada_url = portada_url,
                descripcion = descripcion,
                genero = genero
            };



            //enviamos por POST el objeto que creamos a la URL de la API
            var videojuegojson = new StringContent(JsonConvert.SerializeObject(videojuego), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(urlApi, videojuegojson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Videojuego>(await response.Content.ReadAsStringAsync());
        }

        public async Task<Videojuego?> ActualizarAsync(string nombre, string portada_url, string descripcion, string genero, string id)
        {
            //creamos un objeto del tipo Libro con los parámetros que llegan
            Videojuego videojuego = new Videojuego()
            {
                nombre = nombre,
                portada_url = portada_url,
                descripcion = descripcion,
                genero = genero
            };



            //enviamos por POST el objeto que creamos a la URL de la API
            var videojuegojson = new StringContent(
                    JsonConvert.SerializeObject(videojuego),
                    Encoding.UTF8, "application/json");

            var response = await client.PutAsync(urlApi + "/" + id, videojuegojson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Videojuego>(
                await response.Content.ReadAsStringAsync());
        }

        public async Task<Videojuego?> ObtenerPorIdAsync(string id)
        {
            var response = await client.GetStringAsync($"{urlApi}/{id}");
            return JsonConvert.DeserializeObject<Videojuego>(response);
        }

        public async Task<bool> EliminarAsync(string id)
        {
            var response = await client.DeleteAsync(urlApi + "/" + id);
            return response.IsSuccessStatusCode;
        }
    }
}
