namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
    public class LgImplGasFacturar
    {
        private string _almacen;
        private string _codguia;
        private string _fechaguia;
        private string _nroguiaremision;
        private string _nrooc;
        private string _proveedor;
        private string _proyecto;

        public LgImplGasFacturar()
        {
        }

        public LgImplGasFacturar(string tcProyecto, string tcNrooc, string tcAlmacen, string tcCodguia, string tcFechaguia, string tcNroguiaremision, string tcProveedor)
        {
            this.Proyecto = tcProyecto;
            this.Nrooc = tcNrooc;
            this.Almacen = tcAlmacen;
            this.Codguia = tcCodguia;
            this.Fechaguia = tcFechaguia;
            this.Nroguiaremision = tcNroguiaremision;
            this.Proveedor = tcProveedor;
        }

        public string Almacen
        {
            get
            {
                return this._almacen;
            }
            set
            {
                this._almacen = value;
            }
        }

        public string Codguia
        {
            get
            {
                return this._codguia;
            }
            set
            {
                this._codguia = value;
            }
        }

        public string Fechaguia
        {
            get
            {
                return this._fechaguia;
            }
            set
            {
                this._fechaguia = value;
            }
        }

        public string Nroguiaremision
        {
            get
            {
                return this._nroguiaremision;
            }
            set
            {
                this._nroguiaremision = value;
            }
        }

        public string Nrooc
        {
            get
            {
                return this._nrooc;
            }
            set
            {
                this._nrooc = value;
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
    }
}
