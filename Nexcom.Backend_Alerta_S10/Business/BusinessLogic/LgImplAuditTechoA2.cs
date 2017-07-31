namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
    public class LgImplAuditTechoA2
    {
        private string _almacen;
        private string _calmacen;
        private string _cantidadguia;
        private string _codrecurso;
        private string _costo;
        private string _cpedido;
        private string _cpedir;
        private string _descripcion;
        private string _fechaguia;
        private string _guia;
        private string _movimiento;
        private string _precio;
        private string _proyecto;
        private string _simbolo;
        private string _techo;
        private string _usuarioguia;

        public LgImplAuditTechoA2()
        {
        }

        public LgImplAuditTechoA2(string tcProyecto, string tcCodrecurso, string tcDescripcion, string tcSimbolo, string tcTecho, string tcCpedido, string tcCalmacen, string tcCpedir, string tcFechaguia, string tcAlmacen, string tcGuia, string tcPrecio, string tcCosto, string tcCantidadguia, string tcUsuarioguia, string tcMovimiento)
        {
            this._proyecto = tcProyecto;
            this._codrecurso = tcCodrecurso;
            this._descripcion = tcDescripcion;
            this._simbolo = tcSimbolo;
            this._techo = tcTecho;
            this._cpedido = tcCpedido;
            this._calmacen = tcCalmacen;
            this._cpedir = tcCpedir;
            this._fechaguia = tcFechaguia;
            this._almacen = tcAlmacen;
            this._guia = tcGuia;
            this._precio = tcPrecio;
            this._costo = tcCosto;
            this._cantidadguia = tcCantidadguia;
            this._usuarioguia = tcUsuarioguia;
            this._movimiento = tcMovimiento;
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

        public string Calmacen
        {
            get
            {
                return this._calmacen;
            }
            set
            {
                this._calmacen = value;
            }
        }

        public string Cantidadguia
        {
            get
            {
                return this._cantidadguia;
            }
            set
            {
                this._cantidadguia = value;
            }
        }

        public string Codrecurso
        {
            get
            {
                return this._codrecurso;
            }
            set
            {
                this._codrecurso = value;
            }
        }

        public string Costo
        {
            get
            {
                return this._costo;
            }
            set
            {
                this._costo = value;
            }
        }

        public string Cpedido
        {
            get
            {
                return this._cpedido;
            }
            set
            {
                this._cpedido = value;
            }
        }

        public string Cpedir
        {
            get
            {
                return this._cpedir;
            }
            set
            {
                this._cpedir = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return this._descripcion;
            }
            set
            {
                this._descripcion = value;
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

        public string Guia
        {
            get
            {
                return this._guia;
            }
            set
            {
                this._guia = value;
            }
        }

        public string Movimiento
        {
            get
            {
                return this._movimiento;
            }
            set
            {
                this._movimiento = value;
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

        public string Simbolo
        {
            get
            {
                return this._simbolo;
            }
            set
            {
                this._simbolo = value;
            }
        }

        public string Techo
        {
            get
            {
                return this._techo;
            }
            set
            {
                this._techo = value;
            }
        }

        public string Usuarioguia
        {
            get
            {
                return this._usuarioguia;
            }
            set
            {
                this._usuarioguia = value;
            }
        }
    }
}
