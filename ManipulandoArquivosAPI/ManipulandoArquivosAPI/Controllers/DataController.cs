using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ManipulandoArquivosAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/data")]
    public class DataController : ApiController
    {

        [HttpPost]
        [Route("receiveFile")]
        public HttpResponseMessage receiveFile()
        {
            return Request.CreateResponse(HttpStatusCode.Accepted,
                "Inserção realizada com sucesso");
        }
    }
}
