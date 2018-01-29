using System;
using System.Web;

namespace SecureNuGetServer
{
  public class AcmeChallengeHandler : IHttpHandler
  {
    public void ProcessRequest(HttpContext context)
    {
      context.Response.StatusCode = 200;
      context.Response.ContentType = "text/plain";
      context.Response.Write("acme-challenge-response " + Guid.NewGuid());
    }

    public bool IsReusable => true;
  }
}