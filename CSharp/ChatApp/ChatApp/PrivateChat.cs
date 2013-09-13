using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace ChatApp
{
    public partial class PrivateChat : Form
    {
        Socket skt;
        EndPoint localEndPoint, remoteEndPoint;
        byte[] buffer;

        public PrivateChat()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // set up socket
            skt = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            skt.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            // get loack and remote IP
            textLocalIP.Text = GetLocalIP();
            textRemoteIP.Text = GetLocalIP();
            textLocalPort.Text = "91";
            textRemotePort.Text = "80";

        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            // binding Socket

            localEndPoint = new IPEndPoint(IPAddress.Parse(textLocalIP.Text), Convert.ToInt32(textLocalPort.Text));
            skt.Bind(localEndPoint);

            // connecting
            remoteEndPoint = new IPEndPoint(IPAddress.Parse(textRemoteIP.Text), Convert.ToInt32(textRemotePort.Text));
            skt.Connect(remoteEndPoint);
            //Listeninf the specific port

            buffer = new byte[1500];

            skt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(MessageCallBack), buffer);

            buttonConnect.BackColor = Color.LightGreen;
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                // converting byte[] to string

                ASCIIEncoding asciiEncoding = new ASCIIEncoding();
                string reseivedMessage = asciiEncoding.GetString(receivedData);


                // adding the msg to the listbox
                listViewMSG.View = View.Details;
               
                ListViewItem item1 = new ListViewItem("Friend", 0);
                item1.SubItems.Add(reseivedMessage);
                item1.SubItems.Add(string.Format("[{0,2}:{1,2}:{2,2}]", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second));
                //Add the items to the ListView.
                listViewMSG.Items.AddRange(new ListViewItem[] { item1 });


                // adding this message into Listbox
                listMessages.Items.Add("Friend: " + reseivedMessage);

                buffer = new byte[1500];
                skt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remoteEndPoint, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                // not cool way to do it
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            // conver string msg to byte[]
            ASCIIEncoding asciiEndcoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];

            sendingMessage = asciiEndcoding.GetBytes(textMessage.Text);
            // sending the endcoded message
            skt.Send(sendingMessage);
            
            // adding the msg to the listbox
            listViewMSG.View = View.Details;

            ListViewItem item1 = new ListViewItem("Me", 0);
            item1.SubItems.Add(textMessage.Text);
            item1.SubItems.Add(string.Format("[{0,2}:{1,2}:{2,2}]", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second));
            //Add the items to the ListView.
            listViewMSG.Items.AddRange(new ListViewItem[] { item1 });


            listMessages.Items.Add(string.Format("Me at [{0,2}:{1,2}:{2,2}]: {3}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, textMessage.Text));
            textMessage.Text = "";
        }

        private void textMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (textMessage.Text != "")
                {
                    buttonSend_Click(sender, e);
                }
            }
            e.Handled = false;
        }

        private void btnSwitchPorts_Click(object sender, EventArgs e)
        {
            string temp = textLocalPort.Text;
            textLocalPort.Text = textRemotePort.Text;
            textRemotePort.Text = temp;
        }


    }
}
