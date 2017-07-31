namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogicMasivoC
{
    public class LgImplVerifNroCc
    {
        private string _cc;
        private string _descripcion;

        public LgImplVerifNroCc()
        {
        }

        public LgImplVerifNroCc(string tcCc, string tcDescripcion)
        {
            this.Cc = tcCc;
            this.Descripcion = tcDescripcion;
        }

        public string Cc
        {
            get { return _cc; }
            set { _cc = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
