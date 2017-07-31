namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
    public class LgImplTechoP
    {
        private string _codproyecto;
        private string _estadoproyecto;
        private string _excedenteAc;
        private string _excedenteEq;
        private string _excedenteMa;
        private string _excedenteMo;
        private string _excedentePresupuesto2;
        private string _excedenteSc;
        private string _proyecto;

        public LgImplTechoP()
        {
        }

        public LgImplTechoP(string tcCodproyecto, string tcEstadoproyecto, string tcProyecto, string tcExcedentePresupuesto2, string tcExcedenteMa, string tcExcedenteSc, string tcExcedenteEq, string tcExcedenteAc, string tcExcedenteMo)
        {
            this._codproyecto = tcCodproyecto;
            this._estadoproyecto = tcEstadoproyecto;
            this._excedenteAc = tcExcedenteAc;
            this._excedenteEq = tcExcedenteEq;
            this._excedenteMa = tcExcedenteMa;
            this._excedenteMo = tcExcedenteMo;
            this._excedentePresupuesto2 = tcExcedentePresupuesto2;
            this._excedenteSc = tcExcedenteSc;
            this._proyecto = tcProyecto;
        }

        public string Codproyecto
        {
            get
            {
                return this._codproyecto;
            }
            set
            {
                this._codproyecto = value;
            }
        }

        public string Estadoproyecto
        {
            get
            {
                return this._estadoproyecto;
            }
            set
            {
                this._estadoproyecto = value;
            }
        }

        public string ExcedenteAc
        {
            get
            {
                return this._excedenteAc;
            }
            set
            {
                this._excedenteAc = value;
            }
        }

        public string ExcedenteEq
        {
            get
            {
                return this._excedenteEq;
            }
            set
            {
                this._excedenteEq = value;
            }
        }

        public string ExcedenteMa
        {
            get
            {
                return this._excedenteMa;
            }
            set
            {
                this._excedenteMa = value;
            }
        }

        public string ExcedenteMo
        {
            get
            {
                return this._excedenteMo;
            }
            set
            {
                this._excedenteMo = value;
            }
        }

        public string ExcedentePresupuesto2
        {
            get
            {
                return this._excedentePresupuesto2;
            }
            set
            {
                this._excedentePresupuesto2 = value;
            }
        }

        public string ExcedenteSc
        {
            get
            {
                return this._excedenteSc;
            }
            set
            {
                this._excedenteSc = value;
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
