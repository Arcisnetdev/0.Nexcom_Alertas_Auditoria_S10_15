using Nexcom.Backend_Alerta_S10.Business.BusinessUtils;
using System;

namespace Nexcom.Backend_Alerta_S10.Business.BusinessObject
{
    public class ObImplControl
    {
        public static object InsertarLgImplAuditDTechoASelAll(string codrecurso, string descripcion, string simbolo, string cpedido, string proyecto, string guia, string fechaguia, string cantidadguia, string usuarioguia, string almacen, string movimiento)
        {
            return BeImplUtil.BeImplData.InsertarLgImplAuditDTechoASelAll(codrecurso, descripcion, simbolo, cpedido, proyecto, guia, fechaguia, cantidadguia, usuarioguia, almacen, movimiento);
        }

        public static object PoblarLgImplAuditDTechoASelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplAuditDTechoASelAll();
        }

        public static object PoblarLgImplAuditTechoA2SelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplAuditTechoA2SelAll();
        }

        public static object PoblarLgImplGasFacturarSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplGasFacturarSelAll();
        }

        public static object PoblarLgImplOcsFacturarSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplOcsFacturarSelAll();
        }

        public static object PoblarLgImplPedCreEnDiaSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplPedCreEnDiaSelAll();
        }

        public static object PoblarLgImplRecPedExcedenTechoSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplRecPedExcedenTechoSelAll();
        }

        public static object PoblarLgImplSegTransferenciaSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplSegTransferenciaSelAll();
        }

        public static object PoblarLgImplTechoPSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplTechoPSelAll();
        }

        public static object PoblarLgImplTechoP2SelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplTechoP2SelAll();
        }

        public static object PoblarLgImplPedApSinOc2DSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplPedApSinOc2DSelAll();
        }

        public static object PoblarLgImplOcCreadasAyerSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplOcCreadasAyerSelAll();
        }

        public static object PoblarLgImplOcCreadasAyer2SelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplOcCreadasAyer2SelAll();
        }

        public static object PoblarLgImplOcModifAyerSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplOcModifAyerSelAll();
        }

        public static object PoblarLgImplOcModifAyer2SelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplOcModifAyer2SelAll();
        }

        public static object PoblarLgImplRecApro7MoDiaSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplRecApro7MoDiaSelAll();
        }

        public static object PoblarLgImplResultOperCSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplResultOperCSelAll();
        }

        public static object PoblarLgImplResultOperDSelAll(string codproyecto, string codpresupuesto)
        {
            return BeImplUtil.BeImplData.ObtenerLgImplResultOperDSelAll(codproyecto, codpresupuesto);
        }

        public static object PoblarLgImplPrecioOrdenCompraSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplPrecioOrdenCompraSelAll();
        }

        public static object PoblarLgImplGuiaAlmacenDSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplGuiaAlmacenDSelAll();
        }

        public static object ActualizarGuiaAlmacenDTmpSelAll(string iditem)
        {
            return BeImplUtil.BeImplData.ActualizarLgImplGuiaAlmacenDSelAll(iditem);
        }

        public static object PoblarLgImplRecursoCeroNegativoSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplRecursoCeroNegativoSelAll();
        }

        public static object PoblarLgImplKardexCeroNegativoSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplKardexCeroNegativoSelAll();
        }

        public static object PoblarLgImplComedorSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplComedorSelAll();
        }

        public static object PoblarLgImplComedor2SelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplComedor2SelAll();
        }
        
        public static object PoblarLgImplComedor3SelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplComedor3SelAll();
        }
       
        public static object PoblarLgImplComedor4SelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplComedor4SelAll();
        }

        public static object PoblarLgImplVerifNroUserSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplVerifNroUserSelAll();
        }

        public static object PoblarLgImplNroProveedorSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplNroProveedorSelAll();
        }

        public static object PoblarLgImplVerifNroCcSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplVerifNroCcSelAll();
        }

        public static object PoblarLgImplVerifNroProSSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplVerifNroProSSelAll();
        }

        public static object PoblarLgImplVerifNroNDocSelAll(string usuario)
        {
            return BeImplUtil.BeImplData.ObtenerLgImplVerifNroNDocSelAll(usuario);
        }

        public static object PoblarLgImplAuditTechoRecNoPreSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplAuditTechoRecNoPreSelAll();
        }

        public static object PoblarLgImplAuditTechoProySelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplAuditTechoProySelAll();
        }

        public static object PoblarLgImplAuditRecursoS10SelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplAuditRecursoS10SelAll();
        }

        public static object PoblarLgImplSegTansferenciaGgSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplSegTansferenciaGgSelAll();
        }

        public static object PoblarLgImplSegTansferenciaGgToSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplSegTansferenciaGgToSelAll();
        }

        public static object PoblarLgImplAuditoriaSalarioPSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplAuditoriaSalarioPSelAll();
        }

        public static object ActualizarLgImplAuditoriaSalarioPSelAll(string IdItem)
        {
            return BeImplUtil.BeImplData.ActualizarLgImplAuditoriaSalarioPSelAll(IdItem);
        }

        public static object ActualizarLgImplAuditoriaVacaSelAll(string IdItem)
        {
            return BeImplUtil.BeImplData.ActualizarLgImplAuditoriaVacaSelAll(IdItem);
        }

        public static object PoblarLgImplAuditoriaVacaSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplAuditoriaVacaSelAll();
        }

        public static object InsertarLgImplCabeceraS10_To_SpringSelAll(string Proveedor, string NumeroDocumento, string TipoDocumento, string CompaniaCodigo, DateTime FechaRegistro,
            DateTime FechaDocumento, DateTime FechaRecepcion, DateTime FechaVencimiento, DateTime FechaVencimientoOriginal, string MonedaDocumento, string TipoServicio,
            decimal MontoAfecto, decimal MontoImponible, decimal MontoImpuestoVentas, decimal MontoImpuesto, decimal MontoObligacion, decimal MontoAdelantos, decimal MontoPagoParcial,
            decimal MontoCreditoFiscal, string UnidadNegocio, string UnidadReplicacion, string FlujoCaja, string CentroCostos, string OC, string ProveedorPagarA, string PagarANombre,
            string GenerarPago, string TipoPago, string MonedaPago, string IngresadoPor, string Comentarios, string ComentariosAdicional, string Usuario, string NumeroAdelanto,
            string TipoAdelanto, string CuentaAbono, string AdministradorRubro, string Contacto)
        {
            return BeImplUtil.BeImplData.InsertarLgImplCabeceraS10_To_SpringSelAll( Proveedor,  NumeroDocumento,  TipoDocumento,  CompaniaCodigo,  FechaRegistro, 
             FechaDocumento,  FechaRecepcion,  FechaVencimiento,  FechaVencimientoOriginal,  MonedaDocumento,  TipoServicio, 
             MontoAfecto,  MontoImponible,  MontoImpuestoVentas,  MontoImpuesto,  MontoObligacion,  MontoAdelantos,  MontoPagoParcial, 
             MontoCreditoFiscal,  UnidadNegocio,  UnidadReplicacion,  FlujoCaja,  CentroCostos,  OC,  ProveedorPagarA,  PagarANombre, 
             GenerarPago,  TipoPago,  MonedaPago,  IngresadoPor,  Comentarios,  ComentariosAdicional,  Usuario,  NumeroAdelanto, 
             TipoAdelanto,  CuentaAbono,  AdministradorRubro,  Contacto);
        }

        public static object InsertarLgImplDetalleS10_To_SpringSelAll(string CompaniaCodigo, string Proveedor, string TipoDocumento, string NumeroDocumento, string Linea, decimal Monto, string CuentaContable,
            string Proyecto, string CentroCosto, string Descripcion, string Personal, string Sucursal)
        {
            return BeImplUtil.BeImplData.InsertarLgImplDetalleS10_To_SpringSelAll( CompaniaCodigo,  Proveedor,  TipoDocumento,  NumeroDocumento,  Linea,  Monto,  CuentaContable, 
             Proyecto,  CentroCosto,  Descripcion,  Personal,  Sucursal);
        }

        public static object PoblarLgImplDetalleS10SelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplDetalleS10SelAll();
        }

        public static object PoblarLgImplCabeceraS10SelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplCabeceraS10SelAll();
        }

        public static object InsertarLgImplCabeceraS10_To_SpringTmp1SelAll(string Proveedor, string NumeroDocumento, string TipoDocumento, DateTime FechaRegistro, string Tipo)
        {
            return BeImplUtil.BeImplData.InsertarLgImplCabeceraS10_To_SpringTmp1SelAll(Proveedor, NumeroDocumento, TipoDocumento, FechaRegistro, Tipo);
        }

        public static object InsertarLgImplCabeceraS10_To_SpringTmp2SelAll(string Proveedor, string NumeroDocumento, string TipoDocumento, DateTime FechaRegistro, string Tipo)
        {
            return BeImplUtil.BeImplData.InsertarLgImplCabeceraS10_To_SpringTmp2SelAll(Proveedor, NumeroDocumento, TipoDocumento, FechaRegistro, Tipo);
        }

        public static object InsertarLgImplCabeceraS10_To_SpringTmp3SelAll(string Proveedor, string NumeroDocumento, string TipoDocumento, DateTime FechaRegistro, string Tipo)
        {
            return BeImplUtil.BeImplData.InsertarLgImplCabeceraS10_To_SpringTmp3SelAll(Proveedor, NumeroDocumento, TipoDocumento, FechaRegistro, Tipo);
        }

        public static object PoblarLgImplPedServApNoOSSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplPedServApNoOSSelAll();
        }

        public static object PoblarLgImplOSNoFCSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplOSNoFCSelAll();
        }

        public static object PoblarLgImplPrestamoRecursoSelAll()
        {
            return BeImplUtil.BeImplData.ObtenerLgImplPrestamoRecursoSelAll();
        }
        
        
    }
}
