
namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogicMasivoC
{
   public class LgImplVerifNroProS
    {

        private string _numerodocumento;
        private string _observacion;
        private string _tipodocumento;

        public LgImplVerifNroProS()
        {
        }

        public LgImplVerifNroProS(string tcTipodocumento, string tcNumerodocumento, string tcObservacion)
        {
            this.Tipodocumento = tcTipodocumento;
            this.Numerodocumento = tcNumerodocumento;
            this.Observacion = tcObservacion;
        }

       public string Numerodocumento
       {
           get { return _numerodocumento; }
           set { _numerodocumento = value; }
       }

       public string Observacion
       {
           get { return _observacion; }
           set { _observacion = value; }
       }

       public string Tipodocumento
       {
           get { return _tipodocumento; }
           set { _tipodocumento = value; }
       }
    }
}
