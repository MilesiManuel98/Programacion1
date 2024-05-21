using EjerciciosDePrueba.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class Estereo
    {
        private string marca;
        private string color;
        private string material;

        public ModoEstereoEnum Modo;
        public bool Encendido;
        public int Volumen;

        Random random = new Random();

        int randomNumber = random.Next(0, 101);

        public Estereo(string marca, string color, string material)
        {
            this.marca = marca;
            this.color = color;
            this.material = material;

            this.Volumen = 50;
            this.Encendido = false;
            this.Modo = ModoEstereoEnum.Radio;
        }

        public void PresionarBotonEncendido()
        {
            this.Encendido = !this.Encendido;

        }

        public void CambiarModo(ModoEstereoEnum modo)
        {
            if (this.Encendido)
                this.Modo = modo;
            else
                Console.WriteLine("Error: el estereo debe estar prendida");
        }

        public void SeleccionarEmicion()
        {
            if (Encendido)
            {
                if (Modo == ModoEstereoEnum.Radio)
                {
                    Volumen = 0 + Random.Next(Int32.MaxValue);
                }
                else if (Modo == ModoEstereoEnum.Auxiliar)
                {
                    
                }
                else if (Modo == ModoEstereoEnum.Bluetooth)
                {

                }
                else if (Modo == ModoEstereoEnum.CD)
                {

                }
            }
            else
            {
                Console.WriteLine("Error: el estereo debe estar prendida");
            }
        }
    }
}
