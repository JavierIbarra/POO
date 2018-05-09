using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Ejemplo
{
    public delegate void agregarPersona(Persona persona);   // definimos el delegate

    public partial class Form1 : Form
    {
        private agregarPersona PersonaNueva;    // inicializamos una variable del tipo delegate definido anteriormente 

        List<Persona> ListaPersonas;        // inicializamos ListaPersonas

        public Form1()
        {
            ListaPersonas = new List<Persona>();        // creamos la ListaPersona
            PersonaNueva = new agregarPersona(AgregarPersona); // creamos el delegate
            InitializeComponent();      
        }


        private void ButtonRegistrar_Click(object sender, EventArgs e)   // Click en Registrar   
        {
            Ventana1 creador = new Ventana1(AgregarPersona);    // Nos envia a la ventana 1
        }

        private void AgregarPersona(Persona persona)        // definimos el método utilizado por el delegate
        {
            ListaPersonas.Add(persona);     // agregamos una persona a la lista
        }

        // ---------------------- Button Verificar --------------------------------

        private void ButtonVerificar_Click(object sender, EventArgs e)     // Click en Verificar
        {
            string rut = TextBox_Rut.Text;  // asignamos a rut el valor escrito en el TextBox
            LabelTitulo.Text = rut;         //Cambiamos el titulo(Label) por la variable rut 
        }

        // -------------------- Ocultar Botones -------------------------
        private void ButtonOcultar_Click(object sender, EventArgs e)        // Click en Ocultar o Mostrar
        {
            if (ButtonOcultar.Text == "Ocultar")    // si dice Ocultar
            {
                Ocultar_Inicio();       // Ocultamos todo
                ButtonOcultar.Text = "Mostrar"; // Cambiamos el nombre de el boton ocultar por Mostrar
            }
            else        // si dice Mostrar
            {
                Mostrar_Inicio();       // Mostramos  todo
                ButtonOcultar.Text = "Ocultar"; // Cambiamos el nombre de el boton mostrar por Ocultar
            }
        }

        private void Ocultar_Inicio()       // Ocultamos
        {
            LabelTitulo.Visible = false;
            LabelRut.Visible = false;
            TextBox_Rut.Visible = false;
            ButtonVerificar.Visible = false;
            ButtonRegistrar.Visible = false;
        }

        private void Mostrar_Inicio()   //  Mostramos
        {
            LabelTitulo.Visible = true;
            LabelRut.Visible = true;
            TextBox_Rut.Visible = true;
            ButtonVerificar.Visible = true;
            ButtonRegistrar.Visible = true;
        }

        private static void GuardarSimulacion(List<Persona> simulacion, string direccion)
        {
            FileStream fs = new FileStream(direccion, FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, simulacion);
            fs.Close();
        }
    }
}
