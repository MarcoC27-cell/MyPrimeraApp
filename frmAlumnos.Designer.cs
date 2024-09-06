namespace MyPrimeraApp
{
    partial class frmAlumnos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            txtNombre = new TextBox();
            BtnGuardar = new Button();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblEdad = new Label();
            cmbEdad = new ComboBox();
            btnCargar = new Button();
            DGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(12, 182);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(125, 23);
            BtnGuardar.TabIndex = 3;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(14, 59);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 0;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(14, 77);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 1;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(14, 112);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad";
            // 
            // cmbEdad
            // 
            cmbEdad.FormattingEnabled = true;
            cmbEdad.Items.AddRange(new object[] { "12", "13", "14", "15", "16", "17", "18" });
            cmbEdad.Location = new Point(16, 139);
            cmbEdad.Name = "cmbEdad";
            cmbEdad.Size = new Size(121, 23);
            cmbEdad.TabIndex = 2;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(12, 222);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(125, 23);
            btnCargar.TabIndex = 4;
            btnCargar.Text = "Cargar ";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // DGV
            // 
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(251, 27);
            DGV.Name = "DGV";
            DGV.Size = new Size(438, 263);
            DGV.TabIndex = 5;
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DGV);
            Controls.Add(btnCargar);
            Controls.Add(cmbEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(BtnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "frmAlumnos";
            Text = "Alumnos";
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Button BtnGuardar;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblEdad;
        private ComboBox cmbEdad;
        private Button btnCargar;
        private DataGridView DGV;
    }
}
