using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acta_de_repceción_tecnica
{
    public partial class Datos_proveedor : Form
    {
        public Datos_proveedor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var nITproveedor = txtNit.Text;
            string nombreProveedor = txtNombreProveedor.Text;
            String nombre = txtPersonaencargada.Text;
            String celular = txtCelular.Text;
            var correoelectronico = txtCorreo.Text;

            var datos = @"NIT proveedor: " + nITproveedor +
                         " Nombre Proveedor: " + nombreProveedor +
                         "Nombre: " + nombre +
                         "Celular: " + celular +
                         "Correoelectronico: " + correoelectronico;

            MessageBox.Show(datos, "Datos proveedor",
                MessageBoxButtons.OK);

            try
            {
                if (nITproveedor.Trim() == "")
                {
                    MessageBox.Show("El NIT del proveedor no debe estar vacío",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (nombreProveedor.Trim() == "")
                {
                    MessageBox.Show("El nombre del proveedor no debe estar vacío",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (nombre.Trim() == "")
                {
                    MessageBox.Show("El nombre de la persona encargada no debe estar vacío",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (celular.Trim() == "")
                {
                    MessageBox.Show("El celular no debe estar vacío",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (correoelectronico.Trim() == "")
                {
                    MessageBox.Show("El correo electronico no debe estar vacío",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                var principal = new Datos_proveedor();
                principal.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor sabes te queremos. Por ahora el sistema tiene dificultades. Volveremos pronto.  " +
                    "El error presentado es: " + ex.Message,
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }


            Application.Exit();
        }        
    }
}
