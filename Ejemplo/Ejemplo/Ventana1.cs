using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class Ventana1 : Form
    {
        public event agregarPersona PersonaAgregada;    // definimos el evento

        public Ventana1()   // No lo utilizamos
        {
            InitializeComponent();
        }


        public Ventana1(agregarPersona persona) // obtine la llamada de ventana realizada en Form1 (ButtonRegistrar_Click) 
        {
            PersonaAgregada += persona;    // Al utilizar la PersonaAgregada(Persona) se llamara a utilizar el delegate de Form1 
            InitializeComponent();      // Inicia la ventana
            this.Show();            //  Inicia la ventana
        }

        private void Agregar_Click(object sender, EventArgs e)  // Click en Agregar
        {
            string Rut = TextBoxRut.Text;       // asignamos el TextBoxRut a la variable Rut
            string Nombre = TextBoxNombre.Text;     
            int Edad = int.Parse(TextBoxEdad.Text); // tomamos el TextBoxEdad y lo asignamos a la variable Edad 
            PersonaAgregada(new Persona(Rut, Nombre, Edad));    // Creamos una persona y la agregamos mediante el metodo descrito por el delegete en Form1
        }
    }
}
