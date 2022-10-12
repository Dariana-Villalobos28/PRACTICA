using System;
using System.Windows.Forms;
using EntidadesCatalogo;
using ManejadoresCatalogo;

namespace PresentacionCatalogo
{
    public partial class FrmHerramientas : Form
    {
        EntidadHerramientas eh;
        ManejadorHerramientas mh;
        public FrmHerramientas()
        {
            InitializeComponent();
            eh = new EntidadHerramientas();
            mh = new ManejadorHerramientas();
        }
        int i = 0;
        void Actualizar()
        {
            mh.Mostrar(dtgDatos, txtBuscar.Text);
        }
        private void dtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            eh._CodigoHerramientas = dtgDatos.CurrentRow.Cells["codigoherramientas"].Value.ToString();
            eh._Nombre = dtgDatos.CurrentRow.Cells["Nombre"].Value.ToString();
            eh._Medida = dtgDatos.CurrentRow.Cells["Medida"].Value.ToString();
            eh._Descripcion = dtgDatos.CurrentRow.Cells["Descripcion"].Value.ToString();
            eh._Marca = dtgDatos.CurrentRow.Cells["Marca"].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
