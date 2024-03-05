namespace Acta_de_repceción_tecnica
{
    partial class Datos_proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos_proveedor));
            lblNIT = new Label();
            txtNit = new TextBox();
            txtNombreProveedor = new TextBox();
            lblNombreProveedor = new Label();
            txtPersonaencargada = new TextBox();
            lblNombre = new Label();
            txtCelular = new TextBox();
            lblCelular = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            gbPersona = new GroupBox();
            gbProveedor = new GroupBox();
            btnGuardar = new Button();
            gbPersona.SuspendLayout();
            gbProveedor.SuspendLayout();
            SuspendLayout();
            // 
            // lblNIT
            // 
            lblNIT.AutoSize = true;
            lblNIT.Location = new Point(38, 35);
            lblNIT.Name = "lblNIT";
            lblNIT.Size = new Size(105, 20);
            lblNIT.TabIndex = 0;
            lblNIT.Text = "NIT proveedor";
            // 
            // txtNit
            // 
            txtNit.Location = new Point(230, 28);
            txtNit.Name = "txtNit";
            txtNit.Size = new Size(207, 27);
            txtNit.TabIndex = 38;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(230, 94);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(207, 27);
            txtNombreProveedor.TabIndex = 40;
            // 
            // lblNombreProveedor
            // 
            lblNombreProveedor.AutoSize = true;
            lblNombreProveedor.Location = new Point(38, 101);
            lblNombreProveedor.Name = "lblNombreProveedor";
            lblNombreProveedor.Size = new Size(136, 20);
            lblNombreProveedor.TabIndex = 39;
            lblNombreProveedor.Text = "Nombre Proveedor";
            // 
            // txtPersonaencargada
            // 
            txtPersonaencargada.Location = new Point(155, 61);
            txtPersonaencargada.Name = "txtPersonaencargada";
            txtPersonaencargada.Size = new Size(207, 27);
            txtPersonaencargada.TabIndex = 42;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(15, 64);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 41;
            lblNombre.Text = "Nombre";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(155, 127);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(207, 27);
            txtCelular.TabIndex = 44;
           
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(15, 127);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(55, 20);
            lblCelular.TabIndex = 43;
            lblCelular.Text = "Celular";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(534, 140);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(207, 27);
            txtTelefono.TabIndex = 46;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(394, 131);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 45;
            lblTelefono.Text = "Teléfono";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(534, 58);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(207, 27);
            txtCorreo.TabIndex = 48;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(394, 61);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(136, 20);
            lblCorreo.TabIndex = 47;
            lblCorreo.Text = "Correo Electronico ";
            // 
            // gbPersona
            // 
            gbPersona.Controls.Add(txtCorreo);
            gbPersona.Controls.Add(lblCorreo);
            gbPersona.Controls.Add(txtTelefono);
            gbPersona.Controls.Add(lblTelefono);
            gbPersona.Controls.Add(txtCelular);
            gbPersona.Controls.Add(lblCelular);
            gbPersona.Controls.Add(txtPersonaencargada);
            gbPersona.Controls.Add(lblNombre);
            gbPersona.Location = new Point(8, 214);
            gbPersona.Name = "gbPersona";
            gbPersona.Size = new Size(767, 201);
            gbPersona.TabIndex = 49;
            gbPersona.TabStop = false;
            gbPersona.Text = "Persona encargada del proveedor";
            // 
            // gbProveedor
            // 
            gbProveedor.Controls.Add(txtNombreProveedor);
            gbProveedor.Controls.Add(lblNombreProveedor);
            gbProveedor.Controls.Add(txtNit);
            gbProveedor.Controls.Add(lblNIT);
            gbProveedor.Location = new Point(8, 32);
            gbProveedor.Name = "gbProveedor";
            gbProveedor.Size = new Size(767, 152);
            gbProveedor.TabIndex = 50;
            gbProveedor.TabStop = false;
            gbProveedor.Text = "Proveedor";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 255);
            btnGuardar.Location = new Point(-162, 468);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(1062, 67);
            btnGuardar.TabIndex = 51;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Datos_proveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 533);
            Controls.Add(btnGuardar);
            Controls.Add(gbProveedor);
            Controls.Add(gbPersona);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Datos_proveedor";
            Text = "Datos Proveedor";
            gbPersona.ResumeLayout(false);
            gbPersona.PerformLayout();
            gbProveedor.ResumeLayout(false);
            gbProveedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNIT;
        private TextBox txtNit;
        private TextBox txtNombreProveedor;
        private Label lblNombreProveedor;
        private TextBox txtPersonaencargada;
        private Label lblNombre;
        private TextBox txtCelular;
        private Label lblCelular;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private GroupBox gbPersona;
        private GroupBox gbProveedor;
        private Button btnGuardar;
    }
}