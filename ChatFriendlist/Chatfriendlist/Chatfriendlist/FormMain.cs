using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Chatfriendlist
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private delegate void delucfclient(friendInfo f);
        private void FormMain_Load(object sender, EventArgs e)
        {
            FormMain.CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(new ThreadStart(listen));
            Thread.Sleep(100);
            th.IsBackground = true;
            th.Start();
            UdpClient uc = new UdpClient();
            //IPAddress hoststr =Dns.GetHostEntry(Dns.GetHostName()).Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).First();
            IPAddress ipa = Dns.GetHostAddresses(Dns.GetHostName()).Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).First();
            //IPAddress hostip = IPAddress.Parse(hoststr);
            IPEndPoint myip = new IPEndPoint(IPAddress.Parse("255.255.255.255"),9527);
            string sendmes = "LOGIN|zj|0|你若盛开，清风自来～～|" + ipa;
           // MessageBox.Show(sendmes);
            byte[] sendmesby=Encoding.Default.GetBytes(sendmes);
            uc.Send(sendmesby, sendmesby.Length, myip);
        }
        private void listen() 
        {
            UdpClient uc = new UdpClient(9527);
            while (true) 
            {
                IPEndPoint ip = new IPEndPoint(IPAddress.Any,0);
                byte[] remesby = uc.Receive(ref ip);
                string remes = Encoding.Default.GetString(remesby);
                string[] datas = remes.Split('|');
                if (datas.Length < 5)
                {
                    continue;
                }
                if (datas[0] == "LOGIN")
                {
                   
                    friendInfo fi = new friendInfo();
                    

                    int headpiccount = Convert.ToInt32(datas[2]);
                    //if (headpiccount < 0 || headpiccount > 9)
                    //{
                    //    headpiccount = 0;
                    //}
                    fi.ucheadpic = headpiccount;
                    fi.ucnickname = datas[1];
                    fi.ucshuoshuo = datas[3];
                    //MessageBox.Show(datas[4]);
                    if (datas[4] == "192.168.1.224")
                    {
                        continue;
                    }
                    else
                    {
                        fi.ucip = IPAddress.Parse(datas[4]);
                        IPEndPoint fip = new IPEndPoint(fi.ucip, 9527);
                        string sendmes = "LOGIN|zj|1|你若盛开，清风自来～～|192.168.1.224";
                        byte[] sendmesby = Encoding.Default.GetBytes(sendmes);
                        uc.Send(sendmesby, sendmesby.Length, fip);
                    }

                   // MessageBox.Show(fi.ucip.ToString());
                    //fi.ucip =IPAddress.Parse(datas[4]);
                    //fi.ucip = IPAddress.Parse("192.168.1.224");
                    object[] para = new object[1];
                    para[0] = fi;
                    this.Invoke(new delucfclient(this.ucfclient),para);
                    //string sendmes = "LOGIN|zj|0|你若盛开，清风自来～～|" + ipa;
                   
                    
                    
                }   
            } 
        }
        public void ucfclient(friendInfo f) 
        {
            UCfriend ucf = new UCfriend();
            ucf.Formmain = this;
            ucf.Friendlist = f;
            //ucf.Top += 50;
            ucf.Top =this.panfriend.Controls.Count*ucf.Height;
            this.panfriend.Controls.Add(ucf);
        }
        
    }
}
