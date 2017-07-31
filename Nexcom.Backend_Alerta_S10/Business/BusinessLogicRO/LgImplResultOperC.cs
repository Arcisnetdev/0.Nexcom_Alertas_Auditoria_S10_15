namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogicRO
{
  public  class LgImplResultOperC
    {
       private string _codpresupuesto;
        private string _codproyecto;
        private string _desPresupuesto;
        private string _desProyecto;
        private string _presupuesto;
        private string _programado;
        private string _reall;
        private string _tipopresupuesto;
        private string _valorizado;

        public LgImplResultOperC()
        {
        }

        public LgImplResultOperC(string tcCodproyecto, string tcDesProyecto, string tcTipopresupuesto, string tcCodpresupuesto,
            string tcDesPresupuesto, string tcPresupuesto, string tcProgramado, string tcValorizado, string tcReall)
        {
            this.Codproyecto = tcCodproyecto;
            this.DesProyecto = tcDesProyecto;
            this.Tipopresupuesto = tcTipopresupuesto;
            this.Codpresupuesto = tcCodpresupuesto;
            this.DesPresupuesto = tcDesPresupuesto;
            this.Presupuesto = tcPresupuesto;
            this.Programado = tcProgramado;
            this.Valorizado = tcValorizado;
            this.Reall = tcReall;
        }

      public string Codpresupuesto
      {
          get { return _codpresupuesto; }
          set { _codpresupuesto = value; }
      }

      public string Codproyecto
      {
          get { return _codproyecto; }
          set { _codproyecto = value; }
      }

      public string DesPresupuesto
      {
          get { return _desPresupuesto; }
          set { _desPresupuesto = value; }
      }

      public string DesProyecto
      {
          get { return _desProyecto; }
          set { _desProyecto = value; }
      }

      public string Presupuesto
      {
          get { return _presupuesto; }
          set { _presupuesto = value; }
      }

      public string Programado
      {
          get { return _programado; }
          set { _programado = value; }
      }

      public string Reall
      {
          get { return _reall; }
          set { _reall = value; }
      }

      public string Tipopresupuesto
      {
          get { return _tipopresupuesto; }
          set { _tipopresupuesto = value; }
      }

      public string Valorizado
      {
          get { return _valorizado; }
          set { _valorizado = value; }
      }
    }
}
