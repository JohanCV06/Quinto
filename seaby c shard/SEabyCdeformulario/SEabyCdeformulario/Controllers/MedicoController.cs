using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace SEabyCdeformulario.Controllers
{
    public class MedicoController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            switch (form.Get("op"))
            {

                case "insertar":
                    {
                        SEabyvisual.Medico item = new SEabyvisual.Medico();
                        item._IDMEDICO = form.Get("_IDMEDICO");
                        item._NOMBRE = form.Get("_NOMBRE");
                        SEabyvisual.Institucion ins = new SEabyvisual.Institucion();
                        ins._IDINSTITUCION = form.Get("_INSTITUCION");
                        item._INSTITUCION = ins;
                       
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.InsertarMedico());
                        return response;
                        break;


                    }
                case "modificar":
                    {
                        SEabyvisual.Medico item = new SEabyvisual.Medico();
                        item._IDMEDICO = form.Get("_IDMEDICO");
                        item._NOMBRE = form.Get("_NOMBRE");
                        SEabyvisual.Institucion ins = new SEabyvisual.Institucion();
                        ins._IDINSTITUCION = form.Get("_INSTITUCION");
                        item._INSTITUCION = ins;
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.ActualizarMedico());
                        return response;
                        break;
                    }
                case "eliminar":
                    {
                        SEabyvisual.Medico item = new SEabyvisual.Medico();
                        item._IDMEDICO = form.Get("_IDMEDICO");
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.EliminarMedico());
                        return response;
                        break;
                    }
                case "listar":
                    {
                        HttpResponseMessage response = Request.CreateResponse<List<SEabyvisual.Medico>>(SEabyvisual.Medico.Seleccionar());

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


