namespace EntidadesCatalogo
{
    public class EntidadRefracciones
    {
        public EntidadRefracciones()
        {
        }

        public EntidadRefracciones(string codigoBarras, string nombre, string descripcion, string marca)
        {
            _CodigoBarras = codigoBarras;
            _Nombre = nombre;
            _Descripcion = descripcion;
            _Marca = marca;
        }

        public string _CodigoBarras { get; set; }
        public string _Nombre { get; set; }
        public string _Descripcion  { get; set; }
        public string _Marca { get; set; }
    }
}
