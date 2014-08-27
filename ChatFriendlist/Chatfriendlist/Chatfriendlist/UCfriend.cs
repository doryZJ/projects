using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chatfriendlist
{
    public partial class UCfriend : UserControl
    {
        private FormMain formmain;

        public FormMain Formmain
        {
            get { return formmain; }
            set { formmain = value;}
        }

        private friendInfo friendlist;

        public friendInfo Friendlist
        {
            get { return friendlist; }
            set 
            { 
                friendlist = value;
                this.lblucnickname.Text = value.ucnickname;
                this.lblucshuoshuo.Text = value.ucshuoshuo;
                this.lblucip.Text = value.ucip.ToString();
                this.picbheadpic.Image= this.formmain.ilheadpic.Images[value.ucheadpic];
            }
        }
       
           
        public UCfriend()
        {
            InitializeComponent();
        }

       
    }
}
