using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro;         // Indicamos la libreria 

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            string rut = textBoxRut.Text;   // Obtenemos el rut entregado

            if (rut.Length == 9)    // Confirmamos que el rut contenga el tamaño adecuado
            {
                Persona persona = new Persona();    // Inicializamos la clase persona de la libreria

                if (persona.VerifivarRut(rut))  // Verificamos rut (Metodo descrito en la libreria Registro)
                {
                    MessageBox.Show("Rut Aceptado");
                }
                else
                {
                    MessageBox.Show("Rut invalido");
                }
            }
            else
            {
                MessageBox.Show("El rut debe tener un largo de 9 digitos");
            }
        }
    }
}
