namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
    public class LgImplPedCreEnDia
    {
        private string _alm;
        private string _codrec;
        private string _cped;
        private string _eped;
        private string _estal;
        private string _estcot;
        private string _estor;
        private string _fapr;
        private string _fped;
        private string _npedm;
        private string _obsped;
        private string _proy;
        private string _rec;
        private string _tped;
        private string _un;
        private string _usapro;
        private string _usreg;

        public LgImplPedCreEnDia()
        {
        }

        public LgImplPedCreEnDia(string tcProy, string tcAlm, string tcTped, string tcEped, string tcNpedm, string tcCodrec, string tcRec, string tcUn, string tcCped, string tcObsped, string tcFped, string tcFapr, string tcUsreg, string tcUsapro, string tcEstor, string tcEstal, string tcEstcot)
        {
            this.Proy = tcProy;
            this.Alm = tcAlm;
            this.Tped = tcTped;
            this.Eped = tcEped;
            this.Npedm = tcNpedm;
            this.Codrec = tcCodrec;
            this.Rec = tcRec;
            this.Un = tcUn;
            this.Cped = tcCped;
            this.Obsped = tcObsped;
            this.Fped = tcFped;
            this.Fapr = tcFapr;
            this.Usreg = tcUsreg;
            this.Usapro = tcUsapro;
            this.Estor = tcEstor;
            this.Estal = tcEstal;
            this.Estcot = tcEstcot;
        }

        public string Alm
        {
            get
            {
                return this._alm;
            }
            set
            {
                this._alm = value;
            }
        }

        public string Codrec
        {
            get
            {
                return this._codrec;
            }
            set
            {
                this._codrec = value;
            }
        }

        public string Cped
        {
            get
            {
                return this._cped;
            }
            set
            {
                this._cped = value;
            }
        }

        public string Eped
        {
            get
            {
                return this._eped;
            }
            set
            {
                this._eped = value;
            }
        }

        public string Estal
        {
            get
            {
                return this._estal;
            }
            set
            {
                this._estal = value;
            }
        }

        public string Estcot
        {
            get
            {
                return this._estcot;
            }
            set
            {
                this._estcot = value;
            }
        }

        public string Estor
        {
            get
            {
                return this._estor;
            }
            set
            {
                this._estor = value;
            }
        }

        public string Fapr
        {
            get
            {
                return this._fapr;
            }
            set
            {
                this._fapr = value;
            }
        }

        public string Fped
        {
            get
            {
                return this._fped;
            }
            set
            {
                this._fped = value;
            }
        }

        public string Npedm
        {
            get
            {
                return this._npedm;
            }
            set
            {
                this._npedm = value;
            }
        }

        public string Obsped
        {
            get
            {
                return this._obsped;
            }
            set
            {
                this._obsped = value;
            }
        }

        public string Proy
        {
            get
            {
                return this._proy;
            }
            set
            {
                this._proy = value;
            }
        }

        public string Rec
        {
            get
            {
                return this._rec;
            }
            set
            {
                this._rec = value;
            }
        }

        public string Tped
        {
            get
            {
                return this._tped;
            }
            set
            {
                this._tped = value;
            }
        }

        public string Un
        {
            get
            {
                return this._un;
            }
            set
            {
                this._un = value;
            }
        }

        public string Usapro
        {
            get
            {
                return this._usapro;
            }
            set
            {
                this._usapro = value;
            }
        }

        public string Usreg
        {
            get
            {
                return this._usreg;
            }
            set
            {
                this._usreg = value;
            }
        }
    }
}
