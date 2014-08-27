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

namespace hytc.chat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainForm.CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(new ThreadStart(listen));
            Thread.Sleep(100);
            th.IsBackground = true;
            th.Start();
            UdpClient uc = new UdpClient();
            //string myip = this.txts_ipadd.Text;
            IPEndPoint myipaddress = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 9527);
            //string recmes = Encoding.Default.GetString(mesby);
            string sxstr = "INROOM|ZJ";
            byte[] sxstrby = Encoding.Default.GetBytes(sxstr);
            uc.Send(sxstrby, sxstrby.Length, myipaddress);
          
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            UdpClient uc = new UdpClient();
            string ip=this.txts_ipadd.Text;
            IPEndPoint ipaddress = new IPEndPoint(IPAddress.Parse(ip), 9527);
            string sentxt = this.txtb_sendmes.Text;
            byte[] sentxtby = Encoding.Default.GetBytes(sentxt);
            uc.Send(sentxtby,sentxtby.Length,ipaddress);
        }
        private void listen()
        {
            UdpClient uc = new UdpClient(9527);
            while (true) {
                IPEndPoint ip = new IPEndPoint(IPAddress.Any, 0);
                byte[] remesby=uc.Receive(ref ip);
                string recmes = Encoding.Default.GetString(remesby);
                string[] datas = recmes.Split('|');
                if(datas[0]=="PUBLIC")
                {
                    if (datas.Count()> 2)
                    {
                        string nemestr = datas[2];
                        this.txtbox_sx.Text += nemestr + "\r\n";
                        this.txtbox_sx.Text += "上线了" + "\r\n";
                        string submes = datas[1];
                        this.txtb_recmes.Text += nemestr + "\r\n";
                        this.txtb_recmes.Text += submes + "\r\n"; 
                    }
                    
                }
                else if (datas[0] == "INROOM")
                {
                    if (datas.Count() > 1)
                    {
                        string submes = datas[1];
                        this.txtbox_sx.Text += submes + "\r\n";
                        this.txtbox_sx.Text += "上线了";
                    }
                   
                }
                else
                {
                }
                
                
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            Application.Exit();
            

        }
        
    }
}
