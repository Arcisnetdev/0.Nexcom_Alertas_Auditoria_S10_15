namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
   public class LgImplOcCreadasAyer2
    {
        private string _estadoorden;
        private string _fechaactualizacion;
        private string _fechacreacion;
        private string _fechahoy;
        private string _simbolo;
        private string _valortotalemitidoenordenes;

        public LgImplOcCreadasAyer2()
        {
        }

        public LgImplOcCreadasAyer2(string tcFechacreacion, string tcFechaactualizacion, string tFechahoyc, string tcEstadoorden, string tcSimbolo, 
            string tcValortotalemitidoenordenes)
        {
            this.Fechacreacion = tcFechacreacion;
            this.Fechaactualizacion = tcFechaactualizacion;
            this.Fechahoy = tFechahoyc;
            this.Estadoorden = tcEstadoorden;
            this.Simbolo = tcSimbolo;
            this.Estadoorden = tcEstadoorden;
            this.Valortotalemitidoenordenes = tcValortotalemitidoenordenes;
        }

       public string Estadoorden
       {
           get { return _estadoorden; }
           set { _estadoorden = value; }
       }

       public string Fechaactualizacion
       {
           get { return _fechaactualizacion; }
           set { _fechaactualizacion = value; }
       }

       public string Fechacreacion
       {
           get { return _fechacreacion; }
           set { _fechacreacion = value; }
       }

       public string Fechahoy
       {
           get { return _fechahoy; }
           set { _fechahoy = value; }
       }

       public string Simbolo
       {
           get { return _simbolo; }
           set { _simbolo = value; }
       }

       public string Valortotalemitidoenordenes
       {
           get { return _valortotalemitidoenordenes; }
           set { _valortotalemitidoenordenes = value; }
       }
    }
}
