using System;
using System.Collections;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogic;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;

namespace Nexcom.FrontEnd_Alerta_S10_OCSFacturar_cs
{
    public partial class FrmAlerta : Form
    {
        public FrmAlerta()
        {
            InitializeComponent();
        }

        private void FrmAlerta_Load(object sender, EventArgs e)
        {
            LgImplOcsFacturars Ocsf = (LgImplOcsFacturars)ObImplControl.PoblarLgImplOcsFacturarSelAll();

            if (Ocsf.Count > 0)
            {
                this.EnvioOcsf();
            }
            this.Dispose();
        }

        private void EnvioOcsf()
        {
            MailMessage message = new MailMessage();
            //Lista para envio a Operaciones
            message.To.Add("arosales@nexcom.com.pe");
            message.Bcc.Add("jcahuana@nexcom.com.pe");
            //message.Bcc.Add("jramirez@nexcom.com.pe");
            message.Bcc.Add("klandeo@nexcom.com.pe");
            //message.Bcc.Add("jdelgado@nexcom.com.pe");
            message.Bcc.Add("jalvarez@nexcom.com.pe");

            //Lista para envio a GAF
            //message.Bcc.Add("jvillanueva@nexcom.com.pe");
            //message.Bcc.Add("lperez@nexcom.com.pe");
            //message.Bcc.Add("dzapata@nexcom.com.pe");

            message.From = new MailAddress("noresponder@nexcom.com.pe", "Recursos de Ordenes de Compra y/o Servicio pendientes de ingreso a Almacen.", Encoding.UTF8);
            message.Subject = "Alerta de Control -> Recursos de Ordenes de Compra y/o Servicio pendientes de ingreso a Almacen.";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.TextoEnvioOcsf();
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


        private string TextoEnvioOcsf()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = (((((((((str + "<body><center> " + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>") + "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>" + "<br>El listado presentado a continuacion son los que deben ser corroborado en ERP S10.") + "</div><br>" + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + "<table width='890'  cellpadding='3'>" + "<tr><td colspan='2'>") + "<hr /> </td></tr>" + "<tr><td width='350' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROYECTO</td>") + "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>COD_ORDEN</td>" + "<td width='140' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>TIPO</td>") + "<td width='50' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>COD_PROVEEDOR</td>" + "<td width='70' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROVEEDOR</td>") + "<td width='50' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>COD_INSUMO</td>" + "<td width='90' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>RECURSO</td>") + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>UNIDAD</td>" + "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CANTIDAD</td>") + "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PRECIO</td>" + "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>TOTAL</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplOcsFacturarSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplOcsFacturar current = (LgImplOcsFacturar)enumerator.Current;
                    str = str + "<tr><td width='350' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Proyecto + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Codorden + "</td>";
                    str = str + "<td width='140' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Tipoorden + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Codproveedor + "</td>";
                    str = str + "<td width='70' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Proveedor + "</td>";
                    str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Codinsumo + "</td>";
                    str = str + "<td width='90' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Recurso + "</td>";
                    str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Unidad + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Cantidad + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Precio + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Total + "</td></tr>";
                }
            }
            finally
            {
                //if (enumerator is IDisposable)
                //{
                //    (enumerator as IDisposable).Dispose();
                //}
            }
            return (((str + "</table>" + "</div>") + "<hr /><div style='font-size:10px; padding-left:30px; padding-right:30px'>" +
                "<strong><em>Nexos Comerciales S.A</em></strong><br><br>") +
                "<strong>P.D:</strong> Este correo es solo para confirmar el estado de recepcion. Agradeceremos no responderlo.</div> </div>" +
                "</center></body></html>");
        }

    }
}
