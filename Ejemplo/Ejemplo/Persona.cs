using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    [Serializable]
    public class Persona
    {
        private string Rut;
        private string Nombre;
        private int Edad;

        public Persona(string rut, string nombre, int edad)
        {
            this.Rut = rut;
            this.Nombre = nombre;
            this.Edad = edad;
        }


    }
}
