using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogic;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;

namespace Nexcom.FrontEnd_Alerta_S10_Techo02_cs
{
    public partial class FrmAlert : Form
    {
        public FrmAlert()
        {
            InitializeComponent();
        }

        private void FrmAlert_Load(object sender, EventArgs e)
        {
            LgImplAuditTechoA2s techos = (LgImplAuditTechoA2s)ObImplControl.PoblarLgImplAuditTechoA2SelAll();

            if (techos.Count < 0)
            {
                this.InsertaDetalle_Techo02();
            }
            else
            {
                this.InsertaDetalle_Techo02();
                this.EnvioAlertaTecho02(); 
            }
           this.Dispose();
        }

        private void EnvioAlertaTecho02()
        {
            MailMessage message = new MailMessage();
            message.CC.Add("arosales@nexcom.com.pe");
            //message.CC.Add("yyabiku@nexcom.com.pe");
            //message.CC.Add("ecoasaca@nexcom.com.pe");
            //message.CC.Add("kvilca@nexcom.com.pe");
            //message.CC.Add("jcahuana@nexcom.com.pe");
            //message.CC.Add("lperez@nexcom.com.pe");
            //message.CC.Add("personal_almacen@nexcom.com.pe");

            message.From = new MailAddress("noresponder@nexcom.com.pe", "Verificar transferencia de recursos que exceden el techo.", Encoding.UTF8);
            message.Subject = "Alerta de Control -> Verificar transferencia de recursos que exceden el techo.";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.ContenidoAlertaTecho02();
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
            catch (SmtpException)
            {
            }
        }

        private string ContenidoAlertaTecho02()
        {
            string str = "<html>";
            str = str + "<body><center> <div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'><br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong><br>El listado presentado a continuacion son los que deben ser corroborado en ERP S10, en el TECHO DE MATERIALES.</div><br><div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'><table width='1130'  cellpadding='3'><tr><td colspan='2'><hr /> </td></tr><tr><td width='350' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROYECTO</td><td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CODIGO</td><td width='140' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>RECURSO</td><td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>SIMBOLO</td><td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>TECHO</td><td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CANTXPEDIDO</td><td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CANTXALMACEN</td><td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CANTXPEDIR</td><td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ALMACEN_GUIA</td><td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>MOVIMIENTO</td><td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FECHA_GUIA</td><td width='20' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>GUIA</td><td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CANTIDAD</td><td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ULTIMO PRECIO COMPRA</td><td width='20' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>COSTO</td><td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>USUARIO_GUIA</td></tr>";
            try
            {
                IEnumerator enumerator = ((IEnumerable)ObImplControl.PoblarLgImplAuditTechoA2SelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplAuditTechoA2 current = (LgImplAuditTechoA2)enumerator.Current;
                    str = str + "<tr><td width='350' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Proyecto + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Codrecurso + "</td>";
                    str = str + "<td width='140' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Descripcion + "</td>";
                    str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Simbolo + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Techo + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Cpedido + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Calmacen + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Cpedir + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Guia + "</td>";
                    str = str + "<td width='20' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Cantidadguia + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Fechaguia + "</td>";
                    str = str + "<td width='20' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Almacen + "</td>";
                    str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Usuarioguia + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Precio + "</td>";
                    str = str + "<td width='20' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Costo + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Movimiento + "</td></tr>";
                }
            }
            finally
            {
            }
            return (str + "</table></div><hr /><div style='font-size:10px; padding-left:30px; padding-right:30px'><strong><em>Nexos Comerciales S.A</em></strong><br><br><strong>P.D:</strong> Este correo es solo para confirmar el estado de recepcion. Agradeceremos no responderlo.</div> </div></center></body></html>");
        }


        private void InsertaDetalle_Techo02()
        {
            try
            {

                foreach (LgImplAuditDTechoA oRow in (IEnumerable<LgImplAuditDTechoA>)ObImplControl.PoblarLgImplAuditDTechoASelAll())
                {
                    ObImplControl.InsertarLgImplAuditDTechoASelAll(oRow.Codrecurso, oRow.Descripcion, oRow.Simbolo, oRow.Cpedido, oRow.Proyecto,
                        oRow.Guia, oRow.Fechaguia, oRow.Cantidadguia, oRow.Usuarioguia, oRow.Almacen, oRow.Movimiento);
                }
               
            }
            catch (Exception ex)
            {
                Exception exception = ex;
            }
        }

    }
}
