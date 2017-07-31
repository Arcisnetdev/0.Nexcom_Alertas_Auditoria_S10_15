using Nexcom.Backend_Alerta_S10.Business.BusinessLogicMasivoC;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;
using System;
using System.Collections;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Nexcom.FrontEnd_Alerta_S10_CorreoMasivo_cs
{
    public partial class FrmAlert : Form
    {
        public FrmAlert()
        {
            InitializeComponent();
        }

        private void FrmAlert_Load(object sender, EventArgs e)
        {
            LgImplVerifNroUsers rs = (LgImplVerifNroUsers)ObImplControl.PoblarLgImplVerifNroUserSelAll();
            LgImplVerifNroProveedors proveedors = (LgImplVerifNroProveedors)ObImplControl.PoblarLgImplNroProveedorSelAll();
            LgImplVerifNroCcs cs = (LgImplVerifNroCcs)ObImplControl.PoblarLgImplVerifNroCcSelAll();
            LgImplVerifNroProSs os = (LgImplVerifNroProSs)ObImplControl.PoblarLgImplVerifNroProSSelAll();
            if (proveedors.Count > 0)
            {
                this.Envio();
            }
            if (cs.Count > 0)
            {
                this.Envio2();
            }
            if (rs.Count > 0)
            {
                this.Envio3();
            }
            if (os.Count > 0)
            {
                this.Envio4();
            }
            this.Dispose();
        }

        private void Envio()
        {
            MailMessage message = new MailMessage();
            message.To.Add("arosales@nexcom.com.pe");
            //message.To.Add("jreyna@nexcom.com.pe");
            //message.CC.Add("lvalencia@nexcom.com.pe");
            message.From = new MailAddress("noresponder@nexcom.com.pe", "Interface S10-Spring", Encoding.UTF8);
            message.Subject = "Incluir Listado de Proveedores-Spring";
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
            //message.To.Add("jreyna@nexcom.com.pe");
            //message.CC.Add("lvalencia@nexcom.com.pe");
            message.From = new MailAddress("noresponder@nexcom.com.pe", "Interface S10-Spring", Encoding.UTF8);
            message.Subject = "Incluir Listado de Centro de Costo-Spring";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.Texto2();
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("192.168.100.2")
            {
                Port = 0x19,
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
            IEnumerator enumerator;
            MailMessage message = new MailMessage();
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplVerifNroUserSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplVerifNroUser current = (LgImplVerifNroUser)enumerator.Current;
                    message.To.Clear();
                    message.To.Add("arosales@nexcom.com.pe");
                    //message.To.Add(current.USUARIO + "@nexcom.com.pe");
                    message.From = new MailAddress("noresponder@nexcom.com.pe", "Interface S10-Spring", Encoding.UTF8);
                    message.Subject = "Verificar Nro Documento - S10";
                    message.SubjectEncoding = Encoding.UTF8;
                    message.Body = this.Texto3(current.Usuario);
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
            }
            finally
            {
                //if (enumerator is IDisposable)
                //{
                //    (enumerator as IDisposable).Dispose();
                //}
            }
        }

        private void Envio4()
        {
            MailMessage message = new MailMessage();
            message.To.Add("arosales@nexcom.com.pe");
            //message.To.Add("lvalencia@nexcom.com.pe");
            //message.CC.Add("jreyna@nexcom.com.pe");
            message.From = new MailAddress("noresponder@nexcom.com.pe", "Interface S10-Spring", Encoding.UTF8);
            message.Subject = "Listado de Facturas no Procesadas";
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
            str = (((((str + "<body><center> ") + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>" +
                "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>") + 
                "<br>El listado presentado a continuacion son los que deben ser registrados en el ERP SPRING, como condicion de Proveedor." + 
                "</div><br>") + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>" + 
                "<table width='610'  cellpadding='7'>") + "<tr><td colspan='2'>" + "<hr /> </td></tr>") + 
                "<tr><td width='122' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>RUC</td>" +
                "<td width='452' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>DESCRIPCION</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplNroProveedorSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplVerifNroProveedor current = (LgImplVerifNroProveedor)enumerator.Current;
                    str = str + "<tr><td width='122' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.Ruc + "</td>";
                    str = str + "<td width='452' valign='top' style='font-size:11px; font-family:Arial'> " + current.Descripcion + "</td></tr>";
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

        private string Texto2()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = (((((str + "<body><center> ") + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>" +
                "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>") + 
                "<br>El listado presentado a continuacion son los que deben ser registrados en el ERP SPRING, como condicion de Centro de Costos." + 
                "</div><br>") + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>" + 
                "<table width='610'  cellpadding='7'>") + "<tr><td colspan='2'>" + "<hr /> </td></tr>") +
                "<tr><td width='122' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>CENTRO DE COSTO</td>" + 
                "<td width='452' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>DESCRIPCION</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplVerifNroCcSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplVerifNroCc current = (LgImplVerifNroCc)enumerator.Current;
                    str = str + "<tr><td width='122' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.Cc + "</td>";
                    str = str + "<td width='452' valign='top' style='font-size:11px; font-family:Arial'> " + current.Descripcion + "</td></tr>";
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

        private string Texto3(string xuser)
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = (((((str + "<body><center> ") + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>" +
                "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>") + 
                "<br>El listado presentado a continuacion son los que deben ser revisados en el ERP S10." + "</div><br>") +
                "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>" + 
                "<table width='610'  cellpadding='7'>") + "<tr><td colspan='2'>" + "<hr /> </td></tr>") +
                "<tr><td width='122' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>NRO DOCUMENTO</td>" + 
                "<td width='452' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>PROVEEDOR</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplVerifNroNDocSelAll(xuser)).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplVerifNroNDoc current = (LgImplVerifNroNDoc)enumerator.Current;
                    str = str + "<tr><td width='122' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.NroDoc + "</td>";
                    str = str + "<td width='452' valign='top' style='font-size:11px; font-family:Arial'> " + current.Descripcion + "</td></tr>";
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

        private string Texto4()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = (((((str + "<body><center> " + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>") +
                "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>" + 
                "<br>El listado presentado a continuacion es facturas no procesadas en el Interface.") + "</div><br>" + 
                "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + 
                "<table width='610'  cellpadding='7'>" + "<tr><td colspan='2'>") + "<hr /> </td></tr>" + 
                "<tr><td width='122' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>NRO DOCUMENTO</td>") + 
                "<td width='222' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>NUMERO DOCUMENTO</td>" + 
                "<td width='222' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>OBSERVACION</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplVerifNroProSSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplVerifNroProS current = (LgImplVerifNroProS)enumerator.Current;
                    str = str + "<tr><td width='122' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.Tipodocumento + "</td>";
                    str = str + "<td width='222' valign='top' style='font-size:11px; font-family:Arial'> " + current.Numerodocumento + "</td>";
                    str = str + "<td width='222' valign='top' style='font-size:11px; font-family:Arial'> " + current.Observacion + "</td></tr>";
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
