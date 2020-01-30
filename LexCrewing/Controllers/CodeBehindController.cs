using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
namespace LexCrewing.Controllers
{
    public class CodeBehindController : ApiController
    {

        [System.Web.Mvc.HttpGet]
        public IEnumerable<dynamic> GetRank()
        {
            // Create a PetaPoco database object
            var db = new PetaPoco.Database("DefaultConnection");

            // Show all Branches
            var b = db.Query<dynamic>("SELECT RankCode,RankDescription FROM Rank").ToList();

            return b;
        }
    }
}
