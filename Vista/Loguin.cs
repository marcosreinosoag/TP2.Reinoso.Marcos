using Entidades;

namespace Vista
{
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado;
            string claveIngresada;
            usuarioIngresado = txb_usuario.Text;
            claveIngresada = txb_clave.Text;

            if (TrucoArg.VerificarUsuarioYClave(usuarioIngresado, claveIngresada))
            {
                Menu_Principal frm_menuPrincipal = new Menu_Principal();
                frm_menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                lbl_error.Text = "Datos Incorrectos";
            }
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            txb_usuario.Text = "MarcosReinoso2022";
            txb_clave.Text = "1234";
        }

    }
}