
namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogicPedServ
{
    public class LgImplPrestamoRecurso
    {
        private string _proyecto;
        private string _movimiento;
        private string _parcial;
        private string _proyorigen;
        private string _ano;
        private string _mes;

        public LgImplPrestamoRecurso()
        {
        }

        public LgImplPrestamoRecurso(string tcProy, string tcMovimiento, string tcParcial, string tcPOrigen, string tcAno, string tcMes)
        {
            this._proyecto = tcProy;
            this._movimiento = tcMovimiento;
            this._parcial = tcParcial;
            this._proyorigen = tcPOrigen;
            this._ano = tcAno;
            this._mes = tcMes;
        }

        public string Proyecto
        {
            get { return _proyecto; }
            set { _proyecto = value; }
        }

        public string Movimiento
        {
            get { return _movimiento; }
            set { _movimiento = value; }
        }

        public string Parcial
        {
            get { return _parcial; }
            set { _parcial = value; }
        }

        public string Proyorigen
        {
            get { return _proyorigen; }
            set { _proyorigen = value; }
        }

        public string Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }

        public string Mes
        {
            get { return _mes; }
            set { _mes = value; }
        }


    }
}
