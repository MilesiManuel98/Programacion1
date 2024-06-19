using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    public class Empresa <T> where T : Empleado
    {
        List<T> empleados = new List<T>();
        string nombre;
        public Empresa(string nombre) 
        {
            this.nombre = nombre;
        }
        public void agregarEmpleado(T empleado)
        {
            empleados.Add(empleado);
        }
        public bool quitarEmploado(T empleado)
        {
            if (empleados.Contains(empleado))
            {
                empleados.Remove(empleado);
                return true;
            }
            else
            {
                return false;
            }
        }
        public string listarPersonas()
        {
            string retorno = $"Lista de empleados de {this.nombre}" + Environment.NewLine;
            foreach (var trabajador in empleados)
            {
                retorno += trabajador.ImprimirInfo() + Environment.NewLine;
            }
            return retorno;
        }
    }
}
