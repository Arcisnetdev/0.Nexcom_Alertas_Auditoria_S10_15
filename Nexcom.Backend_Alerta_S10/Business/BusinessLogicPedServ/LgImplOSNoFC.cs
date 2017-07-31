using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogicPedServ
{
    public class LgImplOSNoFC
    {
        private string _proyecto;
        private string _codos;
        private string _tipoos;
        private string _fecha;
        private string _osestado;
        private string _proveedor;
        private string _codinsumo;
        private string _recurso;
        private string _unidad;
        private string _cantidad;
        private string _precio;
        private string _total;
        private string _estadofacturado;

         public LgImplOSNoFC()
        {
        }

        public LgImplOSNoFC(string tcProyecto, string tcCodOS, string tcTipoOS, string tcFecha, string tcOSEstado, string tcProveedor,
            string tcCodInsumo, string tcRecurso ,string tcUnidad, string tcCantidad, string tcPrecio, string tcTotal, string tcEstadoFacturado)
        {
            this._proyecto = tcProyecto;
            this._codos = tcCodOS;
            this._tipoos = tcTipoOS;
            this._fecha = tcFecha;
            this._osestado = tcOSEstado;
            this._proveedor = tcProveedor;
            this._codinsumo = tcCodInsumo;
            this._recurso = tcRecurso;
            this._unidad = tcUnidad;
            this._cantidad = tcCantidad;
            this._precio = tcPrecio;
            this._total = tcTotal;
            this._estadofacturado = tcEstadoFacturado;
        }
        public string Cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                _cantidad = value;
            }
        }
        public string Codinsumo
        {
            get
            {
                return _codinsumo;
            }
            set
            {
                _codinsumo = value;
            }
        }
        public string Codos
        {
            get
            {
                return _codos;
            }
            set
            {
                _codos = value;
            }
        }
        public string Estadofacturado
        {
            get
            {
                return _estadofacturado;
            }
            set
            {
                _estadofacturado = value;
            }
        }
        public string Fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = value;
            }
        }
        public string Osestado
        {
            get
            {
                return _osestado;
            }
            set
            {
                _osestado = value;
            }
        }
        public string Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }
        public string Proveedor
        {
            get
            {
                return _proveedor;
            }
            set
            {
                _proveedor = value;
            }
        }
        public string Proyecto
        {
            get
            {
                return _proyecto;
            }
            set
            {
                _proyecto = value;
            }
        }
        public string Recurso
        {
            get
            {
                return _recurso;
            }
            set
            {
                _recurso = value;
            }
        }
        public string Tipoos
        {
            get
            {
                return _tipoos;
            }
            set
            {
                _tipoos = value;
            }
        }
        public string Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
            }
        }
        public string Unidad
        {
            get
            {
                return _unidad;
            }
            set
            {
                _unidad = value;
            }
        }


    }
}
