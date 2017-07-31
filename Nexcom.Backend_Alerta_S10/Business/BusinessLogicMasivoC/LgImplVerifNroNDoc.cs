
namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogicMasivoC
{
   public class LgImplVerifNroNDoc
    {

 private string _descripcion;
        private string _nroDoc;

        public LgImplVerifNroNDoc()
        {
        }

        public LgImplVerifNroNDoc(string tcNroDoc, string tcDescripcion)
        {
            this.NroDoc = tcNroDoc;
            this.Descripcion = tcDescripcion;
        }

       public string Descripcion
       {
           get { return _descripcion; }
           set { _descripcion = value; }
       }

       public string NroDoc
       {
           get { return _nroDoc; }
           set { _nroDoc = value; }
       }
    }
}
