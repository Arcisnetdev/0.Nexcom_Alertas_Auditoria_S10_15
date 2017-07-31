namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
    public class LgImplSegTransferencia
    {
        private string _ActualizacionFecha;
        private string _ActualizacionUsuario;
        private string _Almacen;
        private string _Ano;
        private string _CodGuia;
        private string _CodGuiaRelacion;
        private string _CodPedido;
        private string _CreacionFecha;
        private string _CreacionUsuario;
        private string _EstadoCierre;
        private string _FechaGuia;
        private string _Igv;
      //  private string _MovimientoDestino;
        private string _MovimientoOrigen;
        private string _NroDocumento;
        private string _Parcial;
        private string _Proyecto;
        private string _ProyectoDestino;
        private string _SerieDocumento;
        private string _Simbolo;
        private string _TipoCambio;
        private string _Total;
        private string _CodRecurso;
        private string _Recurso;

        public LgImplSegTransferencia()
        {
        }

        public LgImplSegTransferencia(string tcProyecto, string tcAlmacen, string tcCodGuia, string tcFechaGuia, string tcSerieDocumento, string tcNroDocumento, string tcMovimientoOrigen, string tcEstadoCierre, string tcSimbolo, string tcTipoCambio, string tcParcial, string tcIgv, string tcTotal, string tcCodPedido, string tcProyectoDestino, string tcCodGuiaRelacion, string tcCreacionUsuario, string tcCreacionFecha, string tcActualizacionUsuario, string tcActualizacionFecha, string tcAno, string tcCodRecurso, string tcRecurso)
        {
            this.Proyecto = tcProyecto;
            this._Almacen = tcAlmacen;
            this._CodGuia = tcCodGuia;
            this._FechaGuia = tcFechaGuia;
            this._SerieDocumento = tcSerieDocumento;
            this._NroDocumento = tcNroDocumento;
            this._MovimientoOrigen = tcMovimientoOrigen;
            this._EstadoCierre = tcEstadoCierre;
            this._Simbolo = tcSimbolo;
            this._CodRecurso = tcCodRecurso;
            this._Recurso = tcRecurso;
            this._TipoCambio = tcTipoCambio;
            this._Parcial = tcParcial;
            this._Igv = tcIgv;
            this._Total = tcTotal;
            this._CodPedido = tcCodPedido;
            this._ProyectoDestino = tcProyectoDestino;
            this._CodGuiaRelacion = tcCodGuiaRelacion;
            //  this._MovimientoDestino = tcMovimientoDestino;
            this._CreacionUsuario = tcCreacionUsuario;
            this._CreacionFecha = tcCreacionFecha;
            this._ActualizacionUsuario = tcActualizacionUsuario;
            this._ActualizacionFecha = tcActualizacionFecha;
            this._Ano = tcAno;
        }

        public string ActualizacionFecha
        {
            get
            {
                return this._ActualizacionFecha;
            }
            set
            {
                this._ActualizacionFecha = value;
            }
        }

        public string ActualizacionUsuario
        {
            get
            {
                return this._ActualizacionUsuario;
            }
            set
            {
                this._ActualizacionUsuario = value;
            }
        }

        public string Almacen
        {
            get
            {
                return this._Almacen;
            }
            set
            {
                this._Almacen = value;
            }
        }

        public string Ano
        {
            get
            {
                return this._Ano;
            }
            set
            {
                this._Ano = value;
            }
        }

        public string CodGuia
        {
            get
            {
                return this._CodGuia;
            }
            set
            {
                this._CodGuia = value;
            }
        }

        public string CodGuiaRelacion
        {
            get
            {
                return this._CodGuiaRelacion;
            }
            set
            {
                this._CodGuiaRelacion = value;
            }
        }

        public string CodPedido
        {
            get
            {
                return this._CodPedido;
            }
            set
            {
                this._CodPedido = value;
            }
        }


        public string CodRecurso
        {
            get
            {
                return _CodRecurso;
            }
            set
            {
                _CodRecurso = value;
            }
        }
        public string CreacionFecha
        {
            get
            {
                return this._CreacionFecha;
            }
            set
            {
                this._CreacionFecha = value;
            }
        }

        public string CreacionUsuario
        {
            get
            {
                return this._CreacionUsuario;
            }
            set
            {
                this._CreacionUsuario = value;
            }
        }

        public string EstadoCierre
        {
            get
            {
                return this._EstadoCierre;
            }
            set
            {
                this._EstadoCierre = value;
            }
        }

        public string FechaGuia
        {
            get
            {
                return this._FechaGuia;
            }
            set
            {
                this._FechaGuia = value;
            }
        }

        public string Igv
        {
            get
            {
                return this._Igv;
            }
            set
            {
                this._Igv = value;
            }
        }

    
        public string MovimientoOrigen
        {
            get
            {
                return this._MovimientoOrigen;
            }
            set
            {
                this._MovimientoOrigen = value;
            }
        }

        public string NroDocumento
        {
            get
            {
                return this._NroDocumento;
            }
            set
            {
                this._NroDocumento = value;
            }
        }

        public string Parcial
        {
            get
            {
                return this._Parcial;
            }
            set
            {
                this._Parcial = value;
            }
        }

        public string Proyecto
        {
            get
            {
                return this._Proyecto;
            }
            set
            {
                this._Proyecto = value;
            }
        }

        public string ProyectoDestino
        {
            get
            {
                return this._ProyectoDestino;
            }
            set
            {
                this._ProyectoDestino = value;
            }
        }

        public string Recurso
        {
            get
            {
                return _Recurso;
            }
            set
            {
                _Recurso = value;
            }
        }
        public string SerieDocumento
        {
            get
            {
                return this._SerieDocumento;
            }
            set
            {
                this._SerieDocumento = value;
            }
        }

        public string Simbolo
        {
            get
            {
                return this._Simbolo;
            }
            set
            {
                this._Simbolo = value;
            }
        }

        public string TipoCambio
        {
            get
            {
                return this._TipoCambio;
            }
            set
            {
                this._TipoCambio = value;
            }
        }

        public string Total
        {
            get
            {
                return this._Total;
            }
            set
            {
                this._Total = value;
            }
        }
    }
}
