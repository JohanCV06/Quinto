using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace SEabyCdeformulario.Controllers
{
    public class EnfermedadController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            switch (form.Get("op"))
            {

                case "insertar":
                    {
                        SEabyvisual.Enfermedad item = new SEabyvisual.Enfermedad();
                        item._IDENFERMEDAD = form.Get("_IDENFERMEDAD");
                        item._NOMBRE = form.Get("_NOMBRE");
                        item._SINTOMAS = form.Get("_SINTOMAS");
                        
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.InsertarEnfermedad());
                        return response;
                        break;


                    }
                case "modificar":
                    {
                        SEabyvisual.Enfermedad item = new SEabyvisual.Enfermedad();
                        item._IDENFERMEDAD = form.Get("_IDENFERMEDAD");
                        item._NOMBRE = form.Get("_NOMBRE");
                        item._SINTOMAS = form.Get("_SINTOMAS");
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.ActualizarEnfermedad());
                        return response;
                        break;
                    }
                case "eliminar":
                    {
                        SEabyvisual.Enfermedad item = new SEabyvisual.Enfermedad();
                        item._IDENFERMEDAD = form.Get("_IDENFERMEDAD");
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.EliminarEnfermedad());
                        return response;
                        break;
                    }
                case "listar":
                    {
                        HttpResponseMessage response = Request.CreateResponse<List<SEabyvisual.Enfermedad>>(SEabyvisual.Enfermedad.Seleccionar());

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


