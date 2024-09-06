using MyPrimeraApp.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyPrimeraApp
{
    public partial class frmAlumnos : Form
    {
        List<Alumno> Alumnos = new List<Alumno>();

        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var alumno = new Alumno(txtNombre.Text, txtApellido.Text);
            var edad = 0;
            int.TryParse(cmbEdad.Text, out edad);
            alumno.Edad = edad;

            // Validar que el alumno no existe
            if (Alumnos.Any(x => x.Nombre == alumno.Nombre && x.Apellido == alumno.Apellido))
            {
                MessageBox.Show("El alumno ya existe", "Mensaje Alumnos");
                return;
            }

            // Guardar en el archivo
            using (StreamWriter sw = new StreamWriter("C:\\BaseDeDatos\\Alumnos.txt", append: true))
            {
                sw.WriteLine($"{txtNombre.Text},{txtApellido.Text},{cmbEdad.Text}");
            }

            MessageBox.Show($"El nombre es: {txtNombre.Text} {txtApellido.Text}\nEdad: {cmbEdad.Text}", "Mensaje de Alumnos");
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            // Limpiar la lista y el DataGridView
            Alumnos.Clear();
            DGV.DataSource = null;
            DGV.AutoGenerateColumns = true;

            try
            {
                using (StreamReader sr = new StreamReader("C:\\BaseDeDatos\\Alumnos.txt"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        var valores = linea.Split(',');
                        if (valores.Length == 3 && int.TryParse(valores[2], out int edad))
                        {
                            var alumno = new Alumno(valores[0], valores[1], edad);
                            Alumnos.Add(alumno);
                        }
                        else
                        {
                            MessageBox.Show("Error al leer la línea: " + linea, "Error de Formato");
                        }
                    }
                }

                // Configurar el DataGridView
                DGV.DataSource = Alumnos;
                DGV.Refresh();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
