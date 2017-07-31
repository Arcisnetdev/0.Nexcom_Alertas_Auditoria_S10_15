namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogicCom
{
   public class LgImplComedor3
    {

        private string _cantidad;
        private string _comida;
        private string _nombrecompleto;

        public LgImplComedor3()
        {
        }

        public LgImplComedor3(string tcNombrecompleto, string tcComida, string tcCantidad)
        {
            this.Nombrecompleto = tcNombrecompleto;
            this.Comida = tcComida;
            this.Cantidad = tcCantidad;
        }

       public string Cantidad
       {
           get { return _cantidad; }
           set { _cantidad = value; }
       }

       public string Comida
       {
           get { return _comida; }
           set { _comida = value; }
       }

       public string Nombrecompleto
       {
           get { return _nombrecompleto; }
           set { _nombrecompleto = value; }
       }
    }
}
