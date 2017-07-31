using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogicSalary
{
    public class LgImplAuditoriaP
    {
        private string _Codigo;
        private string _CodUser;
        private string _Fecha;
        private string _IdItem;
        private string _IP;
        private string _MontoLocal;
        private string _MontoLocalA;
        private string _Nombre;
        private string _Cargo;
        private string _CentroC;
        private string _Gerencia;
        private string _Area;

        public LgImplAuditoriaP()
        {
        }

        public LgImplAuditoriaP(string tcIdItem, string tcCodUser, string tcCodigo, string tcNombre, string tcMontoLocal, string tcMontoLocalA, string tcIP, string tcFecha, string tcCargo,
            string tcCentroC, string tcArea, string tcGerencia)
        {
            this._IdItem = tcIdItem;
            this._CodUser = tcCodUser;
            this._Codigo = tcCodigo;
            this._Nombre = tcNombre;
            this._MontoLocal = tcMontoLocal;
            this._MontoLocalA = tcMontoLocalA;
            this._IP = tcIP;
            this._Fecha = tcFecha;
            this._CentroC = tcCentroC;
            this._Cargo = tcCargo;
            this._Area = tcArea;
            this._Gerencia = tcGerencia;
        }
        public string Area
        {
            get
            {
                return _Area;
            }
            set
            {
                _Area = value;
            }
        }
        public string Cargo
        {
            get
            {
                return _Cargo;
            }
            set
            {
                _Cargo = value;
            }
        }
        public string CentroC
        {
            get
            {
                return _CentroC;
            }
            set
            {
                _CentroC = value;
            }
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
        public string Gerencia
        {
            get
            {
                return _Gerencia;
            }
            set
            {
                _Gerencia = value;
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
        public string MontoLocal
        {
            get
            {
                return _MontoLocal;
            }
            set
            {
                _MontoLocal = value;
            }
        }
        public string MontoLocalA
        {
            get
            {
                return _MontoLocalA;
            }
            set
            {
                _MontoLocalA = value;
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
    }
}
