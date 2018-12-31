using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ManipulandoArquivosAPI.Controllers
{
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
