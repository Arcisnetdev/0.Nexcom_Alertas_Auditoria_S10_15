using System;
using System.Collections;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogic;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;

namespace Nexcom.FrontEnd_Alerta_S10_Techo_cs
{
    public partial class FrmAlerta : Form
    {
        public FrmAlerta()
        {
            InitializeComponent();
        }

        private void FrmAlerta_Load(object sender, EventArgs e)
        {
            LgImplTechoPs auditTechoControl = (LgImplTechoPs)ObImplControl.PoblarLgImplTechoPSelAll();

            if (auditTechoControl.Count > 0)
            {
                this.EnvioAlertaTecho();
            }
            this.Dispose();
        }

        void EnvioAlertaTecho()
        {
            MailMessage message = new MailMessage();
            message.To.Add("arosales@nexcom.com.pe");
            message.To.Add("practicante4_costos@nexcom.com.pe");
            message.To.Add("practicante3_costos@nexcom.com.pe");
            //message.To.Add("ecoasaca@nexcom.com.pe");
            message.CC.Add("lperez@nexcom.com.pe");
            message.CC.Add("odepando@nexcom.com.pe");
            message.CC.Add("jgomez@nexcom.com.pe");
            message.CC.Add("mbuchanan@nexcom.com.pe");
            message.CC.Add("scelestino@nexcom.com.pe");
            message.CC.Add("jcahuana@nexcom.com.pe");

            message.From = new MailAddress("noresponder@nexcom.com.pe", "Verificar excedente de presupuesto segun grupo de recursos en el S10 ERP.", Encoding.UTF8);
            message.Subject = "Alerta de Control -> Verificar excedente de presupuesto segun grupo de recursos en el S10 ERP.";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.ContenidoAlertaTecho();
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
                throw ex;
            }

        }

        private string ContenidoAlertaTecho()
        {
            IEnumerator enumerator;
            IEnumerator enumerator2;
            string str = "<html>";
            str = ((((((((str + "<body><center> " + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>") +
                "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>" +
                "<br>El listado presentado a continuacion son los que deben ser corroborado en ERP S10.") + "</div><br>" +
                "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + "<table width='430'  cellpadding='3'>" +
                "<tr><td colspan='7'>") + "<hr /> </td></tr>" + "<tr><td colspan='7'>") + "</div><br>" +
                "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>") + "<table width='350'  cellpadding='2'>" +
                "<tr><td width='70' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>TOTAL_EXCEDENTE_PRESUPUESTO(S/.)</td>") +
                "<td width='70' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>TOTAL_EXCEDENTE_MATERIALES(S/.)</td>" +
                "<td width='70' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>TOTAL_EXCEDENTE_SUBCONTRATOS(S/.)</td>") +
                "<td width='70' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>TOTAL_EXCEDENTE_EQUIPOS(S/.)</td>" +
                "<td width='70' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>TOTAL_EXCEDENTE_MANO_OBRA(S/.)</td></tr>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplTechoP2SelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    LgImplTechoP2 current = (LgImplTechoP2)enumerator.Current;
                    str = str + "<tr><td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;color:red'>" + current.SExPpto + "</td>";
                    str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;color:red'> " + current.SExMa + "</td>";
                    str = str + "<td width='80' valign='top' style='font-size:8px; font-family:Arial;text-align:center;color:red'> " + current.SExSc + "</td>";
                    str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;color:red'> " + current.SExEq + "</td>";
                    str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;color:red'>" + current.SExMo + "</td></tr>";
                }
            }
            finally
            {
                //if (enumerator is IDisposable)
                //{
                //    (enumerator as IDisposable).Dispose();
                //}
            }
            str = ((((str + "</table>") + "</div>" + "<hr /> </td></tr>") +
                "<tr><td width='200' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROYECTO</td>" +
                "<td width='50' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>EXCEDENTE_PRESUPUESTO(S/.)</td>") +
                "<td width='50' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>EXCEDENTE_MATERIALES(S/.)</td>" +
                "<td width='50' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>EXCEDENTE_SUBCONTRATOS(S/.)</td>") +
                "<td width='50' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>EXCEDENTE_EQUIPOS(S/.)</td>" +
                "<td width='50' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>EXCEDENTE_MANO_OBRA(S/.)</td></tr>";
            try
            {
                enumerator2 = ((IEnumerable)ObImplControl.PoblarLgImplTechoPSelAll()).GetEnumerator();
                while (enumerator2.MoveNext())
                {
                    LgImplTechoP control2 = (LgImplTechoP)enumerator2.Current;
                    str = str + "<tr><td width='200' valign='top' style='font-size:8px; font-family:Arial;text-align:left;'> " + control2.Proyecto + "</td>";
                    if (control2.ExcedentePresupuesto2 == "0.00")
                    {
                        str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:RIGHT;'> " + control2.ExcedentePresupuesto2 + "</td>";
                    }
                    else
                    {
                        str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:RIGHT;color:red'> " + control2.ExcedentePresupuesto2 + "</td>";
                    }
                    if (control2.ExcedenteMa == "0.00")
                    {
                        str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:RIGHT;'> " + control2.ExcedenteMa + "</td>";
                    }
                    else
                    {
                        str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:RIGHT;color:red'> " + control2.ExcedenteMa + "</td>";
                    }
                    if (control2.ExcedenteSc == "0.00")
                    {
                        str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:RIGHT;'> " + control2.ExcedenteSc + "</td>";
                    }
                    else
                    {
                        str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:RIGHT;color:red'> " + control2.ExcedenteSc + "</td>";
                    }
                    if (control2.ExcedenteEq == "0.00")
                    {
                        str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:RIGHT;'> " + control2.ExcedenteEq + "</td>";
                    }
                    else
                    {
                        str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:RIGHT;color:red'> " + control2.ExcedenteEq + "</td>";
                    }
                    if (control2.ExcedenteMo == "0.00")
                    {
                        str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:RIGHT;'> " + control2.ExcedenteMo + "</td></tr>";
                    }
                    else
                    {
                        str = str + "<td width='50' valign='top' style='font-size:8px; font-family:Arial;text-align:RIGHT;color:red'> " + control2.ExcedenteMo + "</td></tr>";
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
