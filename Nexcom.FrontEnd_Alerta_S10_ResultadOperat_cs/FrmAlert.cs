using System;
using System.Collections;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Nexcom.Backend_Alerta_S10.Business.BusinessLogicRO;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;

namespace Nexcom.FrontEnd_Alerta_S10_ResultadOperat_cs
{
    public partial class FrmAlert : Form
    {
        public FrmAlert()
        {
            InitializeComponent();
        }

        private void FrmAlert_Load(object sender, EventArgs e)
        {

            LgImplResultOperCs resultadoOp = (LgImplResultOperCs)ObImplControl.PoblarLgImplResultOperCSelAll();
            if (resultadoOp.Count > 0)
            {
                this.EnvioRoper();
            }

            this.Dispose();
        }

        private void EnvioRoper()
        {
            MailMessage message = new MailMessage();
            //Lista para enviar a Operaciones
            message.Bcc.Add("arosales@nexcom.com.pe");
			//message.Bcc.Add("external_s10@nexcom.com.pe");
			//message.To.Add("ecoasaca@nexcom.com.pe");

			//Lista para enviar a GAF
			//message.To.Add("vmelendez@nexcom.com.pe");
			//message.To.Add("scelestino@nexcom.com.pe");

			message.From = new MailAddress("noresponder@nexcom.com.pe", "Verificar Resultados Operativos del proyecto en el S10 ERP", Encoding.UTF8);
            message.Subject = "Alerta de Control -> Verificar Resultados Operativos del proyecto en el S10 ERP.";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = this.TextoEnvioRoper();
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

        private string TextoEnvioRoper()
        {
            IEnumerator enumerator;
            string str = "<html>";
            str = ((str + "<body><center> " + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>") + 
                "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>" + 
                "<br>El listado presentado a continuacion son los que deben ser corroborado en ERP S10.") + 
                "</div><br><hr />" + "<div style='font-size:11px; font-family:Arial;padding:20px'>";
            try
            {
                enumerator = ((IEnumerable)ObImplControl.PoblarLgImplResultOperCSelAll()).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    IEnumerator enumerator2;
                    LgImplResultOperC current = (LgImplResultOperC)enumerator.Current;
                    str = str + "<table cellspacing='0' cellpadding='0' width='605px'><tr><td colspan='3' width='350'></td><td  style='font-size:10px; font-family:Arial;text-align:center;border:1px solid black;background-color:#C5E3ED' width='85'><strong>PRESUPUESTO</strong></td>" +
                        "<td width='85' style='font-size:10px; font-family:Arial;text-align:center;border:1px solid black;background-color:#C5E3ED'><strong>REAL</strong></td></tr>";
                    str = str + "<tr><td  style='font-size:10px; font-family:Arial;text-align:left;font-weight: bold;border:1px solid black;background-color:#C5D5E9' colspan='3' width='350'>Proyecto:" + current.DesProyecto + "</td>";
                    str = str + "<td align='right' valign='top' style='font-size:10px; font-family:Arial;text-align:center;border:1px solid black;background-color:#FFA6A6'> " + current.Presupuesto + "</td>";
                    str = str + "<td align='right' valign='top' style='font-size:10px; font-family:Arial;text-align:center;border:1px solid black;background-color:#FFA6A6'> " + current.Reall + "</td>";
                    str = str + "</tr><tr><td style='font-size:10px; font-family:Arial;text-align:left;font-weight: bold;border:1px solid black;background-color:#C5D5E9' colspan='3' width='350'>Presupuestos:" + current.Tipopresupuesto + "-" + current.DesPresupuesto + "</td>";
                    str = str + "<td colspan='4' rowspan='2' style='border:1px solid black'>&nbsp;</td> </tr><tr><td colspan='3' width='350' style='font-size:10px; font-family:Arial;text-align:left;font-weight: bold;border:1px solid black;background-color:#C5D5E9'>Detalle:</td></tr>";
                    try
                    {
                        enumerator2 = ((IEnumerable)ObImplControl.PoblarLgImplResultOperDSelAll(current.Codproyecto, current.Codpresupuesto)).GetEnumerator();
                        while (enumerator2.MoveNext())
                        {
                            LgImplResultOperD rod = (LgImplResultOperD)enumerator2.Current;
                            str = str + "<tr>";
                            str = str + "<td colspan='3'  width='350' align='right' valign='top' style='font-size:10px; font-family:Arial;text-align:right;border:1px solid black'> " + rod.Recurso + "</td>";
                            str = str + "<td align='right' valign='top' style='font-size:10px; font-family:Arial;text-align:center;border:1px solid black' width='85'> " + rod.Presupuesto + "</td>";
                            str = str + "<td align='right' valign='top' style='font-size:10px; font-family:Arial;text-align:center;border:1px solid black' width='85'> " + rod.Reall + "</td></tr>";
                        }
                    }
                    finally
                    {
                        //if (enumerator2 is IDisposable)
                        //{
                        //    (enumerator2 as IDisposable).Dispose();
                        //}
                    }
                    str = str + "</table><br />";
                }
            }
                finally
                {
                    //if (enumerator is IDisposable)
                    //{
                    //    (enumerator as IDisposable).Dispose();
                    //}
                }
            return (((str + "</div>") + "<hr /><div style='font-size:10px; padding-left:30px; padding-right:30px'>" + "<strong><em>Nexos Comerciales S.A</em></strong><br><br>") + "<strong>P.D:</strong> Este correo es solo para confirmar el estado de recepcion. Agradeceremos no responderlo.</div> </div>" + "</center></body></html>");
        }
        }


    }
