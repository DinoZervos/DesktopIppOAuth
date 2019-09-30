using System;
using System.Windows.Forms;
using DesktopIppOAuth;

namespace DesktopIppOAuthSample {

  public partial class FormMain : Form {

    // OAuth consumer key and secret from OAuth provider, replace with your own!!
    private string consumerId = string.Empty;
    private string consumerSecret = string.Empty;
    private OAuthConnector _connector;

    public FormMain() {

      InitializeComponent();

    }

    private void FormMain_Load(object sender, EventArgs e) {

      txtConsumerId.Text = consumerId;
      txtConsumerSecret.Text = consumerSecret;
      _connector = new OAuthConnector();
      _connector.IppOAuthResultEvent += _connector_IppOAuthResultEvent;

    }

    void _connector_IppOAuthResultEvent(string accessToken, string refreshToken) {

      SafeInvokeHelper.Invoke(txtAccessToken, "set_Text", accessToken);
      SafeInvokeHelper.Invoke(txtRefreshToken, "set_Text", refreshToken);

    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {

      _connector.CleanUp();

    }

    private void buttonConnect_Click(object sender, EventArgs e) {

      consumerId = txtConsumerId.Text;
      consumerSecret = txtConsumerSecret.Text;

      _connector.Connect(consumerId, consumerSecret);
      
    }

  }

}
