using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Nexcom.Backend_Alerta_S10.Business.BusinessLogicPedServ;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;
using System.Net.Mail;
using System.Collections;

namespace Nexcom.FrontEnd_Alerta_27_S10_ITE_Proyectos
{
    public partial class Alertas : Form
    {
        public Alertas()
        {
            InitializeComponent();
        }

        private void Alertas_Load(object sender, EventArgs e)
        {
            LgImplPrestamoRecursos envioOSNF = (LgImplPrestamoRecursos)ObImplControl.PoblarLgImplPrestamoRecursoSelAll();

            if (envioOSNF.Count > 0)
            {
                this.EnvioOSNF();
            }
            this.Dispose();
        }

        private void EnvioOSNF()
        {
            MailMessage message = new MailMessage();
            message.To.Add("arosales@nexcom.com.pe");
            //message.Bcc.Add("wvigil@nexcom.com.pe");
            //message.Bcc.Add("dvasquez@nexcom.com.pe");
            //message.Bcc.Add("jalvarez@nexcom.com.pe");
            //message.Bcc.Add("jramirez@nexcom.com.pe");
            //message.Bcc.Add("yyabiku@nexcom.com.pe");
            //message.Bcc.Add("kvilca@nexcom.com.pe");
            //message.Bcc.Add("jdelgado@nexcom.com.pe");

            message.From = new MailAddress("noresponder@nexcom.com.pe", "Prestamos realizados entre proyectos en el mes.", Encoding.UTF8);
            message.Subject = "Alerta de Control -> Prestamos realizados entre proyectos en el mes.";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.Texto3();
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("192.168.100.2")
            {
                Port = 25, //port number
                Host = "192.168.100.2" //server address
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


        private string Texto3()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = (((((((str + "<body><center> " + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:800px;'>") +
                "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>" +
                "<br>El listado presentado a continuacion son los prestamos realizados entre proyectos al mes, debe ser verificado en el sistema.") +
                "</div><br>" + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + "<table width='980'  cellpadding='3'>" +
                "<tr><td colspan='2'>") + "<hr /> </td></tr>" +
                "<tr><td width='400' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROYECTO DESTINO</td>") +
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>MOVIMIENTO</td>" +
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial;color:red'>PARCIAL S/.</td>") +
                "<td width='400' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROYECTO ORIGEN</td>" +
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>AÑO</td>") +
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>MES</td></tr>";

            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplPrestamoRecursoSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplPrestamoRecurso current = (LgImplPrestamoRecurso)enumerator.Current;
                    str = str + "<tr><td width='400' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Proyecto + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Movimiento + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;color:red'> " + current.Parcial + "</td>";
                    str = str + "<td width='400' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Proyorigen + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Ano + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Mes + "</td></tr>";

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
