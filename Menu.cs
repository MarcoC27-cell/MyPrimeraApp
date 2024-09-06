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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            var Alumnos = new frmAlumnos();
            Alumnos.ShowDialog();
        }

        private void btnMaestros_Click(object sender, EventArgs e)
        {
            var Maestros = new frmMaestros();
            Maestros.ShowDialog();
        }

        private void btnAula_Click(object sender, EventArgs e)
        {
            var Aula = new Aula();  
            Aula.ShowDialog();
        }
    }
}
