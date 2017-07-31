using Nexcom.Backend_Alerta_S10.Business.BusinessLogicS10;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nexcom.FrontEnd_Alerta_S10_ObligacionesSpring_cs
{
    public partial class FrmAlerta : Form
    {
        public FrmAlerta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Cabecera_Spring();
            this.Detalle_Spring();
            this.Dispose();
             }

        private void Cabecera_Spring()
        {
            IEnumerator enumerator;
            IEnumerator enumerator2 = null;

            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplCabeceraS10SelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplCabeceraS10 current = (LgImplCabeceraS10)enumerator.Current;
                    if (Convert.ToDouble(current.ENRDOC) == 1.0)
                    {
                        if (Convert.ToDouble(current.EP) == 1.0)
                        {
                            if (Convert.ToDouble(current.ECC) == 1.0)
                            {
                                string str = Convert.ToString(current.FechaDocumento) ;
                                string str2 = Convert.ToString(current.FechaVencimiento) ;
                                string str3 = Convert.ToString(current.FechaVencimientoOriginal);
                                ObImplControl.InsertarLgImplCabeceraS10_To_SpringSelAll(current.Proveedor, current.NumeroDocumento, current.TipoDocumento, current.CompaniaCodigo, current.FechaRegistro,
                                    Convert.ToDateTime(str), current.FechaRecepcion, Convert.ToDateTime(str2), Convert.ToDateTime(str3), current.MonedaDocumento, current.TipoServicio,
                                    Convert.ToDecimal(current.MontoAdelantos), Convert.ToDecimal(current.MontoImponible), Convert.ToDecimal(current.MontoImpuestoVentas),
                                    Convert.ToDecimal(current.MontoImpuesto), Convert.ToDecimal(current.MontoObligacion), Convert.ToDecimal(current.MontoAdelantos),
                                    Convert.ToDecimal(current.MontoPagoParcial), Convert.ToDecimal(current.MontoCreditoFiscal), current.UnidadNegocio, current.UnidadReplicacion, 
                                    current.FlujoCaja, current.CentroCostos, current.OC, current.ProveedorPagarA, current.PagarANombre, current.GenerarPago, current.TipoPago, current.MonedaPago,
                                    current.IngresadoPor, current.Comentarios, current.ComentariosAdicional, current.Usuario, current.NumeroAdelanto, current.TipoAdelanto, current.CuentaAbono,
                                    current.AdministradorRubro, current.Contacto);
                            }
                            else
                            {
                                ObImplControl.InsertarLgImplCabeceraS10_To_SpringTmp1SelAll(current.Proveedor, current.NumeroDocumento, current.TipoDocumento, current.FechaRegistro, "NCC");
                            }
                        }
                        else
                        {
                            ObImplControl.InsertarLgImplCabeceraS10_To_SpringTmp2SelAll(current.Proveedor, current.NumeroDocumento, current.TipoDocumento, current.FechaRegistro, "NE");
                        }
                    }
                    else
                    {
                        ObImplControl.InsertarLgImplCabeceraS10_To_SpringTmp3SelAll(current.Proveedor, current.NumeroDocumento, current.TipoDocumento, current.FechaRegistro, "NNRDOC");
                    }
                }
            }
            finally
            {
                if (enumerator2 is IDisposable)
                {
                    ((IDisposable)enumerator2).Dispose();
                }
            }
        }

        private void Detalle_Spring()
        {
            IEnumerator enumerator;
            IEnumerator enumerator2=null;
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplDetalleS10SelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplDetalleS10 current = (LgImplDetalleS10)enumerator.Current;
                    ObImplControl.InsertarLgImplDetalleS10_To_SpringSelAll(current.CompaniaCodigo, current.Proveedor, current.TipoDocumento, current.NumeroDocumento, 
                        current.Linea, Convert.ToDecimal(current.Monto), current.CuentaContable, current.Proyecto, current.CentroCosto, current.Descripcion, current.Persona, current.Sucursal);
                }
            }
            finally
            {
                if (enumerator2 is IDisposable)
                {
                    ((IDisposable)enumerator2).Dispose();
                }
            }
        }


    }
}
