namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
   public class LgImplAuditRecursoS10
    {
        private string _accion;
        private string _activos;
        private string _codinsumo;
        private string _consumod;
        private string _consumoh;
        private string _descripcion;
        private string _familia1;
        private string _familia2;
        private string _fecha;
        private string _iditem;
        private string _ip;
        private string _login;
        private string _materiales;
        private string _nivel;
        private string _nivelp;
        private string _servicioa;
        private string _servicioc;
        private string _servicioo;

        public LgImplAuditRecursoS10()
        {
        }

        public LgImplAuditRecursoS10(string tcIditem, string tcCodinsumo, string tcNivel, string tcDescripcion, string tcNivelp,
            string tcFamilia1, string tcFamilia2, string tcMateriales, string tcActivos, string tcServicioo, string tcServicioa, 
            string tcServicioc, string tcConsumod, string tcConsumoh, string tcAccion, string tcLogin, string tcIp, string tcFecha)
        {
            this.Iditem = tcIditem;
            this.Codinsumo = tcCodinsumo;
            this.Nivel = tcNivel;
            this.Descripcion = tcDescripcion;
            this.Nivelp = tcNivelp;
            this.Familia1 = tcFamilia1;
            this.Familia2 = tcFamilia2;
            this.Materiales = tcMateriales;
            this.Activos = tcActivos;
            this.Servicioo = tcServicioo;
            this.Servicioa = tcServicioa;
            this.Servicioc = tcServicioc;
            this.Consumod = tcConsumod;
            this.Consumoh = tcConsumoh;
            this.Accion = tcAccion;
            this.Login = tcLogin;
            this.Ip = tcIp;
            this.Fecha = tcFecha;
        }

       public string Accion
       {
           get { return _accion; }
           set { _accion = value; }
       }

       public string Activos
       {
           get { return _activos; }
           set { _activos = value; }
       }

       public string Codinsumo
       {
           get { return _codinsumo; }
           set { _codinsumo = value; }
       }

       public string Consumod
       {
           get { return _consumod; }
           set { _consumod = value; }
       }

       public string Consumoh
       {
           get { return _consumoh; }
           set { _consumoh = value; }
       }

       public string Descripcion
       {
           get { return _descripcion; }
           set { _descripcion = value; }
       }

       public string Familia1
       {
           get { return _familia1; }
           set { _familia1 = value; }
       }

       public string Familia2
       {
           get { return _familia2; }
           set { _familia2 = value; }
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

       public string Login
       {
           get { return _login; }
           set { _login = value; }
       }

       public string Materiales
       {
           get { return _materiales; }
           set { _materiales = value; }
       }

       public string Nivel
       {
           get { return _nivel; }
           set { _nivel = value; }
       }

       public string Nivelp
       {
           get { return _nivelp; }
           set { _nivelp = value; }
       }

       public string Servicioa
       {
           get { return _servicioa; }
           set { _servicioa = value; }
       }

       public string Servicioc
       {
           get { return _servicioc; }
           set { _servicioc = value; }
       }

       public string Servicioo
       {
           get { return _servicioo; }
           set { _servicioo = value; }
       }
    }
}
