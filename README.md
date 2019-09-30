DesktopIppOAuth
==============

A Library for desktop application to get the OAuth2 Access Tokens of Intuit Partner Platform Rest APIs. 

Quick Start
----------

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
