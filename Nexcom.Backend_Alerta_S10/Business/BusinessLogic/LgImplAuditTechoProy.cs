namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
   public class LgImplAuditTechoProy
    {

       private string _codproyecto;
        private string _coduser;
        private string _descripcion;
        private string _fecha;
        private string _iditem;
        private string _ip;

        public LgImplAuditTechoProy()
        {
        }

        public LgImplAuditTechoProy(string tcIditem, string tcCoduser, string tCodproyecto, string tcDescripcion, 
            string tcIp, string tcFecha)
        {
            this.Iditem = tcIditem;
            this.Coduser = tcCoduser;
            this.Codproyecto = tCodproyecto;
            this.Descripcion = tcDescripcion;
            this.Ip = tcIp;
            this.Fecha = tcFecha;
        }

       public string Codproyecto
       {
           get { return _codproyecto; }
           set { _codproyecto = value; }
       }

       public string Coduser
       {
           get { return _coduser; }
           set { _coduser = value; }
       }

       public string Descripcion
       {
           get { return _descripcion; }
           set { _descripcion = value; }
       }

       public string Fecha
       {
           get { return _fecha; }
           set { _fecha = value; }
       }

       public string Iditem
       {
           get { return _iditem; }
           set { _iditem = value; }
       }

       public string Ip
       {
           get { return _ip; }
           set { _ip = value; }
       }
    }
}
