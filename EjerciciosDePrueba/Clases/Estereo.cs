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
        public double Emisora;

        public Estereo(string marca, string color, string material)
        {
            this.marca = marca;
            this.color = color;
            this.material = material;

            this.Emisora = 99.9;
            this.Volumen = 0;
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
        public void VolumenRamdom()
        {
            Random random = new Random();
            Volumen = random.Next(0, 101);
        }
        public void EmisoraRandom()
        {
            Random random = new Random();
            double min = 88.0;
            double max = 109.0;
            double randomNumber = min + (random.NextDouble() * (max - min));
            Emisora = Math.Round(randomNumber,1);
        }
        public void SeleccionarModo()
        {
            VolumenRamdom();
            EmisoraRandom();
            if (Encendido)
            {
                Console.WriteLine($"Modo: {Modo}");
                Console.WriteLine($"Nivel de Volumen: {Volumen}");
                if (Modo == ModoEstereoEnum.Radio)
                {
                    Console.WriteLine($"Emisora de Radio FM: {Emisora}");
                    Console.WriteLine("Cancion escuchada: Open Sesame (Abracadabra) [feat. Leila K] - Maddix");
                }
                else if (Modo == ModoEstereoEnum.Auxiliar)
                {
                    Console.WriteLine("Cancion escuchada: Redemption - by Boris Brejcha");
                }
                else if (Modo == ModoEstereoEnum.Bluetooth)
                {
                    Console.WriteLine("Cancion escuchada: My Gasoline - by Maddix, Fēlēs");
                }
                else if (Modo == ModoEstereoEnum.CD)
                {
                    Console.WriteLine("Cancion escuchada: My Church - by Will Clarke, MK");
                }

            }
            else
            {
                Console.WriteLine("Error: el estereo debe estar prendida");
            }
        }
    }
}
