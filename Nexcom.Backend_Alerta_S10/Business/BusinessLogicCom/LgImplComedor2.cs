namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogicCom
{
   public class LgImplComedor2
    {
        private string _comida;
        private string _total;

        public LgImplComedor2()
        {
        }

        public LgImplComedor2(string tcComida, string tcTotal)
        {
            this.Comida = tcComida;
            this.Total = tcTotal;
        }

       public string Comida
       {
           get { return _comida; }
           set { _comida = value; }
       }

       public string Total
       {
           get { return _total; }
           set { _total = value; }
       }
    }
}
