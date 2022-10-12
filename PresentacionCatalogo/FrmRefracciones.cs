using System;
using System.Windows.Forms;
using EntidadesCatalogo;
using ManejadoresCatalogo;

namespace PresentacionCatalogo
{
    public partial class FrmRefracciones : Form
    {
        EntidadRefracciones er;
        ManejadorRefracciones mr;
        public FrmRefracciones()
        {
            er = new EntidadRefracciones();
            mr = new ManejadorRefracciones();
            InitializeComponent();
        }
        int i = 0; 
        void Actualizar()
        {
            mr.Mostrar(txtBuscar.Text, dtgDatos);
        }
        private void dtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            er._CodigoBarras = dtgDatos.CurrentRow.Cells["codigoBarras"].Value.ToString();
            er._Nombre = dtgDatos.CurrentRow.Cells["nombre"].Value.ToString();
            er._Descripcion = dtgDatos.CurrentRow.Cells["descripcion"].Value.ToString();
            er._Marca = dtgDatos.CurrentRow.Cells["marca"].Value.ToString();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
