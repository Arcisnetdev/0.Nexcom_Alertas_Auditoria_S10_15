using System;
using System.Collections;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogic;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;

namespace Nexcom.FrontEnd_Alerta_S10_Transferencia_cs
{
    public partial class FrmAlert : Form
    {
        public FrmAlert()
        {
            InitializeComponent();
        }

        private void FrmAlert_Load(object sender, EventArgs e)
        {
            LgImplSegTransferencias controls = (LgImplSegTransferencias)ObImplControl.PoblarLgImplSegTransferenciaSelAll();

            if (controls.Count > 0)
            {
                this.EnvioAlertaTransferencias();
            }
            this.Dispose();
        }

        void EnvioAlertaTransferencias()
        {
            MailMessage message = new MailMessage();
            //Lista para enviar a Operaciones
            message.Bcc.Add("arosales@nexcom.com.pe");
            message.To.Add("jalvarez@nexcom.com.pe");
            message.To.Add("jcahuana@nexcom.com.pe");
            message.CC.Add("personal_almacen@nexcom.com.pe");

            //Lista para enviar a GAF
            //message.To.Add("lperez@nexcom.com.pe");
            //message.CC.Add("scelestino@nexcom.com.pe");
            //message.CC.Add("odepando@nexcom.com.pe");
            //message.CC.Add("mbuchanan@nexcom.com.pe");

            message.From = new MailAddress("noresponder@nexcom.com.pe", "Movimientos de Almacen ETE y ETEP Pendientes de Ingreso Proyecto destino.", Encoding.UTF8);
            message.Subject = "Alerta de Control -> Movimientos de Almacen ETE y ETEP Pendientes de Ingreso Proyecto destino.";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.ContenidoAlertaTransf();
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("192.168.100.2")
            {
                Port = 25,
                Host = "192.168.100.2"
            };
            try
            {
                client.Send(message);
            }
            catch (SmtpException ex)
            {
                SmtpException exception = ex;
            }

        }
        
       
        private string ContenidoAlertaTransf()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = (((((str + "<body><center> " + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:800px;'>") +
                "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>" +
                "<br>El listado presentado a continuacion son los que deben ser corroborado en ERP S10.") + "</div><br>" +
                "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + "<table width='2200'  cellpadding='2'>" +
                "<tr><td width='880' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROYECTO_ORIGEN</td>") +
                "<td width='80' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>VALORIZADO (S/.)</td>" +
                "<td width='80' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ESTADO_PROYECTO</td>") +
                "<td width='880' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROYECTO_DESTINO</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplSegTansferenciaGgSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplSegTansferenciaGg current = (LgImplSegTansferenciaGg)enumerator.Current;
                    str = str + "<tr><td width='880' valign='top' style='font-size:8px; font-family:Arial;text-align:left;color:#000000'>" + current.Proyecto + "</td>";
                    str = str + "<td width='80' valign='top' style='font-size:8px; font-family:Arial;text-align:center;color:red'> " + current.Total + "</td>";
                    str = str + "<td width='80' valign='top' style='font-size:8px; font-family:Arial;text-align:center;color:red'> " + current.Estado + "</td>";
                    str = str + "<td width='880' valign='top' style='font-size:8px; font-family:Arial;text-align:left;color:#000000'>" + current.Destino + "</td></tr>";
                }
            }
            finally
            {
                //if (enumerator is IDisposable)
                //{
                //    (enumerator as IDisposable).Dispose();
                //}
            }
            str = ((((((((((((((((str + "</table>") + "</div>" + "<hr /> </td></tr>") + "<table width='2200'  cellpadding='2'>" +
                "<tr><td colspan='7'>") + "</td></tr>" + "<tr><td colspan='7'>") + "</div><br>" +
                "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") +
                "<tr><td width='100' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-bottom-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>Proyecto</td>" + 
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>Almacen</td>") + 
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>CodGuia</td>" + 
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>FechaGuia</td>") + 
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>SerieDocumento</td>" + 
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>NroDocumento</td>") + 
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>MovimientoOrigen</td>" + 
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>EstadoCierre</td>") +
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>CodigoRecurso</td>" +
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>Recurso</td>") +
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>Simbolo</td>" +
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>TipoCambio</td>") + 
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>Parcial</td>" +
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>Igv</td>") + 
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>Total</td>" + 
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>CodPedido</td>") + 
                "<td width='100' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>ProyectoDestino</td>" +
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#DF0101;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>CodGuiaRelacion</td>") +
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>CreacionUsuario</td>" + 
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>CreacionFecha</td>") + 
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>ActualizacionUsuario</td>" + 
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>ActualizacionFecha</td>") +
                "<td width='50' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>Ano</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplSegTransferenciaSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplSegTransferencia current = (LgImplSegTransferencia)enumerator.Current;
                    str = str + "<tr><td width='100' valign='top' style='font-size:8px; font-family:Arial;text-align:left;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'> " + current.Proyecto + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'> " + current.Almacen + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'> " + current.CodGuia + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.FechaGuia + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.SerieDocumento + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.NroDocumento + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'> " + current.MovimientoOrigen + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'> " + current.EstadoCierre + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'> " + current.CodRecurso + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'> " + current.Recurso + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'> " + current.Simbolo + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'> " + current.TipoCambio + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.Parcial + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.Igv + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.Total + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.CodPedido + "</td>";
                    str = str + "<td width='100' valign='top' style='font-size:8px; font-family:Arial;text-align:left;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.ProyectoDestino + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#DF0101;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>" + current.CodGuiaRelacion + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.CreacionUsuario + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.CreacionFecha + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.ActualizacionUsuario + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.ActualizacionFecha + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-right-style: dashed;border-right-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>" + current.Ano + "</td></tr>";
                }
            }
            finally
            {
                //if (enumerator2 is IDisposable)
                //{
                //    (enumerator2 as IDisposable).Dispose();
                //}
            }
            return (((str + "</table>" + "</div>") + "<hr /><div style='font-size:10px; padding-left:30px; padding-right:30px'>" +
                "<strong><em>Nexos Comerciales S.A</em></strong><br><br>") +
                "<strong>P.D:</strong> Este correo es solo para confirmar el estado de recepcion. Agradeceremos no responderlo.</div> </div>" +
                "</center></body></html>");
        }


    }

}
