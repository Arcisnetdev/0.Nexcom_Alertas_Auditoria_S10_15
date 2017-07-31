namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
   public class LgImplKardexCeroNegativo
    {
        private string _almacen;
        private string _almacentrans;
        private string _cantidad;
        private string _codrecurso;
        private string _fechaguia;
        private string _moneda;
        private string _movimiento;
        private string _nroguia;
        private string _precio;
        private string _proyecto;
        private string _proyectotrans;
        private string _recurso;
        private string _stockactual;
        private string _stockanterior;
        private string _unidad;

        public LgImplKardexCeroNegativo()
        {
        }

        public LgImplKardexCeroNegativo(string tcProyecto, string tcAlmacen, string tcCodrecurso, string tcRecurso, string tcUnidad, string tcFechaguia, 
            string tcNroguia, string tcMovimiento, string tcMoneda, string tcCantidad, string tcStockactual, string tcStOckanterior, string tcPrecio, 
            string tcProyectotrans, string tcAlmacentrans)
        {
            this.Proyecto = tcProyecto;
            this.Almacen = tcAlmacen;
            this.Codrecurso = tcCodrecurso;
            this.Recurso = tcRecurso;
            this.Unidad = tcUnidad;
            this.Fechaguia = tcFechaguia;
            this.Nroguia = tcNroguia;
            this.Movimiento = tcMovimiento;
            this.Moneda = tcMoneda;
            this.Cantidad = tcCantidad;
            this.Stockactual = tcStockactual;
            this.Stockanterior = tcStOckanterior;
            this.Precio = tcPrecio;
            this.Proyectotrans = tcProyectotrans;
            this.Almacentrans = tcAlmacentrans;
        }

       public string Almacen
       {
           get { return _almacen; }
           set { _almacen = value; }
       }

       public string Almacentrans
       {
           get { return _almacentrans; }
           set { _almacentrans = value; }
       }

       public string Cantidad
       {
           get { return _cantidad; }
           set { _cantidad = value; }
       }

       public string Codrecurso
       {
           get { return _codrecurso; }
           set { _codrecurso = value; }
       }

       public string Fechaguia
       {
           get { return _fechaguia; }
           set { _fechaguia = value; }
       }

       public string Moneda
       {
           get { return _moneda; }
           set { _moneda = value; }
       }

       public string Movimiento
       {
           get { return _movimiento; }
           set { _movimiento = value; }
       }

       public string Nroguia
       {
           get { return _nroguia; }
           set { _nroguia = value; }
       }

       public string Precio
       {
           get { return _precio; }
           set { _precio = value; }
       }

       public string Proyecto
       {
           get { return _proyecto; }
           set { _proyecto = value; }
       }

       public string Proyectotrans
       {
           get { return _proyectotrans; }
           set { _proyectotrans = value; }
       }

       public string Recurso
       {
           get { return _recurso; }
           set { _recurso = value; }
       }

       public string Stockactual
       {
           get { return _stockactual; }
           set { _stockactual = value; }
       }

       public string Stockanterior
       {
           get { return _stockanterior; }
           set { _stockanterior = value; }
       }

       public string Unidad
       {
           get { return _unidad; }
           set { _unidad = value; }
       }
    }
}
