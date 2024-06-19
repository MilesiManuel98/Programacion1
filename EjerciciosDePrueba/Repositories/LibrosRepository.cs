using EjerciciosDePrueba.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Repositories
{
    public class LibrosRepository
    {
        string urlApi = "https://ingenieria-f193.restdb.io/rest/libros";
        HttpClient client = new HttpClient();

        public LibrosRepository()
        {
            //configuramos que trabajará con respuestas JSON
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("apikey", "64f8c70f68885484ef0bfe89");
        }
        public async Task<ObservableCollection<Libro>?> ObtenerLibrosAsync()
        {

            var response = await client.GetStringAsync(urlApi);
            return JsonConvert.DeserializeObject<ObservableCollection<Libro>>(response);

        }

        public async Task<Libro?> AgregarAsync(string nombre, string genero, int paginas, string editorial, string sinopsis, string portada_url, string autor)
        {
            //creamos un objeto del tipo Nota con los parámetros que llegan
            Libro libro = new Libro()
            {
                nombre = nombre,
                genero = genero,
                paginas = paginas,
                editorial = editorial,
                sinopsis = sinopsis,
                portada_url = portada_url,
                autor = autor
            };



            //enviamos por POST el objeto que creamos a la URL de la API
            var librojson = new StringContent(JsonConvert.SerializeObject(libro), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(urlApi, librojson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Libro>(await response.Content.ReadAsStringAsync());
        }

        public async Task<Libro?> ActualizarAsync(string nombre, string autor, string editorial, string portada_url, string sinopsis, int paginas, string genero, string id)
        {
            //creamos un objeto del tipo Libro con los parámetros que llegan
            Libro libro = new Libro()
            {
                nombre = nombre,
                autor = autor,
                editorial = editorial,
                portada_url = portada_url,
                sinopsis = sinopsis,
                paginas = paginas,
                genero = genero
            };



            //enviamos por POST el objeto que creamos a la URL de la API
            var librojson = new StringContent(
                    JsonConvert.SerializeObject(libro),
                    Encoding.UTF8, "application/json");

            var response = await client.PutAsync(urlApi + "/" + id, librojson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Libro>(
                await response.Content.ReadAsStringAsync());
        }

        public async Task<Libro?> ObtenerPorIdAsync(string id)
        {
            var response = await client.GetStringAsync($"{urlApi}/{id}");
            return JsonConvert.DeserializeObject<Libro>(response);
        }

        public async Task<bool> EliminarAsync(string id)
        {
            var response = await client.DeleteAsync(urlApi + "/" + id);
            return response.IsSuccessStatusCode;
        }
    }
}
