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
        Assembly asm;   // Inicializamos el Assembly(Para abrir el DLL)
        Type tipos;     // Inicializamos el Tipo (Para abrir la clase que se encuentra en el DLL)
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
                asm = Assembly.LoadFile(Application.StartupPath + "\\NuevoModelo.dll");     // Abrimos el DLL ubicado en la carpeta Debug de la aplicación
                tipos = asm.GetType("NuevoModelo.Persona");                                 // Seleccionamos  la clase a utilizar (Debemos saber las clases existentes en el DLL)
            }
            catch (FileNotFoundException ex)    // En caso de algún error
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

            objeto = Agregar(Nombre, Apellido, Rut, Edad);                                 // Llamamos a la función Agregar 
            string valor = UtilizarMetodos(objeto, "NombreCompleto", "Resultado");         // Llamamos a la función UtilizarMetodos( objeto, método que queremos utilizar, método con el cual obtenemos el valor creado generalmente es un método get)
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
            MethodInfo NombreCompleto = tipos.GetMethod(metodoUtilizado);  // Llamamos al método "NombreCompleto" de la Clase utilizada en la variable "tipos"
            NombreCompleto.Invoke(objeto, null);                            // Invocamos el método pasando el objeto y los parámetos necesarios

            /* Ejemplo (Si el método utiliza parametros):
            
            object[] parametro = new object[] {nombre,apellido};
            NombreCompleto.Invoke(objeto, parametro);
           
             */

            PropertyInfo nombreCompleto = tipos.GetProperty(metodoRecuperador);     // Llamamos al método "Resultado" y lo asignamos a una variable 
            return (string)nombreCompleto.GetValue(objeto);                         // Mediante el método "Resultado" obtenemos el valor creado por el método "NombreCompleto" 

        }
    }
}
