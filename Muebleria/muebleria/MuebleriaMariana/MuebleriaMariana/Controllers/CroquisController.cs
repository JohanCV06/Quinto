using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace MuebleriaMariana.Controllers
{
    public class CroquisController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            switch (form.Get("op"))
            {

                case "insertar":
                    {
                        Croquis item = new Croquis();
                        item._Id_croquis = Convert.ToInt32(form.Get("_Id_croquis"));
                        item._Nombre_cliente = form.Get("_Nombre_cliente");
                        item._Fecha = Convert.ToDateTime(form.Get("_Fecha"));
                        item._Precio_costo = Convert.ToDecimal(form.Get("_Precio_costo").ToString().Replace(',', '.'));
                        item._Precio_venta = Convert.ToDecimal(form.Get("_Precio_venta").ToString().Replace(',', '.'));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.Insertar_Croquis());
                        return response;
                        break;
                    }
                case "modificar":
                    {
                        Croquis item = new Croquis();
                        item._Id_croquis = Convert.ToInt32(form.Get("_Id_croquis"));
                        item._Nombre_cliente = form.Get("_Nombre_cliente");
                        item._Fecha = Convert.ToDateTime(form.Get("_Fecha"));
                        item._Precio_costo = Convert.ToDecimal(form.Get("_Precio_costo").ToString().Replace(',', '.'));
                        item._Precio_venta = Convert.ToDecimal(form.Get("_Precio_venta").ToString().Replace(',', '.'));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.Modificar_Croquis());
                        return response;
                        break;
                    }
                case "eliminar":
                    {
                        Croquis item = new Croquis();
                        item._Id_croquis = Convert.ToInt32(form.Get("_Id_croquis"));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.Eliminar_Croquis());
                        return response;
                        break;
                    }
                case "insertarmoduloacroquis":
                    {

                        Decimal EJEX = Convert.ToDecimal(form.Get("ejex"));
                        Decimal EJEY = Convert.ToDecimal(form.Get("ejey"));

                        Modulo mod = new Modulo();
                        mod._Id_modulo = Convert.ToInt32(form.Get("_Id_modulo"));
                        Croquis cro = new Croquis();
                        cro._Id_croquis = Convert.ToInt32(form.Get("_Id_croquis"));


                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, Croquis.InsertaModuloACroquis(mod, cro, EJEX, EJEY));
                        return response;
                        break;
                    }
                case "listar":
                    {
                        HttpResponseMessage response = Request.CreateResponse<List<Croquis>>(Croquis.Seleccionar());

                        return response;
                        break;
                    }

                default:
                    {
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 0);
                        return response;
                        break;
                    }
            }
        }
    }
}
