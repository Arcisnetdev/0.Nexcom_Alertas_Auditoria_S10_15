namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
   public class LgImplSegTansferenciaGg
    {
        private string _codigo;
        private string _proyecto;
        private string _estado;
        private string _total;
       private string _destino;

        public LgImplSegTansferenciaGg( string tcProyecto, string tcEstado, string tcTotal, string tcDestino)
        {
                        this.Proyecto = tcProyecto;
            this.Estado = tcEstado;
            this.Total = tcTotal;
            this.Destino = tcDestino;
        }
      
       public LgImplSegTansferenciaGg()
        {
        }

   
       public string Proyecto
       {
           get { return _proyecto; }
           set { _proyecto = value; }
       }

       public string Estado
       {
           get { return _estado; }
           set { _estado = value; }
       }

       public string Total
       {
           get { return _total; }
           set { _total = value; }
       }

       public string Destino
       {
           get { return _destino; }
           set { _destino = value; }
       }
    }

}
