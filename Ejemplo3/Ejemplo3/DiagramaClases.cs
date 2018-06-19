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
    public partial class DiagramaClases : Form
    {
        private int numero;
        Assembly Ensamblado = Assembly.LoadFile(Application.StartupPath + "\\NuevoModelo.dll");     // Llamamos al DLL
        Type[] Tipos;                                                                               // Inicializamos los Tipos

        public DiagramaClases()
        {
            InitializeComponent();
            numero = 0;                             // numero para recorer Tipos
            Tipos = Ensamblado.GetTypes();          // Asignamos todos los tipos del DLL a la variable "Tipos"
            MetodosAtributos(numero);               // Llamamos a la funcion MetodosAtributos
        }

        private void DiagramaClases_Load(object sender, EventArgs e)
        {
            foreach (Type Tipo in Tipos)        // Recorremos los Tipos
            {
                if (Tipo.IsClass == true)       // Si un Tipo es una clases
                {
                    listClases.Items.Add(Tipo.FullName);    // Agregamos a la lista del listBox "listaClase"
                }

            }
        }

        private void ClaseAnt_Click(object sender, EventArgs e) // Boton Siguiente
        {
            if (numero > 0)             // Comprobamos que pertenesca al recorrido posible
            {
                numero -= 1;                    
                MetodosAtributos(numero);       // Llamamos a la funcion MetodosAtributos
            }
        }

        private void ClaseSig_Click(object sender, EventArgs e)     
        {
            if (numero < Tipos.Length - 1)       // Comprobamos que pertenesca al recorrido posible
            {
                numero += 1;
                MetodosAtributos(numero);       // Llamamos a la funcion MetodosAtributos
            }
        }

        private void MetodosAtributos(int numero)
        {
            if (numero < Tipos.Length && 0 <= numero)   // Comprobamos el recorido disponible
            {
                NClase.Text = "" + Tipos[numero];   // Señalamos la clase en pantalla
                listMetodos.Items.Clear();          // Borramos las listas de los listBox
                listAtributos.Items.Clear();        // Borramos las listas de los listBox
                listparametros.Items.Clear();       // Borramos las listas de los listBox

                PropertyInfo[] Atributos = Tipos[numero].GetProperties();   // Obtenemos los atributos de un Tipo
                foreach (PropertyInfo Atributo in Atributos)                // Recorremos los atributos del Tipo
                {
                    listAtributos.Items.Add(Atributo.Name);                // Mostramos el nombre
                }
                MethodInfo[] Metodos = Tipos[numero].GetMethods();          // Obtenemos los metodos de un Tipo
                foreach (MethodInfo Metodo in Metodos)                      // Recorremos los metodos del Tipo
                {
                    listMetodos.Items.Add(Metodo.ReturnTypeCustomAttributes);   // Mostramos el tipo de variable(string, int, bool)
                    listMetodos.Items.Add(Metodo.Name);                         // Mostramos el nombre
                    listMetodos.Items.Add("-----------------------------------------------------------------");
                }

                ConstructorInfo[] constructores = Tipos[numero].GetConstructors();      // Obtenemos los constructores de un Tipo
                foreach (ConstructorInfo constructor in constructores)                  // Recorremos los constructores del Tipo
                {
                    listparametros.Items.Add(constructor.ToString());                   // Mostramos los constuctores
                    listparametros.Items.Add("****************************************************************************************************************************************************************************************************************");

                    ParameterInfo[] parametrosConstructor = constructor.GetParameters();    // Mostramos los parametros del constructor
                    foreach (ParameterInfo parametro in parametrosConstructor)              // Recorremos los parametros
                    {
                        listparametros.Items.Add(parametro);                    // Mostramos el parametro
                    }
                }

            }
        }
    }
}
