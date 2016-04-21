using System.Threading;
using System.Windows.Forms;

namespace TcpSocket
{
    public partial class ClientForm : Form
    {
        private Client client;

        public ClientForm()
        {
            client = new Client(this);

            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, System.EventArgs e)
        {
            BtnConnect.Enabled = false;
            BtnDisconnect.Enabled = true;
            TextBoxHostName.Enabled = false;
            TextBoxPort.Enabled = false;
            TextBoxName.Enabled = true;
            TextBoxMessage.Enabled = true;
            BtnSendMessage.Enabled = true;

            client.Start(TextBoxHostName.Text, int.Parse(TextBoxPort.Text));
        }

        private void BtnDisconnect_Click(object sender, System.EventArgs e)
        {
            Disconnect();
        }

        delegate void DisconnectCallback();
        public void Disconnect()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new DisconnectCallback(Disconnect));
            }
            else
            {
                BtnConnect.Enabled = true;
                BtnDisconnect.Enabled = false;
                TextBoxHostName.Enabled = true;
                TextBoxPort.Enabled = true;
                TextBoxName.Enabled = false;
                TextBoxMessage.Enabled = false;
                BtnSendMessage.Enabled = false;

                client.Disconnect();
            }
        }

        private void BtnSendMessage_Click(object sender, System.EventArgs e)
        {
            client.SendMessage(TextBoxName.Text + ": " + TextBoxMessage.Text);
        }

        delegate void SetMessageCallback(string message);
        public void SetMessage(string message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new SetMessageCallback(SetMessage), message);
            }
            else
            {
                ListBoxClientInformations.Items.Add(message);
            }
        }
    }
}
