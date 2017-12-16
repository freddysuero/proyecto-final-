using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtPromedio.Clear();        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            int cantAlumnos, nota;
            double promedio=0;
            //Entrada de datos
            cantAlumnos = Convert.ToInt32(txtCantidad.Text);
            //proceso
            //implementamos el bucle
            for (int i = 1; i <= cantAlumnos; i++)
            {
                do
                {
                    //leer la nota con un inputbux
                    //agregar la referencia para utilizar el inputbox
                    nota = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese La Nota Del Alumno" + i, "Nota"));
                } while (nota <= 0 || nota >= 100);
                promedio =(promedio+nota);
            }
            //salida de informacion
            txtPromedio.Text = Convert.ToString(promedio);
        }
    }
}
