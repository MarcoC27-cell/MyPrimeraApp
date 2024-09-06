using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPrimeraApp
{
    public partial class frmMaestros : Form
    {
        public frmMaestros()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path: "C:\\BaseDeDatos\\Maestros.txt", append: true))

            {
                sw.WriteLine("El nombre del Maestro es: " + txtNombre.Text + "\nEl apedillo del Maestro es: " + txtApellido.Text + " \nLa direccion es: " + txtDireccion.Text 
                    + "\nLa cedula es: " + txtCedula.Text);
            }
            MessageBox.Show(text: "El nombre es: " + txtNombre.Text + " " + txtApellido.Text
                + " \nDireccion: " + txtDireccion.Text + "\nCedula: " + txtCedula.Text, caption: "Mensaje de Alumnos");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

