namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
    public class LgImplOcModifAyer2
    {

        private string _estadoorden;
        private string _fechaactualizacion;
        private string _fechahoy;
        private string _simbolo;
        private string _valortotalactualenordenes;

        public LgImplOcModifAyer2()
        {
        }

        public LgImplOcModifAyer2(string tcFechahoy, string tcFechaactualizacion, string tcEstadoorden, string tcSimbolo, 
            string tcValortotalactualenordenes)
        {
            this.Fechahoy = tcFechahoy;
            this.Fechaactualizacion = tcFechaactualizacion;
            this.Estadoorden = tcEstadoorden;
            this.Simbolo = tcSimbolo;
            this.Valortotalactualenordenes = tcValortotalactualenordenes;
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

        public string Valortotalactualenordenes
        {
            get { return _valortotalactualenordenes; }
            set { _valortotalactualenordenes = value; }
        }
    }
}
