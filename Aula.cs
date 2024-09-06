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
    public partial class Aula : Form
    {
        public Aula()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path: "C:\\BaseDeDatos\\Aula.txt", append: true))

            {
                sw.WriteLine("Maestro en Aula: " + txtNombreMaestro.Text +"\nNumero de aula: " + cmbBoxNumeroDeAula.Text + "\nHora de entrada: " + cmbBoxHoraDeEntrada.Text
                    + " \nHora de salida: " + cmbBoxHoraDeSalida.Text);
            }
            MessageBox.Show(text: "Maestro en aula: " +txtNombreMaestro.Text + "\nEl numero de aula es: " + cmbBoxNumeroDeAula.Text + "\nLa hora de entrada es: "
                + cmbBoxHoraDeEntrada.Text + " \nLa hora de salida es: " + cmbBoxHoraDeSalida.Text, caption: "Aula y Horas de Entrada y Salida");
        }

        private void cmbBoxNumeroDeAula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxHoraDeEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxHoraDeSalida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreMaestro_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aula_Load(object sender, EventArgs e)
        {

        }
    }
}
