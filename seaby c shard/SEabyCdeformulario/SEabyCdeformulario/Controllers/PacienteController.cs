using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace SEabyCdeformulario.Controllers
{
    public class PacienteController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            switch (form.Get("op"))
            {

                case "insertar":
                    {
                        SEabyvisual.Paciente item = new SEabyvisual.Paciente();
                        item._IDPACIENTE = form.Get("_IDPACIENTE");
                        SEabyvisual.Medico med = new SEabyvisual.Medico();
                        med._IDMEDICO = form.Get("_IDMEDICO");
                        item._IDMEDICO = med;
                        SEabyvisual.Institucion Ins = new SEabyvisual.Institucion();
                        Ins._IDINSTITUCION = form.Get("_IDINSTITUCION");
                        item._IDINSTITUCION = Ins;
                        item._NOMBRE = form.Get("_NOMBRE");
                        item._EDAD = Convert.ToInt32(form.Get("_EDAD"));
                        item._PESO = Convert.ToDecimal(form.Get("_PESO").ToString().Replace(',', '.'));
                        item._ESTATURA = Convert.ToDecimal(form.Get("_ESTATURA").ToString().Replace(',', '.'));
                        item._SANGRE = form.Get("_SANGRE");
                        item._VICIOS = form.Get("_VICIOS");
                        item._MEDICACION = form.Get("_MEDICACION");
                        item._ALERGIAS = form.Get("_ALERGIAS");
                        item._PADECIMIENTOS = form.Get("_PADECIMIENTOS");
                        item._GENERO = Convert.ToBoolean(Convert.ToInt32(form.Get("_GENERO").ToString()));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.InsertarPaciente());
                        string LISTACRUDA = "";
                        LISTACRUDA = LISTACRUDA + form.Get("_LISTADEPADECIMIENTOS");
                        var jsonArrayString = LISTACRUDA;

                        JArray jsonArray = JArray.Parse(jsonArrayString);
                        int contador = 0;
   
                        foreach (var result in jsonArray)
                        {
                            contador = contador + 1;
                            // this can be a string or null
                            string IDENFERMEDAD = (string)result;
                            SEabyCdeformulario.Paciente_Enfermedad PE = new Paciente_Enfermedad();
                           
                           SEabyvisual.Enfermedad EN = new SEabyvisual.Enfermedad();
                            EN._IDENFERMEDAD =IDENFERMEDAD;


                            PE._IDPACIENTE = item;
                            PE._IDENFERMEDAD = EN;
                            PE._IDPACIENTEENFERMEDAD = item._IDPACIENTE + EN._IDENFERMEDAD;
                            PE.InsertarPacienteEnfermedad();
                        }

                        return response;
                        break;


                    }
                case "modificar":
                    {
                        SEabyvisual.Paciente item = new SEabyvisual.Paciente();
                        item._IDPACIENTE = form.Get("_IDPACIENTE");
                        SEabyvisual.Medico med = new SEabyvisual.Medico();
                        med._IDMEDICO = form.Get("_IDMEDICO");
                        item._IDMEDICO = med;
                        SEabyvisual.Institucion Ins = new SEabyvisual.Institucion();
                        Ins._IDINSTITUCION = form.Get("_IDINSTITUCION");
                        item._IDINSTITUCION = Ins;
                        item._NOMBRE = form.Get("_NOMBRE");
                        item._EDAD = Convert.ToInt32(form.Get("_EDAD"));
                        item._PESO = Convert.ToDecimal(form.Get("_PESO").ToString().Replace(',', '.'));
                        item._ESTATURA = Convert.ToDecimal(form.Get("_ESTATURA").ToString().Replace(',', '.'));
                        item._SANGRE = form.Get("_SANGRE");
                        item._VICIOS = form.Get("_VICIOS");
                        item._MEDICACION = form.Get("_MEDICACION");
                        item._ALERGIAS = form.Get("_ALERGIAS");
                        item._PADECIMIENTOS = form.Get("_PADECIMIENTOS");
                        item._GENERO = Convert.ToBoolean(form.Get("_GENERO"));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.ActualizarPaciente());
                        return response;
                        break;
                    }
                case "eliminar":
                    {
                        SEabyvisual.Paciente item = new SEabyvisual.Paciente();
                        item._IDPACIENTE = form.Get("_IDPACIENTE");
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, item.EliminarPaciente());
                        return response;
                        break;
                    }
                case "listar":
                    {
                        HttpResponseMessage response = Request.CreateResponse<List<SEabyvisual.Paciente>>(SEabyvisual.Paciente.Seleccionar());

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


