
namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogicPedServ
{
    public class LgImplPedServApNoOS
    {
        private string _alm;
        private string _codrec;
        private string _cped;
        private string _diapro;
        private string _eped;
        private string _estal;
        private string _estcot;
        private string _estor;
        private string _fapr;
        private string _fped;
        private string _item;
        private string _npedm;
        private string _obsped;
        private string _proy;
        private string _rec;
        private string _tped;
        private string _un;
        private string _usapro;
        private string _usreg;

        public LgImplPedServApNoOS()
        {
        }

        public LgImplPedServApNoOS(string tcProy, string tcAlm, string tcTped, string tcEped, string tcNpedm, string tcCodrec,
            string tcRec, string tcUn, string tcCped, string tcObsped, string tcFped, string tcFapr, string tcDiapro, string tcItem,
            string tcUsreg, string tcUsapro, string tcEstor, string tcEstal, string tcEstcot)
        {
            this._proy = tcProy;
            this._alm = tcAlm;
            this._tped = tcTped;
            this._eped = tcEped;
            this._npedm = tcNpedm;
            this._codrec = tcCodrec;
            this._rec = tcRec;
            this._un = tcUn;
            this._cped = tcCped;
            this._obsped = tcObsped;
            this._fped = tcFped;
            this._fapr = tcFapr;
            this._diapro = tcDiapro;
            this._item = tcItem;
            this._usreg = tcUsreg;
            this._usapro = tcUsapro;
            this._estor = tcEstor;
            this._estal = tcEstal;
            this._estcot = tcEstcot;
        }

        public string Alm
        {
            get { return _alm; }
            set { _alm = value; }
        }

        public string Codrec
        {
            get { return _codrec; }
            set { _codrec = value; }
        }

        public string Cped
        {
            get { return _cped; }
            set { _cped = value; }
        }

        public string Diapro
        {
            get { return _diapro; }
            set { _diapro = value; }
        }

        public string Eped
        {
            get { return _eped; }
            set { _eped = value; }
        }

        public string Estal
        {
            get { return _estal; }
            set { _estal = value; }
        }

        public string Estcot
        {
            get { return _estcot; }
            set { _estcot = value; }
        }

        public string Estor
        {
            get { return _estor; }
            set { _estor = value; }
        }

        public string Fapr
        {
            get { return _fapr; }
            set { _fapr = value; }
        }

        public string Fped
        {
            get { return _fped; }
            set { _fped = value; }
        }

        public string Item
        {
            get { return _item; }
            set { _item = value; }
        }

        public string Npedm
        {
            get { return _npedm; }
            set { _npedm = value; }
        }

        public string Obsped
        {
            get { return _obsped; }
            set { _obsped = value; }
        }

        public string Proy
        {
            get { return _proy; }
            set { _proy = value; }
        }

        public string Rec
        {
            get { return _rec; }
            set { _rec = value; }
        }

        public string Tped
        {
            get { return _tped; }
            set { _tped = value; }
        }

        public string Un
        {
            get { return _un; }
            set { _un = value; }
        }

        public string Usapro
        {
            get { return _usapro; }
            set { _usapro = value; }
        }

        public string Usreg
        {
            get { return _usreg; }
            set { _usreg = value; }
        }
    }
}
