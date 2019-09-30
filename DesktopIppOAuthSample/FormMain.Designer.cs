namespace DesktopIppOAuthSample
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.buttonConnect = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtConsumerId = new System.Windows.Forms.TextBox();
      this.txtConsumerSecret = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtAccessToken = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtRefreshToken = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // buttonConnect
      // 
      this.buttonConnect.Location = new System.Drawing.Point(127, 113);
      this.buttonConnect.Name = "buttonConnect";
      this.buttonConnect.Size = new System.Drawing.Size(207, 42);
      this.buttonConnect.TabIndex = 0;
      this.buttonConnect.Text = "Connect";
      this.buttonConnect.UseVisualStyleBackColor = true;
      this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(68, 38);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Client Id:";
      // 
      // textBoxConsumerKey
      // 
      this.txtConsumerId.Location = new System.Drawing.Point(127, 38);
      this.txtConsumerId.Name = "textBoxConsumerKey";
      this.txtConsumerId.Size = new System.Drawing.Size(284, 20);
      this.txtConsumerId.TabIndex = 2;
      // 
      // textBoxConsumerKeySecret
      // 
      this.txtConsumerSecret.Location = new System.Drawing.Point(127, 70);
      this.txtConsumerSecret.Name = "textBoxConsumerKeySecret";
      this.txtConsumerSecret.Size = new System.Drawing.Size(284, 20);
      this.txtConsumerSecret.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(50, 70);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(70, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Client Secret:";
      // 
      // textBoxAccessToken
      // 
      this.txtAccessToken.Location = new System.Drawing.Point(127, 177);
      this.txtAccessToken.Name = "textBoxAccessToken";
      this.txtAccessToken.Size = new System.Drawing.Size(423, 20);
      this.txtAccessToken.TabIndex = 10;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(41, 177);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(76, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Access Token";
      // 
      // textBoxAccessTokenSecret
      // 
      this.txtRefreshToken.Location = new System.Drawing.Point(127, 205);
      this.txtRefreshToken.Name = "textBoxAccessTokenSecret";
      this.txtRefreshToken.Size = new System.Drawing.Size(423, 20);
      this.txtRefreshToken.TabIndex = 12;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(38, 208);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(78, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Refresh Token";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(580, 252);
      this.Controls.Add(this.txtRefreshToken);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtAccessToken);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtConsumerSecret);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtConsumerId);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonConnect);
      this.Name = "FormMain";
      this.Text = "Desktop Ipp OAuth";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsumerId;
        private System.Windows.Forms.TextBox txtConsumerSecret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRefreshToken;
        private System.Windows.Forms.Label label6;
    }
}

