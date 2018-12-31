using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
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
            var httpRequest = HttpContext.Current.Request;

            var file = httpRequest.Files["file"];

            StreamReader stream = new StreamReader(file.InputStream, Encoding.Default);
            var line = stream.ReadLine();

            Debug.WriteLine(line);

            return Request.CreateResponse(HttpStatusCode.Accepted,
                "Inserção realizada com sucesso");
        }
    }
}
