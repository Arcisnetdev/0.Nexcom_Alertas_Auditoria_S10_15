using Nexcom.Backend_Alerta_S10.Business.BusinessLogic;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;
using System;
using System.Collections;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Nexcom.FrontEnd_Alerta_S10_RecApro7moDia
{
    public partial class FrmAlert : Form
    {
        public FrmAlert()
        {
            InitializeComponent();
        }

        private void FrmAlert_Load(object sender, EventArgs e)
        {
            LgImplRecApro7moDias ped7modia = (LgImplRecApro7moDias)ObImplControl.PoblarLgImplRecApro7MoDiaSelAll();


            if (ped7modia.Count > 0)
            {
                this.Envioped7modia();
            }
            this.Dispose();
        }

        private void Envioped7modia()
        {
            MailMessage message = new MailMessage();
            message.To.Add("arosales@nexcom.com.pe");
            //message.Bcc.Add("yyabiku@nexcom.com.pe");
            message.Bcc.Add("kvilca@nexcom.com.pe");
            message.Bcc.Add("wvigil@nexcom.com.pe");
            //message.Bcc.Add("dvasquez@nexcom.com.pe");
            message.Bcc.Add("jalvarez@nexcom.com.pe");
            message.Bcc.Add("jcahuana@nexcom.com.pe");

            message.From = new MailAddress("noresponder@nexcom.com.pe", "Primeros 500 recursos en OC y/o Servicio Aprobados sin ingreso a Almacen despues de 7 dias.", Encoding.UTF8);
            message.Subject = "Alerta de Control -> Primeros 500 recursos en OC y/o Servicio Aprobados sin ingreso a Almacen despues de 7 dias.";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.Textoped7modia();
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

        private string Textoped7modia()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = (((((((((((str + "<body><center> " + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>") + 
                "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>" + 
                "<br>El listado presentado a continuaci\x00f3n son los primeros 500 Recursos de Ordenes aprobados sin Ingreso al Almacen despues de 7 dias.") 
                + "</div><br>" + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + 
                "<table width='1390'  cellpadding='3'>" + "<tr><td colspan='2'>") + "<hr /> </td></tr>" + 
                "<tr><td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CODPROYECTO</td>") +
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROYECTO</td>" +
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROVEEDOR</td>") + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>TIPOORDEN</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ESTADOORDEN</td>") + 
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>NROORDEN</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CODRECURSO</td>") + 
                "<td width='220' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>RECURSO</td>" + 
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>UNIDAD</td>") + 
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CANTIDAD</td>" + 
                "<td width='100' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CAANTIDADEnAlmacen</td>") + 
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CANTIDADPorEntregar</td>" + 
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>UsuarioRegist</td>") + 
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FechaAprobacion</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>Dias_AprobOrden_Comp</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplRecApro7MoDiaSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplRecApro7moDia current = (LgImplRecApro7moDia)enumerator.Current;
                    str = str + "<tr><td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Codproyecto + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Proyecto + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Proveedor + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Tipoorden + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Estadoorden + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Nroorden + "</td>";
                    str = str + "<td width='120' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Codrecurso + "</td>";
                    str = str + "<td width='220' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Recurso + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Unidad + "</td>";
                    str = str + "<td width='100' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Cantidad + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Cantidadenalmacen + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Cantidadporentregar + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Usuarioregistrador + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Fechaaprobacion + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.DiasAprobordenComp + "</td></tr>";
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
