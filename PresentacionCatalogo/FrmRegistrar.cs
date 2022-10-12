using System;
using System.Drawing;
using System.Windows.Forms;
using EntidadesCatalogo;
using ManejadoresCatalogo;

namespace PresentacionCatalogo
{
    public partial class FrmRegistrar : Form
    {
        ManejadorLoginRegistrar mlr;
        EntidadUsuarios eu;
        public FrmRegistrar()
        {
            InitializeComponent();
            mlr = new ManejadorLoginRegistrar();
            eu = new EntidadUsuarios();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
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
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Gainsboro;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtConfContraseña_Enter(object sender, EventArgs e)
        {
            if (txtConfContraseña.Text == "CONFIRMAR CONTRASEÑA")
            {
                txtConfContraseña.Text = "";
                txtConfContraseña.ForeColor = Color.Gainsboro;
                txtConfContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtConfContraseña_Leave(object sender, EventArgs e)
        {
            if (txtConfContraseña.Text == "")
            {
                txtConfContraseña.Text = "CONFIRMAR CONTRASEÑA";
                txtConfContraseña.ForeColor = Color.Gray;
                txtConfContraseña.UseSystemPasswordChar = false;
            }
        }

        private void chbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbMostrar.Checked == true)
            {
                txtConfContraseña.UseSystemPasswordChar = false;
                txtConfContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                if (chbMostrar.Checked == false)
                {
                    txtConfContraseña.UseSystemPasswordChar = true;
                    txtConfContraseña.UseSystemPasswordChar = true;
                }
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRES(S)")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Gainsboro;
            }
        }

        private void txtApeP_Enter(object sender, EventArgs e)
        {
            if (txtApeP.Text == "APELLIDO PATERNO")
            {
                txtApeP.Text = "";
                txtApeP.ForeColor = Color.Gainsboro;
            }
        }

        private void txtApeP_Leave(object sender, EventArgs e)
        {
            if (txtApeP.Text == "")
            {
                txtApeP.Text = "APELLIDO PATERNO";
                txtApeP.ForeColor = Color.Gray;
            }
        }

        private void txtApeM_Enter(object sender, EventArgs e)
        {
            if (txtApeM.Text == "APELLIDO MATERNO")
            {
                txtApeM.Text = "";
                txtApeM.ForeColor = Color.Gainsboro;
            }
        }

        private void txtApeM_Leave(object sender, EventArgs e)
        {
            if (txtApeM.Text == "")
            {
                txtApeM.Text = "APELLIDO MATERNO";
                txtApeM.ForeColor = Color.Gray;
            }
        }

        private void txtfdn_Enter(object sender, EventArgs e)
        {
            if (txtfdn.Text == "FECHA DE NACIMIENTO")
            {
                txtfdn.Text = "";
                txtfdn.ForeColor = Color.Gainsboro;
            }
        }

        private void txtfdn_Leave(object sender, EventArgs e)
        {
            if   (txtfdn.Text == "")
            {
                txtfdn.Text = "FECHA DE NACIMIENTO";
                txtfdn.ForeColor = Color.Gainsboro;
            }
        }
        private void txtPermisos_Enter(object sender, EventArgs e)
        {
            if (txtPermisos.Text == "PERMISOS")
            {
                txtPermisos.Text = "";
                txtPermisos.ForeColor = Color.Gainsboro;
            }
        }

        private void txtPermisos_Leave(object sender, EventArgs e)
        {
            if (txtPermisos.Text == "")
            {
                txtPermisos.Text = "PERMISOS";
                txtPermisos.ForeColor = Color.Gray;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtConfContraseña.Text)
            {
                GuardarRegistro();
                this.Hide();
                FrmLogin f1 = new FrmLogin();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Verifique que las contraseñas coincidan.");
            }
        }
        public static string permiso;
        private void GuardarRegistro()
        {
            permiso = eu._FKIdPermisos;
            eu._RFC = txtUsuario.Text;
            eu._Contraseña = txtContraseña.Text;
            eu._Nombre = txtContraseña.Text;
            eu._ApellidoP = txtApeP.Text;
            eu._ApellidoM = txtApeM.Text;
            eu._FechaNacimiento = txtfdn.Text;
            eu._FKIdPermisos = txtPermisos.Text;
            mlr.Guardar(eu);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin f1 = new FrmLogin();
            f1.Show();
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE(S)";
                txtNombre.ForeColor = Color.Gray;
            }
        }
    }
}
