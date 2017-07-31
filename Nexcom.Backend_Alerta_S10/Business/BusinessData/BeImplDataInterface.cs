using Nexcom.Backend_Alerta_S10.Business.BusinessLogic;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogicCom;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogicMasivoC;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogicRO;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogicSalary;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogicPedServ;

namespace Nexcom.Backend_Alerta_S10.Business.BusinessData
{
    using Microsoft.Practices.EnterpriseLibrary.Data;
    using Nexcom.Backend_Alerta_S10.Business.BusinessLogicS10;
    using System;

    public abstract class BeImplDataInterface
    {
        protected BeImplDataInterface()
        {
        }

        public abstract bool InsertarLgImplAuditDTechoASelAll(string codrecurso, string descripcion, string simbolo, string cpedido, string proyecto, string guia, string fechaguia, string cantidadguia, string usuarioguia, string almacen, string movimiento);
        public abstract LgImplPrestamoRecursos ObtenerLgImplPrestamoRecursoSelAll(); //Prestamos de recursos entre proyectos
        public abstract LgImplPedServApNoOSs ObtenerLgImplPedServApNoOSSelAll();
        public abstract LgImplOSNoFCs ObtenerLgImplOSNoFCSelAll();     
        public abstract LgImplAuditDTechoAs ObtenerLgImplAuditDTechoASelAll(); //Auditoria Techo Presupuestado
        public abstract LgImplAuditTechoA2s ObtenerLgImplAuditTechoA2SelAll(); //Auditoria Techo Presupuestado
        public abstract LgImplGasFacturars ObtenerLgImplGasFacturarSelAll(); //Guias de Almacen pendientes de regularizacion con factura
        public abstract LgImplOcsFacturars ObtenerLgImplOcsFacturarSelAll(); //Ordenes de compra o Servicio pendientes de facturar
        public abstract LgImplPedCreEnDias ObtenerLgImplPedCreEnDiaSelAll(); //Pedidos creados en el dia
        public abstract LgImplRecPedExcedenTechos ObtenerLgImplRecPedExcedenTechoSelAll();
        public abstract LgImplSegTransferencias ObtenerLgImplSegTransferenciaSelAll();
        public abstract LgImplTechoP2s ObtenerLgImplTechoP2SelAll();
        public abstract LgImplTechoPs ObtenerLgImplTechoPSelAll();
        public abstract LgImplPedApSinOc2Ds ObtenerLgImplPedApSinOc2DSelAll();
        public abstract LgImplOcCreadasAyers ObtenerLgImplOcCreadasAyerSelAll();
        public abstract LgImplOcCreadasAyer2s ObtenerLgImplOcCreadasAyer2SelAll();
        public abstract LgImplOcModifAyers ObtenerLgImplOcModifAyerSelAll();
        public abstract LgImplOcModifAyer2s ObtenerLgImplOcModifAyer2SelAll();
        public abstract LgImplRecApro7moDias ObtenerLgImplRecApro7MoDiaSelAll();
        public abstract LgImplResultOperCs ObtenerLgImplResultOperCSelAll();
        public abstract LgImplResultOperDs ObtenerLgImplResultOperDSelAll(string codproyecto, string codpresupuesto);
        public abstract LgImplPrecioOrdenCompras ObtenerLgImplPrecioOrdenCompraSelAll();
        public abstract LgImplGuiaAlmacenDs ObtenerLgImplGuiaAlmacenDSelAll();
        public abstract bool ActualizarLgImplGuiaAlmacenDSelAll(string iditem);
        public abstract LgImplRecursoCeroNegativos ObtenerLgImplRecursoCeroNegativoSelAll();
        public abstract LgImplKardexCeroNegativos ObtenerLgImplKardexCeroNegativoSelAll();
        public abstract LgImplComedors ObtenerLgImplComedorSelAll();
        public abstract LgImplComedor2s ObtenerLgImplComedor2SelAll();
        public abstract LgImplComedor3s ObtenerLgImplComedor3SelAll();
        public abstract LgImplComedor4s ObtenerLgImplComedor4SelAll();
        public abstract LgImplVerifNroUsers ObtenerLgImplVerifNroUserSelAll();
        public abstract LgImplVerifNroProveedors ObtenerLgImplNroProveedorSelAll();
        public abstract LgImplVerifNroCcs ObtenerLgImplVerifNroCcSelAll();
        public abstract LgImplVerifNroProSs ObtenerLgImplVerifNroProSSelAll();
        public abstract LgImplVerifNroNDocs ObtenerLgImplVerifNroNDocSelAll(string usuario);
        public abstract LgImplAuditTechoRecNoPres ObtenerLgImplAuditTechoRecNoPreSelAll();
        public abstract LgImplAuditTechoProys ObtenerLgImplAuditTechoProySelAll();
        public abstract LgImplAuditRecursoS10s ObtenerLgImplAuditRecursoS10SelAll();
        public abstract LgImplSegTansferenciaGgs ObtenerLgImplSegTansferenciaGgSelAll();
        public abstract LgImplSegTansferenciaGgTos ObtenerLgImplSegTansferenciaGgToSelAll();
        public abstract LgImplAuditoriaPs ObtenerLgImplAuditoriaSalarioPSelAll();
        public abstract bool ActualizarLgImplAuditoriaSalarioPSelAll(string IdItem);
        public abstract bool ActualizarLgImplAuditoriaVacaSelAll(string IDITEM);
        public abstract LgImplAuditoriaVacas ObtenerLgImplAuditoriaVacaSelAll();
        public abstract bool InsertarLgImplCabeceraS10_To_SpringSelAll(string Proveedor, string NumeroDocumento, string TipoDocumento, string CompaniaCodigo, DateTime FechaRegistro,
            DateTime FechaDocumento, DateTime FechaRecepcion, DateTime FechaVencimiento, DateTime FechaVencimientoOriginal, string MonedaDocumento, string TipoServicio,
            decimal MontoAfecto, decimal MontoImponible, decimal MontoImpuestoVentas, decimal MontoImpuesto, decimal MontoObligacion, decimal MontoAdelantos, decimal MontoPagoParcial,
            decimal MontoCreditoFiscal, string UnidadNegocio, string UnidadReplicacion, string FlujoCaja, string CentroCostos, string OC, string ProveedorPagarA, string PagarANombre,
            string GenerarPago, string TipoPago, string MonedaPago, string IngresadoPor, string Comentarios, string ComentariosAdicional, string Usuario, string NumeroAdelanto,
            string TipoAdelanto, string CuentaAbono, string AdministradorRubro, string Contacto);
        public abstract bool InsertarLgImplDetalleS10_To_SpringSelAll(string CompaniaCodigo, string Proveedor, string TipoDocumento, string NumeroDocumento, string Linea, decimal Monto, string CuentaContable,
            string Proyecto, string CentroCosto, string Descripcion, string Personal, string Sucursal);
        public abstract bool InsertarLgImplCabeceraS10_To_SpringTmp1SelAll(string Proveedor, string NumeroDocumento, string TipoDocumento, DateTime FechaRegistro, string Tipo);
        public abstract bool InsertarLgImplCabeceraS10_To_SpringTmp2SelAll(string Proveedor, string NumeroDocumento, string TipoDocumento, DateTime FechaRegistro, string Tipo);
        public abstract bool InsertarLgImplCabeceraS10_To_SpringTmp3SelAll(string Proveedor, string NumeroDocumento, string TipoDocumento, DateTime FechaRegistro, string Tipo);
        public abstract LgImplDetalleS10s ObtenerLgImplDetalleS10SelAll();
        public abstract LgImplCabeceraS10s ObtenerLgImplCabeceraS10SelAll();
        
        public abstract Database BaseReportes { get; }
        public abstract Database BaseWeb { get; }
        public abstract Database BaseRegomsa { get; }
        public abstract Database BaseS10 { get; }
        public abstract Database BaseSpring { get; }
      
    }
}
