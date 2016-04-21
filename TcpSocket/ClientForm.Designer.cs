namespace TcpSocket
{
    partial class ClientForm
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
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.BtnSendMessage = new System.Windows.Forms.Button();
            this.LabelHostName = new System.Windows.Forms.Label();
            this.TextBoxHostName = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.ListBoxClientInformations = new System.Windows.Forms.ListBox();
            this.LabelPort = new System.Windows.Forms.Label();
            this.TextBoxPort = new System.Windows.Forms.TextBox();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(12, 93);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(38, 13);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Name:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Enabled = false;
            this.TextBoxName.Location = new System.Drawing.Point(15, 109);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(343, 20);
            this.TextBoxName.TabIndex = 1;
            // 
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.Location = new System.Drawing.Point(12, 132);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(53, 13);
            this.LabelMessage.TabIndex = 2;
            this.LabelMessage.Text = "Message:";
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Enabled = false;
            this.TextBoxMessage.Location = new System.Drawing.Point(15, 148);
            this.TextBoxMessage.Multiline = true;
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Size = new System.Drawing.Size(343, 65);
            this.TextBoxMessage.TabIndex = 3;
            // 
            // BtnSendMessage
            // 
            this.BtnSendMessage.Enabled = false;
            this.BtnSendMessage.Location = new System.Drawing.Point(15, 219);
            this.BtnSendMessage.Name = "BtnSendMessage";
            this.BtnSendMessage.Size = new System.Drawing.Size(343, 23);
            this.BtnSendMessage.TabIndex = 4;
            this.BtnSendMessage.Text = "Send Message";
            this.BtnSendMessage.UseVisualStyleBackColor = true;
            this.BtnSendMessage.Click += new System.EventHandler(this.BtnSendMessage_Click);
            // 
            // LabelHostName
            // 
            this.LabelHostName.AutoSize = true;
            this.LabelHostName.Location = new System.Drawing.Point(12, 14);
            this.LabelHostName.Name = "LabelHostName";
            this.LabelHostName.Size = new System.Drawing.Size(63, 13);
            this.LabelHostName.TabIndex = 5;
            this.LabelHostName.Text = "Host Name:";
            // 
            // TextBoxHostName
            // 
            this.TextBoxHostName.Location = new System.Drawing.Point(15, 30);
            this.TextBoxHostName.Name = "TextBoxHostName";
            this.TextBoxHostName.Size = new System.Drawing.Size(167, 20);
            this.TextBoxHostName.TabIndex = 6;
            this.TextBoxHostName.Text = "127.0.0.1";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(15, 56);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(167, 34);
            this.BtnConnect.TabIndex = 7;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // ListBoxClientInformations
            // 
            this.ListBoxClientInformations.FormattingEnabled = true;
            this.ListBoxClientInformations.Location = new System.Drawing.Point(15, 248);
            this.ListBoxClientInformations.Name = "ListBoxClientInformations";
            this.ListBoxClientInformations.Size = new System.Drawing.Size(343, 82);
            this.ListBoxClientInformations.TabIndex = 8;
            // 
            // LabelPort
            // 
            this.LabelPort.AutoSize = true;
            this.LabelPort.Location = new System.Drawing.Point(185, 14);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(29, 13);
            this.LabelPort.TabIndex = 9;
            this.LabelPort.Text = "Port:";
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.Location = new System.Drawing.Point(188, 30);
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.Size = new System.Drawing.Size(170, 20);
            this.TextBoxPort.TabIndex = 10;
            this.TextBoxPort.Text = "3000";
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Enabled = false;
            this.BtnDisconnect.Location = new System.Drawing.Point(188, 56);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(170, 34);
            this.BtnDisconnect.TabIndex = 11;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 345);
            this.Controls.Add(this.BtnDisconnect);
            this.Controls.Add(this.TextBoxPort);
            this.Controls.Add(this.LabelPort);
            this.Controls.Add(this.ListBoxClientInformations);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.TextBoxHostName);
            this.Controls.Add(this.LabelHostName);
            this.Controls.Add(this.BtnSendMessage);
            this.Controls.Add(this.TextBoxMessage);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.TextBox TextBoxMessage;
        private System.Windows.Forms.Button BtnSendMessage;
        private System.Windows.Forms.Label LabelHostName;
        private System.Windows.Forms.TextBox TextBoxHostName;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.ListBox ListBoxClientInformations;
        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.TextBox TextBoxPort;
        private System.Windows.Forms.Button BtnDisconnect;
    }
}