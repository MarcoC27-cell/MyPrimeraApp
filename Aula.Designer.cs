namespace MyPrimeraApp
{
    partial class Aula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumeroDeAula = new Label();
            lblHoraDeEntrada = new Label();
            cmbBoxNumeroDeAula = new ComboBox();
            cmbBoxHoraDeEntrada = new ComboBox();
            lblHoraDeSalida = new Label();
            cmbBoxHoraDeSalida = new ComboBox();
            btnGuardar = new Button();
            label1 = new Label();
            txtNombreMaestro = new TextBox();
            SuspendLayout();
            // 
            // lblNumeroDeAula
            // 
            lblNumeroDeAula.AutoSize = true;
            lblNumeroDeAula.Location = new Point(382, 92);
            lblNumeroDeAula.Name = "lblNumeroDeAula";
            lblNumeroDeAula.Size = new Size(94, 15);
            lblNumeroDeAula.TabIndex = 0;
            lblNumeroDeAula.Text = "Numero de Aula";
            // 
            // lblHoraDeEntrada
            // 
            lblHoraDeEntrada.AutoSize = true;
            lblHoraDeEntrada.Location = new Point(382, 154);
            lblHoraDeEntrada.Name = "lblHoraDeEntrada";
            lblHoraDeEntrada.Size = new Size(93, 15);
            lblHoraDeEntrada.TabIndex = 1;
            lblHoraDeEntrada.Text = "Hora De Entrada";
            // 
            // cmbBoxNumeroDeAula
            // 
            cmbBoxNumeroDeAula.FormattingEnabled = true;
            cmbBoxNumeroDeAula.Items.AddRange(new object[] { "1", "2", "3" });
            cmbBoxNumeroDeAula.Location = new Point(396, 119);
            cmbBoxNumeroDeAula.Name = "cmbBoxNumeroDeAula";
            cmbBoxNumeroDeAula.Size = new Size(60, 23);
            cmbBoxNumeroDeAula.TabIndex = 1;
            cmbBoxNumeroDeAula.SelectedIndexChanged += cmbBoxNumeroDeAula_SelectedIndexChanged;
            // 
            // cmbBoxHoraDeEntrada
            // 
            cmbBoxHoraDeEntrada.FormattingEnabled = true;
            cmbBoxHoraDeEntrada.Items.AddRange(new object[] { "7:00 AM", "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "13:00 PM", "14:00 PM" });
            cmbBoxHoraDeEntrada.Location = new Point(396, 185);
            cmbBoxHoraDeEntrada.Name = "cmbBoxHoraDeEntrada";
            cmbBoxHoraDeEntrada.Size = new Size(60, 23);
            cmbBoxHoraDeEntrada.TabIndex = 2;
            cmbBoxHoraDeEntrada.SelectedIndexChanged += cmbBoxHoraDeEntrada_SelectedIndexChanged;
            // 
            // lblHoraDeSalida
            // 
            lblHoraDeSalida.AutoSize = true;
            lblHoraDeSalida.Location = new Point(381, 211);
            lblHoraDeSalida.Name = "lblHoraDeSalida";
            lblHoraDeSalida.Size = new Size(84, 15);
            lblHoraDeSalida.TabIndex = 4;
            lblHoraDeSalida.Text = "Hora De Salida";
            // 
            // cmbBoxHoraDeSalida
            // 
            cmbBoxHoraDeSalida.FormattingEnabled = true;
            cmbBoxHoraDeSalida.Items.AddRange(new object[] { "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "13:00 PM", "14:00 PM", "15:00 PM" });
            cmbBoxHoraDeSalida.Location = new Point(396, 238);
            cmbBoxHoraDeSalida.Name = "cmbBoxHoraDeSalida";
            cmbBoxHoraDeSalida.Size = new Size(60, 23);
            cmbBoxHoraDeSalida.TabIndex = 3;
            cmbBoxHoraDeSalida.SelectedIndexChanged += cmbBoxHoraDeSalida_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(390, 276);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 25);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 7;
            label1.Text = "Maestro en Aula";
            // 
            // txtNombreMaestro
            // 
            txtNombreMaestro.Location = new Point(324, 52);
            txtNombreMaestro.Name = "txtNombreMaestro";
            txtNombreMaestro.Size = new Size(215, 23);
            txtNombreMaestro.TabIndex = 0;
            txtNombreMaestro.TextChanged += txtNombreMaestro_TextChanged;
            // 
            // Aula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNombreMaestro);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(cmbBoxHoraDeSalida);
            Controls.Add(lblHoraDeSalida);
            Controls.Add(cmbBoxHoraDeEntrada);
            Controls.Add(cmbBoxNumeroDeAula);
            Controls.Add(lblHoraDeEntrada);
            Controls.Add(lblNumeroDeAula);
            Name = "Aula";
            Text = "Aula";
            Load += Aula_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumeroDeAula;
        private Label lblHoraDeEntrada;
        private ComboBox cmbBoxNumeroDeAula;
        private ComboBox cmbBoxHoraDeEntrada;
        private Label lblHoraDeSalida;
        private ComboBox cmbBoxHoraDeSalida;
        private Button btnGuardar;
        private Label label1;
        private TextBox txtNombreMaestro;
    }
}