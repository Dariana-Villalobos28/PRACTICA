using AccesoDatos;
using EntidadesCatalogo;
using System.Windows.Forms;

namespace ManejadoresCatalogo
{
    public class ManejadorRefracciones
    {
        AccesoBase ab = new AccesoBase("localhost", "root", "", "Catalogo", 3306);
        public string Guardar(EntidadRefracciones er)
        {
            return ab.Comando(string.Format("insert into modulo_refracciones values '{0}','{1}','{2}','{3}',)", er._CodigoBarras, er._Nombre, er._Descripcion, er._Marca));
        }
        public void Mostrar(string dato, DataGridView tabla)
        {
            tabla.DataSource = ab.Mostrar(string.Format("select * from modulo_refracciones where nombre like '%{0}%' or codigobarras like '%{0}%';", dato), "modulo_refracciones").Tables["modulo_refracciones"];
            tabla.AutoResizeColumns();
        }
        public string Editar(EntidadRefracciones er)
        {
            return ab.Comando(string.Format("update modulo_refracciones set nombre = '{0}', descripcion = '{1}', marca = '{2}' where codigobarras = '{3}'", er._Nombre,
                er._Descripcion, er._Marca, er._CodigoBarras));
        }
        public string Borrar(EntidadRefracciones er)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("¿Está seguro de eliminar?" + er._Descripcion, "Atención!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = ab.Comando(string.Format("delete from modulo_refracciones where codigobarras = '{0}'", er._CodigoBarras));
            }
            return r;
        }
    }
}
