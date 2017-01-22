namespace HMIS_121
{
    partial class FrmMain
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
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.btnClose_Media = new System.Windows.Forms.Button();
            this.btnOpen_Media = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMh = new System.Windows.Forms.TextBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(92, 39);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(154, 20);
            this.txtMedia.TabIndex = 0;
            // 
            // btnClose_Media
            // 
            this.btnClose_Media.Location = new System.Drawing.Point(279, 31);
            this.btnClose_Media.Name = "btnClose_Media";
            this.btnClose_Media.Size = new System.Drawing.Size(145, 34);
            this.btnClose_Media.TabIndex = 1;
            this.btnClose_Media.Text = "Đóng BA Thanh toán muộn";
            this.btnClose_Media.UseVisualStyleBackColor = true;
            this.btnClose_Media.Click += new System.EventHandler(this.btnClose_Media_Click);
            // 
            // btnOpen_Media
            // 
            this.btnOpen_Media.Location = new System.Drawing.Point(471, 28);
            this.btnOpen_Media.Name = "btnOpen_Media";
            this.btnOpen_Media.Size = new System.Drawing.Size(144, 36);
            this.btnOpen_Media.TabIndex = 2;
            this.btnOpen_Media.Text = "Mở BA Thanh toán muộn";
            this.btnOpen_Media.UseVisualStyleBackColor = true;
            this.btnOpen_Media.Click += new System.EventHandler(this.btnOpen_Media_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số Bệnh Án: ";
            // 
            // txtMh
            // 
            this.txtMh.Location = new System.Drawing.Point(63, 112);
            this.txtMh.Name = "txtMh";
            this.txtMh.Size = new System.Drawing.Size(182, 20);
            this.txtMh.TabIndex = 4;
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(63, 165);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(182, 20);
            this.txtKq.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ma hoa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "Giai ma";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txtMh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen_Media);
            this.Controls.Add(this.btnClose_Media);
            this.Controls.Add(this.txtMedia);
            this.Name = "FrmMain";
            this.Text = "Viện phí 121";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Button btnClose_Media;
        private System.Windows.Forms.Button btnOpen_Media;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMh;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

