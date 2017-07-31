using System.Collections.Generic;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogic;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;
using System;
using System.Collections;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Nexcom.FrontEnd_Alerta_S10_GuiAlmacen_cs
{
    public partial class FrmAlert : Form
    {
        public FrmAlert()
        {
            InitializeComponent();
        }

        private void FrmAlert_Load(object sender, EventArgs e)
        {
            
            LgImplGuiaAlmacenDs controls = (LgImplGuiaAlmacenDs)ObImplControl.PoblarLgImplGuiaAlmacenDSelAll();
            if (controls.Count > 0)
            {
                
                this.EnvioGuiaD();
                this.Actualizar_DatoEnvioGuiaD();
            }
            this.Dispose();
        }

        private void EnvioGuiaD()
        {
            MailMessage message = new MailMessage();
            message.To.Add("arosales@nexcom.com.pe");
            //message.CC.Add("lperez@nexcom.com.pe");
            //message.CC.Add("scelestino@nexcom.com.pe");
            message.From = new MailAddress("noresponder@nexcom.com.pe", "Verificar Guias de Almacen en el S10 ERP.", Encoding.UTF8);
            message.Subject = "Alerta de Control -> Verificar Guias de Almacen en el S10 ERP.";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.TextoEnvioGuiaD();
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

        private string TextoEnvioGuiaD()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = ((((((((((((((str + "<body><center> ") + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>" +
                "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>") + 
                "<br>El listado presentado a continuacion son los que deben ser corroborado en ERP S10, en las Guias de Almacen." + "</div><br>") + 
                "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>" + "<table width='1070'  cellpadding='2'>") + 
                "<tr><td colspan='2'>" + "<hr /> </td></tr>") + 
                "<tr><td width='40' valign='top' style='text-align:center;background-color:yellow;font-size:8px; font-family:Arial'>Transaccion</td>" + 
                "<td width='40' valign='top' style='text-align:center;background-color:yellow;font-size:8px; font-family:Arial'>Trans. Realizado Por</td>") + 
                "<td width='40' valign='top' style='text-align:center;background-color:yellow;font-size:8px; font-family:Arial'>Desde IP</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:yellow;font-size:8px; font-family:Arial'>Trans. Realizado el</td>") + 
                "<td width='160' valign='top' style='text-align:center;background-color:green;font-size:8px; font-family:Arial'>Proyecto</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:green;font-size:8px; font-family:Arial'>Almacen</td>") + 
                "<td width='40' valign='top' style='text-align:center;background-color:green;font-size:8px; font-family:Arial'>Movimiento</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:green;font-size:8px; font-family:Arial'>Nro. Gu\x00eda</td>") + 
                "<td width='40' valign='top' style='text-align:center;background-color:green;font-size:8px; font-family:Arial'>Fecha Gu\x00eda</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:green;font-size:8px; font-family:Arial'>C\x00f3digo Recurso</td>") + 
                "<td width='220' valign='top' style='text-align:center;background-color:green;font-size:8px; font-family:Arial'>Recurso</td>" + 
                "<td width='20' valign='top' style='text-align:center;background-color:green;font-size:8px; font-family:Arial'>Unidad</td>") + 
                "<td width='30' valign='top' style='text-align:center;background-color:green;font-size:8px; font-family:Arial'>Cantidad</td>" + 
                "<td width='30' valign='top' style='text-align:center;background-color:green;font-size:8px; font-family:Arial'>Precio</td>") + 
                "<td width='20' valign='top' style='text-align:center;background-color:green;font-size:8px; font-family:Arial'>Moneda</td>" + 
                "<td width='30' valign='top' style='text-align:center;background-color:green;font-size:8px; font-family:Arial'>Parcial</td>") + 
                "<td width='20' valign='top' style='text-align:center;background-color:green;font-size:8px; font-family:Arial'>Creado por</td>" + 
                "<td width='40' valign='top' style='text-align:center;background-color:green;font-size:8px; font-family:Arial'>Fecha creaci\x00f3n</td>") +
                "<td width='20' valign='top' style='text-align:center;background-color:green;font-size:8px; font-family:Arial'>Actualizado por</td>" + 
                "<td width='40' valign='top' style='text-align:center;background-color:green;font-size:8px; font-family:Arial'>Fecha actualizaci\x00f3n</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplGuiaAlmacenDSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplGuiaAlmacenD current = (LgImplGuiaAlmacenD)enumerator.Current;
                    if ((((current.Abreviatura == "I I") | (current.Abreviatura == "I DPR")) | (current.Abreviatura == "E PRO")) | (current.Abreviatura == "E AC"))
                    {
                        str = str + "<tr bgcolor='#ECF9FF'>";
                    }
                    else
                    {
                        str = str + "<tr>";
                    }
                    if (current.Estado == "Adicion")
                    {
                        str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Estado + "</td>";
                    }
                    else
                    {
                        str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;color:red'>" + current.Estado + "</td>";
                    }
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Usuario + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Ip + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Fecha + "</td>";
                    str = str + "<td width='160' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Proyecto + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Almacen + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Abreviatura + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Codguia + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Fechaguia + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Codinsumo + "</td>";
                    str = str + "<td width='220' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Insumo + "</td>";
                    str = str + "<td width='20' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Unidad + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Cantidad + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Precio + "</td>";
                    str = str + "<td width='20' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Moneda + "</td>";
                    str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Parcial + "</td>";
                    str = str + "<td width='20' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Cu + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Cf + "</td>";
                    str = str + "<td width='20' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Au + "</td>";
                    str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Af + "</td></tr>";
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

        private void Actualizar_DatoEnvioGuiaD()
        {
            foreach (LgImplGuiaAlmacenD oRow in (IEnumerable<LgImplGuiaAlmacenD>) ObImplControl.PoblarLgImplGuiaAlmacenDSelAll())
            {
                ObImplControl.ActualizarGuiaAlmacenDTmpSelAll(oRow.Iditem);
            }
        }

    }
}
