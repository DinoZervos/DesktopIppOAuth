using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace DesktopIppOAuth {

  public class OAuthController : ApiController {

    public delegate void oAuthCallbackHandler(string code, string state, string realmId);

    public event oAuthCallbackHandler oAuthCallbackEvent;

    public OAuthController() {

      this.oAuthCallbackEvent += OAuthConnector.CurrentInstance.oAuthCallback;

    }

    public HttpResponseMessage Get(string code, string state, string realmId) {

      // this sets the access tokens in the oAUthConnector
      oAuthCallbackEvent.Invoke(code, state, realmId);

      string content;

      if (string.IsNullOrEmpty(OAuthConnector.CurrentInstance.AccessToken )) {
        content = @"<!DOCTYPE html><html><head><title>DesktopIppOAuth</title></head>" +
        @"<body><h1 style='color:red;'>Failed!</h1>" +
        @"<p>A connection to QuickBooks online could not be established..</p></body></html>";
      }
      else {
        content = @"<!DOCTYPE html><html><head><title>DesktopIppOAuth</title></head>" +
        @"<body><h1 style='color:green;'>Success!</h1>" +
        @"<p>You have authorized the application to connect to your QuickBooks online.</p></body></html>";
      }

      // show the result
      HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "text/html");

      response.Content = new StringContent(content, Encoding.UTF8, "text/html");

      return response;

    }

  }

}
