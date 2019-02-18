using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace MuebleriaMariana//UN COMENTARIO
{
    public class ModuloController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            switch (form.Get("op"))
            {

                case "insertar":
                    {
                        Modulo item = new Modulo();
                        item._Id_modulo = Convert.ToInt32(form.Get("_Id_modulo"));
                        item._Nombre_modulo = form.Get("_Nombre_modulo");
                        item._Ancho = Convert.ToDecimal(form.Get("_Ancho").ToString().Replace(',', '.'));
                        item._Alto = Convert.ToDecimal(form.Get("_Alto").ToString().Replace(',', '.'));
                        item._Fondo = Convert.ToDecimal(form.Get("_Fondo").ToString().Replace(',', '.'));
                        item._Tipo_modulo = form.Get("_Tipo_modulo");
                        item._Precio_modulo = Convert.ToInt32(form.Get("_Precio_modulo"));
                        item._Foto1_modulo = form.Get("_Foto1_modulo");
                        item._Foto2_modulo = form.Get("_Foto2_modulo");
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.Insertar_Modulo());
                        return response;
                        break;
                    }
                case "modificar":
                    {
                        Modulo item = new Modulo();
                        item._Id_modulo = Convert.ToInt32(form.Get("_Id_modulo"));
                        item._Nombre_modulo = form.Get("_Nombre_modulo");
                        item._Ancho = Convert.ToDecimal(form.Get("_Ancho").ToString().Replace(',', '.'));
                        item._Alto = Convert.ToDecimal(form.Get("_Alto").ToString().Replace(',', '.'));
                        item._Fondo = Convert.ToDecimal(form.Get("_Fondo").ToString().Replace(',', '.'));
                        item._Foto1_modulo = form.Get("_Foto1_modulo");
                        item._Foto2_modulo = form.Get("_Foto1_modulo");
                        item._Precio_modulo = Convert.ToInt32(form.Get("_Precio_modulo"));
                        item._Tipo_modulo = form.Get("_Tipo_modulo");
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.Modificar_Modulo());
                        return response;
                        break;
                    }
                case "eliminar":
                    {
                        Modulo item = new Modulo();
                        item._Id_modulo = Convert.ToInt32(form.Get("_Id_modulo"));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.Eliminar_Modulo());
                        return response;
                        break;
                    }

                case "listar":
                    {
                        HttpResponseMessage response = Request.CreateResponse<List<Modulo>>(Modulo.Seleccionar());

                        return response;
                        break;
                    }
                case "insertarcomponenteamodulo":
                    {
                        Modulo item = new Modulo();
                        item._Id_modulo = Convert.ToInt32(form.Get("_Id_modulo"));

                        Componente item2 = new Componente();
                        item2._Id_componente = Convert.ToInt32(form.Get("_Id_componente"));

                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, Modulo.InsertarComponenteAModulo(item, item2, Convert.ToDecimal(form.Get("cantidad").ToString().Replace(',', '.'))));

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

