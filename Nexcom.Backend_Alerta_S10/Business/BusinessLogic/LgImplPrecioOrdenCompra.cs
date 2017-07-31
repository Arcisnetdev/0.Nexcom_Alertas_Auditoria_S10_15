namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
  public  class LgImplPrecioOrdenCompra
    {
       private string _cant;
        private string _codac;
        private string _codan;
        private string _codrec;
        private string _comac;
        private string _coman;
        private string _desfpag;
        private string _desrec;
        private string _dif;
        private string _faoc;
        private string _faoc2;
        private string _froc;
        private string _froc2;
        private string _ocac;
        private string _ocan;
        private string _pac;
        private string _pan;
        private string _provac;
        private string _provan;
        private string _proyac;
        private string _proyan;
        private string _sac;
        private string _san;
        private string _u;

        public LgImplPrecioOrdenCompra()
        {
        }

        public LgImplPrecioOrdenCompra(string tcCodac, string tcProyac, string tcCodan, string tcProyan, string tcCodrec, string tcDesrec, 
            string tcOcac, string tcOcan, string tcFroc, string tcFaoc, string tcSac, string tcPac, string tcSan, string tcPan, string tcCant, 
            string tcDif, string tcProvac, string tcProvan, string tcDesfpag, string tcComac, string tcComan, string tcFroc2, string tcFaoc2, 
            string tcU)
        {
            this.Codac = tcCodac;
            this.Proyac = tcProyac;
            this.Codan = tcCodan;
            this.Proyan = tcProyan;
            this.Codrec = tcCodrec;
            this.Desrec = tcDesrec;
            this.Ocac = tcOcac;
            this.Ocan = tcOcan;
            this.Froc = tcFroc;
            this.Faoc = tcFaoc;
            this.Sac = tcSac;
            this.Pac = tcPac;
            this.San = tcSan;
            this.Pan = tcPan;
            this.Cant = tcCant;
            this.Dif = tcDif;
            this.Provac = tcProvac;
            this.Provan = tcProvan;
            this.Desfpag = tcDesfpag;
            this.Comac = tcComac;
            this.Coman = tcComan;
            this.Froc2 = tcFroc2;
            this.Faoc2 = tcFaoc2;
            this.U = tcU;
        }

      public string Cant
      {
          get { return _cant; }
          set { _cant = value; }
      }

      public string Codac
      {
          get { return _codac; }
          set { _codac = value; }
      }

      public string Codan
      {
          get { return _codan; }
          set { _codan = value; }
      }

      public string Codrec
      {
          get { return _codrec; }
          set { _codrec = value; }
      }

      public string Comac
      {
          get { return _comac; }
          set { _comac = value; }
      }

      public string Coman
      {
          get { return _coman; }
          set { _coman = value; }
      }

      public string Desfpag
      {
          get { return _desfpag; }
          set { _desfpag = value; }
      }

      public string Desrec
      {
          get { return _desrec; }
          set { _desrec = value; }
      }

      public string Dif
      {
          get { return _dif; }
          set { _dif = value; }
      }

      public string Faoc
      {
          get { return _faoc; }
          set { _faoc = value; }
      }

      public string Faoc2
      {
          get { return _faoc2; }
          set { _faoc2 = value; }
      }

      public string Froc
      {
          get { return _froc; }
          set { _froc = value; }
      }

      public string Froc2
      {
          get { return _froc2; }
          set { _froc2 = value; }
      }

      public string Ocac
      {
          get { return _ocac; }
          set { _ocac = value; }
      }

      public string Ocan
      {
          get { return _ocan; }
          set { _ocan = value; }
      }

      public string Pac
      {
          get { return _pac; }
          set { _pac = value; }
      }

      public string Pan
      {
          get { return _pan; }
          set { _pan = value; }
      }

      public string Provac
      {
          get { return _provac; }
          set { _provac = value; }
      }

      public string Provan
      {
          get { return _provan; }
          set { _provan = value; }
      }

      public string Proyac
      {
          get { return _proyac; }
          set { _proyac = value; }
      }

      public string Proyan
      {
          get { return _proyan; }
          set { _proyan = value; }
      }

      public string Sac
      {
          get { return _sac; }
          set { _sac = value; }
      }

      public string San
      {
          get { return _san; }
          set { _san = value; }
      }

      public string U
      {
          get { return _u; }
          set { _u = value; }
      }
    }
}
