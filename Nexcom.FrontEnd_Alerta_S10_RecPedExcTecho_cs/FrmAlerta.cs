using System;
using System.Collections;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogic;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;

namespace Nexcom.FrontEnd_Alerta_S10_RecPedExcTecho_cs
{
    public partial class FrmAlerta : Form
    {
        public FrmAlerta()
        {
            InitializeComponent();
        }

        private void FrmAlerta_Load(object sender, EventArgs e)
        {
            LgImplRecPedExcedenTechos controls = (LgImplRecPedExcedenTechos)ObImplControl.PoblarLgImplRecPedExcedenTechoSelAll();
            if (controls.Count > 0)
            {
                this.Envio();
            }

            this.Dispose();
        }

        private void Envio()
        {
            MailMessage message = new MailMessage();
            //Lista para enviar a Operaciones
            message.To.Add("arosales@nexcom.com.pe");
            message.Bcc.Add("ecoasaca@nexcom.com.pe");
            message.Bcc.Add("kvilca@nexcom.com.pe");
            message.Bcc.Add("jcahuana@nexcom.com.pe");
            //message.Bcc.Add("yyabiku@nexcom.com.pe");

            //Lista para enviar a GAF
            //message.Bcc.Add("scelestino@nexcom.com.pe");
            //message.Bcc.Add("odepando@nexcom.com.pe");
            //message.Bcc.Add("vmelendez@nexcom.com.pe");

            message.From = new MailAddress("noresponder@nexcom.com.pe", "Recursos en Pedidos de Compra y/o Servicio que exceden del techo presupuestado.", Encoding.UTF8);
            message.Subject = "Alerta de Control -> Verificar/Analizar/Corregir los Recursos en Pedidos de Compra y/o Servicio que exceden del techo presupuestado.";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.Texto();
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
        private string Texto()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = ((((((((((((((str + "<body><center> ") + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>" + "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>") + "<br>El listado presentado a continuacion son los Recursos de Pedidos que exceden del Techo." + "</div><br>") + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>" + "<table width='1240'  cellpadding='3'>") + "<tr><td colspan='2'>" + "<hr /> </td></tr>") + "<tr><td width='320' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROYECTO</td>" + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ALMACEN</td>") + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>TIPOPEDIDO</td>" + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ESTADOPEDIDO</td>") + "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>NROPEDIDO</td>" + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CODRECURSO</td>") + "<td width='120' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>RECURSO</td>" + "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>UNIDAD</td>") + "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CANTPEDIDO</td>" + "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CANTTECHO</td>") + "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>EXCEDETECHO</td>" + "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CANTXPEDIR</td>") + "<td width='100' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>OBSPEDIDO</td>" + "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FECHAPEDIDO</td>") + "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FECHAAPROBACION</td>" + "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>USUARIOREGISTRO</td>") + "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>USUARIOAPROBACION</td>" + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ESTADOORDEN</td>") + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ESTADOALMACEN</td>" + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ESTADOCOTIZACION</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplRecPedExcedenTechoSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplRecPedExcedenTecho current = (LgImplRecPedExcedenTecho)enumerator.Current;
                    str = str + "<tr><td width='320' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Proy + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Alm + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Tped + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Eped + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Npedm + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Codrec + "</td>";
                    str = str + "<td width='120' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Rec + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Un + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Cped + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Ctec + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Extec + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Cxped + "</td>";
                    str = str + "<td width='100' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Obsped + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Fped + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Fapr + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Usreg + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Usapro + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Estor + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Estal + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Estcot + "</td></tr>";
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
