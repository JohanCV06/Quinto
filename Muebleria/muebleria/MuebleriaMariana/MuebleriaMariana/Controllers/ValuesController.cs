using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace MuebleriaMariana.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 0);
            return response;
        }
    }
}
