namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
    public class LgImplOcsFacturar
    {
        private string _cantidad;
        private string _codinsumo;
        private string _codorden;
        private string _codproveedor;
        private string _precio;
        private string _proveedor;
        private string _proyecto;
        private string _recurso;
        private string _tipoorden;
        private string _total;
        private string _unidad;

        public LgImplOcsFacturar()
        {
        }

        public LgImplOcsFacturar(string tcProyecto, string tcCodorden, string tcTipoorden, string tcCodproveedor, string tcProveedor, string tcCodinsumo, string tcRecurso, string tcUnidad, string tcCantidad, string tcPrecio, string tcTotal)
        {
            this.Proyecto = tcProyecto;
            this.Codorden = tcCodorden;
            this.Tipoorden = tcTipoorden;
            this.Codproveedor = tcCodproveedor;
            this.Proveedor = tcProveedor;
            this.Codinsumo = tcCodinsumo;
            this.Recurso = tcRecurso;
            this.Unidad = tcUnidad;
            this.Cantidad = tcCantidad;
            this.Precio = tcPrecio;
            this.Total = tcTotal;
        }

        public string Cantidad
        {
            get
            {
                return this._cantidad;
            }
            set
            {
                this._cantidad = value;
            }
        }

        public string Codinsumo
        {
            get
            {
                return this._codinsumo;
            }
            set
            {
                this._codinsumo = value;
            }
        }

        public string Codorden
        {
            get
            {
                return this._codorden;
            }
            set
            {
                this._codorden = value;
            }
        }

        public string Codproveedor
        {
            get
            {
                return this._codproveedor;
            }
            set
            {
                this._codproveedor = value;
            }
        }

        public string Precio
        {
            get
            {
                return this._precio;
            }
            set
            {
                this._precio = value;
            }
        }

        public string Proveedor
        {
            get
            {
                return this._proveedor;
            }
            set
            {
                this._proveedor = value;
            }
        }

        public string Proyecto
        {
            get
            {
                return this._proyecto;
            }
            set
            {
                this._proyecto = value;
            }
        }

        public string Recurso
        {
            get
            {
                return this._recurso;
            }
            set
            {
                this._recurso = value;
            }
        }

        public string Tipoorden
        {
            get
            {
                return this._tipoorden;
            }
            set
            {
                this._tipoorden = value;
            }
        }

        public string Total
        {
            get
            {
                return this._total;
            }
            set
            {
                this._total = value;
            }
        }

        public string Unidad
        {
            get
            {
                return this._unidad;
            }
            set
            {
                this._unidad = value;
            }
        }
    }
}
