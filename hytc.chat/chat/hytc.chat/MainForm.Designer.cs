namespace hytc.chat
{
    partial class MainForm
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
            this.txts_ipadd = new System.Windows.Forms.TextBox();
            this.txtb_recmes = new System.Windows.Forms.TextBox();
            this.txtb_sendmes = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.txtbox_sx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txts_ipadd
            // 
            this.txts_ipadd.Location = new System.Drawing.Point(28, 12);
            this.txts_ipadd.Name = "txts_ipadd";
            this.txts_ipadd.Size = new System.Drawing.Size(313, 21);
            this.txts_ipadd.TabIndex = 0;
            // 
            // txtb_recmes
            // 
            this.txtb_recmes.Location = new System.Drawing.Point(28, 49);
            this.txtb_recmes.Multiline = true;
            this.txtb_recmes.Name = "txtb_recmes";
            this.txtb_recmes.Size = new System.Drawing.Size(313, 176);
            this.txtb_recmes.TabIndex = 1;
            // 
            // txtb_sendmes
            // 
            this.txtb_sendmes.Location = new System.Drawing.Point(28, 247);
            this.txtb_sendmes.Name = "txtb_sendmes";
            this.txtb_sendmes.Size = new System.Drawing.Size(313, 21);
            this.txtb_sendmes.TabIndex = 2;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(266, 287);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txtbox_sx
            // 
            this.txtbox_sx.Location = new System.Drawing.Point(370, 12);
            this.txtbox_sx.Multiline = true;
            this.txtbox_sx.Name = "txtbox_sx";
            this.txtbox_sx.Size = new System.Drawing.Size(137, 288);
            this.txtbox_sx.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 322);
            this.Controls.Add(this.txtbox_sx);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txtb_sendmes);
            this.Controls.Add(this.txtb_recmes);
            this.Controls.Add(this.txts_ipadd);
            this.Name = "MainForm";
            this.Text = "聊天";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txts_ipadd;
        private System.Windows.Forms.TextBox txtb_recmes;
        private System.Windows.Forms.TextBox txtb_sendmes;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txtbox_sx;
    }
}

