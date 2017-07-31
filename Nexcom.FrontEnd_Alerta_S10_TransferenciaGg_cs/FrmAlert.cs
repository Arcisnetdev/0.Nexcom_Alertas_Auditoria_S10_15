using System;
using System.Collections;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogic;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;

namespace Nexcom.FrontEnd_Alerta_S10_TransferenciaGg_cs
{
    public partial class FrmAlert : Form
    {
        public FrmAlert()
        {
            InitializeComponent();
        }

        private void FrmAlert_Load(object sender, EventArgs e)
        {
            LgImplSegTansferenciaGgs controls = (LgImplSegTansferenciaGgs)ObImplControl.PoblarLgImplSegTansferenciaGgSelAll();

            if (controls.Count > 0)
            {
                this.EnvioAlertaTransferencias();
            }
            this.Dispose();
        }

        void EnvioAlertaTransferencias()
        {
            MailMessage message = new MailMessage();
            //Lista para enviar a Operaciones
            message.Bcc.Add("arosales@nexcom.com.pe");
			//message.To.Add("jalvarez@nexcom.com.pe");
			//message.To.Add("jcahuana@nexcom.com.pe");
			//message.Bcc.Add("personal_almacen@nexcom.com.pe");

			//Lista para enviar a GAF
			message.To.Add("lperez@nexcom.com.pe");
			message.CC.Add("scelestino@nexcom.com.pe");
			message.CC.Add("external_s10@nexcom.com.pe");
			message.CC.Add("odepando@nexcom.com.pe");
			message.CC.Add("mbuchanan@nexcom.com.pe");
			message.CC.Add("jgomez@nexcom.com.pe");

			message.From = new MailAddress("noresponder@nexcom.com.pe", "Valorizado de Movimientos de Almacen ETE y ETEP Pendientes de Ingreso en Proyecto destino.", Encoding.UTF8);
            message.Subject = "Alerta de Control -> Valorizado de Movimientos de Almacen ETE y ETEP Pendientes de Ingreso en Proyecto destino.";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.ContenidoAlertaTransfG();
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

        //private string ContenidoAlertaTransferencias()
        //{
        //    IEnumerator enumerator;
        //    string str = "<html>";
        //    str = ((((((str + "<body><center> ") + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>" + 
        //        "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>") + 
        //        "<br>El listado presentado a continuaci\x00f3n es el valorizado de las Guias de egreso por ETE y ETEP pendientes de ingreso en el proyecto destino." + 
        //        "</div><br>") + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>" + "<table width='1110'  cellpadding='3'>") + 
        //        "<tr><td colspan='2'>" + "<hr /> </td></tr>") + 
        //        "<tr><td width='150' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>Proyecto</td>" + 
        //        "<td width='150' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>Estado</td>") +
        //        "<td width='150' valign='top' style='text-align:center;background-color:#ECF9FF;font-size:8px; font-family:Arial;border-color:#999;border-left-style: dashed;border-left-width:1px;border-bottom-style: dashed;border-bottom-width:1px'>Valorizado S/.</td>";
        //    try
        //    {
        //        enumerator = ((IEnumerable)ObImplControl.PoblarLgImplSegTansferenciaGgSelAll()).GetEnumerator();
        //        while (enumerator.MoveNext())
        //        {
        //            LgImplSegTansferenciaGg current = (LgImplSegTansferenciaGg)enumerator.Current;
        //            str = str + "<td width='20' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'> " + current.Proyecto + "</td>";
        //            str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'> " + current.Estado + "</td>";
        //            str = str + "<td width='30' valign='top' style='font-size:8px; font-family:Arial;text-align:center;border-color:#999;border-bottom-style: dashed;border-bottom-width:1px'>" + current.Total + "</td>";
        //        }
        //    }
        //    finally
        //    {
        //        //if (enumerator is IDisposable)
        //        //{
        //        //    (enumerator as IDisposable).Dispose();
        //        //}
        //    }
        //    return (((str + "</table>" + "</div>") + "<hr /><div style='font-size:10px; padding-left:30px; padding-right:30px'>" + "<strong><em>Nexos Comerciales S.A.C</em></strong><br><br>") + 
        //        "<strong>P.D:</strong> Este correo es solo para confirmar el estado de recepcion. Agradeceremos no responderlo.</div> </div>" + "</center></body></html>");
        //}


        //private string TextoTransferenciaGG()
        //{
        //    IEnumerator enumerator;
        //    string str = "<html>";
        //    str = ((((((str + "<body><center> ") +
        //               "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>" +
        //               "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>") +
        //              "<br>El listado presentado a continuaci\x00f3n es el valorizado de las guias de egreso por ETE y ETEP pendientes de ingreso en el proyecto destino." +
        //              "</div><br>") +
        //             "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>" +

        //        "<table width='900'  cellpadding='3'>") + "<tr><td colspan='2'>" + "<hr /> </td></tr>") +
        //        "<tr><td width='100' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROYECTO</td>" +
        //        "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>VALORIZADO S/.</td>") +
        //        "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ESTADO</td></tr>";
        //    try
        //    {
        //        enumerator = ((IEnumerable)ObImplControl.PoblarLgImplSegTansferenciaGgSelAll()).GetEnumerator();
        //        while (enumerator.MoveNext())
        //        {
        //            LgImplSegTansferenciaGg current = (LgImplSegTansferenciaGg)enumerator.Current;
        //            str = str + "<tr><td width='100' valign='top' style='font-size:8px; font-family:Arial;text-align:left;'>" + current.Proyecto + "</td>";
        //            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;color:#DF0101;'> " + current.Total + "</td>";
        //            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Estado + "</td></tr>";
        //        }
        //    }
        //    finally
        //    {
        //        //if (enumerator is IDisposable)
        //        //{
        //        //    (enumerator as IDisposable).Dispose();
        //        //}
        //    }
        //    return (((str + "</table>" + "</div>") + "<hr /><div style='font-size:10px; padding-left:30px; padding-right:30px'>" +
        //        "<strong><em>Nexos Comerciales S.A</em></strong><br><br>") +
        //        "<strong>P.D:</strong> Este correo es solo para confirmar el estado de recepcion. Agradeceremos no responderlo.</div> </div>" +
        //        "</center></body></html>");
        //}

        private string ContenidoAlertaTransfG()
        {
            IEnumerator enumerator;
            IEnumerator enumerator2;
            string str = "<html>";
            str = (((((((str + "<body><center> " + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>") +
                "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>" +
                "<br>El listado presentado a continuacion son los que deben ser corroborado en ERP S10.") + "</div><br>" +
                "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + "<table width='430'  cellpadding='2'>" +
                "<tr><td colspan='7'>") + "<hr /> </td></tr>" + "<tr><td colspan='7'>") + "</div><br>" +
                "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + "<table width='1380'  cellpadding='2' >" +
                "<tr><td width='70' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:10px; font-family:Arial'>TOTAL VALORIZADO (S/.)</td>");
            
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplSegTansferenciaGgToSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplSegTansferenciaGgTo valTot = (LgImplSegTansferenciaGgTo)enumerator.Current;
                    str = str + "<tr><td width='10' valign='top' style='font-size:10px; font-family:Arial;text-align:center;color:red'>" + valTot.Total +"</td>";
                }
            }
            finally
            {
                //if (enumerator is IDisposable)
                //{
                //    (enumerator as IDisposable).Dispose();
                //}
            }
            str = (((str + "</table>") + "</div>" + "<hr /> </td></tr>") +
                "<tr><td width='620' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROYECTO_ORIGEN</td>" +
                "<td width='80' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>VALORIZADO (S/.)</td>") +
                "<td width='60' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ESTADO_PROYECTO</td>"+
                "<td width='620' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROYECTO_DESTINO</td>";
            try
            {
                enumerator2 = ((IEnumerable)ObImplControl.PoblarLgImplSegTansferenciaGgSelAll()).GetEnumerator();
                while (enumerator2.MoveNext())
                {
                     LgImplSegTansferenciaGg valxproyecto = (LgImplSegTansferenciaGg)enumerator2.Current;
                    str = str + "<tr><td width='620' valign='top' style='font-size:8px; font-family:Arial;text-align:left;'> " + valxproyecto.Proyecto + "</td>";
                    if (valxproyecto.Total == "0.00")
                    {
                        str = str + "<td width='80' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + valxproyecto.Total + "</td>";
                    }
                    else
                    {
                        str = str + "<td width='80' valign='top' style='font-size:8px; font-family:Arial;text-align:center;color:red'> " + valxproyecto.Total + "</td>";
                    }
                    if (valxproyecto.Estado == "")
                    {
                        str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + valxproyecto.Estado + "</td>";
                    }
                    else
                    {
                        str = str + "<td width='60' valign='top' style='font-size:8px; font-family:Arial;text-align:center;color:red'> " + valxproyecto.Estado + "</td>";
                    }
                    if (valxproyecto.Destino != "")
                    {
                        str = str + "<td width='620' valign='top' style='font-size:8px; font-family:Arial;text-align:left;'> " + valxproyecto.Destino + "</td>";
                    }
                    else
                    {
                        str = str + "<td width='620' valign='top' style='font-size:8px; font-family:Arial;text-align:left;color:red'> " + valxproyecto.Destino + "</td>";
                    }
                   
                }
            }
            finally
            {
                //if (enumerator2 is IDisposable)
                //{
                //    (enumerator2 as IDisposable).Dispose();
                //}
            }
            return (((str + "</table>" + "</div>") + "<hr /><div style='font-size:10px; padding-left:30px; padding-right:30px'>" +
                "<strong><em>Nexos Comerciales S.A</em></strong><br><br>") +
                "<strong>P.D:</strong> Este correo es solo para confirmar el estado de recepcion. Agradeceremos no responderlo.</div> </div>" +
                "</center></body></html>");
        }

    }
}
