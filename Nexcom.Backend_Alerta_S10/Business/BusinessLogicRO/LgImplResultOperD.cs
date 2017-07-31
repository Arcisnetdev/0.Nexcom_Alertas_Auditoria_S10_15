namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogicRO
{
   public class LgImplResultOperD
    {
       private string _grupo;
        private string _presupuesto;
        private string _programado;
        private string _reall;
        private string _recurso;
        private string _valorizado;

        public LgImplResultOperD()
        {
        }

        public LgImplResultOperD(string tcGrupo, string tcRecurso, string tcPresupuesto, string tcProgramado, string tcValorizado, string tcReall)
        {
            this.Grupo = tcGrupo;
            this.Recurso = tcRecurso;
            this.Presupuesto = tcPresupuesto;
            this.Programado = tcProgramado;
            this.Valorizado = tcValorizado;
            this.Reall = tcReall;
        }


       public string Grupo
       {
           get { return _grupo; }
           set { _grupo = value; }
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

       public string Recurso
       {
           get { return _recurso; }
           set { _recurso = value; }
       }

       public string Valorizado
       {
           get { return _valorizado; }
           set { _valorizado = value; }
       }
    }
}
