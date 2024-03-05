using Entidades;
using Negocio;
using Repositorio;
using System.ComponentModel;
namespace Acta_de_repceción_tecnica
{
    public partial class Autentificación : Form
    {
        private const string USUARIO = "VaLuLa";
        private const string CONTRASEÑA = "987";
        public Autentificación()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var usuario = txtUsuario.Text;
                var contraseña = txtContraseña.Text;
                var funcion = txtFuncion.Text;
                var nivel = cboNivel.SelectedItem as string;

                if (usuario.Trim() == "")
                {
                    MessageBox.Show("El usuario no debe estar vacío",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (contraseña.Trim() == "")
                {
                    MessageBox.Show("La contraseña no debe estar vacía",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (funcion.Trim() == "")
                {
                    MessageBox.Show("La función no debe estar vacía",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(nivel))
                {
                    MessageBox.Show("El usuario no debe estar vacío",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;



                }
                if (USUARIO == usuario && CONTRASEÑA == contraseña)
                {
                    var principal = new MDIPrincipal();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Las credenciales de ingreso no son válidas. por favor verifique.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            this.Close();
        }

        private void Autentificación_Load(object sender, EventArgs e)
        {

        }

    }
}
