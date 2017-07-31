namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
  public  class LgImplSegTansferenciaGgTo
  {
      private string _estado;
      private string _total;
     public LgImplSegTansferenciaGgTo(string tcEstado, string tcTotal)
        {
            this.Estado = tcEstado;
            this.Total = tcTotal;
        }

     public LgImplSegTansferenciaGgTo()
        {
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
  }

}
