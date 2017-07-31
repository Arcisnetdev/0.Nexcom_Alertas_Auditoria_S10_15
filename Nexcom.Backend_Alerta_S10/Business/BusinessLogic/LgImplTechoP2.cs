namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
    public class LgImplTechoP2
    {
        private string _sExEq;
        private string _sExMa;
        private string _sExMo;
        private string _sExPpto;
        private string _sExSc;

        public LgImplTechoP2()
        {
        }

        public LgImplTechoP2(string tcSExPpto, string tcSExMa, string tcSExSc, string tcSExEq, string tcSExMo)
        {
            this._sExEq = tcSExEq;
            this._sExMa = tcSExMa;
            this._sExMo = tcSExMo;
            this._sExPpto = tcSExPpto;
            this._sExSc = tcSExSc;
        }

        public string SExEq
        {
            get
            {
                return this._sExEq;
            }
            set
            {
                this._sExEq = value;
            }
        }

        public string SExMa
        {
            get
            {
                return this._sExMa;
            }
            private set
            {
                this._sExMa = value;
            }
        }

        public string SExMo
        {
            get
            {
                return this._sExMo;
            }
            private set
            {
                this._sExMo = value;
            }
        }

        public string SExPpto
        {
            get
            {
                return this._sExPpto;
            }
            private set
            {
                this._sExPpto = value;
            }
        }

        public string SExSc
        {
            get
            {
                return this._sExSc;
            }
            private set
            {
                this._sExSc = value;
            }
        }
    }
}
