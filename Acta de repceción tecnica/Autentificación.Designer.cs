namespace Acta_de_repceción_tecnica
{
    partial class Autentificación
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autentificación));
            btnIngresar = new Button();
            btnSalir = new Button();
            lblUsuario = new Label();
            lblFuncion = new Label();
            lblNivel = new Label();
            txtUsuario = new TextBox();
            txtFuncion = new TextBox();
            pictureBox1 = new PictureBox();
            gbDatosingreso = new GroupBox();
            txtContraseña = new TextBox();
            lblContraseña = new Label();
            cboNivel = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbDatosingreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(192, 255, 255);
            btnIngresar.Location = new Point(0, 330);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(802, 61);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 128, 128);
            btnSalir.Location = new Point(0, 390);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(802, 61);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(22, 47);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblFuncion
            // 
            lblFuncion.AutoSize = true;
            lblFuncion.Location = new Point(22, 150);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(60, 20);
            lblFuncion.TabIndex = 2;
            lblFuncion.Text = "Función";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Location = new Point(22, 214);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(43, 20);
            lblNivel.TabIndex = 4;
            lblNivel.Text = "Nivel";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(175, 40);
            txtUsuario.MaxLength = 20;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(327, 27);
            txtUsuario.TabIndex = 1;
            // 
            // txtFuncion
            // 
            txtFuncion.Location = new Point(175, 143);
            txtFuncion.MaxLength = 20;
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(327, 27);
            txtFuncion.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.clinica_medellin;
            pictureBox1.Location = new Point(565, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // gbDatosingreso
            // 
            gbDatosingreso.Controls.Add(txtContraseña);
            gbDatosingreso.Controls.Add(lblContraseña);
            gbDatosingreso.Controls.Add(cboNivel);
            gbDatosingreso.Controls.Add(txtFuncion);
            gbDatosingreso.Controls.Add(txtUsuario);
            gbDatosingreso.Controls.Add(lblNivel);
            gbDatosingreso.Controls.Add(lblFuncion);
            gbDatosingreso.Controls.Add(lblUsuario);
            gbDatosingreso.Location = new Point(35, 44);
            gbDatosingreso.Name = "gbDatosingreso";
            gbDatosingreso.Size = new Size(524, 259);
            gbDatosingreso.TabIndex = 9;
            gbDatosingreso.TabStop = false;
            gbDatosingreso.Text = "Datos de Ingreso";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(175, 96);
            txtContraseña.MaxLength = 20;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(327, 27);
            txtContraseña.TabIndex = 7;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(22, 103);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 6;
            lblContraseña.Text = "Contraseña";
            // 
            // cboNivel
            // 
            cboNivel.AllowDrop = true;
            cboNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNivel.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cboNivel.Location = new Point(175, 206);
            cboNivel.Name = "cboNivel";
            cboNivel.Size = new Size(327, 28);
            cboNivel.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // Autentificación
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbDatosingreso);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Autentificación";
            Text = "Autentificación";
            Load += Autentificación_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbDatosingreso.ResumeLayout(false);
            gbDatosingreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIngresar;
        private Button btnSalir;
        private Label lblUsuario;
        private Label lblFuncion;
        private Label lblNivel;
        private TextBox txtUsuario;
        private TextBox txtFuncion;
        private PictureBox pictureBox1;
        private GroupBox gbDatosingreso;
        private ComboBox cboNivel;
        private ErrorProvider erpMensaje;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private TextBox txtContraseña;
        private Label lblContraseña;
    }
}