using System;
using System.Collections;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogic;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;

namespace Nexcom.FrontEnd_Alerta_S10_RecursoCeroNegativo_cs
{
    public partial class FrmAlert : Form
    {
        public FrmAlert()
        {
            InitializeComponent();
        }

        private void FrmAlert_Load(object sender, EventArgs e)
        {
            LgImplRecursoCeroNegativos ceroNetativo = (LgImplRecursoCeroNegativos)ObImplControl.PoblarLgImplRecursoCeroNegativoSelAll();
            if (ceroNetativo.Count > 0)
            {
                this.EnvioCeroNegativo();
            }
            this.Dispose();
        }

        private void EnvioCeroNegativo()
        {
            MailMessage message = new MailMessage();
            //Lista para enviar a Operaciones
            message.To.Add("arosales@nexcom.com.pe");
            //message.Bcc.Add("jalvarez@nexcom.com.pe");
            message.Bcc.Add("personal_almacen@nexcom.com.pe");

            //Lista para enviar a GAF
            //message.Bcc.Add("lperez@nexcom.com.pe");
            //message.Bcc.Add("scelestino@nexcom.com.pe");
            
            message.From = new MailAddress("noresponder@nexcom.com.pe", "Recursos con Cantidad y/o Precio en cero y/o negativo.", Encoding.UTF8);
            message.Subject = "Alerta de Control -> Recursos con Cantidad y/o Precio en cero y/o negativo.";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.TextoCeroNetativo();
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

        private string TextoCeroNetativo()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = ((((((((((((str + "<body><center> ") + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>" +
                "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>") + 
                "<br>El listado presentado a continuaci\x00f3n son los primeros 500 Recursos con Cantidades y Precios tanto en Negativos y/o Ceros." +
                "</div><br>") + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>" + 
                "<table width='1390'  cellpadding='3'>") + "<tr><td colspan='2'>" + "<hr /> </td></tr>") + 
                "<tr><td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROYECTO</td>" +
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ALMACEN</td>") +
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>MOVIMIENTO</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FECHAGUIA</td>") + 
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>NROGUIA</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CODRECURSO</td>") + 
                "<td width='220' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>RECURSO</td>" + 
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>UNIDAD</td>") + 
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CANTIDAD</td>" + 
                "<td width='100' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PRECIO</td>") +
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>USUARIOREGISTRADOR</td>" +
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>USUARIOMODIFICADOR</td>") +
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>USUARIOCREADOR</td>" + 
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ACTUALIZACIONUSUARIO</td>") + 
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CREACIONFECHA</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ACTUALIZACIONFECHA</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplRecursoCeroNegativoSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplRecursoCeroNegativo current = (LgImplRecursoCeroNegativo)enumerator.Current;
                    str = str + "<tr><td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Proyecto + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Almacen + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Movimiento + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Fechaguia + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Nroguia + "</td>";
                    str = str + "<td width='120' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Codrecurso + "</td>";
                    str = str + "<td width='220' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Recurso + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Unidad + "</td>";
                    str = str + "<td width='100' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Cantidad + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Precio + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Usuarioregistrador + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Usuariomodificador + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Usuariocreador + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Actualizacionusuario + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Creacionfecha + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Actualizacionfecha + "</td></tr>";
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
