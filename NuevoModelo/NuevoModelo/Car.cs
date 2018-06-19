using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoModelo
{
    class Car
    {
        private string marca;
        private string modelo;
        private int año;
        private Persona dueño;

        public Car(string Nmarca, string Nmodelo, int Naño, Persona Ndueño)
        {
            this.marca = Nmarca;
            this.modelo = Nmodelo;
            this.año = Naño;
            this.dueño = Ndueño;
        }

        public string Marca
        {
            get { return marca; }
        }

        public string Modelo
        {
            get { return modelo; }
        }

        public int Año
        {
            get { return año; }
        }

        public Persona Dueño
        {
            get { return dueño; }
            set { dueño = value; }
        }
    }
}
