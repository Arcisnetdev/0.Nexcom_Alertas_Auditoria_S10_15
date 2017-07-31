namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
   public class LgImplRecursoCeroNegativo
    {

         private string _actualizacionfecha;
        private string _actualizacionusuario;
        private string _almacen;
        private string _cantidad;
        private string _codrecurso;
        private string _creacionfecha;
        private string _fechaguia;
        private string _movimiento;
        private string _nroguia;
        private string _precio;
        private string _proyecto;
        private string _recurso;
        private string _unidad;
        private string _usuariocreador;
        private string _usuariomodificador;
        private string _usuarioregistrador;

        public LgImplRecursoCeroNegativo()
        {
        }

        public LgImplRecursoCeroNegativo(string tcProyecto, string tcAlmacen, string tcMovimiento, string tcFechaguia, string tcNroguia, string tcCodrecurso, 
            string tcRecurso, string tcUnidad, string tcCantidad, string tcPrecio, string tcUsuariomodificador, string tcUsuarioregistrador, string tcUsuariocreador, 
            string tcActualizacionusuario, string tcCreacionfecha, string tcActualizacionfecha)
        {
            this.Proyecto = tcProyecto;
            this.Almacen = tcAlmacen;
            this.Movimiento = tcMovimiento;
            this.Fechaguia = tcFechaguia;
            this.Nroguia = tcNroguia;
            this.Codrecurso = tcCodrecurso;
            this.Recurso = tcRecurso;
            this.Unidad = tcUnidad;
            this.Cantidad = tcCantidad;
            this.Precio = tcPrecio;
            this.Usuariomodificador = tcUsuariomodificador;
            this.Usuarioregistrador = tcUsuarioregistrador;
            this.Usuariocreador = tcUsuariocreador;
            this.Actualizacionusuario = tcActualizacionusuario;
            this.Creacionfecha = tcCreacionfecha;
            this.Actualizacionfecha = tcActualizacionfecha;
        }


       public string Actualizacionfecha
       {
           get { return _actualizacionfecha; }
           set { _actualizacionfecha = value; }
       }

       public string Actualizacionusuario
       {
           get { return _actualizacionusuario; }
           set { _actualizacionusuario = value; }
       }

       public string Almacen
       {
           get { return _almacen; }
           set { _almacen = value; }
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

       public string Creacionfecha
       {
           get { return _creacionfecha; }
           set { _creacionfecha = value; }
       }

       public string Fechaguia
       {
           get { return _fechaguia; }
           set { _fechaguia = value; }
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

       public string Recurso
       {
           get { return _recurso; }
           set { _recurso = value; }
       }

       public string Unidad
       {
           get { return _unidad; }
           set { _unidad = value; }
       }

       public string Usuariocreador
       {
           get { return _usuariocreador; }
           set { _usuariocreador = value; }
       }

       public string Usuariomodificador
       {
           get { return _usuariomodificador; }
           set { _usuariomodificador = value; }
       }

       public string Usuarioregistrador
       {
           get { return _usuarioregistrador; }
           set { _usuarioregistrador = value; }
       }
    }
}
