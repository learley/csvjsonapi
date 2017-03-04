using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace csvjsonapi.Controllers
{
    [RoutePrefix("api/static")]
    public class StaticController : ApiController
    {
        //// GET: api/Static
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Static/{dataset}
        [Route("{jsonfile}")]
        public object Get(string jsonfile)
        {
            string path = @"D:\home\site\wwwroot\data\" + jsonfile + ".json"; //TODO: make this a relative path or pulled from configuration
            string allText = System.IO.File.ReadAllText(path);

            object jsonObject = JsonConvert.DeserializeObject(allText);
            return jsonObject;
        }

        //// POST: api/Static
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Static/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Static/5
        //public void Delete(int id)
        //{
        //}
    }
}
