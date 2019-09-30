/*
   
  Copyright (C) Chaverware LLC - All Rights Reserved
  Unauthorized copying of this file, via any medium is strictly prohibited
  Proprietary and confidential
  Written by Dino Zervos [dzervos@chaverware.com] September 2019
    
*/
using Intuit.Ipp.OAuth2PlatformClient;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesktopIppOAuth {

  public class OAuthConnector {

    #region Fields

    // URLs for the OAuth provider
    private string _defaultBaseAddress = @"http://localhost:65521/";
    IDisposable _webApp = null;

    #endregion

    #region Events

    public event IppOAuthResultHandler IppOAuthResultEvent;

    public delegate void IppOAuthResultHandler(string accessToken, string refreshToken);

    #endregion

    #region Properties

    public string AccessToken { get; set; } //

    public string BaseAddress { get; set; } //

    public string ConsumerId { get; set; } //

    public string ConsumerSecret { get; set; } //

    public string RefreshToken { get; set; } //

    internal static OAuthConnector CurrentInstance { get; set; } //

    private string RedirectUrl { get; set; } //

    #endregion

    #region Methods

    public void CleanUp() {

      if (_webApp != null) {
        _webApp.Dispose();
        _webApp = null;
      }

      CurrentInstance = null;

    }

    public void Connect(string consumerId, string consumerSecret) {

      Connect(consumerId, consumerSecret, _defaultBaseAddress);

    }

    public void Connect(string consumerId, string consumerSecret, string baseAddress) {

      this.ConsumerId = consumerId;
      this.ConsumerSecret = consumerSecret;
      this.BaseAddress = baseAddress ?? _defaultBaseAddress;
      this.RedirectUrl = this.BaseAddress + @"api/oauth";

      if(CurrentInstance != null) {
        CurrentInstance.CleanUp();
      }

      CurrentInstance = this;

      // start the server
      _webApp = WebApp.Start<Startup>(url: this.BaseAddress);

      // prepare scopes
      List<OidcScopes> scopes = new List<OidcScopes>();
      scopes.Add(OidcScopes.Accounting);

      // get auth url
      OAuth2Client client = GetoAuthClient();
      string authorizationUrl = client.GetAuthorizationURL(scopes);

      // start it in the customer's browser
      // this will then call back the get function int the controller
      System.Diagnostics.Process.Start(authorizationUrl);

    }

    internal async void oAuthCallback(string code, string state, string realmId) {

      // the controller calls this when it has the code so it can get the token

      try {

        OAuth2Client client = GetoAuthClient();
        TokenResponse result = await client.GetBearerTokenAsync(code);
        this.AccessToken = result.AccessToken;
        this.RefreshToken = result.RefreshToken;
        IppOAuthResultEvent.Invoke(this.AccessToken, this.RefreshToken);

        await Task.Run(
          () => {
            Task.Delay(2000).Wait();
            CleanUp();
          });
      }
      catch(Exception ex) {
        CleanUp();
        throw ex;
      }

    }

    private OAuth2Client GetoAuthClient() {

      return new OAuth2Client(this.ConsumerId, this.ConsumerSecret, this.RedirectUrl, "sandbox");

    }

  #endregion

  }

}
