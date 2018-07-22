using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace API.filters
{
    public class CustomAunthenticationFilter : AuthorizationFilterAttribute
    {
        //
        // Summary:
        //     Calls when an action is being authorized.
        //
        // Parameters:
        //   actionContext:
        //     The context.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The context parameter is null.
        public override void OnAuthorization(HttpActionContext actionContext)
        {

        }

        // Summary:
        //     Processes requests that fail authorization.
        //
        // Parameters:
        //   actionContext:
        //     The context.
        protected virtual void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
        }    //
             // Summary:
             //     Indicates whether the specified control is authorized.
             //
             // Parameters:
             //   actionContext:
             //     The context.
             //
             // Returns:
             //     true if the control is authorized; otherwise, false.
        protected virtual bool IsAuthorized(HttpActionContext actionContext)
        {
            return true;
        }
    }


    public class BasicAunthenticationFilter : AuthorizationFilterAttribute
    {
        //
        // Summary:
        //     Calls when an action is being authorized.
        //
        // Parameters:
        //   actionContext:
        //     The context.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The context parameter is null.
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                string authenticationtoken = actionContext.Request.Headers.Authorization.Parameter;
                //string decodedtoken = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationtoken));

                string userName = authenticationtoken.Split(':')[0];
                string Password = authenticationtoken.Split(':')[1];
                if(userName=="koti" && Password=="koti")
                Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(userName), null);
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);

                }
            }
        }

        // Summary:
        //     Processes requests that fail authorization.
        //
        // Parameters:
        //   actionContext:
        //     The context.
        protected virtual void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
        }    //
             // Summary:
             //     Indicates whether the specified control is authorized.
             //
             // Parameters:
             //   actionContext:
             //     The context.
             //
             // Returns:
             //     true if the control is authorized; otherwise, false.
        protected virtual bool IsAuthorized(HttpActionContext actionContext)
        {
            return true;
        }
    }
}