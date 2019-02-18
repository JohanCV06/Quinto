
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace MuebleriaMariana.Controllers
{
    public class PiezaController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            switch (form.Get("op"))
            {

                case "insertar":
                    {
                        Pieza item = new Pieza();
                        item._id_pieza = Convert.ToInt32(form.Get("_id_pieza"));
                        item._Nombre_pieza = form.Get("_Nombre_pieza");
                        item._Descripcion = form.Get("_Descripcion");
                        item._Foto1_pieza = form.Get("_Foto1_pieza");
                        item._Foto2_pieza = form.Get("_Foto2_pieza");
                        item._Precio_pieza = Convert.ToDecimal(form.Get("_Precio_pieza").ToString().Replace(',', '.'));
                        item._Unidad_medida = form.Get("_Unidad_medida");
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.Insertar_Piezas());
                        return response;
                        break; 


                    }
                case "modificar":
                    {
                        Pieza item = new Pieza();
                        item._id_pieza = Convert.ToInt32(form.Get("_id_pieza"));
                        item._Nombre_pieza = form.Get("_Nombre_pieza");
                        item._Descripcion = form.Get("_Descripcion");
                        item._Foto1_pieza = form.Get("_Foto1_pieza");
                        item._Foto2_pieza = form.Get("_Foto2_pieza");
                        item._Precio_pieza = Convert.ToDecimal(form.Get("_Precio_pieza").ToString().Replace(',', '.'));
                        item._Unidad_medida = form.Get("_Unidad_medida");
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.Modificar_Piezas());
                        return response;
                        break;
                    }
                case "eliminar":
                    {
                        Pieza item = new Pieza();
                        item._id_pieza = Convert.ToInt32(form.Get("_id_pieza"));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.Eliminar_Piezas());
                        return response;
                        break;
                    }
                case "listar":
                    {
                        HttpResponseMessage response = Request.CreateResponse<List<Pieza>>(Pieza.Seleccionar());

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
