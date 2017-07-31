using System;
using System.Collections;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogic;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;

namespace Nexcom.FrontEnd_Alerta_S10_AuditRecursoS10_cs
{
    public partial class FrmAlert : Form
    {
        public FrmAlert()
        {
            InitializeComponent();
        }

        private void FrmAlert_Load(object sender, EventArgs e)
        {
            LgImplAuditRecursoS10s recS10 = (LgImplAuditRecursoS10s)ObImplControl.PoblarLgImplAuditRecursoS10SelAll();


            if (recS10.Count > 0)
            {
                this.EnviorecS10();
            }
            this.Dispose();
        }

        private void EnviorecS10()
        {
            MailMessage message = new MailMessage();
            message.To.Add("arosales@nexcom.com.pe");
            //message.To.Add("lperez@nexcom.com.pe");
            //message.CC.Add("yyubiku@nexcom.com.pe");
            //message.CC.Add("jalvarez@nexcom.com.pe");
            //message.CC.Add("scelestino@nexcom.com.pe");

            message.From = new MailAddress("noresponder@nexcom.com.pe", "Verificar Recursos Creados en S10 ERP.", Encoding.UTF8);
            message.Subject = "Alerta de Control -> Verificar Recursos Creados en S10 ERP.";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.TextorecS10();
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

        private string TextorecS10()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = ((((((((((((str + "<body><center> ") + 
                "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>" + 
                "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>") +
                "<br>El listado presentado a continuacion son los que deben ser corroborado en ERP S10, en los RECURSOS." + "</div><br>") + 
                "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>" + 
                "<table width='1100'  cellpadding='2'>") + "<tr><td colspan='2'>" + "<hr /> </td></tr>") + 
                "<tr><td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>TIPO</td>" +
                "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CODINSUMO</td>") + 
                "<td width='300' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>DESCRIPCION</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FAMILIA0</td>") + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FAMILIA1</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FAMILIA2</td>") +
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>C.MATERIALES</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>C.ACTIVOS</td>") + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>C.OPERACIONES</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>C.ADMINISTRACION</td>") + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>C.COMERCIAL</td>" +
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CONSUMOD</td>") + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CONSUMOH</td>" + 
                "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>USUARIO</td>") + 
                "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>IP</td>" + 
                "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FECHA</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplAuditRecursoS10SelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplAuditRecursoS10 current = (LgImplAuditRecursoS10)enumerator.Current;
                    str = str + "<tr><td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Accion + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Codinsumo + "</td>";
                    str = str + "<td width='300' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Descripcion + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Nivelp + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Familia1 + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Familia2 + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Materiales + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Activos + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Servicioo + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Servicioa + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Servicioc + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Consumod + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Consumoh + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Login + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Ip + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Fecha + "</td></tr>";
                }
            }
            finally
            {
                //if (enumerator is IDisposable)
                //{
                //    (enumerator as IDisposable).Dispose();
                //}
            }
            return (((str + "</table>" + "</div>") + "<hr /><div style='font-size:10px; padding-left:30px; padding-right:30px'>" + "<strong><em>Nexos Comerciales S.A</em></strong><br><br>") + "<strong>P.D:</strong> Este correo es solo para confirmar el estado de recepcion. Agradeceremos no responderlo.</div> </div>" + "</center></body></html>");
        }

    }
}
