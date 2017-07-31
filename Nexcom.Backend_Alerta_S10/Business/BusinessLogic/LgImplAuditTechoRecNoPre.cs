
namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
   public class LgImplAuditTechoRecNoPre
    {
 
        private string _almacen;
        private string _cantidadguia;
        private string _codrecurso;
        private string _costo;
        private string _cpedido;
        private string _descripcion;
        private string _fechaguia;
        private string _guia;
        private string _movimiento;
        private string _precio;
        private string _proyecto;
        private string _simbolo;
        private string _usuarioguia;

        public LgImplAuditTechoRecNoPre()
        {
        }

        public LgImplAuditTechoRecNoPre(string tcCodrecurso, string tcDescripcion, string tcSimbolo, string tcCpedido, 
            string tcProyecto, string tcGuia, string tcFechaguia, string tcCantidadguia, string tcPrecio, string tcCosto, 
            string tcUsuarioguia, string tcAlmacen, string tcMovimiento)
        {
            this.Codrecurso = tcCodrecurso;
            this.Descripcion = tcDescripcion;
            this.Simbolo = tcSimbolo;
            this.Cpedido = tcCpedido;
            this.Proyecto = tcProyecto;
            this.Guia = tcGuia;
            this.Fechaguia = tcFechaguia;
            this.Cantidadguia = tcCantidadguia;
            this.Precio = tcPrecio;
            this.Costo = tcCosto;
            this.Usuarioguia = tcUsuarioguia;
            this.Almacen = tcAlmacen;
            this.Movimiento = tcMovimiento;
        }

       

       public string Cantidadguia
       {
           get { return _cantidadguia; }
           set { _cantidadguia = value; }
       }

       public string Codrecurso
       {
           get { return _codrecurso; }
           set { _codrecurso = value; }
       }

       public string Costo
       {
           get { return _costo; }
           set { _costo = value; }
       }

       public string Cpedido
       {
           get { return _cpedido; }
           set { _cpedido = value; }
       }

       public string Descripcion
       {
           get { return _descripcion; }
           set { _descripcion = value; }
       }

       public string Fechaguia
       {
           get { return _fechaguia; }
           set { _fechaguia = value; }
       }

       public string Guia
       {
           get { return _guia; }
           set { _guia = value; }
       }

       public string Movimiento
       {
           get { return _movimiento; }
           set { _movimiento = value; }
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

       public string Simbolo
       {
           get { return _simbolo; }
           set { _simbolo = value; }
       }

       public string Usuarioguia
       {
           get { return _usuarioguia; }
           set { _usuarioguia = value; }
       }

       public string Almacen
       {
           get { return _almacen; }
           set { _almacen = value; }
       }
    }
}
