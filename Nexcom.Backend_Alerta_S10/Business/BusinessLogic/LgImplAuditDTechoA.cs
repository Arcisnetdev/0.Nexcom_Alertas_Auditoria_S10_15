namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
    public class LgImplAuditDTechoA
    {
        private string _almacen;
        private string _cantidadguia;
        private string _codrecurso;
        private string _cpedido;
        private string _descripcion;
        private string _fechaguia;
        private string _guia;
        private string _movimiento;
        private string _proyecto;
        private string _simbolo;
        private string _usuarioguia;

        public LgImplAuditDTechoA()
        {
        }

        public LgImplAuditDTechoA(string tcCodrecurso, string tcDescripcion, string tcSimbolo, string tcCpedido, string tcProyecto, string tcGuia, string tcFechaguia, string tcCantidadguia, string tcUsuarioguia, string tcAlmacen, string tcMovimiento)
        {
            this._codrecurso = tcCodrecurso;
            this._descripcion = tcDescripcion;
            this._simbolo = tcSimbolo;
            this._cpedido = tcCpedido;
            this._proyecto = tcProyecto;
            this._guia = tcGuia;
            this._fechaguia = tcFechaguia;
            this._cantidadguia = tcCantidadguia;
            this._usuarioguia = tcUsuarioguia;
            this._almacen = tcAlmacen;
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
