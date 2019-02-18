using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace SEabyCdeformulario.Controllers
{
    public class DiagnosticoController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            switch (form.Get("op"))
            {

                case "insertar":
                    {
                        SEabyvisual.Diagnostico item = new SEabyvisual.Diagnostico();
                        item._IDDIAGNOSTICO = form.Get("_IDDIAGNOSTICO");
                        SEabyvisual.Medico med = new SEabyvisual.Medico();
                        med._IDMEDICO = form.Get("_IDMEDICO");
                        item._IDMEDICO = med;
                        SEabyvisual.Paciente pac = new SEabyvisual.Paciente();
                        pac._IDPACIENTE = form.Get("_IDPACIENTE");
                        item._IDPACIENTE = pac;
                        item._DESCRIPCION = form.Get("_DESCRIPCION");
                        item._SEGUIMIENTO = form.Get("_SEGUIMIENTO");
                        item._DIA = form.Get("_DIA");
                        item._MES = form.Get("_MES");
                        item._ANNO = form.Get("_ANNO");
                        
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.InsertarDiagnostico());
                        return response;
                        break;


                    }
                case "modificar":
                    {
                        SEabyvisual.Diagnostico item = new SEabyvisual.Diagnostico();
                        item._IDDIAGNOSTICO = form.Get("_IDDIAGNOSTICO");
                        SEabyvisual.Medico med = new SEabyvisual.Medico();
                        med._IDMEDICO = form.Get("_IDMEDICO");
                        item._IDMEDICO = med;
                        SEabyvisual.Paciente pac = new SEabyvisual.Paciente();
                        pac._IDPACIENTE = form.Get("_IDPACIENTE");
                        item._IDPACIENTE = pac;
                        item._DESCRIPCION = form.Get("_DESCRIPCION");
                        item._SEGUIMIENTO = form.Get("_SEGUIMIENTO");
                        item._DIA = form.Get("_DIA");
                        item._MES = form.Get("_MES");
                        item._ANNO = form.Get("_ANNO");
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.ActualizarDiagnostico());
                        return response;
                        break;
                    }
                case "eliminar":
                    {
                        SEabyvisual.Diagnostico item = new SEabyvisual.Diagnostico();
                        item._IDDIAGNOSTICO = form.Get("_IDDIAGNOSTICO");
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.EliminarDiagnostico());
                        return response;
                        break;
                    }
                case "listar":
                    {
                        HttpResponseMessage response = Request.CreateResponse<List<SEabyvisual.Diagnostico>>(SEabyvisual.Diagnostico.Seleccionar());

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


