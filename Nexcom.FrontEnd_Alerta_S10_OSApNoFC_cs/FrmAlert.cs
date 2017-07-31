using System;
using System.Collections.Generic;
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

namespace Nexcom.FrontEnd_Alerta_S10_OSApNoFC_cs
{
    public partial class FrmAlert : Form
    {
        public FrmAlert()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LgImplOSNoFCs envioOSNF = (LgImplOSNoFCs)ObImplControl.PoblarLgImplOSNoFCSelAll();

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

            message.From = new MailAddress("noresponder@nexcom.com.pe", "Ordenes de Servicio No Facturados.", Encoding.UTF8);
            message.Subject = "Alerta de Control -> Ordenes de Servicio No Facturados.";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.Texto3();
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

        private string Texto3()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = ((((((((((str + "<body><center> " + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>") +
                "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>" +
                "<br>El listado presentado a continuacion son las Ordenes de Servicio aprobados pendientes de facturación a la fecha.") +
                "</div><br>" + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + "<table width='890'  cellpadding='3'>" +
                "<tr><td colspan='2'>") + "<hr /> </td></tr>" +
                "<tr><td width='320' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROYECTO</td>") +
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CODORDEN</td>" +
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>TIPOORDEN</td>") +
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FECHAORDEN</td>" +
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ESTADOORDEN</td>") +
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROVEEDOR</td>" +
                "<td width='120' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CODRECURSO</td>") +
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>RECURSO</td>" +
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>UNIDAD</td>") +
                "<td width='100' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CANTIDAD</td>" +
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PRECIO</td>") +
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>TOTAL</td>" +
                "<td width='30' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ESTADOFACTURADO</td></tr>";

            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplOSNoFCSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplOSNoFC current = (LgImplOSNoFC)enumerator.Current;
                    str = str + "<tr><td width='320' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Proyecto + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Codos + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Tipoos + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Fecha + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Osestado + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Proveedor + "</td>";
                    str = str + "<td width='120' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Codinsumo + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Recurso + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Unidad + "</td>";
                    str = str + "<td width='100' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Cantidad + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Precio + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Total + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Estadofacturado + "</td></tr>";

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
