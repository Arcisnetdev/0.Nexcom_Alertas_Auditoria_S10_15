namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
   public  class LgImplOcModifAyer
    {
        private string _aprobado;
        private string _cantidadactualenorden;
        private string _cc;
        private string _codproyecto;
        private string _codrecurso;
        private string _contecho;
        private string _dsctoporct;
        private string _estadoorden;
        private string _fechaactualizacion;
        private string _fechaaprobacion;
        private string _fechacreacion;
        private string _fechaorden;
        private string _fpago;
        private string _nroorden;
        private string _observaciondelrecurso;
        private string _observacionorden;
        private string _parcialrecurso;
        private string _parcialtotalorden;
        private string _precio;
        private string _precioexcedetecho;
        private string _preciotecho;
        private string _proveedor;
        private string _proyecto;
        private string _recurso;
        private string _recursoafectadoconigv;
        private string _simb;
        private string _tipodecambio;
        private string _tipoorden;
        private string _unidad;
        private string _usuarioaprobador;
        private string _usuarioregistrador;
        private string _valordsctototalorden;
        private string _valorigvtotalorden;
        private string _valornetototalorden;
        private string _valortotalactualdeltotaldelaorden;

        public LgImplOcModifAyer()
        {
        }

        public LgImplOcModifAyer(string tcCodproyecto, string tcProyecto, string tcProveedor, string tcCc, string tcTipoorden, string tcFpago, 
            string tcEstadoorden, string tcNroorden, string tcCodrecurso, string tcRecurso, string tcUnidad, string tcSimb, string tcCantidadactualenorden, 
            string tcContecho, string tcPreciotecho, string tcPrecio, string tcPrecioexcedetecho, string tcDsctoporct, string tcParcialrecurso,
            string tcParcialtotalorden, string tcValordsctototalorden, string tcValornetototalorden, string tcValorigvtotalorden, 
            string tcValortotalactualdeltotaldelaorden, string tcRecursoafectadoconigv, string tcTipodecambio, string tcFechacreacion, 
            string tcFechaactualizacion, string tcFechaorden, string tcUsuarioregistrador, string tcAprobado, string tcUsuarioaprobador,
            string tcFechaaprobacion, string tcObservacionorden, string tcObservaciondelrecurso)
        {
            this.Codproyecto = tcCodproyecto;
            this.Proyecto = tcProyecto;
            this.Proveedor = tcProveedor;
            this._cc = tcCc;
            this.Tipoorden = tcTipoorden;
            this.Fpago = tcFpago;
            this.Estadoorden = tcEstadoorden;
            this.Nroorden = tcNroorden;
            this.Codrecurso = tcCodrecurso;
            this.Recurso = tcRecurso;
            this.Unidad = tcUnidad;
            this.Simb = tcSimb;
            this.Cantidadactualenorden = tcCantidadactualenorden;
            this.Contecho = tcContecho;
            this.Preciotecho = tcPreciotecho;
            this.Precio = tcPrecio;
            this.Precioexcedetecho = tcPrecioexcedetecho;
            this.Dsctoporct = tcDsctoporct;
            this.Parcialrecurso = tcParcialrecurso;
            this.Parcialtotalorden = tcParcialtotalorden;
            this.Valordsctototalorden = tcValordsctototalorden;
            this.Valornetototalorden = tcValornetototalorden;
            this.Valorigvtotalorden = tcValorigvtotalorden;
            this.Valortotalactualdeltotaldelaorden = tcValortotalactualdeltotaldelaorden;
            this.Recursoafectadoconigv = tcRecursoafectadoconigv;
            this.Tipodecambio = tcTipodecambio;
            this.Fechacreacion = tcFechacreacion;
            this.Fechaactualizacion = tcFechaactualizacion;
            this.Fechaorden = tcFechaorden;
            this.Usuarioregistrador = tcUsuarioregistrador;
            this.Aprobado = tcAprobado;
            this.Usuarioaprobador = tcUsuarioaprobador;
            this.Fechaaprobacion = tcFechaaprobacion;
            this.Observacionorden = tcObservacionorden;
            this.Observaciondelrecurso = tcObservaciondelrecurso;
        }

       public string Aprobado
       {
           get { return _aprobado; }
           set { _aprobado = value; }
       }

       public string Cantidadactualenorden
       {
           get { return _cantidadactualenorden; }
           set { _cantidadactualenorden = value; }
       }

       public string Cc
       {
           get { return _cc; }
           set { _cc = value; }
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

       public string Contecho
       {
           get { return _contecho; }
           set { _contecho = value; }
       }

       public string Dsctoporct
       {
           get { return _dsctoporct; }
           set { _dsctoporct = value; }
       }

       public string Estadoorden
       {
           get { return _estadoorden; }
           set { _estadoorden = value; }
       }

       public string Fechaactualizacion
       {
           get { return _fechaactualizacion; }
           set { _fechaactualizacion = value; }
       }

       public string Fechaaprobacion
       {
           get { return _fechaaprobacion; }
           set { _fechaaprobacion = value; }
       }

       public string Fechacreacion
       {
           get { return _fechacreacion; }
           set { _fechacreacion = value; }
       }

       public string Fechaorden
       {
           get { return _fechaorden; }
           set { _fechaorden = value; }
       }

       public string Fpago
       {
           get { return _fpago; }
           set { _fpago = value; }
       }

       public string Nroorden
       {
           get { return _nroorden; }
           set { _nroorden = value; }
       }

       public string Observaciondelrecurso
       {
           get { return _observaciondelrecurso; }
           set { _observaciondelrecurso = value; }
       }

       public string Observacionorden
       {
           get { return _observacionorden; }
           set { _observacionorden = value; }
       }

       public string Parcialrecurso
       {
           get { return _parcialrecurso; }
           set { _parcialrecurso = value; }
       }

       public string Parcialtotalorden
       {
           get { return _parcialtotalorden; }
           set { _parcialtotalorden = value; }
       }

       public string Precio
       {
           get { return _precio; }
           set { _precio = value; }
       }

       public string Precioexcedetecho
       {
           get { return _precioexcedetecho; }
           set { _precioexcedetecho = value; }
       }

       public string Preciotecho
       {
           get { return _preciotecho; }
           set { _preciotecho = value; }
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

       public string Recursoafectadoconigv
       {
           get { return _recursoafectadoconigv; }
           set { _recursoafectadoconigv = value; }
       }

       public string Simb
       {
           get { return _simb; }
           set { _simb = value; }
       }

       public string Tipodecambio
       {
           get { return _tipodecambio; }
           set { _tipodecambio = value; }
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

       public string Usuarioaprobador
       {
           get { return _usuarioaprobador; }
           set { _usuarioaprobador = value; }
       }

       public string Usuarioregistrador
       {
           get { return _usuarioregistrador; }
           set { _usuarioregistrador = value; }
       }

       public string Valordsctototalorden
       {
           get { return _valordsctototalorden; }
           set { _valordsctototalorden = value; }
       }

       public string Valorigvtotalorden
       {
           get { return _valorigvtotalorden; }
           set { _valorigvtotalorden = value; }
       }

       public string Valornetototalorden
       {
           get { return _valornetototalorden; }
           set { _valornetototalorden = value; }
       }

       public string Valortotalactualdeltotaldelaorden
       {
           get { return _valortotalactualdeltotaldelaorden; }
           set { _valortotalactualdeltotaldelaorden = value; }
       }
    }
}
