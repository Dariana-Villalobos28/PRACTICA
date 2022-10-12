using System;
using System.Windows.Forms;
using AccesoDatos;
using EntidadesCatalogo;

namespace ManejadoresCatalogo
{
    public class ManejadorLoginRegistrar
    {
        public AccesoBase _base;
        public ManejadorLoginRegistrar()
        {
            _base = new AccesoBase("localhost", "root", "", "Catalogo", 3306);
        }
        public string Guardar(EntidadUsuarios eu)
        {
            return _base.Comando(string.Format("insert into usuario values(null, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", eu._RFC, eu._Contraseña, eu._Nombre, eu._ApellidoP, eu._ApellidoM, eu._FechaNacimiento, eu._FKIdPermisos));
        }
        public int Login(string lUsuario, string lContraseña)
        {
            string consulta = string.Format("SELECT count(*) FROM usuario WHERE rfc = '{0}' AND Contraseña = '{1}',", lUsuario, lContraseña);
            int c = int.Parse(_base.ConsultaRetorno(consulta));
            return c;
        }
        public int ValidarUsuarios(string vUsuario, string vContraseña)
        {
            int c = 0;
            try
            {
                c = Login(vUsuario, vContraseña);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de validación" + ex.Message);
            }
            return c;
        }
        public string Permisos(string permiso)
        {
            string consulta = string.Format("SELECT idpermisos FROM permisos WHERE idpermisos = '{0}';", permiso);
            string c = _base.ConsultaRetorno(consulta);
            return c;
        }
        public string Permiso(string rfc)
        {
            string consulta = string.Format("select fkidpermisos from usuarios where rfc = '{0}';", rfc);
            string c = _base.ConsultaRetorno(consulta);
            return c;
        }
    }
}
