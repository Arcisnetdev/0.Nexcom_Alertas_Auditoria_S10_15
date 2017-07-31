using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogicS10
{
    public class LgImplCabeceraS10
    {

        private string _AdministradorRubro;
        private string _CentroCostos;
        private string _Comentarios;
        private string _ComentariosAdicional;
        private string _CompaniaCodigo;
        private string _Contacto;
        private string _CuentaAbono;
        private string _ECC;
        private string _ENRDOC;
        private string _EP;
        private DateTime _FechaDocumento;
        private DateTime _FechaRecepcion;
        private DateTime _FechaRegistro;
        private DateTime _FechaVencimiento;
        private DateTime _FechaVencimientoOriginal;
        private string _FlujoCaja;
        private string _GenerarPago;
        private string _IngresadoPor;
        private string _MonedaDocumento;
        private string _MonedaPago;
        private string _MontoAdelantos;
        private string _MontoAfecto;
        private string _MontoCreditoFiscal;
        private string _MontoImponible;
        private string _MontoImpuesto;
        private string _MontoImpuestoVentas;
        private string _MontoObligacion;
        private string _MontoPagoParcial;
        private string _NumeroAdelanto;
        private string _NumeroDocumento;
        private string _OC;
        private string _PagarANombre;
        private string _Proveedor;
        private string _ProveedorPagarA;
        private string _TipoAdelanto;
        private string _TipoDocumento;
        private string _TipoPago;
        private string _TipoServicio;
        private string _UnidadNegocio;
        private string _UnidadReplicacion;
        private string _Usuario;

        public LgImplCabeceraS10()
        {
        }

        public LgImplCabeceraS10(string tcProveedor, string tcNumeroDocumento, string tcTipoDocumento, string tcCompaniaCodigo, DateTime tcFechaRegistro, DateTime tcFechaDocumento,
            DateTime tcFechaRecepcion, DateTime tcFechaVencimiento, DateTime tcFechaVencimientoOriginal, string tcMonedaDocumento, string tcTipoServicio, string tcMontoAfecto,
            string tcMontoImponible, string tcMontoImpuestoVentas, string tcMontoImpuesto, string tcMontoObligacion, string tcMontoAdelantos, string tcMontoPagoParcial, string tcMontoCreditoFiscal,
            string tcUnidadNegocio, string tcUnidadReplicacion, string tcFlujoCaja, string tcCentroCostos, string tcOC, string tcProveedorPagarA, string tcPagarANombre, string tcGenerarPago,
            string tcTipoPago, string tcMonedaPago, string tcIngresadoPor, string tcComentarios, string tcComentariosAdicional, string tcUsuario, string tcNumeroAdelanto, string tcTipoAdelanto,
            string tcCuentaAbono, string tcAdministradorRubro, string tcEP, string tcECC, string tcENRDOC, string tcContacto)
        {
            this.Proveedor = tcProveedor;
            this._NumeroDocumento = tcNumeroDocumento;
            this._TipoDocumento = tcTipoDocumento;
            this._CompaniaCodigo = tcCompaniaCodigo;
            this._FechaRegistro = tcFechaRegistro;
            this._FechaDocumento = tcFechaDocumento;
            this._FechaRecepcion = tcFechaRecepcion;
            this._FechaVencimiento = tcFechaVencimiento;
            this._FechaVencimientoOriginal = tcFechaVencimientoOriginal;
            this._MonedaDocumento = tcMonedaDocumento;
            this._TipoServicio = tcTipoServicio;
            this._MontoAfecto = tcMontoAfecto;
            this._MontoImponible = tcMontoImponible;
            this._MontoImpuestoVentas = tcMontoImpuestoVentas;
            this._MontoImpuesto = tcMontoImpuesto;
            this._MontoObligacion = tcMontoObligacion;
            this._MontoAdelantos = tcMontoAdelantos;
            this._MontoPagoParcial = tcMontoPagoParcial;
            this._MontoCreditoFiscal = tcMontoCreditoFiscal;
            this._UnidadNegocio = tcUnidadNegocio;
            this._UnidadReplicacion = tcUnidadReplicacion;
            this._FlujoCaja = tcFlujoCaja;
            this._CentroCostos = tcCentroCostos;
            this._OC = tcOC;
            this._ProveedorPagarA = tcProveedorPagarA;
            this._PagarANombre = tcPagarANombre;
            this._GenerarPago = tcGenerarPago;
            this._TipoPago = tcTipoPago;
            this._MonedaPago = tcMonedaPago;
            this._IngresadoPor = tcIngresadoPor;
            this._Comentarios = tcComentarios;
            this._ComentariosAdicional = tcComentariosAdicional;
            this._Usuario = tcUsuario;
            this._NumeroAdelanto = tcNumeroAdelanto;
            this._TipoAdelanto = tcTipoAdelanto;
            this._CuentaAbono = tcCuentaAbono;
            this._AdministradorRubro = tcAdministradorRubro;
            this._EP = tcEP;
            this._ECC = tcECC;
            this._ENRDOC = tcENRDOC;
            this._Contacto = tcContacto;
        }
        public string AdministradorRubro
        {
            get
            {
                return _AdministradorRubro;
            }
            set
            {
                _AdministradorRubro = value;
            }
        }
        public string CentroCostos
        {
            get
            {
                return _CentroCostos;
            }
            set
            {
                _CentroCostos = value;
            }
        }
        public string Comentarios
        {
            get
            {
                return _Comentarios;
            }
            set
            {
                _Comentarios = value;
            }
        }
        public string ComentariosAdicional
        {
            get
            {
                return _ComentariosAdicional;
            }
            set
            {
                _ComentariosAdicional = value;
            }
        }
        public string CompaniaCodigo
        {
            get
            {
                return _CompaniaCodigo;
            }
            set
            {
                _CompaniaCodigo = value;
            }
        }
        public string Contacto
        {
            get
            {
                return _Contacto;
            }
            set
            {
                _Contacto = value;
            }
        }
        public string CuentaAbono
        {
            get
            {
                return _CuentaAbono;
            }
            set
            {
                _CuentaAbono = value;
            }
        }
        public string ECC
        {
            get
            {
                return _ECC;
            }
            set
            {
                _ECC = value;
            }
        }
        public string ENRDOC
        {
            get
            {
                return _ENRDOC;
            }
            set
            {
                _ENRDOC = value;
            }
        }
        public string EP
        {
            get
            {
                return _EP;
            }
            set
            {
                _EP = value;
            }
        }
        public DateTime FechaDocumento
        {
            get
            {
                return _FechaDocumento;
            }
            set
            {
                _FechaDocumento = value;
            }
        }
        public DateTime FechaRecepcion
        {
            get
            {
                return _FechaRecepcion;
            }
            set
            {
                _FechaRecepcion = value;
            }
        }
        public DateTime FechaRegistro
        {
            get
            {
                return _FechaRegistro;
            }
            set
            {
                _FechaRegistro = value;
            }
        }
        public DateTime FechaVencimiento
        {
            get
            {
                return _FechaVencimiento;
            }
            set
            {
                _FechaVencimiento = value;
            }
        }
        public DateTime FechaVencimientoOriginal
        {
            get
            {
                return _FechaVencimientoOriginal;
            }
            set
            {
                _FechaVencimientoOriginal = value;
            }
        }
        public string FlujoCaja
        {
            get
            {
                return _FlujoCaja;
            }
            set
            {
                _FlujoCaja = value;
            }
        }
        public string GenerarPago
        {
            get
            {
                return _GenerarPago;
            }
            set
            {
                _GenerarPago = value;
            }
        }
        public string IngresadoPor
        {
            get
            {
                return _IngresadoPor;
            }
            set
            {
                _IngresadoPor = value;
            }
        }
        public string MonedaDocumento
        {
            get
            {
                return _MonedaDocumento;
            }
            set
            {
                _MonedaDocumento = value;
            }
        }
        public string MonedaPago
        {
            get
            {
                return _MonedaPago;
            }
            set
            {
                _MonedaPago = value;
            }
        }
        public string MontoAdelantos
        {
            get
            {
                return _MontoAdelantos;
            }
            set
            {
                _MontoAdelantos = value;
            }
        }
        public string MontoAfecto
        {
            get
            {
                return _MontoAfecto;
            }
            set
            {
                _MontoAfecto = value;
            }
        }
        public string MontoCreditoFiscal
        {
            get
            {
                return _MontoCreditoFiscal;
            }
            set
            {
                _MontoCreditoFiscal = value;
            }
        }
        public string MontoImponible
        {
            get
            {
                return _MontoImponible;
            }
            set
            {
                _MontoImponible = value;
            }
        }
        public string MontoImpuesto
        {
            get
            {
                return _MontoImpuesto;
            }
            set
            {
                _MontoImpuesto = value;
            }
        }
        public string MontoImpuestoVentas
        {
            get
            {
                return _MontoImpuestoVentas;
            }
            set
            {
                _MontoImpuestoVentas = value;
            }
        }
        public string MontoObligacion
        {
            get
            {
                return _MontoObligacion;
            }
            set
            {
                _MontoObligacion = value;
            }
        }
        public string MontoPagoParcial
        {
            get
            {
                return _MontoPagoParcial;
            }
            set
            {
                _MontoPagoParcial = value;
            }
        }
        public string NumeroAdelanto
        {
            get
            {
                return _NumeroAdelanto;
            }
            set
            {
                _NumeroAdelanto = value;
            }
        }
        public string NumeroDocumento
        {
            get
            {
                return _NumeroDocumento;
            }
            set
            {
                _NumeroDocumento = value;
            }
        }
        public string OC
        {
            get
            {
                return _OC;
            }
            set
            {
                _OC = value;
            }
        }
        public string PagarANombre
        {
            get
            {
                return _PagarANombre;
            }
            set
            {
                _PagarANombre = value;
            }
        }
        public string Proveedor
        {
            get
            {
                return _Proveedor;
            }
            set
            {
                _Proveedor = value;
            }
        }
        public string ProveedorPagarA
        {
            get
            {
                return _ProveedorPagarA;
            }
            set
            {
                _ProveedorPagarA = value;
            }
        }
        public string TipoAdelanto
        {
            get
            {
                return _TipoAdelanto;
            }
            set
            {
                _TipoAdelanto = value;
            }
        }
        public string TipoDocumento
        {
            get
            {
                return _TipoDocumento;
            }
            set
            {
                _TipoDocumento = value;
            }
        }
        public string TipoPago
        {
            get
            {
                return _TipoPago;
            }
            set
            {
                _TipoPago = value;
            }
        }
        public string TipoServicio
        {
            get
            {
                return _TipoServicio;
            }
            set
            {
                _TipoServicio = value;
            }
        }
        public string UnidadNegocio
        {
            get
            {
                return _UnidadNegocio;
            }
            set
            {
                _UnidadNegocio = value;
            }
        }
        public string UnidadReplicacion
        {
            get
            {
                return _UnidadReplicacion;
            }
            set
            {
                _UnidadReplicacion = value;
            }
        }
        public string Usuario
        {
            get
            {
                return _Usuario;
            }
            set
            {
                _Usuario = value;
            }
        }

    }
}