using System;
using System.Collections;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogic;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;

namespace Nexcom.FrontEnd_Alerta_S10_AuditTechoProy_cs
{
    public partial class frmAlert : Form
    {
        public frmAlert()
        {
            InitializeComponent();
        }

        private void frmAlert_Load(object sender, EventArgs e)
        {
            LgImplAuditTechoProys techoproy = (LgImplAuditTechoProys)ObImplControl.PoblarLgImplAuditTechoProySelAll();


            if (techoproy.Count > 0)
            {
                this.Enviotechoproy();
            }
            this.Dispose();
        }

        private void Enviotechoproy()
        {
            MailMessage message = new MailMessage();
            message.To.Add("arosales@nexcom.com.pe");

            //message.To.Add("odepando@nexcom.com.pe");
            //message.To.Add("lperez@nexcom.com.pe");
            //message.To.Add("scelestino@nexcom.com.pe");

            message.From = new MailAddress("noresponder@nexcom.com.pe", "Verificar Techo del Proyecto en el S10 ERP.", Encoding.UTF8);
            message.Subject = "Alerta de Control -> Verificar Techo del Proyecto en el S10 ERP.";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.Textotechoproy();
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("192.168.100.2")
            {
                Port = 25, //puerto de servidor de correos local
                Host = "192.168.100.2" //direccion ip del servidor de correos o dominio
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

        private string Textotechoproy()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = ((((((str + "<body><center> " + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>") + "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>" + "<br>El listado presentado a continuacion son los que deben ser vereficados en ERP S10, en la opcion de TECHO DEL PROYECTO.") + "</div><br>" + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + "<table width='610'  cellpadding='7'>" + "<tr><td colspan='2'>") + "<hr /> </td></tr>" + "<tr><td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>CODIGO</td>") + "<td width='350' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>NOMBRE</td>" + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>USUARIO</td>") + "<td width='80' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>MAQUINA</td>" + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>FECHA</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplAuditTechoProySelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplAuditTechoProy current = (LgImplAuditTechoProy)enumerator.Current;
                    str = str + "<tr><td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.Codproyecto + "</td>";
                    str = str + "<td width='350' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'> " + current.Descripcion + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.Coduser + "</td>";
                    str = str + "<td width='80' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.Ip + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.Fecha + "</td></tr>";
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
