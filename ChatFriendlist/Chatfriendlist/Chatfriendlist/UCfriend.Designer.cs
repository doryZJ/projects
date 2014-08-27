namespace Chatfriendlist
{
    partial class UCfriend
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picbheadpic = new System.Windows.Forms.PictureBox();
            this.lblucnickname = new System.Windows.Forms.Label();
            this.lblucshuoshuo = new System.Windows.Forms.Label();
            this.lblucip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbheadpic)).BeginInit();
            this.SuspendLayout();
            // 
            // picbheadpic
            // 
            this.picbheadpic.Location = new System.Drawing.Point(10, 0);
            this.picbheadpic.Name = "picbheadpic";
            this.picbheadpic.Size = new System.Drawing.Size(60, 60);
            this.picbheadpic.TabIndex = 0;
            this.picbheadpic.TabStop = false;
            // 
            // lblucnickname
            // 
            this.lblucnickname.AutoSize = true;
            this.lblucnickname.Location = new System.Drawing.Point(92, 11);
            this.lblucnickname.Name = "lblucnickname";
            this.lblucnickname.Size = new System.Drawing.Size(41, 12);
            this.lblucnickname.TabIndex = 1;
            this.lblucnickname.Text = "label1";
            // 
            // lblucshuoshuo
            // 
            this.lblucshuoshuo.AutoSize = true;
            this.lblucshuoshuo.Location = new System.Drawing.Point(92, 36);
            this.lblucshuoshuo.Name = "lblucshuoshuo";
            this.lblucshuoshuo.Size = new System.Drawing.Size(41, 12);
            this.lblucshuoshuo.TabIndex = 2;
            this.lblucshuoshuo.Text = "label2";
            // 
            // lblucip
            // 
            this.lblucip.AutoSize = true;
            this.lblucip.Location = new System.Drawing.Point(163, 24);
            this.lblucip.Name = "lblucip";
            this.lblucip.Size = new System.Drawing.Size(41, 12);
            this.lblucip.TabIndex = 3;
            this.lblucip.Text = "label1";
            this.lblucip.Visible = false;
            // 
            // UCfriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblucip);
            this.Controls.Add(this.lblucshuoshuo);
            this.Controls.Add(this.lblucnickname);
            this.Controls.Add(this.picbheadpic);
            this.Name = "UCfriend";
            this.Size = new System.Drawing.Size(235, 60);
            ((System.ComponentModel.ISupportInitialize)(this.picbheadpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbheadpic;
        private System.Windows.Forms.Label lblucnickname;
        private System.Windows.Forms.Label lblucshuoshuo;
        private System.Windows.Forms.Label lblucip;
    }
}
