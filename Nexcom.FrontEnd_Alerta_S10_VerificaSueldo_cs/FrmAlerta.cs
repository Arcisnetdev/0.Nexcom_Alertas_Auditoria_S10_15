using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Nexcom.Backend_Alerta_S10.Business.BusinessLogicSalary;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;
using System.Net.Mail;
using System.Collections;

namespace Nexcom.FrontEnd_Alerta_S10_VerificaSueldo_cs
{
    public partial class FrmAlerta : Form
    {
        public FrmAlerta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LgImplAuditoriaPs ps = (LgImplAuditoriaPs)ObImplControl.PoblarLgImplAuditoriaSalarioPSelAll();
            LgImplAuditoriaVacas vs = (LgImplAuditoriaVacas)ObImplControl.PoblarLgImplAuditoriaVacaSelAll();
    if (ps.Count > 0)
    {
        this.Envio2();
        this.Actualizar_Dato2();
    }
    if (vs.Count > 0)
    {
        this.Envio3();
        this.Actualizar_Dato3();
    }
    this.Dispose();
}
                
        //private void Actualizar_Dato()
        //{
        //    IEnumerator enumerator;
        //    try
        //    {
        //        enumerator = ((IEnumerable) oAuditoria.Auditoria()).GetEnumerator();
        //        while (enumerator.MoveNext())
        //        {
        //            Auditoria current = (Auditoria) enumerator.Current;
        //            oAuditoria.ActualizarProyectoTmpSelAll(current.IDITEM);
        //        }
        //    }
        //    finally
        //    {
        //        if (enumerator is IDisposable)
        //        {
        //            (enumerator as IDisposable).Dispose();
        //        }
        //    }
        //}

        private void Actualizar_Dato2()
        {
            IEnumerator enumerator;
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplAuditoriaSalarioPSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplAuditoriaP current = (LgImplAuditoriaP)enumerator.Current;
                    ObImplControl.ActualizarLgImplAuditoriaSalarioPSelAll(current.IdItem);
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

        private void Actualizar_Dato3()
        {
            IEnumerator enumerator;
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplAuditoriaVacaSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplAuditoriaVaca current = (LgImplAuditoriaVaca)enumerator.Current;
                    ObImplControl.ActualizarLgImplAuditoriaVacaSelAll(current.IdItem);
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

        //private void Actualizar_Dato4()
        //{
        //    IEnumerator enumerator;
        //    try
        //    {
        //        enumerator = ((IEnumerable) oAuditoriaTE.AuditoriaTE()).GetEnumerator();
        //        while (enumerator.MoveNext())
        //        {
        //            AuditoriaTE current = (AuditoriaTE) enumerator.Current;
        //            oAuditoriaTE.ActualizarTechoTmpSelAll(current.IDITEM);
        //        }
        //    }
        //    finally
        //    {
        //        if (enumerator is IDisposable)
        //        {
        //            (enumerator as IDisposable).Dispose();
        //        }
        //    }
        //}

        //private void Actualizar_Dato5()
        //{
        //    IEnumerator enumerator;
        //    try
        //    {
        //        enumerator = ((IEnumerable) oAuditoriaI.AuditoriaI()).GetEnumerator();
        //        while (enumerator.MoveNext())
        //        {
        //            AuditoriaI current = (AuditoriaI) enumerator.Current;
        //            oAuditoriaI.ActualizarInsumoTmpSelAll(current.IDITEM);
        //        }
        //    }
        //    finally
        //    {
        //        if (enumerator is IDisposable)
        //        {
        //            (enumerator as IDisposable).Dispose();
        //        }
        //    }
        //}

        //private void Envio()
        //{
        //    MailMessage message = new MailMessage();
        //    message.To.Add("personal_sistemas@nexcom.com.pe");
        //    message.From = new MailAddress("noresponder@nexcom.com.pe", "Auditoria Techo-Proyecto", Encoding.UTF8);
        //    message.Subject = "Verificar Techo del Proyecto-S10";
        //    message.SubjectEncoding = Encoding.UTF8;
        //    message.Body = this.Texto();
        //    message.BodyEncoding = Encoding.UTF8;
        //    message.IsBodyHtml = true;
        //    SmtpClient client = new SmtpClient("192.168.100.2") {
        //        Port = 0x19,
        //        Host = "192.168.100.2"
        //    };
        //    try
        //    {
        //        client.Send(message);
        //    }
        //    catch (SmtpException exception1)
        //    {
        //        ProjectData.SetProjectError(exception1);
        //        SmtpException exception = exception1;
        //        ProjectData.ClearProjectError();
        //    }
        //}

        private void Envio2()
        {
            MailMessage message = new MailMessage();
            message.To.Add("arosales@nexcom.com.pe");
            //message.To.Add("mcastillo@nexcom.com.pe");
            //message.CC.Add("mloa@nexcom.com.pe");
            //message.Bcc.Add("psandoval@nexcom.com.pe");
            //message.Bcc.Add("odepando@nexcom.com.pe");
            //message.Bcc.Add("mbuchanan@nexcom.com.pe");
            message.From = new MailAddress("noresponder@nexcom.com.pe", "Auditoria Monto Sueldo", Encoding.UTF8);
            message.Subject = "Verificar Monto Sueldo del SPRING";
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
            //message.To.Add("mcastillo@nexcom.com.pe");
            message.From = new MailAddress("noresponder@nexcom.com.pe", "Auditoria Vacaciones", Encoding.UTF8);
            message.Subject = "Vacaciones del SPRING";
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
            catch (SmtpException exception1)
            {
  
                SmtpException exception = exception1;

            }
        }

       // private void Envio4()
       // {
       //     MailMessage message = new MailMessage();
       //     message.To.Add("personal_almacen@nexcom.com.pe");
       //     message.From = new MailAddress("noresponder@nexcom.com.pe", "Auditoria Techo Materiales", Encoding.UTF8);
       //     message.Subject = "Verificar Techo de Materiales del S10";
       //     message.SubjectEncoding = Encoding.UTF8;
       //     message.Body = this.Texto4();
       //     message.BodyEncoding = Encoding.UTF8;
       //     message.IsBodyHtml = true;
       //     SmtpClient client = new SmtpClient("192.168.100.2") {
       //         Port = 0x19,
       //         Host = "192.168.100.2"
       //     };
       //     try
       //     {
       //         client.Send(message);
       //     }
       //     catch (SmtpException exception1)
       //     {
       //         ProjectData.SetProjectError(exception1);
       //         SmtpException exception = exception1;
       //         ProjectData.ClearProjectError();
       //     }
       // }

       // private void Envio5()
       // {
       //     MailMessage message = new MailMessage();
       //     message.To.Add("rkachahuallpa@nexcom.com.pe");
       //     message.CC.Add("lperez@nexcom.com.pe");
       //     message.CC.Add("yyubiku@nexcom.com.pe");
       //     message.CC.Add("jalvarez@nexcom.com.pe");
       //     message.CC.Add("rfurlong@nexcom.com.pe");
       //     message.CC.Add("casmat@nexcom.com.pe");
       //     message.CC.Add("scelestino@nexcom.com.pe");
       //     message.From = new MailAddress("noresponder@nexcom.com.pe", "Recursos del S10", Encoding.UTF8);
       //     message.Subject = "Verificar Recursos del S10";
       //     message.SubjectEncoding = Encoding.UTF8;
       //     message.Body = this.Texto5();
       //     message.BodyEncoding = Encoding.UTF8;
       //     message.IsBodyHtml = true;
       //     SmtpClient client = new SmtpClient("192.168.100.2") {
       //         Port = 0x19,
       //         Host = "192.168.100.2"
       //     };
       //     try
       //     {
       //         client.Send(message);
       //     }
       //     catch (SmtpException exception1)
       //     {
       //         ProjectData.SetProjectError(exception1);
       //         SmtpException exception = exception1;
       //         ProjectData.ClearProjectError();
       //     }
       // }


       //private string Texto()
       // {
       //     IEnumerator enumerator;
       //     string str = "<html>";
       //     str = ((((((str + "<body><center> " + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>") + "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>" + "<br>El listado presentado a continuacion son los que deben ser vereficados en ERP S10, en la opcion de TECHO DEL PROYECTO.") + "</div><br>" + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + "<table width='610'  cellpadding='7'>" + "<tr><td colspan='2'>") + "<hr /> </td></tr>" + "<tr><td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>CODIGO</td>") + "<td width='350' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>NOMBRE</td>" + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>USUARIO</td>") + "<td width='80' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>MAQUINA</td>" + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>FECHA</td></tr>";
       //     try
       //     {
       //         enumerator = ((IEnumerable) oAuditoria.Auditoria()).GetEnumerator();
       //         while (enumerator.MoveNext())
       //         {
       //             Auditoria current = (Auditoria) enumerator.Current;
       //             str = str + "<tr><td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.CODPROYECTO + "</td>";
       //             str = str + "<td width='350' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'> " + current.DESCRIPCION + "</td>";
       //             str = str + "<td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.CODUSER + "</td>";
       //             str = str + "<td width='80' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.IP + "</td>";
       //             str = str + "<td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.FECHA + "</td></tr>";
       //         }
       //     }
       //     finally
       //     {
       //         if (enumerator is IDisposable)
       //         {
       //             (enumerator as IDisposable).Dispose();
       //         }
       //     }
       //     return (((str + "</table>" + "</div>") + "<hr /><div style='font-size:10px; padding-left:30px; padding-right:30px'>" + "<strong><em>Nexos Comerciales S.A</em></strong><br><br>") + "<strong>P.D:</strong> Este correo es solo para confirmar el estado de recepcion. Agradeceremos no responderlo.</div> </div>" + "</center></body></html>");
       // }

        private string Texto2()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = (((((((((str + "<body><center> " + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>") 
                + "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>" 
                + "<br>El listado presentado a continuacion son los que deben ser corroborado en ERP SPRING, en el SUELDO DEL TRABAJADOR.") 
                + "</div><br>" + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + "<table width='610'  cellpadding='7'>" 
                + "<tr><td colspan='2'>") + "<hr /> </td></tr>" + "<tr><td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>CODIGO</td>") 
                + "<td width='230' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>NOMBRE</td>" 
                + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>MONTO ACTUAL</td>") 
                + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>MONTO ANTERIOR</td>" 
                + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>USUARIO</td>") 
                + "<td width='80' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>MAQUINA</td>" 
                + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>FECHA</td>")
                + "<td width='80' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>PUESTO</td>" 
                + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>CENTROCOSTO</td>")
                + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>GERENCIA</td>"
                + "<td width='80' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>AREA</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplAuditoriaSalarioPSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplAuditoriaP current = (LgImplAuditoriaP)enumerator.Current;
                    str = str + "<tr><td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.Codigo + "</td>";
                    str = str + "<td width='230' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'> " + current.Nombre + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'> " + current.MontoLocal + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'> " + current.MontoLocalA + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.CodUser + "</td>";
                    str = str + "<td width='80' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.IP + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.Fecha + "</td>";
                    str = str + "<td width='80' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.Cargo + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.CentroC + "</td>";
                    str = str + "<td width='80' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.Gerencia + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.Area + "</td></tr>";
                }
            }
            finally
            {
                //if (enumerator is IDisposable)
                //{
                //    (enumerator as IDisposable).Dispose();
                //}
            }
            return (((str + "</table>" + "</div>") 
                + "<hr /><div style='font-size:10px; padding-left:30px; padding-right:30px'>" 
                + "<strong><em>Nexos Comerciales S.A</em></strong><br><br>")
                + "<strong>P.D:</strong> Este correo es solo para confirmar el estado de recepcion. Agradeceremos no responderlo.</div> </div>" + "</center></body></html>");
        }

        private string Texto3()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = ((((((((str + "<body><center> " + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>") + 
                "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>" + 
                "<br>El listado presentado a continuacion son los que deben ser corroborado en ERP SPRING, en las Vacaciones del TRABAJADOR.") +
                "</div><br>" + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + "<table width='730'  cellpadding='7'>" + 
                "<tr><td colspan='2'>") + "<hr /> </td></tr>" + "<tr><td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>CODIGO</td>") + 
                "<td width='230' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>NOMBRE</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>PERIODO</td>") + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>DERECHO</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>UTILIZADO</td>") + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>PENDIENTE</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>USUARIO</td>") + 
                "<td width='80' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>MAQUINA</td>" + 
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:11px; font-family:Arial'>FECHA</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplAuditoriaVacaSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplAuditoriaVaca current = (LgImplAuditoriaVaca)enumerator.Current;
                    str = str + "<tr><td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.Codigo + "</td>";
                    str = str + "<td width='230' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'> " + current.Nombre + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'> " + current.Periodo + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'> " + current.Derecho + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'> " + current.Utilizado + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'> " + current.Pendiente + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.CodUser + "</td>";
                    str = str + "<td width='80' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.IP + "</td>";
                    str = str + "<td width='60' valign='top' style='font-size:11px; font-family:Arial;text-align:center;'>" + current.Fecha + "</td></tr>";
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
                "<strong>P.D:</strong> Este correo es solo para confirmar el estado de recepcion. Agradeceremos no responderlo.</div> </div>" + "</center></body></html>");
        }

       // private string Texto4()
       // {
       //     IEnumerator enumerator;
       //     string str = "<html>";
       //     str = ((((((((((((str + "<body><center> " + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>") + "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>" + "<br>El listado presentado a continuacion son los que deben ser corroborado en ERP S10, en el TECHO DE MATERIALES.") + "</div><br>" + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + "<table width='1070'  cellpadding='3'>" + "<tr><td colspan='2'>") + "<hr /> </td></tr>" + "<tr><td width='350' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROYECTO</td>") + "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CODIGO</td>" + "<td width='140' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>RECURSO</td>") + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>SIMBOLO</td>" + "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>TECHO</td>") + "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CANTXPEDIDO</td>" + "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CANTXALMACEN</td>") + "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CANTXPEDIR</td>" + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ALMACEN_GUIA</td>") + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>MOVIMIENTO</td>" + "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FECHA_GUIA</td>") + "<td width='20' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>GUIA</td>" + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CANTIDAD</td>") + "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>USUARIO_GUIA</td>" + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FECHA_PROCESO</td>") + "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>USUARIO_PROCESO</td>" + "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>IP_PROCESO</td></tr>";
       //     try
       //     {
       //         enumerator = ((IEnumerable) oAuditoriaTE.AuditoriaTE()).GetEnumerator();
       //         while (enumerator.MoveNext())
       //         {
       //             AuditoriaTE current = (AuditoriaTE) enumerator.Current;
       //             str = str + "<tr><td width='350' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.PROYECTO + "</td>";
       //             str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.CODRECURSO + "</td>";
       //             str = str + "<td width='140' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.DESCRIPCION + "</td>";
       //             str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.SIMBOLO + "</td>";
       //             str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.TECHO + "</td>";
       //             str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.CPEDIDO + "</td>";
       //             str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.CALMACEN + "</td>";
       //             str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.CPEDIR + "</td>";
       //             str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.GUIA + "</td>";
       //             str = str + "<td width='20' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.CANTIDADGUIA + "</td>";
       //             str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.FECHAGUIA + "</td>";
       //             str = str + "<td width='20' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.ALMACEN + "</td>";
       //             str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.USUARIOGUIA + "</td>";
       //             str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.MOVIMIENTO + "</td>";
       //             str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.FECHA + "</td>";
       //             str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.CODUSER + "</td>";
       //             str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.IP + "</td></tr>";
       //         }
       //     }
       //     finally
       //     {
       //         if (enumerator is IDisposable)
       //         {
       //             (enumerator as IDisposable).Dispose();
       //         }
       //     }
       //     return (((str + "</table>" + "</div>") + "<hr /><div style='font-size:10px; padding-left:30px; padding-right:30px'>" + "<strong><em>Nexos Comerciales S.A</em></strong><br><br>") + "<strong>P.D:</strong> Este correo es solo para confirmar el estado de recepcion. Agradeceremos no responderlo.</div> </div>" + "</center></body></html>");
       // }

       // private string Texto5()
       // {
       //     IEnumerator enumerator;
       //     string str = "<html>";
       //     str = ((((((((((((str + "<body><center> ") + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>" + "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>") + "<br>El listado presentado a continuacion son los que deben ser corroborado en ERP S10, en los RECURSOS." + "</div><br>") + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>" + "<table width='1100'  cellpadding='2'>") + "<tr><td colspan='2'>" + "<hr /> </td></tr>") + "<tr><td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>TIPO</td>" + "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CODINSUMO</td>") + "<td width='300' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>DESCRIPCION</td>" + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FAMILIA0</td>") + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FAMILIA1</td>" + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FAMILIA2</td>") + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>C.MATERIALES</td>" + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>C.ACTIVOS</td>") + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>C.OPERACIONES</td>" + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>C.ADMINISTRACION</td>") + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>C.COMERCIAL</td>" + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CONSUMOD</td>") + "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CONSUMOH</td>" + "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>USUARIO</td>") + "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>IP</td>" + "<td width='40' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FECHA</td></tr>";
       //     try
       //     {
       //         enumerator = ((IEnumerable) oAuditoriaI.AuditoriaI()).GetEnumerator();
       //         while (enumerator.MoveNext())
       //         {
       //             AuditoriaI current = (AuditoriaI) enumerator.Current;
       //             str = str + "<tr><td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.ACCION + "</td>";
       //             str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.CODINSUMO + "</td>";
       //             str = str + "<td width='300' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.DESCRIPCION + "</td>";
       //             str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.NIVELP + "</td>";
       //             str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.FAMILIA1 + "</td>";
       //             str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.FAMILIA2 + "</td>";
       //             str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.MATERIALES + "</td>";
       //             str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.ACTIVOS + "</td>";
       //             str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.SERVICIOO + "</td>";
       //             str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.SERVICIOA + "</td>";
       //             str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.SERVICIOC + "</td>";
       //             str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.CONSUMOD + "</td>";
       //             str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.CONSUMOH + "</td>";
       //             str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.LOGIN + "</td>";
       //             str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.IP + "</td>";
       //             str = str + "<td width='40' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.FECHA + "</td></tr>";
       //         }
       //     }
       //     finally
       //     {
       //         if (enumerator is IDisposable)
       //         {
       //             (enumerator as IDisposable).Dispose();
       //         }
       //     }
       //     return (((str + "</table>" + "</div>") + "<hr /><div style='font-size:10px; padding-left:30px; padding-right:30px'>" + "<strong><em>Nexos Comerciales S.A</em></strong><br><br>") + "<strong>P.D:</strong> Este correo es solo para confirmar el estado de recepcion. Agradeceremos no responderlo.</div> </div>" + "</center></body></html>");
       // }

   
    }
}
