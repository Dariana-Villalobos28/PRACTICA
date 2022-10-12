using System;
using System.Drawing;
using System.Windows.Forms;
using ManejadoresCatalogo;

namespace PresentacionCatalogo
{
    public partial class FrmLogin : Form
    {
        public static string val = "";
        ManejadorLoginRegistrar mlr;
        public FrmLogin()
        {
            InitializeComponent();
            mlr = new ManejadorLoginRegistrar();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Gainsboro;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Gainsboro;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void chbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMostrar.Checked == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                if (chbMostrar.Checked == false)
                {
                    txtContraseña.UseSystemPasswordChar = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistrar fr = new FrmRegistrar();
            fr.Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            int v = mlr.ValidarUsuarios(txtUsuario.Text, txtContraseña.Text);
            if (v == 1)
            {
                this.Hide();
                val = mlr.Permisos(txtUsuario.Text);
                FrmPrincipal fp = new FrmPrincipal();
                fp.Show();
            }
            else
            {
                MessageBox.Show("Error, Usuario y/o Contraseña Incorrecto.");
            }
        }
    }
}
