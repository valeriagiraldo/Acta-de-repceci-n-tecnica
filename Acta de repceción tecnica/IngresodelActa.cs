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
    public partial class FormIngresoActa : Form
    {
        public FormIngresoActa()
        {
            InitializeComponent();
        }


        private void FormIngresoActa_Load(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            var empresaAbastece = txtEmpresa.Text;
            dynamic consecutivoFactura = txtConsecutivoFactura.Text;
            string producto = txtProducto.Text;
            String registroSanitario = txtRegistroSanitario.Text;
            DateTime lote = dtpLote.Value;
            DateTime fechaVencimiento = dtpVencimiento.Value;
            string laboratorio = txtLaboratorio.Text;
            string marca = txtMarcaProducto.Text;
            var unidades = txtUnidades.Text;
            var rótuloSecundario = rdbCumpleRótuloSecundario.Checked ? "Cumple\n" :
                                   rdbNocumpleRótuloSecundario.Checked ? "No cumple\n" : "";
            var defectos = rdbCumpleDefectos.Checked ? "Cumple\n" :
                                   rdbNocumpleDefectos.Checked ? "No cumple\n" : "";
            var estado = rdbAceptadoEstado.Checked ? "Aceptado\n" :
                                   rdbRechazadoEstado.Checked ? "Rechazado\n" : "";
            var rótuloPrimario = rdbCumpleRótuloPrimario.Checked ? "Cumple\n" :
                                   rdbNoCumpleRótuloPrimario.Checked ? "No cumple\n" : "";
            var actadelQuímicofarmacéutico = rdbAprobadoActadelQuímicofarmacéutico.Checked ? "Aprobado\n" :
                                   rdbNoAprobadoActadelQuímicofarmacéutico.Checked ? "No aprobado\n" : "";

            var datos = @"Empresa Abastece: " + empresaAbastece +
                         " Consecutivo Factura: " + consecutivoFactura +
                         "Producto: " + producto +
                         "Registro Sanitario: " + registroSanitario +
                         "Lote: " + lote +
                         "Fecha Vencimiento: " + fechaVencimiento +
                         "Laboratorio: " + laboratorio +
                         "Marca: " + marca +
                         "unidades: " + unidades +
                         "Rótulo Secundario: " + rótuloSecundario +
                         "Defectos: " + defectos +
                         "Estado: " + estado +
                         "Rótulo Primario: " + rótuloPrimario +
                         "Acta del Químico farmacéutico: " + actadelQuímicofarmacéutico;
            MessageBox.Show(datos, "Ingreso del Acta",
                MessageBoxButtons.OK);

            try
            {
                if (empresaAbastece.Trim() == "")
                {
                    MessageBox.Show("La empresa abastece no debe estar vacío",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (consecutivoFactura.Trim() == "")
                {
                    MessageBox.Show("El consecutivo factura no debe estar vacío",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (producto.Trim() == "")
                {
                    MessageBox.Show("El producto no debe estar vacío",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (registroSanitario.Trim() == "")
                {
                    MessageBox.Show("El registro sanitario no debe estar vacío",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (lote > DateTime.Now)
                {
                    MessageBox.Show("Ingrese la fecha del lote",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (fechaVencimiento > DateTime.Now)
                {
                    MessageBox.Show("Ingrese la fecha de vencimiento",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (laboratorio.Trim() == "")
                {
                    MessageBox.Show("El laboratorio no debe estar vacío",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (marca.Trim() == "")
                {
                    MessageBox.Show("La marca no debe estar vacía",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (unidades.Trim() == "")
                {
                    MessageBox.Show("Las unidades no deben estar vacías",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                if (!rdbCumpleRótuloSecundario.Checked && !rdbNocumpleRótuloSecundario.Checked)
                {
                    MessageBox.Show("El rótulo secundario no es válido",
                      this.Text,
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return;
                }

                if (!rdbCumpleDefectos.Checked && !rdbNocumpleDefectos.Checked)
                {
                    MessageBox.Show("El defecto no es válido",
                      this.Text,
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return;
                }

                if (!rdbAceptadoEstado.Checked && !rdbRechazadoEstado.Checked)
                {
                    MessageBox.Show("El estado no es válido",
                      this.Text,
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return;
                }

                if (!rdbCumpleRótuloPrimario.Checked && !rdbNoCumpleRótuloPrimario.Checked)
                {
                    MessageBox.Show("El rótulo primario no es válido",
                      this.Text,
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return;
                }

                if (!rdbAprobadoActadelQuímicofarmacéutico.Checked && !rdbNoAprobadoActadelQuímicofarmacéutico.Checked)
                {
                    MessageBox.Show("La aprobación del químico farmacéutico no es válida",
                      this.Text,
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return;
                }

                var principal = new DatosVarios();
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


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}


