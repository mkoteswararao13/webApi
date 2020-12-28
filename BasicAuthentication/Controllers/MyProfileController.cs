using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BasicAuthentication.Filters;
using BasicAuthentication.Models;
namespace BasicAuthentication.Controllers
{
    [BasicAuth]
    public class MyProfileController : ApiController
    {
        public HttpResponseMessage GetProfile(int profileId)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new Profile() { ProfileId = 10, firstName = "sfd" });
        }
    }
}
