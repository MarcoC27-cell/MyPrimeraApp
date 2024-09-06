namespace MyPrimeraApp
{
    partial class Menu
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
            btnAlumnos = new Button();
            btnMaestros = new Button();
            btnAula = new Button();
            SuspendLayout();
            // 
            // btnAlumnos
            // 
            btnAlumnos.Location = new Point(231, 60);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(85, 28);
            btnAlumnos.TabIndex = 0;
            btnAlumnos.Text = "Alumnos";
            btnAlumnos.UseVisualStyleBackColor = true;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // btnMaestros
            // 
            btnMaestros.Location = new Point(352, 60);
            btnMaestros.Name = "btnMaestros";
            btnMaestros.Size = new Size(85, 28);
            btnMaestros.TabIndex = 1;
            btnMaestros.Text = "Maestros";
            btnMaestros.UseVisualStyleBackColor = true;
            btnMaestros.Click += btnMaestros_Click;
            // 
            // btnAula
            // 
            btnAula.Location = new Point(476, 60);
            btnAula.Name = "btnAula";
            btnAula.Size = new Size(85, 28);
            btnAula.TabIndex = 2;
            btnAula.Text = "Aula";
            btnAula.UseVisualStyleBackColor = true;
            btnAula.Click += btnAula_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAula);
            Controls.Add(btnMaestros);
            Controls.Add(btnAlumnos);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAlumnos;
        private Button btnMaestros;
        private Button btnAula;
    }
}