using AccesoDatos;
using EntidadesCatalogo;
using System.Windows.Forms;
namespace ManejadoresCatalogo
{
    public class ManejadorHerramientas
    {
        AccesoBase ab = new AccesoBase("localhost", "root", "", "Catalogo", 3306);
        public string Guardar(EntidadHerramientas eh)
        {
            return ab.Comando(string.Format("insert into modulo_herramientas values'{0}', '{1}', '{2}', '{3}', {4}')", eh._CodigoHerramientas, eh._Nombre, eh._Medida, eh._Descripcion, eh._Marca));
        }
        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = ab.Mostrar(string.Format("select * from modulo_herramientas where nombre like '%{0}%' or codigoherramientas like '%{0}$'", dato), "modulo_herramientas").Tables["modulo_herramientas"];
            tabla.AutoResizeColumns();
        }
        public string Editar(EntidadHerramientas eh)
        {
            return ab.Comando(string.Format("update modulo_herramientas set nombre = '{0}', medida = '{1}',descripcion ='{2}', marca = '{3}', where codigoherramientass = '{4}'", eh._Nombre, eh._Medida,
                eh._Descripcion, eh._Marca, eh._CodigoHerramientas));
        }
        public string Borrar(EntidadHerramientas eh)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("¿Está seguro de eliminar?" + eh._Descripcion, "Atención!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = ab.Comando(string.Format("delete from modulo_herramientas where codigoherramientas = '{0}'", eh._CodigoHerramientas));
            }
            return r;
        }
    }
}
