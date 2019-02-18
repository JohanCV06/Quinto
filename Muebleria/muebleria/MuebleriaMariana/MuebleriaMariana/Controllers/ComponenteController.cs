using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace MuebleriaMariana.Controllers
{
    public class ComponenteController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            switch (form.Get("op"))
            {
                case "insertar":
                    {
                        Componente item = new Componente();
                        item._Id_componente = Convert.ToInt32(form.Get("_Id_componente"));
                        item._Nombre_componente = form.Get("_Nombre_componente");
                        item._Precio_componente = Convert.ToInt32(form.Get("_Precio_componente"));
                        item._Foto1_componente = form.Get("_Foto1_componente");
                        item._Foto2_componente = form.Get("_Foto2_componente");
                        item._Tipo_componente = form.Get("_Tipo_componente");
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.Insertar_Componente());
                        return response;
                        break;
                    }
                case "modificar":
                    {
                        Componente item = new Componente();
                        item._Id_componente = Convert.ToInt32(form.Get("_Id_componente"));
                        item._Nombre_componente = form.Get("_Nombre_componente");
                        item._Precio_componente = Convert.ToInt32(form.Get("_Precio_componente"));
                        item._Foto1_componente = form.Get("_Foto1_componente");
                        item._Foto2_componente = form.Get("_Foto2_componente");
                        item._Tipo_componente = form.Get("_Tipo_componente");
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.Modificar_Componente());
                        return response;
                        break;
                    }
                case "eliminar":
                    {
                        Componente item = new Componente();
                        item._Id_componente = Convert.ToInt32(form.Get("_Id_componente"));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.Eliminar_Componente());
                        return response;
                        break;
                    }

                case "listar":
                    {
                        HttpResponseMessage response = Request.CreateResponse<List<Componente>>(Componente.Seleccionar());

                        return response;
                        break;
                    }


                case "insertarpiezaacomponente":
                    {
                        Componente item = new Componente();

                        item._Id_componente = Convert.ToInt32(form.Get("_Id_componente"));
                        Pieza item2 = new Pieza();
                        item2._id_pieza = Convert.ToInt32(form.Get("_id_pieza"));



                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created,Componente.InsertarPiezaAComponente(item, item2, Convert.ToDecimal(form.Get("cantidad").ToString().Replace(',', '.'))));
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
