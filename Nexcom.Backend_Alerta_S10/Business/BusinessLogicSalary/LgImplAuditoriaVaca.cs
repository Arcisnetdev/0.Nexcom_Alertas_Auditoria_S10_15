using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogicSalary
{
    public class LgImplAuditoriaVaca
    {
        private string _Codigo;
        private string _CodUser;
        private string _Derecho;
        private string _Fecha;
        private string _IdItem;
        private string _IP;
        private string _Nombre;
        private string _Pendiente;
        private string _Periodo;
        private string _Utilizado;

        public LgImplAuditoriaVaca()
        {
        }

        public LgImplAuditoriaVaca(string tcIdItem, string tcCodUser, string tcCodigo, string tcNombre, string tcPeriodo, string tcDerecho, string tcUtilizado, string tcPendiente, string tcIP, string tcFecha)
        {
            this.IdItem = tcIdItem;
            this._CodUser = tcCodUser;
            this._Codigo = tcCodigo;
            this._Nombre = tcNombre;
            this._Periodo = tcPeriodo;
            this._Derecho = tcDerecho;
            this._Utilizado = tcUtilizado;
            this._Pendiente = tcPendiente;
            this._IP = tcIP;
            this._Fecha = tcFecha;
        }
        public string Codigo
        {
            get
            {
                return _Codigo;
            }
            set
            {
                _Codigo = value;
            }
        }
        public string CodUser
        {
            get
            {
                return _CodUser;
            }
            set
            {
                _CodUser = value;
            }
        }
        public string Derecho
        {
            get
            {
                return _Derecho;
            }
            set
            {
                _Derecho = value;
            }
        }
        public string Fecha
        {
            get
            {
                return _Fecha;
            }
            set
            {
                _Fecha = value;
            }
        }
        public string IdItem
        {
            get
            {
                return _IdItem;
            }
            set
            {
                _IdItem = value;
            }
        }
        public string IP
        {
            get
            {
                return _IP;
            }
            set
            {
                _IP = value;
            }
        }
        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value;
            }
        }
        public string Pendiente
        {
            get
            {
                return _Pendiente;
            }
            set
            {
                _Pendiente = value;
            }
        }
        public string Periodo
        {
            get
            {
                return _Periodo;
            }
            set
            {
                _Periodo = value;
            }
        }
        public string Utilizado
        {
            get
            {
                return _Utilizado;
            }
            set
            {
                _Utilizado = value;
            }
        }
    }
}
