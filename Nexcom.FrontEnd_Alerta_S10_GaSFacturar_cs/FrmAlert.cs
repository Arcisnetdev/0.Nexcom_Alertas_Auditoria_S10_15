using System;
using System.Collections;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogic;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;

namespace Nexcom.FrontEnd_Alerta_S10_GaSFacturar_cs
{
    public partial class FrmAlert : Form
    {
        public FrmAlert()
        {
            InitializeComponent();
        }

        private void FrmAlert_Load(object sender, EventArgs e)
        {
            LgImplGasFacturars controls = (LgImplGasFacturars)ObImplControl.PoblarLgImplGasFacturarSelAll();

            if (controls.Count > 0)
            {
                this.EnvioAlertaGuiasASinFacturar();
            }
            this.Dispose();
        }
        private void EnvioAlertaGuiasASinFacturar()
        {
            MailMessage message = new MailMessage();
            //Lista para envio a Operaciones
            message.To.Add("arosales@nexcom.com.pe");
            //message.Bcc.Add("jcahuana@nexcom.com.pe");
            ////message.Bcc.Add("jmiguel@nexcom.com.pe");
            //message.Bcc.Add("klandeo@nexcom.com.pe");
            //message.Bcc.Add("kvilca@nexcom.com.pe");
            //message.Bcc.Add("jramirez@nexcom.com.pe");
            
            //Lista para envio a GAF
            //message.Bcc.Add("srondon@nexcom.com.pe");
            //message.Bcc.Add("lperez@nexcom.com.pe");
            //message.Bcc.Add("jguerrero@nexcom.com.pe");

            message.From = new MailAddress("noresponder@nexcom.com.pe", "Guias de Ingreso por OC/S pendiente de regularizar con factura de compra.", Encoding.UTF8);
            message.Subject = "Alerta de Control -> Guias de Ingreso por OC/S pendiente de regularizar con factura de compra - 07 dias vencidos.";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.TextoEnvioAlertaGuiasASinFacturar();
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

        private string TextoEnvioAlertaGuiasASinFacturar()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = (((((((str + "<body><center> " + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>") +
                "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>" +
                "<br>El listado presentado a continuacion son los que deben ser corroborado en ERP S10.") + "</div><br>" +
                "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + "<table width='860'  cellpadding='3'>" +
                "<tr><td colspan='2'>") + "<hr /> </td></tr>" +
                "<tr><td width='400' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROYECTO</td>") +
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>NRO_ORDEN</td>" +
                "<td width='90' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ALMACEN</td>") +
                "<td width='50' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>COD_GUIA</td>" +
                "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FECHA GUIA</td>") +
                "<td width='70' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>NRO GUIA REMISION</td>" +
                "<td width='180' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROVEEDOR</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplGasFacturarSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplGasFacturar current = (LgImplGasFacturar)enumerator.Current;
                    str = str + "<tr><td width='400' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Proyecto + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Nrooc + "</td>";
                    str = str + "<td width='90' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Almacen + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Codguia + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Fechaguia + "</td>";
                    str = str + "<td width='70' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Nroguiaremision + "</td>";
                    str = str + "<td width='180' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Proveedor + "</td></tr>";
                }
            }
            finally
            {
                //    if (enumerator is IDisposable)
                //    {
                //        (enumerator as IDisposable).Dispose();
                //    }
            }
            return (((str + "</table>" + "</div>") + "<hr /><div style='font-size:10px; padding-left:30px; padding-right:30px'>" +
                "<strong><em>Nexos Comerciales S.A</em></strong><br><br>") +
                "<strong>P.D:</strong> Este correo es solo para confirmar el estado de recepcion. Agradeceremos no responderlo.</div> </div>" +
                "</center></body></html>");
        }

    }
}
