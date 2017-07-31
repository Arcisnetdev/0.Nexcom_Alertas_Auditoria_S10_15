namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogicMasivoC
{
   public class LgImplVerifNroProveedor
    {

        private string _descripcion;
        private string _ruc;

        public LgImplVerifNroProveedor()
        {
        }

        public LgImplVerifNroProveedor(string tcRuc, string tcDescripcion)
        {
            this.Ruc = tcRuc;
            this.Descripcion = tcDescripcion;
        }

       public string Descripcion
       {
           get { return _descripcion; }
           set { _descripcion = value; }
       }

       public string Ruc
       {
           get { return _ruc; }
           set { _ruc = value; }
       }
    }
}
