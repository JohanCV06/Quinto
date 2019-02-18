using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace SEabyCdeformulario.Controllers
{
    public class EstudioController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            switch (form.Get("op"))
            {

                case "insertar":
                    {
                        SEabyvisual.Estudio item = new SEabyvisual.Estudio();
                        item._IDESTUDIO = form.Get("_IDESTUDIO");
                        item._IDDIAGNOSTICO = form.Get("_IDDIAGNOSTICO");
                        item._IDENFERMEDAD = form.Get("_IDENFERMEDAD");
                        item._IDINSTITUCION = form.Get("_IDINSTITUCION");
                        item._NOMBREENFERMEDAD = form.Get("_NOMBREENFERMEDAD");
                        item._PROVINCIA = form.Get("_PROVINCIA");
                        item._GENERO = Convert.ToBoolean(form.Get("_GENERO"));
                        item._DIA = form.Get("_DIA");
                        item._MES = form.Get("_MES");
                        item._ANNO = form.Get("_ANNO");
                        item._NOMBREINSTITUCION = form.Get("_NOMBREINSTITUCION");
                        
                        
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.InsertarEstudio());
                        return response;
                        break;


                    }
                case "modificar":
                    {
                        SEabyvisual.Estudio item = new SEabyvisual.Estudio();
                        item._IDESTUDIO = form.Get("_IDESTUDIO");
                        item._IDDIAGNOSTICO = form.Get("_IDDIAGNOSTICO");
                        item._IDENFERMEDAD = form.Get("_IDENFERMEDAD");
                        item._IDINSTITUCION = form.Get("_IDINSTITUCION");
                        item._NOMBREENFERMEDAD = form.Get("_NOMBREENFERMEDAD");
                        item._PROVINCIA = form.Get("_PROVINCIA");
                        item._GENERO = Convert.ToBoolean(form.Get("_GENERO"));
                        item._DIA = form.Get("_DIA");
                        item._MES = form.Get("_MES");
                        item._ANNO = form.Get("_ANNO");
                        item._NOMBREINSTITUCION = form.Get("_NOMBREINSTITUCION");
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.ActualizarEstudio());
                        return response;
                        break;
                    }
                case "eliminar":
                    {
                        SEabyvisual.Estudio item = new SEabyvisual.Estudio();
                        item._IDESTUDIO = form.Get("_IDESTUDIO");
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.EliminarEstudio());
                        return response;
                        break;
                    }
                case "listar":
                    {
                        HttpResponseMessage response = Request.CreateResponse<List<SEabyvisual.Estudio>>(SEabyvisual.Estudio.Seleccionar());

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


