using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogicS10
{
    public class LgImplDetalleS10
    {
         private string _CentroCosto;
        private string _CompaniaCodigo;
        private string _CuentaContable;
        private string _Descripcion;
        private string _Linea;
        private string _Monto;
        private string _NumeroDocumento;
        private string _Persona;
        private string _Proveedor;
        private string _Proyecto;
        private string _Sucursal;
        private string _TipoDocumento;

        public LgImplDetalleS10()
        {
        }

        public LgImplDetalleS10(string tcCompaniaCodigo, string tcProveedor, string tcTipoDocumento, string tcNumeroDocumento, string tcLinea, 
            string tcMonto, string tcCuentaContable, string tcProyecto, string tcCentroCosto, string tcDescripcion, string tcPersona, string tcSucursal)
        {
            this._CompaniaCodigo = tcCompaniaCodigo;
            this._Proveedor = tcProveedor;
            this._TipoDocumento = tcTipoDocumento;
            this._NumeroDocumento = tcNumeroDocumento;
            this._Linea = tcLinea;
            this._Monto = tcMonto;
            this._CuentaContable = tcCuentaContable;
            this._Proyecto = tcProyecto;
            this._CentroCosto = tcCentroCosto;
            this._Descripcion = tcDescripcion;
            this._Persona = tcPersona;
            this._Sucursal = tcSucursal;
        }
        public string CentroCosto
        {
            get
            {
                return _CentroCosto;
            }
            set
            {
                _CentroCosto = value;
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
        public string CuentaContable
        {
            get
            {
                return _CuentaContable;
            }
            set
            {
                _CuentaContable = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                _Descripcion = value;
            }
        }
        public string Linea
        {
            get
            {
                return _Linea;
            }
            set
            {
                _Linea = value;
            }
        }
        public string Monto
        {
            get
            {
                return _Monto;
            }
            set
            {
                _Monto = value;
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
        public string Persona
        {
            get
            {
                return _Persona;
            }
            set
            {
                _Persona = value;
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
        public string Proyecto
        {
            get
            {
                return _Proyecto;
            }
            set
            {
                _Proyecto = value;
            }
        }
        public string Sucursal
        {
            get
            {
                return _Sucursal;
            }
            set
            {
                _Sucursal = value;
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
    }
}
