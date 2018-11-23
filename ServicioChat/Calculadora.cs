using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Net;
using System.Web.Hosting;
using System.Web;
using CalcEntity;

using System.Net.Mail;
using System.Net.Mime;


using System.IO;

namespace ServicioChat
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Calculadora: ICalculadora
    {
        public string archivo = Path.Combine(HostingEnvironment.MapPath("~/"), "wcfCalc.txt");

        private string To;
        private string Subject;
        private string Body;

        private MailMessage cmail;
        private Attachment Data;


        public Calculadora()
        {
        }

        public int insertaMoneda(string cpass, int ntipo, int nid, string cNombre)
        {

            encript enc = new encript();
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            cpass = cpass != null ? cpass : "";
            if (headers["web"] == null)
            {
                if (File.Exists(archivo))
                {
                    string password = File.ReadLines(archivo).First();
                    if (password.Trim() != enc.Encrypt(cpass.Trim(), "coopec@j@1"))
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }

             try
            {

                using (calculadoraCreditoEntities context = new calculadoraCreditoEntities())
                {
                    if (ntipo == 1)
                    {
                        monedas oMoneda = new monedas();
                        oMoneda.cnombremo = cNombre;

                        context.monedas.Add(oMoneda);
                        context.SaveChanges();
                        return 1;
                    }
                    else
                    {
                        var moneda = context.monedas.FirstOrDefault(n => (n.nidmoneda == nid));
                        if(moneda != null){
                            moneda.cnombremo = cNombre;
                            context.SaveChanges();
                            return 1;
                        }

                    }
                }

                return 0;

            }
             catch (Exception ex)
             {
                 return 0;
             }
        }



        public int insertaLinea(string cpass, int ntipo, int nid, string cNombre, int nidMoneda, decimal nTasa)
        {
            List<monedas> listMoneda = new List<monedas>();
            encript enc = new encript();
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            cpass = cpass != null ? cpass : "";
            if (headers["web"] == null)
            {
                if (File.Exists(archivo))
                {
                    string password = File.ReadLines(archivo).First();
                    if (password.Trim() != enc.Encrypt(cpass.Trim(), "coopec@j@1"))
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }

            try
            {

                using (calculadoraCreditoEntities context = new calculadoraCreditoEntities())
                {
                    if (ntipo == 1)
                    {
                        lineas olineas = new lineas();
                        olineas.cnombrelin = cNombre;
                        olineas.nidmoneda = nidMoneda;
                        olineas.ntasaInter = nTasa;

                        context.lineas.Add(olineas);
                        context.SaveChanges();
                        return 1;
                    }
                    else
                    {
                        var linea = context.lineas.FirstOrDefault(n => (n.nidlineacr == nid));
                        if (linea != null)
                        {
                            linea.cnombrelin = cNombre;
                            linea.nidmoneda = nidMoneda;
                            linea.ntasaInter = nTasa;
                            context.SaveChanges();
                            return 1;
                        }

                    }
                }

                return 0;

            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int borrarLinea(string cpass, int nid)
        {
            List<monedas> listMoneda = new List<monedas>();
            encript enc = new encript();
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            cpass = cpass != null ? cpass : "";
            if (headers["web"] == null)
            {
                if (File.Exists(archivo))
                {
                    string password = File.ReadLines(archivo).First();
                    if (password.Trim() != enc.Encrypt(cpass.Trim(), "coopec@j@1"))
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }

            try
            {

                using (calculadoraCreditoEntities context = new calculadoraCreditoEntities())
                {
                    
                    var linea = context.lineas.FirstOrDefault(n => (n.nidlineacr == nid));
                    if (linea != null)
                    {
                        context.lineas.Remove(linea);
                        context.SaveChanges();
                        return 1;
                    }

                    
                }

                return 0;

            }
            catch (Exception ex)
            {
                return 0;
            }
        }



        public List<MonedasDTO> ObtenerListaMonedas(string cpass)
        {
            List<MonedasDTO> listMoneda = new List<MonedasDTO>();
            encript enc = new encript();
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            cpass = cpass != null ? cpass : "";
            if (headers["web"] == null)
            {
                if (File.Exists(archivo))
                {
                    string password = File.ReadLines(archivo).First();
                    if (password.Trim() != enc.Encrypt(cpass.Trim(), "coopec@j@1"))
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }


             try
            {
                 using (calculadoraCreditoEntities context = new calculadoraCreditoEntities())
                 {
                     listMoneda = (from item in context.monedas
                                   select new MonedasDTO { nidMoneda = item.nidmoneda, cnombreMo = item.cnombremo}).ToList();
                }

                 return listMoneda;

            }
             catch (Exception ex)
             {
                 return null;
             }
       }


        public List<LineasDTO> ObtenerListaLineas(string cpass,int nidMoneda)
        {
            List<LineasDTO> listLineas = new List<LineasDTO>();
            encript enc = new encript();
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            cpass = cpass != null ? cpass : "";
            if (headers["web"] == null)
            {
                if (File.Exists(archivo))
                {
                    string password = File.ReadLines(archivo).First();
                    if (password.Trim() != enc.Encrypt(cpass.Trim(), "coopec@j@1"))
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }


            try
            {
                using (calculadoraCreditoEntities context = new calculadoraCreditoEntities())
                {
                    listLineas = (from item in context.lineas
                                  where item.nidmoneda == nidMoneda
                                  select new LineasDTO { nidLineaCr = item.nidlineacr, cnombreLin = item.cnombrelin, nidmoneda = item.nidmoneda, ntasainter = item.ntasaInter }).ToList();
                }

                return listLineas;

            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public List<PlazosDTO> ObtenerListaPlazos(string cpass)
        {
            List<PlazosDTO> listPlazos = new List<PlazosDTO>();
            encript enc = new encript();
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            cpass = cpass != null ? cpass : "";
            if (headers["web"] == null)
            {
                if (File.Exists(archivo))
                {
                    string password = File.ReadLines(archivo).First();
                    if (password.Trim() != enc.Encrypt(cpass.Trim(), "coopec@j@1"))
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }


            try
            {
                using (calculadoraCreditoEntities context = new calculadoraCreditoEntities())
                {
                    listPlazos = (from item in context.plazos
                                  select new PlazosDTO { nIdPlazo = item.nIdPlazo, nPlazo = item.nplazo}).ToList();
                }

                return listPlazos;

            }
            catch (Exception ex)
            {
                return null;
            }
        }



        public int obtenerDatos(datos dato)
        {
            try
            {
                string nombre = dato.nombre;
                string email = dato.email;
                string telefono = dato.telefono;
                string mensaje = dato.mensaje;
                double monto = dato.monto;
                string moneda = dato.moneda;
                string linea = dato.linea;
                double tasa = dato.tasa;
                int plazo = dato.plazo;
                double cuota = dato.cuota;
                int enviar = dato.enviar;

                Subject = "Calculadora de Crédito, solicitud de información.";
                
                Body = "Nombre: " + nombre + "\n\r" +
                          "Email: " + email + "\n\r" +
                          "Teléfono: " + telefono + "\n\r" +
                          "Mensaje: " + mensaje + "\n\r" +
                          "Monto solicitado: " + monto + "\n\r" +
                          "Moneda: " + moneda + "\n\r" +
                          "Línea Escogida: " + linea + "\n\r" +
                          "Tasa de interés anual: " + tasa + "\n\r"+
                          "Plazo en meses: " + plazo + "\n\r" +
                          "Cuota aproximada a pagar mensual:" + cuota;
                

                cmail = new MailMessage();
                using (calculadoraCreditoEntities context = new calculadoraCreditoEntities())
                {
                    //List<correos> listaC = new List<correos>();

                    var listaC = (from item in context.correos
                                  select item.cNombreC);

                    foreach (var item in listaC)
                    {
                        cmail.To.Add(new MailAddress(item));
                    }

                }

                if (enviar == 1)
                {
                    cmail.To.Add(new MailAddress(email));
                }


                cmail.From = new MailAddress("cfonseca@coopecaja.fi.cr");
                cmail.Subject = Subject;
                cmail.Body = Body;
                cmail.IsBodyHtml = false;
                SmtpClient client = new SmtpClient();
                using (client)
                {
                    client.Host = "mail.coopecaja.fi.cr";
                    client.Port = 25;
                    client.EnableSsl = false;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential("cfonseca@coopecaja.fi.cr", "Zulema2024");
                    client.Send(cmail);
                }

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }





    }
}
