namespace Chatfriendlist
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panfriend = new System.Windows.Forms.Panel();
            this.pic_Headpic = new System.Windows.Forms.PictureBox();
            this.lblnickname = new System.Windows.Forms.Label();
            this.lbl_shuoshuo = new System.Windows.Forms.Label();
            this.ilheadpic = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Headpic)).BeginInit();
            this.SuspendLayout();
            // 
            // panfriend
            // 
            this.panfriend.AutoScroll = true;
            this.panfriend.Location = new System.Drawing.Point(2, 69);
            this.panfriend.Name = "panfriend";
            this.panfriend.Size = new System.Drawing.Size(235, 392);
            this.panfriend.TabIndex = 0;
            // 
            // pic_Headpic
            // 
            this.pic_Headpic.Image = ((System.Drawing.Image)(resources.GetObject("pic_Headpic.Image")));
            this.pic_Headpic.Location = new System.Drawing.Point(3, 3);
            this.pic_Headpic.Name = "pic_Headpic";
            this.pic_Headpic.Size = new System.Drawing.Size(60, 60);
            this.pic_Headpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Headpic.TabIndex = 0;
            this.pic_Headpic.TabStop = false;
            // 
            // lblnickname
            // 
            this.lblnickname.AutoSize = true;
            this.lblnickname.Location = new System.Drawing.Point(78, 9);
            this.lblnickname.Name = "lblnickname";
            this.lblnickname.Size = new System.Drawing.Size(17, 12);
            this.lblnickname.TabIndex = 0;
            this.lblnickname.Text = "zj";
            // 
            // lbl_shuoshuo
            // 
            this.lbl_shuoshuo.AutoSize = true;
            this.lbl_shuoshuo.Location = new System.Drawing.Point(78, 41);
            this.lbl_shuoshuo.Name = "lbl_shuoshuo";
            this.lbl_shuoshuo.Size = new System.Drawing.Size(137, 12);
            this.lbl_shuoshuo.TabIndex = 1;
            this.lbl_shuoshuo.Text = "你若盛开，清风自来～～";
            // 
            // ilheadpic
            // 
            this.ilheadpic.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilheadpic.ImageStream")));
            this.ilheadpic.TransparentColor = System.Drawing.Color.Transparent;
            this.ilheadpic.Images.SetKeyName(0, "g.jpg");
            this.ilheadpic.Images.SetKeyName(1, "getface.jpg");
            this.ilheadpic.Images.SetKeyName(2, "headimg1.jpg");
            this.ilheadpic.Images.SetKeyName(3, "headimg2.jpg");
            this.ilheadpic.Images.SetKeyName(4, "headimg3.jpg");
            this.ilheadpic.Images.SetKeyName(5, "headimg4.jpg");
            this.ilheadpic.Images.SetKeyName(6, "headimg5.jpg");
            this.ilheadpic.Images.SetKeyName(7, "headimg6.jpg");
            this.ilheadpic.Images.SetKeyName(8, "headimg7.jpg");
            this.ilheadpic.Images.SetKeyName(9, "headimg8.jpg");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 462);
            this.Controls.Add(this.lbl_shuoshuo);
            this.Controls.Add(this.lblnickname);
            this.Controls.Add(this.pic_Headpic);
            this.Controls.Add(this.panfriend);
            this.Name = "FormMain";
            this.Text = "FriendList";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Headpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panfriend;
        private System.Windows.Forms.PictureBox pic_Headpic;
        private System.Windows.Forms.Label lblnickname;
        private System.Windows.Forms.Label lbl_shuoshuo;
        public System.Windows.Forms.ImageList ilheadpic;
    }
}

