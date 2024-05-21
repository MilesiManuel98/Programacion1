using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class Persona
    {
        private string nombre;
        private string direccion;
        private int añoNacio;

        public string saludar;

        public Persona(string nombre, string direccion, int añoNacio)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.añoNacio = añoNacio;
        }

        public void Decir(string texto)
        {
            Console.WriteLine($" dice: {texto}");
        }
    }
}
