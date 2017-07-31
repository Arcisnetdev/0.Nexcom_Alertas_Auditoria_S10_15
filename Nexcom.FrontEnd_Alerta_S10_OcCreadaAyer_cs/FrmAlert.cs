 using Nexcom.Backend_Alerta_S10.Business.BusinessLogic;
using Nexcom.Backend_Alerta_S10.Business.BusinessObject;
using System;
using System.Collections;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Nexcom.FrontEnd_Alerta_S10_OcCreadaAyer_cs
{
    public partial class FrmAlert : Form
    {
        public FrmAlert()
        {
            InitializeComponent();
        }

        private void FrmAlert_Load(object sender, EventArgs e)
        {
                LgImplOcCreadasAyers ocCreadasAyer = (LgImplOcCreadasAyers) ObImplControl.PoblarLgImplOcCreadasAyerSelAll();

      if (ocCreadasAyer.Count > 0)
    {
        this.EnvioocCreadasAyer();
    }
  this.Dispose();
        }

        private void EnvioocCreadasAyer()
{
    MailMessage message = new MailMessage();
    message.To.Add("arosales@nexcom.com.pe");
    //message.Bcc.Add("jdelgado@nexcom.com.pe");
    message.Bcc.Add("jalvarez@nexcom.com.pe");
    message.Bcc.Add("figarza@nexcom.com.pe");
            // message.Bcc.Add("yyabiku@nexcom.com.pe");
            message.Bcc.Add("jcahuana@nexcom.com.pe");
            message.Bcc.Add("kvilca@nexcom.com.pe");

    message.From = new MailAddress("noresponder@nexcom.com.pe", "Ordenes de Compra y/o Servicio creadas el dia de ayer.", Encoding.UTF8);
    message.Subject = "Alerta de Control -> Ordenes de Compra y/o Servicio creadas el dia de ayer.";
    message.SubjectEncoding = Encoding.UTF8;
    message.Body = this.TextoEnvioocCreadasAyer();
    message.BodyEncoding = Encoding.UTF8;
    message.IsBodyHtml = true;
    SmtpClient client = new SmtpClient("192.168.100.2") {
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

        private string TextoEnvioocCreadasAyer()
{
    IEnumerator enumerator;
    IEnumerator enumerator2;
    string str = "<html>";
    str = ((((((((str + "<body><center> ") + "<div style='font-size:11px; font-family:Arial; text-align:left; padding:10px; width:650px;'>" + 
        "<br><div style='padding-left:30px; padding-right:30px; text-align:justify'><strong>Estimado(a) usuario(a):</strong>") + 
        "<br>El listado presentado a continuaci\x00f3n son las Ordenes que se han creado el D\x00eda de Ayer." + "</div><br>") + 
        "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>" + "<table width='1308'  cellpadding='2'>") +
        "<tr><td colspan='2'>" + "</div><br>") + "<div style='font-size:11px; font-family:Arial;background-color:#E8EAEE; padding:20px'>" + 
        "<table width='308'  cellpadding='2'>") + "<tr><td colspan='2'>" + "<hr /> </td></tr>") + 
        "<tr><td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FECHACREACION</td>" +
        "<td width='80' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ESTADOORDEN</td>") +
        "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>MON</td>" +
        "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ValorTOTALEMITIDOElDiaDeAyer</td></tr>";
    try
    {
        enumerator = ((IEnumerable) ObImplControl.PoblarLgImplOcCreadasAyer2SelAll()).GetEnumerator();
        while (enumerator.MoveNext())
        {
            LgImplOcCreadasAyer2 current = (LgImplOcCreadasAyer2) enumerator.Current;
            str = str + "<tr><td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Fechacreacion + "</td>";
            str = str + "<td width='80' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Estadoorden + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + current.Simbolo + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + current.Valortotalemitidoenordenes + "</td></tr>";
        }
    }
    finally
    {
        //if (enumerator is IDisposable)
        //{
        //    (enumerator as IDisposable).Dispose();
        //}
    }
    str = (((((((((((((str + "</table>" + "</div>") + "<hr /> </td></tr>" + "<tr><td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROYECTO</td>") + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PROVEEDOR</td>" + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>TIPOORDEN</td>") + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ESTADOORDEN</td>" + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>NROORDEN</td>") + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CODRECURSO</td>" + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>RECURSO</td>") + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>UNIDAD</td>" + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>MON</td>") + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CANTIDAD</td>" + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>CONTECHO</td>") + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PRECIOTECHO</td>" + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PRECIO</td>") + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PRECIOEXCEDETECHO</td>" + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>DSCTOPORCT</td>") + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>PARCIALRECURSO</td>" + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>ValorTotalDelTotalDeLaOrden</td>") + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>TIPODECAMBIO</td>" + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FECHACREACION</td>") + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FECHAORDEN</td>" + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>USUARIOREGISTRADOR</td>") + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>USUARIOAPROBADOR</td>" + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>FECHAAPROBACION</td>") + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>OBSERVACIONORDEN</td>" + "<td width='10' valign='top' style='text-align:center;background-color:#DDDDDD;font-size:8px; font-family:Arial'>OBSERVACIONDELRECURSO</td></tr>";
    try
    {
        enumerator2 = ((IEnumerable) ObImplControl.PoblarLgImplOcCreadasAyerSelAll()).GetEnumerator();
        while (enumerator2.MoveNext())
        {
            LgImplOcCreadasAyer control2 = (LgImplOcCreadasAyer) enumerator2.Current;
            str = str + "<tr><td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Proyecto + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + control2.Proveedor + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + control2.Tipoorden + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Estadoorden + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + control2.Nroorden + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + control2.Codrecurso + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'> " + control2.Recurso + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Unidad + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Simb + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Cantidad + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Contecho + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Preciotecho + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Precio + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Precioexcedetecho + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Dsctoporcentaje + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Parcialrecurso + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Valortotaldeltotaldelaorden + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Tipodecambio + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Fechacreacion + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Fechaorden + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Usuarioregistrador + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Usuarioaprobador + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Fechaaprobacion + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Observacionorden + "</td>";
            str = str + "<td width='10' valign='top' style='font-size:8px; font-family:Arial;text-align:center;'>" + control2.Observaciondelrecurso + "</td></tr>";
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