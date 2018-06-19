using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoModelo
{
    public class Persona
    {
        private string nombreCompleto;
        private string nombre;
        private string apellido;
        private string rut;
        private int edad;

        public Persona(string Nnombre, string Napellido, string Nrut, int Nedad)
        {
            this.nombre = Nnombre;
            this.apellido = Napellido;
            this.rut = Nrut;
            this.edad = Nedad;
        }

        public void NombreCompleto()
        {
            string nombrecompleto = nombre + " " + apellido;
            this.nombreCompleto = nombrecompleto;
        }

        public string Resultado
        {
            get { return nombreCompleto; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Rut
        {
            get { return rut; }
        }

        public int Edad
        {
            get { return edad; }
        }
    }
}
