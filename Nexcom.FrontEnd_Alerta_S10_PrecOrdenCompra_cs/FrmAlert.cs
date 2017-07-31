using System;
using System.Collections;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogic;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;

namespace Nexcom.FrontEnd_Alerta_S10_PrecOrdenCompra_cs
{
    public partial class FrmAlert : Form
    {
        public FrmAlert()
        {
            InitializeComponent();
        }

        private void FrmAlert_Load(object sender, EventArgs e)
        {
            LgImplPrecioOrdenCompras controls = (LgImplPrecioOrdenCompras)ObImplControl.PoblarLgImplPrecioOrdenCompraSelAll();
            if (controls.Count > 0)
            {
                this.EnvioPrecioOc();
            }
            this.Dispose();
        }

        private void EnvioPrecioOc()
        {
            MailMessage message = new MailMessage();
            //Lista para enviar a Operaciones
            message.To.Add("jcahuana@nexcom.com.pe");
            message.Bcc.Add("arosales@nexcom.com.pe");

            //Lista para enviar a GAF
            //message.Bcc.Add("scelestino@nexcom.com.pe");
            //message.Bcc.Add("srondon@nexcom.com.pe");

            message.From = new MailAddress("noresponder@nexcom.com.pe", "Comparativo de precio de recursos en Orden de Compra y/o Servicio vs precio de compra anterior.", Encoding.UTF8);
            message.Subject = "Alerta de Control -> Comparativo de precio de recursos en Orden de Compra y/o Servicio vs precio de compra anterior.";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.TextoPrecioOC();
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

        private string TextoPrecioOC()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = ((((((((((((((str + "<body><center> " + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>") + 
                "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>" + 
                "<br>El listado presentado a continuaci\x00f3n son las Compras Aprobadas que exceden en precio a comparacion de una orden anterior.") +
                "</div><br>" + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + "<table width='1110'  cellpadding='3'>" + 
                "<tr><td colspan='2'>") + "<hr /> </td></tr>" + 
                "  <tr><td colspan='7' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-right-style: dashed;border-right-width:1px;border-left-style: dashed;border-left-width:1px'>ACTUAL</td> <td colspan='6' style='text-align:center;background-color:#FFF2CC;font-size:8px; font-family:Arial;border-color:#999;border-right-style: dashed;border-right-width:1px'>ANTERIOR</td><td colspan='3' style='text-align:center;background-color:#FFD9D9;font-size:8px; font-family:Arial;border-color:#999;border-right-style: dashed;border-right-width:1px'>RECURSO</td><td colspan='4' style='text-align:center;background-color:#F3F3F3;font-size:8px; font-family:Arial;border-color:#999;border-right-style: dashed;border-right-width:1px'>COMPARACION</td> </tr>") + 
                "<tr><td width='150' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>PROYECTO</td>" +
                "<td width='20' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>OC</td>") + 
                "<td width='30' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>FECHAREGISTRO</td>" + 
                "<td width='30' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>FECHAAPROBACION</td>") +
                "<td width='90' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>PROVEEDOR</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>FORMAPAGO</td>") +
                "<td width='60' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-right-style: dashed;border-right-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>COMPRADOR</td>" + 
                "<td width='150' valign='top' style='text-align:center;background-color:#FFF2CC;font-size:8px; font-family:Arial;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>PROYECTO</td>") +
                "<td width='20' valign='top' style='text-align:center;background-color:#FFF2CC;font-size:8px; font-family:Arial;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>OC</td>" +
                "<td width='30' valign='top' style='text-align:center;background-color:#FFF2CC;font-size:8px; font-family:Arial;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>FECHAREGISTRO</td>") + 
                "<td width='30' valign='top' style='text-align:center;background-color:#FFF2CC;font-size:8px; font-family:Arial;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>FECHAAPROBACION</td>" + 
                "<td width='90' valign='top' style='text-align:center;background-color:#FFF2CC;font-size:8px; font-family:Arial;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>PROVEEDOR</td>") + 
                "<td width='60' valign='top' style='text-align:center;background-color:#FFF2CC;font-size:8px; font-family:Arial;border-color:#999;border-right-style: dashed;border-right-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>COMPRADOR</td>" + 
                "<td width='30' valign='top' style='text-align:center;background-color:#FFD9D9;font-size:8px; font-family:Arial;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>CODIGO</td>") + 
                "<td width='120' valign='top' style='text-align:center;background-color:#FFD9D9;font-size:8px; font-family:Arial;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>DESCRIPCION</td>" + 
                "<td width='30' valign='top' style='text-align:center;background-color:#FFD9D9;font-size:8px; font-family:Arial;border-color:#999;border-right-style: dashed;border-right-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>UNIDAD</td>") + 
                "<td width='30' valign='top' style='text-align:center;background-color:#F3F3F3;font-size:8px; font-family:Arial;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>CANTIDAD ACTUAL</td>" +
                "<td width='40' valign='top' style='text-align:center;background-color:#F3F3F3;font-size:8px; font-family:Arial;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>PRECIO ACTUAL</td>") +
                "<td width='40' valign='top' style='text-align:center;background-color:#F3F3F3;font-size:8px; font-family:Arial;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>PRECIO ANTERIOR</td>" +
                "<td width='30' valign='top' style='text-align:center;background-color:#F3F3F3;font-size:8px; font-family:Arial;border-color:#999;border-right-style: dashed;border-right-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>DIFERENCIA(S/.)</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplPrecioOrdenCompraSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplPrecioOrdenCompra current = (LgImplPrecioOrdenCompra)enumerator.Current;
                    str = str + "<tr><td width='150' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'> " + current.Proyac + "</td>";
                    str = str + "<td width='20' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'> " + current.Ocac + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'> " + current.Froc + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.Faoc + "</td>";
                    str = str + "<td width='90' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.Provac + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.Desfpag + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'> " + current.Comac + "</td>";
                    str = str + "<td width='150' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'> " + current.Proyan + "</td>";
                    str = str + "<td width='20' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'> " + current.Ocan + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'> " + current.Froc2 + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.Faoc2 + "</td>";
                    str = str + "<td width='90' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.Provan + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.Coman + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>" + current.Codrec + "</td>";
                    str = str + "<td width='120' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.Desrec + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.U + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'> " + current.Cant + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.Sac + " " + current.Pac + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.San + " " + current.Pan + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-right-style: dashed;border-right-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>" + current.Dif + "</td></tr>";
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
