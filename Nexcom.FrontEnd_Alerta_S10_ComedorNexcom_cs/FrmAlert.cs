using System;
using System.Collections;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogicCom;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;

namespace Nexcom.FrontEnd_Alerta_S10_ComedorNexcom_cs
{
    public partial class FrmAlert : Form
    {
        public FrmAlert()
        {
            InitializeComponent();
        }

        private void FrmAlert_Load(object sender, EventArgs e)
        {
            LgImplComedors comedors = (LgImplComedors)ObImplControl.PoblarLgImplComedorSelAll();
            LgImplComedor2s comedors2 = (LgImplComedor2s)ObImplControl.PoblarLgImplComedor2SelAll();
            LgImplComedor3s comedors3 = (LgImplComedor3s)ObImplControl.PoblarLgImplComedor3SelAll();
            LgImplComedor4s comedors4 = (LgImplComedor4s)ObImplControl.PoblarLgImplComedor4SelAll();

        switch (Convert.ToUInt32(DateTime.Now.Hour.ToString("D2")))
            {
       
                case 9:
                    if (comedors.Count > 0)
                    {
                        this.Envio();
                    }
                    if (comedors2.Count > 0)
                    {
                        this.Envio2();
                    }
                    break;

                case 12:
                    if (comedors3.Count > 0)
                    {
                        this.Envio3();
                    }
                    if (comedors4.Count > 0)
                    {
                        this.Envio4();
                    }
                    break;
            }
            this.Dispose();
        }

        private void Envio()
        {
            MailMessage message = new MailMessage();
            message.To.Add("arosales@nexcom.com.pe");
            //message.To.Add("dbondy@nexcom.com.pe");
            //message.CC.Add("jreyna@nexcom.com.pe");
            message.From = new MailAddress("noresponder@nexcom.com.pe", "Alerta de Control - Pedidos Detallado", Encoding.UTF8);
            message.Subject = "Reporte de Pedidos Detallado";
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

        private void Envio2()
        {
            MailMessage message = new MailMessage();
            message.To.Add("arosales@nexcom.com.pe");
            //message.To.Add("dbondy@nexcom.com.pe");
            //message.CC.Add("jreyna@nexcom.com.pe");
            message.From = new MailAddress("noresponder@nexcom.com.pe", "Alerta de Control - Pedidos Resumido", Encoding.UTF8);
            message.Subject = "Reporte de Pedidos Resumido";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.Texto2();
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

        private void Envio3()
        {
            MailMessage message = new MailMessage();
            message.To.Add("arosales@nexcom.com.pe");
            //message.To.Add("dbondy@nexcom.com.pe");
            //message.CC.Add("jreyna@nexcom.com.pe");
            message.From = new MailAddress("noresponder@nexcom.com.pe", "Alerta de Control - Pedidos Carta Detallado", Encoding.UTF8);
            message.Subject = "Reporte de Pedidos Carta Detallado";
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

        private void Envio4()
        {
            MailMessage message = new MailMessage();
            message.To.Add("arosales@nexcom.com.pe");
            //message.To.Add("dbondy@nexcom.com.pe");
            //message.CC.Add("jreyna@nexcom.com.pe");
            message.From = new MailAddress("noresponder@nexcom.com.pe", "Alerta de Control - Pedidos Carta Resumido", Encoding.UTF8);
            message.Subject = "Reporte de Pedidos Carta Resumido";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.Texto4();
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
            str = (((((str + "<body><center> " + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>") + "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>" + "<br>El listado presentado a continuaci\x00f3n son los Pedidos en forma detallada del Sistema de Comedor.") + "</div><br>" + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + "<table width='500'  cellpadding='3'>" + "<tr><td colspan='2'>") + "<hr /> </td></tr>" + "<tr><td width='300' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:12px; font-family:Arial'>NOMBRE COMPLETO</td>") + "<td width='130' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:12px; font-family:Arial'>COMIDA</td>" + "<td width='70' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:12px; font-family:Arial'>CANTIDAD</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplComedorSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplComedor current = (LgImplComedor)enumerator.Current;
                    str = str + "<tr><td width='300' valign='top' style='font-size:12px; font-family:Arial;text-align:left;'>" + current.Nombrecompleto + "</td>";
                    str = str + "<td width='130' valign='top' style='font-size:12px; font-family:Arial;text-align:left;'> " + current.Comida + "</td>";
                    str = str + "<td width='70' valign='top' style='font-size:12px; font-family:Arial;text-align:center;'>" + current.Cantidad + "</td></tr>";
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

        private string Texto2()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = (((((str + "<body><center> ") + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>" + "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>") + "<br>El listado presentado a continuaci\x00f3n son los Pedidos en forma resumida del Sistema de Comedor." + "</div><br>") + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>" + "<table width='500'  cellpadding='3'>") + "<tr><td colspan='2'>" + "<hr /> </td></tr>") + "<tr><td width='330' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:12px; font-family:Arial'>NOMBRE DEL MENU</td>" + "<td width='70' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:12px; font-family:Arial'>TOTAL</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplComedor2SelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplComedor2 current = (LgImplComedor2)enumerator.Current;
                    str = str + "<tr><td width='330' valign='top' style='font-size:12px; font-family:Arial;text-align:left;'>" + current.Comida + "</td>";
                    str = str + "<td width='70' valign='top' style='font-size:12px; font-family:Arial;text-align:center;'>" + current.Total + "</td></tr>";
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

        private string Texto3()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = (((((str + "<body><center> " + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>") + "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>" + "<br>El listado presentado a continuaci\x00f3n son los Pedidos a la Carta en forma detallada del Sistema de Comedor.") + "</div><br>" + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + "<table width='500'  cellpadding='3'>" + "<tr><td colspan='2'>") + "<hr /> </td></tr>" + "<tr><td width='300' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:12px; font-family:Arial'>NOMBRE COMPLETO</td>") + "<td width='130' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:12px; font-family:Arial'>COMIDA</td>" + "<td width='70' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:12px; font-family:Arial'>CANTIDAD</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplComedor3SelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplComedor3 current = (LgImplComedor3)enumerator.Current;
                    str = str + "<tr><td width='300' valign='top' style='font-size:12px; font-family:Arial;text-align:left;'>" + current.Nombrecompleto + "</td>";
                    str = str + "<td width='130' valign='top' style='font-size:12px; font-family:Arial;text-align:left;'> " + current.Comida + "</td>";
                    str = str + "<td width='70' valign='top' style='font-size:12px; font-family:Arial;text-align:center;'>" + current.Cantidad + "</td></tr>";
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

        private string Texto4()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = (((((str + "<body><center> ") + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>" + "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>") + "<br>El listado presentado a continuaci\x00f3n son los Pedidos a la Carta en forma resumida del Sistema de Comedor." + "</div><br>") + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>" + "<table width='500'  cellpadding='3'>") + "<tr><td colspan='2'>" + "<hr /> </td></tr>") + "<tr><td width='330' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:12px; font-family:Arial'>NOMBRE DEL MENU</td>" + "<td width='70' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:12px; font-family:Arial'>TOTAL</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplComedor4SelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplComedor4 current = (LgImplComedor4)enumerator.Current;
                    str = str + "<tr><td width='330' valign='top' style='font-size:12px; font-family:Arial;text-align:left;'>" + current.Comida + "</td>";
                    str = str + "<td width='70' valign='top' style='font-size:12px; font-family:Arial;text-align:center;'>" + current.Total + "</td></tr>";
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
