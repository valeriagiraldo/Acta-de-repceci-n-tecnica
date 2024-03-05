using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Acta_de_repceción_tecnica
{
    public partial class DatosVarios : Form
    {
        public DatosVarios()
        {
            InitializeComponent();
        }

        private void btncontinuar2_Click_1(object sender, EventArgs e)
        {
            var nombrelaboratorio = txtNLab.Text;
            var estadodellaboratorio = rdbActivo.Checked ? "Activo" :
                                   rdbInactivo.Checked ? "Inactivo" : "";
            var estadodelproducto = rbdActivoP.Checked ? "Activo" :
                                  rbdInactivoP.Checked ? "Inactivo" : "";
            string nombregenérico = txtNombreGenerico.Text;
            string formaFarmacéutica = txtFormaFarmaceutica.Text;
            string concentracióndelproducto = txtConcentracion.Text;
            string duracióndelproducto = txtDuracion.Text;
            var clasificacióndelriesgo = txtRiesgo.Text;
            string presentacionproducto = ltBPresentacionproducto.Text;

            var datos = @"Nombre laboratorio: " + nombrelaboratorio +
                         " Estado del laboratorio: " + estadodellaboratorio +
                         "Estado del producto: " + estadodelproducto +
                         "Nombre genérico: " + nombregenérico +
                         "Forma Farmacéutica: " + formaFarmacéutica +
                         "Concentración del producto: " + concentracióndelproducto +
                         "Duración del producto: " + duracióndelproducto +
                         "Clasificación del riesgo: " + clasificacióndelriesgo +
                         "Presentación del producto: " + presentacionproducto; 

            MessageBox.Show(datos, "Datos Varios",
                MessageBoxButtons.OK);

            try
            {
                if (nombrelaboratorio.Trim() == "")
                {
                    MessageBox.Show("El nombre del laboratorio no debe estar vacío",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (!rdbActivo.Checked && !rdbInactivo.Checked)
                {
                    MessageBox.Show("El estado del laboratorio no es valido",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (!rbdActivoP.Checked && !rbdInactivoP.Checked)
                {
                    MessageBox.Show("El estado del producto no es valido",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (nombregenérico.Trim() == "")
                {
                    MessageBox.Show("El nombre genérico no debe estar vacío",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (formaFarmacéutica.Trim() == "")
                {
                    MessageBox.Show("La forma farmaceutica no debe estar vacía",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (concentracióndelproducto.Trim() == "")
                {
                    MessageBox.Show("La concengtración del producto no debe estar vacía",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (duracióndelproducto.Trim() == "")
                {
                    MessageBox.Show("la duración del producto no debe estar vacía",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (clasificacióndelriesgo.Trim() == "")
                {
                    MessageBox.Show("La clasificación del riesgo no debe estar vacía",
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
        }
        private bool ValidarDatos()
        {

            return true;
        }
        private void DatosVarios_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
