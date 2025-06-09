using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class CFormMain : Form
    {
        public TcpClient mTcpClient = null;
        public NetworkStream mStream = null;
        public CFormMain()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (mTcpClient == null)
            {
                mTcpClient = new TcpClient(AddressFamily.InterNetwork);
                IPAddress iPAddress = IPAddress.Parse(txtIpAddress.Text);
                int port = Convert.ToInt32(txtPort.Text);

                IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, port);
                mTcpClient.Connect(iPEndPoint);

                btConnect.Text = "Disconnect";

                timerReceive.Enabled = true;    
                mStream = mTcpClient.GetStream();   
            }else
            {
                mStream.Close();
                mStream.Dispose();
                mStream = null;

                mTcpClient.Close();
                mTcpClient.Dispose();
                mTcpClient=null;

                btConnect.Text = "Connect";
                timerReceive.Enabled=false; 
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if(mTcpClient == null || mTcpClient.Connected == false) 
            {
                return;
            }
            string messageWithTime = $"{txtName.Text} : {txtSend.Text}";    //   이름 
            byte[] data = Encoding.Default.GetBytes(messageWithTime);
            mTcpClient.Client.Send(data);
        }

        private void timerReceive_Tick(object sender, EventArgs e)
        {
            if (mTcpClient == null || mTcpClient.Connected == false || mStream == null)
            {
                return;
            }

            if(mStream.DataAvailable == true)
            {
                byte[] bzReceive = new byte[1024];

                mStream.ReadAsync(bzReceive, 0, 1024);

                string strReceive = Encoding.Default.GetString(bzReceive);

                StringBuilder sb = new StringBuilder(strReceive);

                string messageWithTime = $"{DateTime.Now}: {sb}";   // 현재 시간

                txtReceive.Text += messageWithTime;
                txtReceive.AppendText("\r\n");
            }

        }
    }
}
