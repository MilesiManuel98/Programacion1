﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Models
{
    public class Videojuego
    {
        public string _id { get; set; }
        public string nombre { get; set; }
        public string portada_url { get; set; }
        public string descripcion { get; set; }
        public string genero { get; set; }
    }
}
