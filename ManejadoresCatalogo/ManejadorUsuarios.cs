using AccesoDatos;
using System.Windows.Forms;
using EntidadesCatalogo;

namespace ManejadoresCatalogo
{
    public class ManejadorUsuarios
    {
        AccesoBase ab = new AccesoBase("localhost", "root", "", "Catalogo", 3306);
        public string Guardar(EntidadUsuarios eu)
        {
            return ab.Comando(string.Format("insert into usuario values(null, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", eu._RFC,
                eu._Contraseña, eu._Nombre, eu._ApellidoP, eu._ApellidoM, eu._FechaNacimiento, eu._FKIdPermisos));
        }
        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = ab.Mostrar(string.Format("select * from usuario where nombre like '%{0}%' or rfc like '%{0}'", dato), "usuario").Tables["usuario"];
            tabla.AutoResizeColumns();
        }
        public string Editar(EntidadUsuarios eu)
        {
            return ab.Comando(string.Format("update usuario set rfc = '{0}', nombre = '{1}', apellidop = '{2}', apellidom = '{3}', fechancaimiento = '{4}', fkidpermisos = '{5}' where idusuario = {6}", eu._RFC, eu._Nombre,
                eu._ApellidoP, eu._ApellidoM, eu._FechaNacimiento, eu._FKIdPermisos, eu._IdUsuario));
        }
        public string Borrar(EntidadUsuarios eu)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("¿Está seguro de eliminar a" + eu._Nombre + " " + eu._ApellidoP + " " + eu._ApellidoM, "Atención!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = ab.Comando(string.Format("delete from usuario where idusuario = '{0}'", eu._IdUsuario));
            }
            return r;
        }
    }
}
