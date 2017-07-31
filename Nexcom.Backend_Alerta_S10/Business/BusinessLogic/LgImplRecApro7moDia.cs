namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
    public class LgImplRecApro7moDia
    {
  private string _CANTIDAD;
        private string _cantidadenalmacen;
        private string _cantidadporentregar;
        private string _codproyecto;
        private string _codrecurso;
        private string _diasAprobordenComp;
        private string _estadoorden;
        private string _fechaaprobacion;
        private string _nroorden;
        private string _proveedor;
        private string _proyecto;
        private string _recurso;
        private string _tipoorden;
        private string _unidad;
        private string _usuarioregistrador;

        public LgImplRecApro7moDia()
        {
        }

        public LgImplRecApro7moDia(string tcCodproyecto, string tcProyecto, string tcProveedor, string tcTipoorden, string tcEstadoorden,
            string tcNroorden, string tcCodrecurso, string tcRecurso, string tcUnidad, string tcCantidad, string tcCantidadenalmacen, 
            string tcCantidadporentregar, string tcUsuarioregistrador, string tcFechaaprobacion, string tcDiasAprobordenComp)
        {
            this.Codproyecto = tcCodproyecto;
            this.Proyecto = tcProyecto;
            this.Proveedor = tcProveedor;
            this.Tipoorden = tcTipoorden;
            this.Estadoorden = tcEstadoorden;
            this.Nroorden = tcNroorden;
            this.Codrecurso = tcCodrecurso;
            this.Recurso = tcRecurso;
            this.Unidad = tcUnidad;
            this.Cantidad = tcCantidad;
            this.Cantidadenalmacen = tcCantidadenalmacen;
            this.Cantidadporentregar = tcCantidadporentregar;
            this.Usuarioregistrador = tcUsuarioregistrador;
            this.Fechaaprobacion = tcFechaaprobacion;
            this.DiasAprobordenComp = tcDiasAprobordenComp;
        }

        public string Cantidad
        {
            get { return _CANTIDAD; }
            set { _CANTIDAD = value; }
        }

        public string Cantidadenalmacen
        {
            get { return _cantidadenalmacen; }
            set { _cantidadenalmacen = value; }
        }

        public string Cantidadporentregar
        {
            get { return _cantidadporentregar; }
            set { _cantidadporentregar = value; }
        }

        public string Codproyecto
        {
            get { return _codproyecto; }
            set { _codproyecto = value; }
        }

        public string Codrecurso
        {
            get { return _codrecurso; }
            set { _codrecurso = value; }
        }

        public string DiasAprobordenComp
        {
            get { return _diasAprobordenComp; }
            set { _diasAprobordenComp = value; }
        }

        public string Estadoorden
        {
            get { return _estadoorden; }
            set { _estadoorden = value; }
        }

        public string Fechaaprobacion
        {
            get { return _fechaaprobacion; }
            set { _fechaaprobacion = value; }
        }

        public string Nroorden
        {
            get { return _nroorden; }
            set { _nroorden = value; }
        }

        public string Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        }

        public string Proyecto
        {
            get { return _proyecto; }
            set { _proyecto = value; }
        }

        public string Recurso
        {
            get { return _recurso; }
            set { _recurso = value; }
        }

        public string Tipoorden
        {
            get { return _tipoorden; }
            set { _tipoorden = value; }
        }

        public string Unidad
        {
            get { return _unidad; }
            set { _unidad = value; }
        }

        public string Usuarioregistrador
        {
            get { return _usuarioregistrador; }
            set { _usuarioregistrador = value; }
        }
    }
}
