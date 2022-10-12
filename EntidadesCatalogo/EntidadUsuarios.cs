namespace EntidadesCatalogo
{
    public class EntidadUsuarios
    {
        public EntidadUsuarios()
        {
        }
        public EntidadUsuarios(object idproducto, string text1, object text2, double v)
        {
        }

        public EntidadUsuarios(int idUsuario, string rFC, string contraseña, string nombre, string apellidoP, string apellidoM, string fechaNacimiento, string fKIdPermisos)
        {
            _IdUsuario = idUsuario;
            _RFC = rFC;
            _Contraseña = contraseña;
            _Nombre = nombre;
            _ApellidoP = apellidoP;
            _ApellidoM = apellidoM;
            _FechaNacimiento = fechaNacimiento;
            _FKIdPermisos = fKIdPermisos;
        }

        public int _IdUsuario { get; set; }
        public string _RFC { get; set; }
        public string _Contraseña { get; set; }
        public string _Nombre { get; set; }
        public string _ApellidoP { get; set; }
        public string _ApellidoM { get; set; }
        public string _FechaNacimiento { get; set; }
        public string _FKIdPermisos { get; set; }
    }
}
