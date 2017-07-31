using Nexcom.Backend_Alerta_S10.Business.BusinessLogic;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogicCom;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogicMasivoC;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogicRO;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogicSalary;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogicPedServ;

namespace Nexcom.Backend_Alerta_S10.Business.BusinessData
{
    using Microsoft.Practices.EnterpriseLibrary.Data;
    using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
    using Nexcom.Backend_Alerta_S10.Business.BusinessLogicS10;
    using System;
    using System.Data;
    using System.Data.Common;
    using System.Data.SqlClient;


    public class BeImplData : BeImplDataInterface
    {
        private static Database _baseReportes;
        private static Database _baseWeb;
        private static Database _baseSpring;
        private static Database _baseS10;
        private static Database _baseRegomsa;

        public override bool InsertarLgImplAuditDTechoASelAll(string codrecurso, string descripcion, string simbolo, string cpedido, string proyecto, string guia, string fechaguia, string cantidadguia, string usuarioguia, string almacen, string movimiento)
        {
            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.SNp_AP_InsertarDetalleTechoA");
            this.BaseReportes.AddInParameter(storedProcCommand, "@pCODRECURSO", DbType.String, codrecurso);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pDESCRIPCION", DbType.String, descripcion);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pSIMBOLO", DbType.String, simbolo);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pCPEDIDO", DbType.String, cpedido);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pPROYECTO", DbType.String, proyecto);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pGUIA", DbType.String, guia);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pFECHAGUIA", DbType.String, fechaguia);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pCANTIDADGUIA", DbType.String, cantidadguia);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pUSUARIOGUIA", DbType.String, usuarioguia);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pALMACEN", DbType.String, almacen);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pMOVIMIENTO", DbType.String, movimiento);
            try
            {
                if (this.BaseReportes.ExecuteNonQuery(storedProcCommand) > 0)
                {
                    return true;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return false;
        }

        public override LgImplAuditDTechoAs ObtenerLgImplAuditDTechoASelAll()
        {
            LgImplAuditDTechoAs as2 = new LgImplAuditDTechoAs();
            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.Auditoria_Detalle_TechoA");
            using (SqlDataReader reader = (SqlDataReader)this.BaseReportes.ExecuteReader(storedProcCommand))
            {
                while (reader.Read())
                {
                    LgImplAuditDTechoA item = new LgImplAuditDTechoA(Convert.ToString(reader["CODRECURSO"]), Convert.ToString(reader["DESCRIPCION"]), Convert.ToString(reader["SIMBOLO"]), Convert.ToString(reader["CPEDIDO"]), Convert.ToString(reader["PROYECTO"]), Convert.ToString(reader["GUIA"]), Convert.ToString(reader["FECHAGUIA"]), Convert.ToString(reader["CANTIDADGUIA"]), Convert.ToString(reader["USUARIOGUIA"]), Convert.ToString(reader["ALMACEN"]), Convert.ToString(reader["MOVIMIENTO"]));
                    as2.Add(item);
                }
            }
            return as2;
        }

        public override LgImplAuditTechoA2s ObtenerLgImplAuditTechoA2SelAll()
        {
            LgImplAuditTechoA2s techos = new LgImplAuditTechoA2s();
            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.Auditoria_Techo2");
            using (SqlDataReader reader = (SqlDataReader)this.BaseReportes.ExecuteReader(storedProcCommand))
            {
                while (reader.Read())
                {
                    LgImplAuditTechoA2 item = new LgImplAuditTechoA2(Convert.ToString(reader["PROYECTO"]), Convert.ToString(reader["CODRECURSO"]), Convert.ToString(reader["DESCRIPCION"]), Convert.ToString(reader["SIMBOLO"]), Convert.ToString(reader["TECHO"]), Convert.ToString(reader["CPEDIDO"]), Convert.ToString(reader["CALMACEN"]), Convert.ToString(reader["CPEDIR"]), Convert.ToString(reader["FECHAGUIA"]), Convert.ToString(reader["GUIA"]), Convert.ToString(reader["ALMACEN"]), Convert.ToString(reader["PRECIO"]), Convert.ToString(reader["COSTO"]), Convert.ToString(reader["MOVIMIENTO"]), Convert.ToString(reader["CANTIDADGUIA"]), Convert.ToString(reader["USUARIOGUIA"]));
                    techos.Add(item);
                }
            }
            return techos;
        }

        public override LgImplGasFacturars ObtenerLgImplGasFacturarSelAll()
        {
            LgImplGasFacturars facturars = new LgImplGasFacturars();
            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.S10_GuiasSinFacturar");
            using (SqlDataReader reader = (SqlDataReader)this.BaseReportes.ExecuteReader(storedProcCommand))
            {
                while (reader.Read())
                {
                    LgImplGasFacturar item = new LgImplGasFacturar(Convert.ToString(reader["PROYECTO"]), Convert.ToString(reader["NROOC"]), Convert.ToString(reader["ALMACEN"]), Convert.ToString(reader["CODGUIA"]), Convert.ToString(reader["FECHAGUIA"]), Convert.ToString(reader["NROGUIAREMISION"]), Convert.ToString(reader["PROVEEDOR"]));
                    facturars.Add(item);
                }
            }
            return facturars;
        }

        public override LgImplOcsFacturars ObtenerLgImplOcsFacturarSelAll()
        {
            LgImplOcsFacturars facturars = new LgImplOcsFacturars();
            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.S10_OrdenCompraSinFacturar");
            using (SqlDataReader reader = (SqlDataReader)this.BaseReportes.ExecuteReader(storedProcCommand))
            {
                while (reader.Read())
                {
                    LgImplOcsFacturar item = new LgImplOcsFacturar(Convert.ToString(reader["PROYECTO"]), Convert.ToString(reader["CODORDEN"]), Convert.ToString(reader["TIPOORDEN"]), Convert.ToString(reader["CODPROVEEDOR"]), Convert.ToString(reader["PROVEEDOR"]), Convert.ToString(reader["CODINSUMO"]), Convert.ToString(reader["RECURSO"]), Convert.ToString(reader["UNIDAD"]), Convert.ToString(reader["CANTIDAD"]), Convert.ToString(reader["PRECIO"]), Convert.ToString(reader["TOTAL"]));
                    facturars.Add(item);
                }
            }
            return facturars;
        }

        public override LgImplPedCreEnDias ObtenerLgImplPedCreEnDiaSelAll()
        {
            LgImplPedCreEnDias dias = new LgImplPedCreEnDias();
            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.Control2");
            using (SqlDataReader reader = (SqlDataReader)this.BaseReportes.ExecuteReader(storedProcCommand))
            {
                while (reader.Read())
                {
                    LgImplPedCreEnDia item = new LgImplPedCreEnDia(Convert.ToString(reader["PROY"]), Convert.ToString(reader["ALM"]), Convert.ToString(reader["TPED"]), Convert.ToString(reader["EPED"]), Convert.ToString(reader["NPEDM"]), Convert.ToString(reader["CODREC"]), Convert.ToString(reader["REC"]), Convert.ToString(reader["UN"]), Convert.ToString(reader["CPED"]), Convert.ToString(reader["OBSPED"]), Convert.ToString(reader["FPED"]), Convert.ToString(reader["FAPR"]), Convert.ToString(reader["USREG"]), Convert.ToString(reader["USAPRO"]), Convert.ToString(reader["ESTOR"]), Convert.ToString(reader["ESTAL"]), Convert.ToString(reader["ESTCOT"]));
                    dias.Add(item);
                }
            }
            return dias;
        }

        public override LgImplRecPedExcedenTechos ObtenerLgImplRecPedExcedenTechoSelAll()
        {
            LgImplRecPedExcedenTechos techos = new LgImplRecPedExcedenTechos();
            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.Control1");
            using (SqlDataReader reader = (SqlDataReader)this.BaseReportes.ExecuteReader(storedProcCommand))
            {
                while (reader.Read())
                {
                    LgImplRecPedExcedenTecho item = new LgImplRecPedExcedenTecho(Convert.ToString(reader["PROY"]), Convert.ToString(reader["ALM"]), Convert.ToString(reader["TPED"]), Convert.ToString(reader["EPED"]), Convert.ToString(reader["NPEDM"]), Convert.ToString(reader["CODREC"]), Convert.ToString(reader["REC"]), Convert.ToString(reader["UN"]), Convert.ToString(reader["CPED"]), Convert.ToString(reader["CTEC"]), Convert.ToString(reader["EXTEC"]), Convert.ToString(reader["CXPED"]), Convert.ToString(reader["OBSPED"]), Convert.ToString(reader["FPED"]), Convert.ToString(reader["FAPR"]), Convert.ToString(reader["USREG"]), Convert.ToString(reader["USAPRO"]), Convert.ToString(reader["ESTOR"]), Convert.ToString(reader["ESTAL"]), Convert.ToString(reader["ESTCOT"]));
                    techos.Add(item);
                }
            }
            return techos;
        }

        public override LgImplSegTransferencias ObtenerLgImplSegTransferenciaSelAll()
        {
            LgImplSegTransferencias transferencias = new LgImplSegTransferencias();
            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.S10_Almacenes_009_03_ETE_ETEP_Seguimiento");
            using (SqlDataReader reader = (SqlDataReader)this.BaseReportes.ExecuteReader(storedProcCommand))
            {
                while (reader.Read())
                {
                    LgImplSegTransferencia item = new LgImplSegTransferencia(Convert.ToString(reader["Proyecto"]), Convert.ToString(reader["Almacen"]), Convert.ToString(reader["CodGuia"]), Convert.ToString(reader["FechaGuia"]), Convert.ToString(reader["SerieDocumento"]), Convert.ToString(reader["NroDocumento"]), Convert.ToString(reader["MovimientoOrigen"]), Convert.ToString(reader["EstadoCierre"]), Convert.ToString(reader["Simbolo"]), Convert.ToString(reader["TipoCambio"]), Convert.ToString(reader["Parcial"]), Convert.ToString(reader["Igv"]), Convert.ToString(reader["Total"]), Convert.ToString(reader["CodPedido"]), Convert.ToString(reader["ProyectoDestino"]), Convert.ToString(reader["CodGuiaRelacion"]), Convert.ToString(reader["CreacionUsuario"]), Convert.ToString(reader["CreacionFecha"]), Convert.ToString(reader["ActualizacionUsuario"]), Convert.ToString(reader["ActualizacionFecha"]), Convert.ToString(reader["Ano"]), Convert.ToString(reader["CodRecurso"]), Convert.ToString(reader["Recurso"]));
                    transferencias.Add(item);
                }
            }
            return transferencias;
        }

        public override LgImplTechoP2s ObtenerLgImplTechoP2SelAll()
        {
            LgImplTechoP2s ops = new LgImplTechoP2s();
            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.Control10");
            using (SqlDataReader reader = (SqlDataReader)this.BaseReportes.ExecuteReader(storedProcCommand))
            {
                while (reader.Read())
                {
                    LgImplTechoP2 item = new LgImplTechoP2(Convert.ToString(reader["S_EX_PPTO"]), Convert.ToString(reader["S_EX_MA"]), Convert.ToString(reader["S_EX_SC"]), Convert.ToString(reader["S_EX_EQ"]), Convert.ToString(reader["S_EX_MO"]));
                    ops.Add(item);
                }
            }
            return ops;
        }

        public override LgImplTechoPs ObtenerLgImplTechoPSelAll()
        {
            LgImplTechoPs ps = new LgImplTechoPs();
            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.Control9");
            using (SqlDataReader reader = (SqlDataReader)this.BaseReportes.ExecuteReader(storedProcCommand))
            {
                while (reader.Read())
                {
                    LgImplTechoP item = new LgImplTechoP(Convert.ToString(reader["CODPROYECTO"]), Convert.ToString(reader["ESTADOPROYECTO"]), Convert.ToString(reader["PROYECTO"]), Convert.ToString(reader["EXCEDENTE_PRESUPUESTO2"]), Convert.ToString(reader["EXCEDENTE_MA"]), Convert.ToString(reader["EXCEDENTE_SC"]), Convert.ToString(reader["EXCEDENTE_EQ"]), Convert.ToString(reader["EXCEDENTE_AC"]), Convert.ToString(reader["EXCEDENTE_MO"]));
                    ps.Add(item);
                }
            }
            return ps;
        }

        public override Database BaseReportes
        {
            get
            {
                if (_baseReportes == null)
                {
                    _baseReportes = new SqlDatabase("Data Source=SERVERERP;Initial Catalog=REPORTES;User ID=sa;Password=BDn2xc4m");
                }
                return _baseReportes;
            }
        }

        public override Database BaseWeb
        {
            get
            {
                if (_baseWeb == null)
                {
                    _baseWeb = new SqlDatabase("Data Source=SERVERERP;Initial Catalog=NEXCOM_WEB;User ID=sa;Password=BDn2xc4m");
                }
                return _baseWeb;
            }
        }

        public override Database BaseRegomsa
        {
            get
            {
                if (_baseRegomsa == null)
                {
                    _baseRegomsa = new SqlDatabase("Data Source=SERVERERP;Initial Catalog=S10REGOMSA;User ID=sa;Password=BDn2xc4m");
                }
                return _baseRegomsa;
            }
        }

        public override Database BaseS10
        {
            get
            {
                if (_baseS10 == null)
                {
                    _baseS10 = new SqlDatabase("Data Source=SERVERERP;Initial Catalog=NEXCOM;User ID=sa;Password=BDn2xc4m");
                }
                return _baseS10;
            }
        }

        public override Database BaseSpring
        {
            get
            {
                if (_baseSpring == null)
                {
                    _baseSpring = new SqlDatabase("Data Source=SERVERERP;Initial Catalog=Prueba_Spring;User ID=sa;Password=BDn2xc4m");
                }
                return _baseSpring;
            }
        }

        public override LgImplPedApSinOc2Ds ObtenerLgImplPedApSinOc2DSelAll()
        {
            LgImplPedApSinOc2Ds oData = new LgImplPedApSinOc2Ds();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Control3");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplPedApSinOc2D oRow = new LgImplPedApSinOc2D(Convert.ToString(oDataReader["PROY"]), Convert.ToString(oDataReader["ALM"]),
                        Convert.ToString(oDataReader["TPED"]), Convert.ToString(oDataReader["EPED"]), Convert.ToString(oDataReader["NPEDM"]),
                        Convert.ToString(oDataReader["CODREC"]), Convert.ToString(oDataReader["REC"]), Convert.ToString(oDataReader["UN"]),
                        Convert.ToString(oDataReader["CPED"]), Convert.ToString(oDataReader["OBSPED"]), Convert.ToString(oDataReader["FPED"]),
                        Convert.ToString(oDataReader["FAPR"]), Convert.ToString(oDataReader["DIAPRO"]), Convert.ToString(oDataReader["ITEM"]),
                        Convert.ToString(oDataReader["USREG"]), Convert.ToString(oDataReader["USAPRO"]), Convert.ToString(oDataReader["ESTOR"]),
                        Convert.ToString(oDataReader["ESTAL"]), Convert.ToString(oDataReader["ESTCOT"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplOcCreadasAyers ObtenerLgImplOcCreadasAyerSelAll()
        {
            LgImplOcCreadasAyers oData = new LgImplOcCreadasAyers();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Control4");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplOcCreadasAyer oRow = new LgImplOcCreadasAyer(Convert.ToString(oDataReader["PROYECTO"]), Convert.ToString(oDataReader["PROVEEDOR"]),
                        Convert.ToString(oDataReader["CC"]), Convert.ToString(oDataReader["TIPOORDEN"]), Convert.ToString(oDataReader["FPAGO"]),
                        Convert.ToString(oDataReader["ESTADOORDEN"]), Convert.ToString(oDataReader["NROORDEN"]), Convert.ToString(oDataReader["CODRECURSO"]),
                        Convert.ToString(oDataReader["RECURSO"]), Convert.ToString(oDataReader["UNIDAD"]), Convert.ToString(oDataReader["SIMB"]),
                        Convert.ToString(oDataReader["CANTIDAD"]), Convert.ToString(oDataReader["CONTECHO"]), Convert.ToString(oDataReader["PRECIOTECHO"]),
                        Convert.ToString(oDataReader["PRECIO"]), Convert.ToString(oDataReader["PRECIOEXCEDETECHO"]),
                        Convert.ToString(oDataReader["DSCTOPORCT"]), Convert.ToString(oDataReader["PARCIALRECURSO"]),
                        Convert.ToString(oDataReader["PARCIALTOTALORDEN"]), Convert.ToString(oDataReader["VALORDSCTOTOTALORDEN"]),
                        Convert.ToString(oDataReader["VALORNETOTOTALORDEN"]), Convert.ToString(oDataReader["VALORIGVTOTALORDEN"]),
                        Convert.ToString(oDataReader["VALORTOTALDELTOTALDELAORDEN"]), Convert.ToString(oDataReader["RECURSOAFECTADOCONIGV"]),
                        Convert.ToString(oDataReader["TIPODECAMBIO"]), Convert.ToString(oDataReader["FECHACREACION"]),
                        Convert.ToString(oDataReader["FECHAACTUALIZACION"]), Convert.ToString(oDataReader["FECHAORDEN"]),
                        Convert.ToString(oDataReader["USUARIOREGISTRADOR"]), Convert.ToString(oDataReader["APROBADO"]),
                        Convert.ToString(oDataReader["USUARIOAPROBADOR"]), Convert.ToString(oDataReader["FECHAAPROBACION"]),
                        Convert.ToString(oDataReader["OBSERVACIONORDEN"]), Convert.ToString(oDataReader["OBSERVACIONDELRECURSO"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplOcCreadasAyer2s ObtenerLgImplOcCreadasAyer2SelAll()
        {
            LgImplOcCreadasAyer2s oData = new LgImplOcCreadasAyer2s();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Control5");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplOcCreadasAyer2 oRow = new LgImplOcCreadasAyer2(Convert.ToString(oDataReader["FECHACREACION"]),
                        Convert.ToString(oDataReader["FECHAACTUALIZACION"]), Convert.ToString(oDataReader["FECHAHOY"]),
                        Convert.ToString(oDataReader["ESTADOORDEN"]), Convert.ToString(oDataReader["SIMBOLO"]),
                        Convert.ToString(oDataReader["VALORTOTALEMITIDOENORDENES"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplOcModifAyers ObtenerLgImplOcModifAyerSelAll()
        {
            LgImplOcModifAyers oData = new LgImplOcModifAyers();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Control6");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplOcModifAyer oRow = new LgImplOcModifAyer(Convert.ToString(oDataReader["CODPROYECTO"]), Convert.ToString(oDataReader["PROYECTO"]),
                        Convert.ToString(oDataReader["PROVEEDOR"]), Convert.ToString(oDataReader["CC"]), Convert.ToString(oDataReader["TIPOORDEN"]),
                        Convert.ToString(oDataReader["FPAGO"]), Convert.ToString(oDataReader["ESTADOORDEN"]), Convert.ToString(oDataReader["NROORDEN"]),
                        Convert.ToString(oDataReader["CODRECURSO"]), Convert.ToString(oDataReader["RECURSO"]), Convert.ToString(oDataReader["UNIDAD"]),
                        Convert.ToString(oDataReader["SIMB"]), Convert.ToString(oDataReader["CANTIDADACTUALENORDEN"]),
                        Convert.ToString(oDataReader["CONTECHO"]), Convert.ToString(oDataReader["PRECIOTECHO"]), Convert.ToString(oDataReader["PRECIO"]),
                        Convert.ToString(oDataReader["PRECIOEXCEDETECHO"]), Convert.ToString(oDataReader["DSCTOPORCT"]),
                        Convert.ToString(oDataReader["PARCIALRECURSO"]), Convert.ToString(oDataReader["PARCIALTOTALORDEN"]),
                        Convert.ToString(oDataReader["VALORDSCTOTOTALORDEN"]), Convert.ToString(oDataReader["VALORNETOTOTALORDEN"]),
                        Convert.ToString(oDataReader["VALORIGVTOTALORDEN"]), Convert.ToString(oDataReader["VALORTOTALACTUALDELTOTALDELAORDEN"]),
                        Convert.ToString(oDataReader["RECURSOAFECTADOCONIGV"]), Convert.ToString(oDataReader["TIPODECAMBIO"]),
                        Convert.ToString(oDataReader["FECHACREACION"]), Convert.ToString(oDataReader["FECHAACTUALIZACION"]),
                        Convert.ToString(oDataReader["FECHAORDEN"]), Convert.ToString(oDataReader["USUARIOREGISTRADOR"]),
                        Convert.ToString(oDataReader["APROBADO"]), Convert.ToString(oDataReader["USUARIOAPROBADOR"]),
                        Convert.ToString(oDataReader["FECHAAPROBACION"]), Convert.ToString(oDataReader["OBSERVACIONORDEN"]),
                        Convert.ToString(oDataReader["OBSERVACIONDELRECURSO"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplOcModifAyer2s ObtenerLgImplOcModifAyer2SelAll()
        {
            LgImplOcModifAyer2s oData = new LgImplOcModifAyer2s();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Control7");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplOcModifAyer2 oRow = new LgImplOcModifAyer2(Convert.ToString(oDataReader["FECHAHOY"]),
                        Convert.ToString(oDataReader["FECHAACTUALIZACION"]), Convert.ToString(oDataReader["ESTADOORDEN"]),
                        Convert.ToString(oDataReader["SIMBOLO"]), Convert.ToString(oDataReader["VALORTOTALACTUALENORDENES"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplRecApro7moDias ObtenerLgImplRecApro7MoDiaSelAll()
        {
            LgImplRecApro7moDias oData = new LgImplRecApro7moDias();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Control8");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplRecApro7moDia oRow = new LgImplRecApro7moDia(Convert.ToString(oDataReader["CODPROYECTO"]),
                        Convert.ToString(oDataReader["PROYECTO"]), Convert.ToString(oDataReader["PROVEEDOR"]),
                        Convert.ToString(oDataReader["TIPOORDEN"]), Convert.ToString(oDataReader["ESTADOORDEN"]),
                        Convert.ToString(oDataReader["NROORDEN"]), Convert.ToString(oDataReader["CODRECURSO"]),
                        Convert.ToString(oDataReader["RECURSO"]), Convert.ToString(oDataReader["UNIDAD"]),
                        Convert.ToString(oDataReader["CANTIDAD"]), Convert.ToString(oDataReader["CANTIDADENALMACEN"]),
                        Convert.ToString(oDataReader["CANTIDADPORENTREGAR"]), Convert.ToString(oDataReader["USUARIOREGISTRADOR"]),
                        Convert.ToString(oDataReader["FECHAAPROBACION"]), Convert.ToString(oDataReader["DIAS_APROBORDEN_COMP"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplResultOperCs ObtenerLgImplResultOperCSelAll()
        {
            LgImplResultOperCs oData = new LgImplResultOperCs();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.S10_Resultado_OperativoC");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplResultOperC oRow = new LgImplResultOperC(Convert.ToString(oDataReader["CODPROYECTO"]), Convert.ToString(oDataReader["DES_PROYECTO"]),
                        Convert.ToString(oDataReader["TIPOPRESUPUESTO"]), Convert.ToString(oDataReader["CODPRESUPUESTO"]),
                        Convert.ToString(oDataReader["DES_PRESUPUESTO"]), Convert.ToString(oDataReader["PRESUPUESTO"]),
                        Convert.ToString(oDataReader["PROGRAMADO"]), Convert.ToString(oDataReader["VALORIZADO"]), Convert.ToString(oDataReader["REALL"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplResultOperDs ObtenerLgImplResultOperDSelAll(string codproyecto, string codpresupuesto)
        {
            LgImplResultOperDs oData = new LgImplResultOperDs();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.S10_Resultado_OperativoD");
            this.BaseWeb.AddInParameter(oComando, "@CODPROYECTO", DbType.String, codproyecto);
            this.BaseWeb.AddInParameter(oComando, "@CODPRESUPUESTO", DbType.String, codpresupuesto);
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplResultOperD oRow = new LgImplResultOperD(Convert.ToString(oDataReader["GRUPO"]), Convert.ToString(oDataReader["RECURSO"]),
                        Convert.ToString(oDataReader["PRESUPUESTO"]), Convert.ToString(oDataReader["PROGRAMADO"]),
                        Convert.ToString(oDataReader["VALORIZADO"]), Convert.ToString(oDataReader["REALL"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplPrecioOrdenCompras ObtenerLgImplPrecioOrdenCompraSelAll()
        {
            LgImplPrecioOrdenCompras oData = new LgImplPrecioOrdenCompras();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Control11");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplPrecioOrdenCompra oRow = new LgImplPrecioOrdenCompra(Convert.ToString(oDataReader["CODAC"]),
                        Convert.ToString(oDataReader["PROYAC"]), Convert.ToString(oDataReader["CODAN"]), Convert.ToString(oDataReader["PROYAN"]),
                        Convert.ToString(oDataReader["CODREC"]), Convert.ToString(oDataReader["DESREC"]), Convert.ToString(oDataReader["OCAC"]),
                        Convert.ToString(oDataReader["OCAN"]), Convert.ToString(oDataReader["FROC"]), Convert.ToString(oDataReader["FAOC"]),
                        Convert.ToString(oDataReader["SAC"]), Convert.ToString(oDataReader["PAC"]), Convert.ToString(oDataReader["SAN"]),
                        Convert.ToString(oDataReader["PAN"]), Convert.ToString(oDataReader["CANT"]), Convert.ToString(oDataReader["DIF"]),
                        Convert.ToString(oDataReader["PROVAC"]), Convert.ToString(oDataReader["PROVAN"]), Convert.ToString(oDataReader["DESFPAG"]),
                        Convert.ToString(oDataReader["COMAC"]), Convert.ToString(oDataReader["COMAN"]), Convert.ToString(oDataReader["FROC2"]),
                        Convert.ToString(oDataReader["FAOC2"]), Convert.ToString(oDataReader["U"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplGuiaAlmacenDs ObtenerLgImplGuiaAlmacenDSelAll()
        {
            LgImplGuiaAlmacenDs oData = new LgImplGuiaAlmacenDs();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Auditoria_GuiaAlmacenD");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplGuiaAlmacenD oRow = new LgImplGuiaAlmacenD(Convert.ToString(oDataReader["IDITEM"]), Convert.ToString(oDataReader["ESTADO"]),
                        Convert.ToString(oDataReader["USUARIO"]), Convert.ToString(oDataReader["IP"]), Convert.ToString(oDataReader["FECHA"]),
                        Convert.ToString(oDataReader["PROYECTO"]), Convert.ToString(oDataReader["ALMACEN"]), Convert.ToString(oDataReader["CODINSUMO"]),
                        Convert.ToString(oDataReader["INSUMO"]), Convert.ToString(oDataReader["UNIDAD"]), Convert.ToString(oDataReader["ABREVIATURA"]),
                        Convert.ToString(oDataReader["CODGUIA"]), Convert.ToString(oDataReader["FECHAGUIA"]), Convert.ToString(oDataReader["CANTIDAD"]),
                        Convert.ToString(oDataReader["PRECIO"]), Convert.ToString(oDataReader["MONEDA"]), Convert.ToString(oDataReader["PARCIAL"]),
                        Convert.ToString(oDataReader["CU"]), Convert.ToString(oDataReader["CF"]), Convert.ToString(oDataReader["AU"]),
                        Convert.ToString(oDataReader["AF"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override bool ActualizarLgImplGuiaAlmacenDSelAll(string iditem)
        {
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Auditoria_GuiaAlmacenD_Actualizar");
            this.BaseReportes.AddInParameter(oComando, "@pIDITEM", DbType.String, iditem);
            try
            {
                if (this.BaseReportes.ExecuteNonQuery(oComando) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return false;
        }

        public override LgImplRecursoCeroNegativos ObtenerLgImplRecursoCeroNegativoSelAll()
        {
            LgImplRecursoCeroNegativos oData = new LgImplRecursoCeroNegativos();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Control12");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplRecursoCeroNegativo oRow = new LgImplRecursoCeroNegativo(Convert.ToString(oDataReader["PROYECTO"]), Convert.ToString(oDataReader["ALMACEN"]),
                        Convert.ToString(oDataReader["MOVIMIENTO"]), Convert.ToString(oDataReader["FECHAGUIA"]), Convert.ToString(oDataReader["NROGUIA"]),
                        Convert.ToString(oDataReader["CODRECURSO"]), Convert.ToString(oDataReader["RECURSO"]), Convert.ToString(oDataReader["UNIDAD"]),
                        Convert.ToString(oDataReader["CANTIDAD"]), Convert.ToString(oDataReader["PRECIO"]), Convert.ToString(oDataReader["USUARIOREGISTRADOR"]),
                        Convert.ToString(oDataReader["USUARIOMODIFICADOR"]), Convert.ToString(oDataReader["USUARIOCREADOR"]),
                        Convert.ToString(oDataReader["ACTUALIZACIONUSUARIO"]), Convert.ToString(oDataReader["CREACIONFECHA"]),
                        Convert.ToString(oDataReader["ACTUALIZACIONFECHA"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplKardexCeroNegativos ObtenerLgImplKardexCeroNegativoSelAll()
        {
            LgImplKardexCeroNegativos oData = new LgImplKardexCeroNegativos();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Control13");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplKardexCeroNegativo oRow = new LgImplKardexCeroNegativo(Convert.ToString(oDataReader["PROYECTO"]),
                        Convert.ToString(oDataReader["ALMACEN"]), Convert.ToString(oDataReader["CODRECURSO"]), Convert.ToString(oDataReader["RECURSO"]),
                        Convert.ToString(oDataReader["UNIDAD"]), Convert.ToString(oDataReader["FECHAGUIA"]), Convert.ToString(oDataReader["NROGUIA"]),
                        Convert.ToString(oDataReader["MOVIMIENTO"]), Convert.ToString(oDataReader["MONEDA"]), Convert.ToString(oDataReader["CANTIDAD"]),
                        Convert.ToString(oDataReader["STOCKANTERIOR"]), Convert.ToString(oDataReader["STOCKACTUAL"]),
                        Convert.ToString(oDataReader["PRECIO"]), Convert.ToString(oDataReader["PROYECTOTRANS"]),
                        Convert.ToString(oDataReader["ALMACENTRANS"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplComedors ObtenerLgImplComedorSelAll()
        {
            LgImplComedors oData = new LgImplComedors();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.ControlComedor");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplComedor oRow = new LgImplComedor(Convert.ToString(oDataReader["NOMBRECOMPLETO"]),
                        Convert.ToString(oDataReader["COMIDA"]), Convert.ToString(oDataReader["CANTIDAD"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplComedor2s ObtenerLgImplComedor2SelAll()
        {
            LgImplComedor2s oData = new LgImplComedor2s();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.ControlComedor2");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplComedor2 oRow = new LgImplComedor2(Convert.ToString(oDataReader["COMIDA"]), Convert.ToString(oDataReader["TOTAL"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplComedor3s ObtenerLgImplComedor3SelAll()
        {
            LgImplComedor3s oData = new LgImplComedor3s();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.ControlComedor3");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplComedor3 oRow = new LgImplComedor3(Convert.ToString(oDataReader["NOMBRECOMPLETO"]),
                        Convert.ToString(oDataReader["COMIDA"]), Convert.ToString(oDataReader["CANTIDAD"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplComedor4s ObtenerLgImplComedor4SelAll()
        {
            LgImplComedor4s oData = new LgImplComedor4s();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.ControlComedor4");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplComedor4 oRow = new LgImplComedor4(Convert.ToString(oDataReader["COMIDA"]), Convert.ToString(oDataReader["TOTAL"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplVerifNroUsers ObtenerLgImplVerifNroUserSelAll()
        {
            LgImplVerifNroUsers oData = new LgImplVerifNroUsers();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Interface_SinNDOCUSER");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplVerifNroUser oRow = new LgImplVerifNroUser(Convert.ToString(oDataReader["USUARIO"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplVerifNroProveedors ObtenerLgImplNroProveedorSelAll()
        {
            LgImplVerifNroProveedors oData = new LgImplVerifNroProveedors();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Interface_SinProveedor");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplVerifNroProveedor oRow = new LgImplVerifNroProveedor(Convert.ToString(oDataReader["RUC"]),
                        Convert.ToString(oDataReader["DESCRIPCION"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplVerifNroCcs ObtenerLgImplVerifNroCcSelAll()
        {
            LgImplVerifNroCcs OData = new LgImplVerifNroCcs();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Interface_SinCC");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplVerifNroCc oRow = new LgImplVerifNroCc(Convert.ToString(oDataReader["CC"]),
                        Convert.ToString(oDataReader["DESCRIPCION"]));
                    OData.Add(oRow);
                }
            }
            return OData;
        }

        public override LgImplVerifNroProSs ObtenerLgImplVerifNroProSSelAll()
        {
            LgImplVerifNroProSs oData = new LgImplVerifNroProSs();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Interface_SinProcesar");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplVerifNroProS oRow = new LgImplVerifNroProS(Convert.ToString(oDataReader["TIPODOCUMENTO"]),
                        Convert.ToString(oDataReader["NUMERODOCUMENTO"]), Convert.ToString(oDataReader["OBSERVACION"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplVerifNroNDocs ObtenerLgImplVerifNroNDocSelAll(string usuario)
        {
            LgImplVerifNroNDocs oData = new LgImplVerifNroNDocs();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Interface_SinNDOC");
            this.BaseReportes.AddInParameter(oComando, "@pusuario", DbType.String, usuario);
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplVerifNroNDoc oRow = new LgImplVerifNroNDoc(Convert.ToString(oDataReader["NroDoc"]),
                        Convert.ToString(oDataReader["DESCRIPCION"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplAuditTechoRecNoPres ObtenerLgImplAuditTechoRecNoPreSelAll()
        {
            LgImplAuditTechoRecNoPres oData = new LgImplAuditTechoRecNoPres();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Auditoria_Techo3C");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplAuditTechoRecNoPre oRow = new LgImplAuditTechoRecNoPre(Convert.ToString(oDataReader["CODRECURSO"]),
                        Convert.ToString(oDataReader["DESCRIPCION"]), Convert.ToString(oDataReader["SIMBOLO"]),
                        Convert.ToString(oDataReader["CPEDIDO"]), Convert.ToString(oDataReader["PROYECTO"]),
                        Convert.ToString(oDataReader["GUIA"]), Convert.ToString(oDataReader["FECHAGUIA"]),
                        Convert.ToString(oDataReader["CANTIDADGUIA"]), Convert.ToString(oDataReader["PRECIO"]),
                        Convert.ToString(oDataReader["COSTO"]), Convert.ToString(oDataReader["USUARIOGUIA"]),
                        Convert.ToString(oDataReader["ALMACEN"]), Convert.ToString(oDataReader["MOVIMIENTO"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplAuditTechoProys ObtenerLgImplAuditTechoProySelAll()
        {
            LgImplAuditTechoProys oData = new LgImplAuditTechoProys();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Auditoria_Proyecto");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplAuditTechoProy oRow = new LgImplAuditTechoProy(Convert.ToString(oDataReader["IDITEM"]),
                        Convert.ToString(oDataReader["CODUSER"]),
                        Convert.ToString(oDataReader["CODPROYECTO"]), Convert.ToString(oDataReader["DESCRIPCION"]),
                        Convert.ToString(oDataReader["IP"]),
                        Convert.ToString(oDataReader["FECHA"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplAuditRecursoS10s ObtenerLgImplAuditRecursoS10SelAll()
        {
            LgImplAuditRecursoS10s oData = new LgImplAuditRecursoS10s();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Auditoria_Insumo");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplAuditRecursoS10 oRow = new LgImplAuditRecursoS10(Convert.ToString(oDataReader["IDITEM"]),
                        Convert.ToString(oDataReader["CODINSUMO"]), Convert.ToString(oDataReader["NIVEL"]),
                        Convert.ToString(oDataReader["DESCRIPCION"]), Convert.ToString(oDataReader["NIVELP"]),
                        Convert.ToString(oDataReader["FAMILIA1"]), Convert.ToString(oDataReader["FAMILIA2"]),
                        Convert.ToString(oDataReader["MATERIALES"]), Convert.ToString(oDataReader["ACTIVOS"]),
                        Convert.ToString(oDataReader["SERVICIOO"]), Convert.ToString(oDataReader["SERVICIOA"]),
                        Convert.ToString(oDataReader["SERVICIOC"]), Convert.ToString(oDataReader["CONSUMOD"]),
                        Convert.ToString(oDataReader["CONSUMOH"]), Convert.ToString(oDataReader["ACCION"]),
                        Convert.ToString(oDataReader["LOGIN"]), Convert.ToString(oDataReader["IP"]),
                        Convert.ToString(oDataReader["FECHA"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplSegTansferenciaGgs ObtenerLgImplSegTansferenciaGgSelAll()
        {
            LgImplSegTansferenciaGgs oData = new LgImplSegTansferenciaGgs();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.S10_Almacenes_009_04_ETE_ETEP_SeguimientoGG");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplSegTansferenciaGg oRow = new LgImplSegTansferenciaGg(
                          Convert.ToString(oDataReader["Descripcion"]), Convert.ToString(oDataReader["Estado_Proyecto"]),
                          Convert.ToString(oDataReader["Total_Pendiente"]), Convert.ToString(oDataReader["Proyecto_Destino"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplSegTansferenciaGgTos ObtenerLgImplSegTansferenciaGgToSelAll()
        {
            LgImplSegTansferenciaGgTos oData = new LgImplSegTansferenciaGgTos();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.S10_Almacenes_009_04_ETE_ETEP_SeguimientoGGTO");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplSegTansferenciaGgTo oRow = new LgImplSegTansferenciaGgTo(Convert.ToString(oDataReader["Estado_Proyecto"]),
                          Convert.ToString(oDataReader["Total_Pendiente"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplAuditoriaPs ObtenerLgImplAuditoriaSalarioPSelAll()
        {
            LgImplAuditoriaPs ps2 = new LgImplAuditoriaPs();
            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.Auditoria_Monto");
            using (SqlDataReader reader = (SqlDataReader)this.BaseReportes.ExecuteReader(storedProcCommand))
            {
                while (reader.Read())
                {
                    LgImplAuditoriaP item = new LgImplAuditoriaP(Convert.ToString(reader["IDITEM"]), Convert.ToString(reader["CODUSER"]),
                        Convert.ToString(reader["CODIGO"]), Convert.ToString(reader["NOMBRE"]), Convert.ToString(reader["MONTOLOCAL"]),
                        Convert.ToString(reader["MONTOLOCALA"]), Convert.ToString(reader["IP"]), Convert.ToString(reader["FECHA"]),
                        Convert.ToString(reader["PUESTO"]), Convert.ToString(reader["CENTROCOSTOS"]), Convert.ToString(reader["AREA"]), Convert.ToString(reader["GERENCIA"]));
                    ps2.Add(item);
                }
            }
            return ps2;
        }

        public override bool ActualizarLgImplAuditoriaSalarioPSelAll(string IdItem)
        {

            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.Auditoria_Monto_Actualizar");
            this.BaseReportes.AddInParameter(storedProcCommand, "@pIDITEM", DbType.String, IdItem);
            try
            {
                if (this.BaseReportes.ExecuteNonQuery(storedProcCommand) > 0)
                {
                    return true;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return false;
        }

        public override LgImplAuditoriaVacas ObtenerLgImplAuditoriaVacaSelAll()
        {
            LgImplAuditoriaVacas vs2 = new LgImplAuditoriaVacas();
            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.Auditoria_Vacacion");
            using (SqlDataReader reader = (SqlDataReader)this.BaseReportes.ExecuteReader(storedProcCommand))
            {
                while (reader.Read())
                {
                    LgImplAuditoriaVaca item = new LgImplAuditoriaVaca(Convert.ToString(reader["IDITEM"]), Convert.ToString(reader["CODUSER"]),
                        Convert.ToString(reader["CODIGO"]), Convert.ToString(reader["NOMBRE"]), Convert.ToString(reader["PERIODO"]),
                        Convert.ToString(reader["DERECHO"]), Convert.ToString(reader["UTILIZADO"]), Convert.ToString(reader["PENDIENTE"]),
                        Convert.ToString(reader["IP"]), Convert.ToString(reader["FECHA"]));
                    vs2.Add(item);
                }
            }
            return vs2;
        }

        public override bool ActualizarLgImplAuditoriaVacaSelAll(string IdItem)
        {
            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.Auditoria_Vacacion_Actualizar");
            this.BaseReportes.AddInParameter(storedProcCommand, "@pIDITEM", DbType.String, IdItem);
            try
            {
                if (this.BaseReportes.ExecuteNonQuery(storedProcCommand) > 0)
                {
                    return true;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return false;
        }

        public override bool InsertarLgImplCabeceraS10_To_SpringSelAll(string Proveedor, string NumeroDocumento, string TipoDocumento, string CompaniaCodigo, DateTime FechaRegistro,
            DateTime FechaDocumento, DateTime FechaRecepcion, DateTime FechaVencimiento, DateTime FechaVencimientoOriginal, string MonedaDocumento, string TipoServicio,
            decimal MontoAfecto, decimal MontoImponible, decimal MontoImpuestoVentas, decimal MontoImpuesto, decimal MontoObligacion, decimal MontoAdelantos, decimal MontoPagoParcial,
            decimal MontoCreditoFiscal, string UnidadNegocio, string UnidadReplicacion, string FlujoCaja, string CentroCostos, string OC, string ProveedorPagarA, string PagarANombre,
            string GenerarPago, string TipoPago, string MonedaPago, string IngresadoPor, string Comentarios, string ComentariosAdicional, string Usuario, string NumeroAdelanto,
            string TipoAdelanto, string CuentaAbono, string AdministradorRubro, string Contacto)
        {
            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.SNp_AP_InsertarObligacion");
            this.BaseReportes.AddInParameter(storedProcCommand, "@pProveedor", DbType.String, Proveedor);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pNumeroDocumento", DbType.String, NumeroDocumento);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pTipoDocumento", DbType.String, TipoDocumento);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pCompaniaCodigo", DbType.String, CompaniaCodigo);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pFechaRegistro", DbType.DateTime, FechaRegistro);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pFechaDocumento", DbType.DateTime, FechaDocumento);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pFechaRecepcion", DbType.DateTime, FechaRecepcion);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pFechaVencimiento", DbType.DateTime, FechaVencimiento);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pFechaVencimientoOriginal", DbType.DateTime, FechaVencimientoOriginal);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pMonedaDocumento", DbType.String, MonedaDocumento);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pTipoServicio", DbType.String, TipoServicio);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pMontoNoAfecto", DbType.Decimal, MontoAfecto);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pMontoImponible", DbType.Decimal, MontoImponible);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pMontoImpuestoVentas", DbType.Decimal, MontoImpuestoVentas);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pMontoImpuestos", DbType.Decimal, MontoImpuesto);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pMontoObligacion", DbType.Decimal, MontoObligacion);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pMontoAdelantos", DbType.Decimal, MontoAdelantos);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pMontoPagoParcial", DbType.Decimal, MontoPagoParcial);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pMontoCreditoFiscal", DbType.Decimal, MontoCreditoFiscal);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pUnidadNegocio", DbType.String, UnidadNegocio);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pUnidadReplicacion", DbType.String, UnidadReplicacion);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pFlujoCaja", DbType.String, FlujoCaja);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pCentroCosto", DbType.String, CentroCostos);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pOC", DbType.String, OC);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pProveedorPagarA", DbType.String, ProveedorPagarA);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pPagaraNombre", DbType.String, PagarANombre);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pGenerarPago", DbType.String, GenerarPago);
            this.BaseReportes.AddInParameter(storedProcCommand, "@PTipoPago", DbType.String, TipoPago);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pMonedaPago", DbType.String, MonedaPago);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pIngresadoPor", DbType.String, IngresadoPor);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pComentarios", DbType.String, Comentarios);
            this.BaseReportes.AddInParameter(storedProcCommand, "@PComentariosAdicional", DbType.String, ComentariosAdicional);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pUsuario", DbType.String, Usuario);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pNumeroAdelanto", DbType.String, NumeroAdelanto);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pTipoAdelanto", DbType.String, TipoAdelanto);
            this.BaseReportes.AddInParameter(storedProcCommand, "@PCuentaAbono", DbType.String, CuentaAbono);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pAdministradorRubro", DbType.String, AdministradorRubro);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pContacto", DbType.String, Contacto);
            try
            {
                if (this.BaseReportes.ExecuteNonQuery(storedProcCommand) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        public override bool InsertarLgImplDetalleS10_To_SpringSelAll(string CompaniaCodigo, string Proveedor, string TipoDocumento, string NumeroDocumento, string Linea, decimal Monto, string CuentaContable,
            string Proyecto, string CentroCosto, string Descripcion, string Personal, string Sucursal)
        {

            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.SNp_AP_InsertarDetalleObligacion");
            this.BaseReportes.AddInParameter(storedProcCommand, "@pCompaniaCodigo", DbType.String, CompaniaCodigo);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pProveedor", DbType.String, Proveedor);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pTipoDocumento", DbType.String, TipoDocumento);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pNumeroDocumento", DbType.String, NumeroDocumento);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pLinea", DbType.String, Linea);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pMonto", DbType.Decimal, Monto);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pCuentaContable", DbType.String, CuentaContable);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pProyecto", DbType.String, Proyecto);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pCentroCosto", DbType.String, CentroCosto);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pDescripcion", DbType.String, Descripcion);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pPersonal", DbType.String, Personal);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pSucursal", DbType.String, Sucursal);
            try
            {
                if (this.BaseReportes.ExecuteNonQuery(storedProcCommand) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        public override bool InsertarLgImplCabeceraS10_To_SpringTmp1SelAll(string Proveedor, string NumeroDocumento, string TipoDocumento, DateTime FechaRegistro, string Tipo)
        {

            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.SNp_AP_InsertartmpObligacion");
            this.BaseReportes.AddInParameter(storedProcCommand, "@pProveedor", DbType.String, Proveedor);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pNumeroDocumento", DbType.String, NumeroDocumento);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pTipoDocumento", DbType.String, TipoDocumento);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pFechaRegistro", DbType.DateTime, FechaRegistro);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pTipo", DbType.String, Tipo);
            try
            {
                if (this.BaseReportes.ExecuteNonQuery(storedProcCommand) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        public override bool InsertarLgImplCabeceraS10_To_SpringTmp2SelAll(string Proveedor, string NumeroDocumento, string TipoDocumento, DateTime FechaRegistro, string Tipo)
        {

            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.SNp_AP_InsertartmpObligacion2");
            this.BaseReportes.AddInParameter(storedProcCommand, "@pProveedor", DbType.String, Proveedor);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pNumeroDocumento", DbType.String, NumeroDocumento);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pTipoDocumento", DbType.String, TipoDocumento);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pFechaRegistro", DbType.DateTime, FechaRegistro);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pTipo", DbType.String, Tipo);
            try
            {
                if (this.BaseReportes.ExecuteNonQuery(storedProcCommand) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        public override bool InsertarLgImplCabeceraS10_To_SpringTmp3SelAll(string Proveedor, string NumeroDocumento, string TipoDocumento, DateTime FechaRegistro, string Tipo)
        {

            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.SNp_AP_InsertartmpObligacion3");
            this.BaseReportes.AddInParameter(storedProcCommand, "@pProveedor", DbType.String, Proveedor);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pNumeroDocumento", DbType.String, NumeroDocumento);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pTipoDocumento", DbType.String, TipoDocumento);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pFechaRegistro", DbType.DateTime, FechaRegistro);
            this.BaseReportes.AddInParameter(storedProcCommand, "@pTipo", DbType.String, Tipo);
            try
            {
                if (this.BaseReportes.ExecuteNonQuery(storedProcCommand) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        public override LgImplCabeceraS10s ObtenerLgImplCabeceraS10SelAll()
        {
            LgImplCabeceraS10s ass2 = new LgImplCabeceraS10s();
            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.S10_CabeceraInterface");
            using (SqlDataReader reader = (SqlDataReader)this.BaseReportes.ExecuteReader(storedProcCommand))
            {
                while (reader.Read())
                {
                    LgImplCabeceraS10 item = new LgImplCabeceraS10(Convert.ToString(reader["PROVEEDOR"]), Convert.ToString(reader["NUMERODOCUMENTO"]), Convert.ToString(reader["TIPODOCUMENTO"]),
                        Convert.ToString(reader["COMPANIACODIGO"]), Convert.ToDateTime(reader["FECHAREGISTRO"]), Convert.ToDateTime(reader["FECHADOCUMENTO"]),
                        Convert.ToDateTime(reader["FECHARECEPCION"]), Convert.ToDateTime(reader["FECHAVENCIMIENTO"]), Convert.ToDateTime(reader["FECHAVENCIMIENTOORIGINAL"]),
                        Convert.ToString(reader["MONEDADOCUMENTO"]), Convert.ToString(reader["TIPOSERVICIO"]), Convert.ToString(reader["MONTONOAFECTO"]),
                        Convert.ToString(reader["MONTOIMPONIBLE"]), Convert.ToString(reader["MONTOIMPUESTOVENTAS"]), Convert.ToString(reader["MONTOIMPUESTO"]),
                        Convert.ToString(reader["MONTOOBLIGACION"]), Convert.ToString(reader["MONTOADELANTOS"]), Convert.ToString(reader["MONTOPAGOPARCIAL"]),
                        Convert.ToString(reader["MONTOCREDITOFISCAL"]), Convert.ToString(reader["UNIDADNEGOCIO"]), Convert.ToString(reader["UNIDADREPLICACION"]),
                        Convert.ToString(reader["FLUJOCAJA"]), Convert.ToString(reader["CENTROCOSTOS"]), Convert.ToString(reader["OC"]), Convert.ToString(reader["PROVEEDORPAGARA"]),
                        Convert.ToString(reader["PAGARANOMBRE"]), Convert.ToString(reader["GENERARPAGO"]), Convert.ToString(reader["TIPOPAGO"]), Convert.ToString(reader["MONEDAPAGO"]),
                        Convert.ToString(reader["INGRESADOPOR"]), Convert.ToString(reader["COMENTARIOS"]), Convert.ToString(reader["COMENTARIOSADICIONAL"]),
                        Convert.ToString(reader["USUARIO"]), Convert.ToString(reader["NUMEROADELANTO"]), Convert.ToString(reader["TIPOADELANTO"]), Convert.ToString(reader["CUENTAABONO"]),
                        Convert.ToString(reader["ADMINISTRADORRUBRO"]), Convert.ToString(reader["EP"]), Convert.ToString(reader["ECC"]), Convert.ToString(reader["ENRDOC"]),
                        Convert.ToString(reader["CONTACTO"]));
                    ass2.Add(item);
                }
            }
            return ass2;
        }

        public override LgImplDetalleS10s ObtenerLgImplDetalleS10SelAll()
        {
            LgImplDetalleS10s ess2 = new LgImplDetalleS10s();
            DbCommand storedProcCommand = this.BaseReportes.GetStoredProcCommand("dbo.S10_DetalleInterface");
            using (SqlDataReader reader = (SqlDataReader)this.BaseReportes.ExecuteReader(storedProcCommand))
            {
                while (reader.Read())
                {
                    LgImplDetalleS10 item = new LgImplDetalleS10(Convert.ToString(reader["COMPANIACODIGO"]), Convert.ToString(reader["PROVEEDOR"]), Convert.ToString(reader["TIPODOCUMENTO"]),
                        Convert.ToString(reader["NUMERODOCUMENTO"]), Convert.ToString(reader["LINEA"]), Convert.ToString(Convert.ToDecimal(reader["MONTO"])),
                        Convert.ToString(reader["CUENTACONTABLE"]), Convert.ToString(reader["PROYECTO"]), Convert.ToString(reader["CENTROCOSTO"]),
                        Convert.ToString(reader["DESCRIPCION"]), Convert.ToString(reader["PERSONA"]), Convert.ToString(reader["SUCURSAL"]));
                    ess2.Add(item);
                }
            }
            return ess2;
        }

        public override LgImplPedServApNoOSs ObtenerLgImplPedServApNoOSSelAll()
        {
            LgImplPedServApNoOSs oData = new LgImplPedServApNoOSs();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Control16");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplPedServApNoOS oRow = new LgImplPedServApNoOS(Convert.ToString(oDataReader["PROY"]), Convert.ToString(oDataReader["ALM"]),
                        Convert.ToString(oDataReader["TPED"]), Convert.ToString(oDataReader["EPED"]), Convert.ToString(oDataReader["NPEDM"]),
                        Convert.ToString(oDataReader["CODREC"]), Convert.ToString(oDataReader["REC"]), Convert.ToString(oDataReader["UN"]),
                        Convert.ToString(oDataReader["CPED"]), Convert.ToString(oDataReader["OBSPED"]), Convert.ToString(oDataReader["FPED"]),
                        Convert.ToString(oDataReader["FAPR"]), Convert.ToString(oDataReader["DIAPRO"]), Convert.ToString(oDataReader["ITEM"]),
                        Convert.ToString(oDataReader["USREG"]), Convert.ToString(oDataReader["USAPRO"]), Convert.ToString(oDataReader["ESTOR"]),
                        Convert.ToString(oDataReader["ESTAL"]), Convert.ToString(oDataReader["ESTCOT"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplOSNoFCs ObtenerLgImplOSNoFCSelAll()
        {
            LgImplOSNoFCs oData = new LgImplOSNoFCs();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Control17");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplOSNoFC oRow = new LgImplOSNoFC(Convert.ToString(oDataReader["Proyecto"]), Convert.ToString(oDataReader["CodOrden"]),
                        Convert.ToString(oDataReader["TipoOrden"]), Convert.ToString(oDataReader["Fecha"]), Convert.ToString(oDataReader["OSEstado"]),
                        Convert.ToString(oDataReader["Proveedor"]), Convert.ToString(oDataReader["CodInsumo"]), Convert.ToString(oDataReader["Recurso"]),
                        Convert.ToString(oDataReader["Unidad"]), Convert.ToString(oDataReader["Cantidad"]), Convert.ToString(oDataReader["Precio"]),
                        Convert.ToString(oDataReader["Total"]), Convert.ToString(oDataReader["EstadoFacturado"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }

        public override LgImplPrestamoRecursos ObtenerLgImplPrestamoRecursoSelAll()
        {
            LgImplPrestamoRecursos oData = new LgImplPrestamoRecursos();
            DbCommand oComando = this.BaseReportes.GetStoredProcCommand("dbo.Control19");
            using (SqlDataReader oDataReader = (SqlDataReader)this.BaseReportes.ExecuteReader(oComando))
            {
                while (oDataReader.Read())
                {
                    LgImplPrestamoRecurso oRow = new LgImplPrestamoRecurso(Convert.ToString(oDataReader["ProyectoDestino"]), Convert.ToString(oDataReader["Movimiento"]),
                        Convert.ToString(oDataReader["ParcialSinIGV"]), Convert.ToString(oDataReader["ProyectoOrigen_Destino"]), Convert.ToString(oDataReader["Ano"]),
                        Convert.ToString(oDataReader["Mes"]));
                    oData.Add(oRow);
                }
            }
            return oData;
        }
    }
}
