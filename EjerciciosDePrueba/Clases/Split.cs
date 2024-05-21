using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class Split
    {
        //declararmos los campos y propiedades

        //campo: a las variables privadas de la clase
        private string color;
        private int frigorias;
        private string marca;
        private bool encendido = false;


        //propiedades: las variables publicas de la clase
        public int temperatura = 24;
        public string modo = "Frio";

        //constructor: metodo que se ejecuta cuando la clase se crea, se intancia en memoria, es decir cuando se construye el objeto
        public Split(string Pcolor, int Pfrigorias, string Pmarca)
        {
            this.color = Pcolor;
            this.frigorias = Pfrigorias;
            this.marca = Pmarca;
        }

        public void PrecionarBotonEncendido()
        {
            this.encendido=!this.encendido;
        }
        public void SubirTemperatura()
        {
            if (this.encendido) 
            {
                this.temperatura++;
            }
            else 
            {
                Console.WriteLine("Error: el split esta apagado");
            }
        }
        public void BajarTemperatura()
        {
            if (this.encendido)
            {
                this.temperatura--;
            }
            else
            {
                Console.WriteLine("Error: el split esta apagado");
            }
        }
        public void CambiarModo(string modo)
        {
            if (this.encendido)
            {
                this.modo = modo;
            }
            else
            {
                Console.WriteLine("Error: el split esta apagado");
            }
        }
    }
}
