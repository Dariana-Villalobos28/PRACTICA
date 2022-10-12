using System;
using System.Windows.Forms;
using ManejadoresCatalogo;

namespace PresentacionCatalogo
{
    public partial class FrmPrincipal : Form
    {
        ManejadorLoginRegistrar mlr;
        public FrmPrincipal()
        {
            InitializeComponent();
            btnAdmin.Hide();
            if(FrmLogin.val == "ADMIN")
            {
                btnAdmin.Show();
            }
        }
        public static Form frmactivo = null;
        public static Form frmhijo;
        public void AbrirFrmHijo(Form frmhijo)
        {
            if (frmactivo !=null)
            {
                frmactivo.Close();
            }
            frmactivo = frmhijo;
            frmhijo.TopLevel = false;
            frmhijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(frmhijo);
            pnlContenedor.Tag = frmhijo;
            frmhijo.BringToFront();
            frmhijo.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            pnlContenedor.BringToFront();
        }

        private void btnRefracciones_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmRefracciones());
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmHerramientas());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmAdminstrar());
        }
    }
}
