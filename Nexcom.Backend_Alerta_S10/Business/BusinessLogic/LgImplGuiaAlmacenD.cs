
namespace Nexcom.Backend_Alerta_S10.Business.BusinessLogic
{
   public class LgImplGuiaAlmacenD
   {
       private string _abreviatura;
        private string _af;
        private string _almacen;
        private string _au;
        private string _cantidad;
        private string _cf;
        private string _codguia;
        private string _codinsumo;
        private string _cu;
        private string _estado;
        private string _fecha;
        private string _fechaguia;
        private string _iditem;
        private string _insumo;
        private string _ip;
        private string _moneda;
        private string _parcial;
        private string _precio;
        private string _proyecto;
        private string _unidad;
        private string _usuario;

        public LgImplGuiaAlmacenD()
        {
        }

        public LgImplGuiaAlmacenD(string tcIditem, string tcEstado, string tcUsuario, string tcIp, string tcFecha, string tcProyecto, string tcAlmacen, 
            string tcCodinsumo, string tcInsumo, string tcUnidad, string tcAbreviatura, string tcCodguia, string tcFechaguia, string tcCantidad,
            string tcPrecio, string tcMoneda, string tcParcia, string tcCu, string tcCf, string tcAu, string tcAf)
        {
            this.Iditem = tcIditem;
            this.Estado = tcEstado;
            this.Usuario = tcUsuario;
            this.Ip = tcIp;
            this.Fecha = tcFecha;
            this.Proyecto = tcProyecto;
            this.Almacen = tcAlmacen;
            this.Codinsumo = tcCodinsumo;
            this.Insumo = tcInsumo;
            this.Unidad = tcUnidad;
            this.Abreviatura = tcAbreviatura;
            this.Codguia = tcCodguia;
            this.Fechaguia = tcFechaguia;
            this.Cantidad = tcCantidad;
            this.Precio = tcPrecio;
            this.Moneda = tcMoneda;
            this.Parcial = tcParcia;
            this.Cu = tcCu;
            this.Cf = tcCf;
            this.Au = tcAu;
            this.Af = tcAf;
        }

       public string Abreviatura
       {
           get { return _abreviatura; }
           set { _abreviatura = value; }
       }

       public string Af
       {
           get { return _af; }
           set { _af = value; }
       }

       public string Almacen
       {
           get { return _almacen; }
           set { _almacen = value; }
       }

       public string Au
       {
           get { return _au; }
           set { _au = value; }
       }

       public string Cantidad
       {
           get { return _cantidad; }
           set { _cantidad = value; }
       }

       public string Cf
       {
           get { return _cf; }
           set { _cf = value; }
       }

       public string Codguia
       {
           get { return _codguia; }
           set { _codguia = value; }
       }

       public string Codinsumo
       {
           get { return _codinsumo; }
           set { _codinsumo = value; }
       }

       public string Cu
       {
           get { return _cu; }
           set { _cu = value; }
       }

       public string Estado
       {
           get { return _estado; }
           set { _estado = value; }
       }

       public string Fecha
       {
           get { return _fecha; }
           set { _fecha = value; }
       }

       public string Fechaguia
       {
           get { return _fechaguia; }
           set { _fechaguia = value; }
       }

       public string Iditem
       {
           get { return _iditem; }
           set { _iditem = value; }
       }

       public string Insumo
       {
           get { return _insumo; }
           set { _insumo = value; }
       }

       public string Ip
       {
           get { return _ip; }
           set { _ip = value; }
       }

       public string Moneda
       {
           get { return _moneda; }
           set { _moneda = value; }
       }

       public string Parcial
       {
           get { return _parcial; }
           set { _parcial = value; }
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

       public string Unidad
       {
           get { return _unidad; }
           set { _unidad = value; }
       }

       public string Usuario
       {
           get { return _usuario; }
           set { _usuario = value; }
       }

   }
}
