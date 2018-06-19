using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Ejemplo3
{
    public partial class AgregarPersona : Form
    {
        Assembly asm;   // Inicializamos el Assembly(Para habrir el DLL)
        Type tipos;     // Inicializamos el Tipo (Para habrir la clase que se encuentra en el DLL)
        object objeto;
        string Nombre;
        string Apellido;
        string Rut;
        int Edad;

        public AgregarPersona()
        {
            InitializeComponent();

            try
            {
                asm = Assembly.LoadFile(Application.StartupPath + "\\NuevoModelo.dll");     // Habrimos el DLL ubicado en la carpeta Debug de la aplicacion
                tipos = asm.GetType("NuevoModelo.Persona");                                 // Selecionamos la clase a utilizar (Debemos saber las clases existentes en el DLL)
            }
            catch (FileNotFoundException ex)    // En caso de algun error
            {
                MessageBox.Show(ex.Message);    // Mostramos el error en pantalla
            }
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            Nombre = textBoxNombre.Text;         // Asignando textos a las variables
            Apellido = textBoxApellido.Text;     // Asignando textos a las variables
            Rut = textBoxRut.Text;               // Asignando textos a las variables
            Edad = int.Parse(textBoxEdad.Text);  // Asignando textos a las variables

            objeto = Agregar(Nombre, Apellido, Rut, Edad);                                 // Llamamos a la funcion Agregar 
            string valor = UtilizarMetodos(objeto, "NombreCompleto", "Resultado");         // Llamamos a la funcion UtilizarMetodos( objeto, metodo que queremos utilizar, metodo con el cual obtenemos el valor creado generalmente es un metodo get)
            labelNombreCompleto.Text += " " + valor;                                       // Mostramos en pantalla
        }

        private object Agregar(string nombre, string apellido, string rut, int edad)    // Esta funcion permite crear una nueva Persona
        {
            object[] datos = new object[] { nombre, apellido, rut, edad };  // Creamos un objeto con los datos que necesita el constructor de la clase Persona
            object obj = Activator.CreateInstance(tipos, datos);            // Utilizamos el constructor de la clase Persona y le pasamos los datos 
            return obj;                                                     // Retornamos el objeto construido
        }

        private string UtilizarMetodos(object objeto, string metodoUtilizado, string metodoRecuperador)     // Con esta funcion utilizamos los metodo de la clase
        {
            MethodInfo NombreCompleto = tipos.GetMethod(metodoUtilizado);  // Llamamos al metodo "NombreCompleto" de la Clase utilizada en la variable "tipos"
            NombreCompleto.Invoke(objeto, null);                            // Invocamos el metodo pasando el objeto y los parametos necesarios

            /* Ejemplo (Si el metodo utiliza parametros):
            
            object[] parametro = new object[] {nombre,apellido};
            NombreCompleto.Invoke(objeto, parametro);
           
             */

            PropertyInfo nombreCompleto = tipos.GetProperty(metodoRecuperador);     // Llamamos al metodo "Resultado" y lo asignamos a una variable 
            return (string)nombreCompleto.GetValue(objeto);                         // Mediante el metodo "Resultado" obtenemos el valor creado por el metodo "NombreCompleto" 

        }
    }
}
