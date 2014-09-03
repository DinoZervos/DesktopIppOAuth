DesktopIppOAuth
==============

A Library for desktop application to get the OAuth Access Token of Intuit Partner Platform Rest APIs. The .Net 4.5 library uses a OWIN selfhost web api 2.0 to receive the OAuth callback so that you don't need to implment a separated web site just for receiving the tokens. The .Net 4.0 library uses asp.net self host web api since OWIN only build on top of .NET 4.5.


Quick Start
----------

* Install Package from Nuget

        Install-Package DesktopIppOAuth

* Use it like this

        // OAuth consumer key and secret from OAuth provider
        private string consumerKey = "your consumer key";
        private string consumerSecret = "your consumer secret";
        private DesktopIppOAuth.OAuthConnector _connector;


        _connector = new OAuthConnector();
        _connector.IppOAuthResultEvent += _connector_IppOAuthResultEvent;

	    _connector.Connect(consumerKey, consumerSecret);

    
        void _connector_IppOAuthResultEvent(string accessToken, string accessTokenSecret, string realmId, string dataSource)
        {
            //save the token information somewhere for later API call.
        }

Why DesktopIppOAuth
-------------------
 
I asked a question on stackoverflow [here] (http://stackoverflow.com/questions/22329226/desktop-application-use-ipp-qbo-api-3-0) about how to do the oauth for my desktop application. 

DesktopIppOAuth uses OWIN to self-host the Web API framework to redirect the callback to the library itself so the application can get the access token right away.


