using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace SEabyCdeformulario.Controllers
{
    public class InstitucionController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            switch (form.Get("op"))
            {

                case "insertar":
                    {
                        SEabyvisual.Institucion item = new SEabyvisual.Institucion();
                        item._IDINSTITUCION = form.Get("_IDINSTITUCION");
                        item._PROVINCIA = form.Get("_PROVINCIA");
                        item._NOMBRE = form.Get("_NOMBRE");
                        
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.InsertarInstitucion());
                        return response;
                        break;


                    }
                case "modificar":
                    {
                        SEabyvisual.Institucion item = new SEabyvisual.Institucion();
                        item._IDINSTITUCION = form.Get("_IDINSTITUCION");
                        item._PROVINCIA = form.Get("_PROVINCIA");
                        item._NOMBRE = form.Get("_NOMBRE");
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.ActualizarInstitucion());
                        return response;
                        break;
                    }
                case "eliminar":
                    {
                        SEabyvisual.Institucion item = new SEabyvisual.Institucion();
                        item._IDINSTITUCION = form.Get("_IDINSTITUCION");
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.EliminarInstitucion());
                        return response;
                        break;
                    }
                case "listar":
                    {
                        HttpResponseMessage response = Request.CreateResponse<List<SEabyvisual.Institucion>>(SEabyvisual.Institucion.Seleccionar());

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


