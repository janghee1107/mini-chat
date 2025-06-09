namespace ChatClient
{
    partial class CFormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.timerReceive = new System.Windows.Forms.Timer(this.components);
            this.btSend = new System.Windows.Forms.Button();
            this.grpConnect = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lnlName = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIpAddr = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.grpConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(12, 125);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReceive.Size = new System.Drawing.Size(763, 368);
            this.txtReceive.TabIndex = 1;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(12, 501);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(629, 89);
            this.txtSend.TabIndex = 2;
            // 
            // timerReceive
            // 
            this.timerReceive.Tick += new System.EventHandler(this.timerReceive_Tick);
            // 
            // btSend
            // 
            this.btSend.Image = global::ChatClient.Properties.Resources.snowman1;
            this.btSend.Location = new System.Drawing.Point(647, 501);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(128, 89);
            this.btSend.TabIndex = 3;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // grpConnect
            // 
            this.grpConnect.BackgroundImage = global::ChatClient.Properties.Resources.background;
            this.grpConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpConnect.Controls.Add(this.txtName);
            this.grpConnect.Controls.Add(this.lnlName);
            this.grpConnect.Controls.Add(this.btConnect);
            this.grpConnect.Controls.Add(this.lblPort);
            this.grpConnect.Controls.Add(this.lblIpAddr);
            this.grpConnect.Controls.Add(this.txtPort);
            this.grpConnect.Controls.Add(this.txtIpAddress);
            this.grpConnect.Location = new System.Drawing.Point(12, 13);
            this.grpConnect.Name = "grpConnect";
            this.grpConnect.Size = new System.Drawing.Size(763, 106);
            this.grpConnect.TabIndex = 0;
            this.grpConnect.TabStop = false;
            this.grpConnect.Text = "Control";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(300, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 7;
            // 
            // lnlName
            // 
            this.lnlName.AutoSize = true;
            this.lnlName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lnlName.Location = new System.Drawing.Point(255, 21);
            this.lnlName.Name = "lnlName";
            this.lnlName.Size = new System.Drawing.Size(39, 16);
            this.lnlName.TabIndex = 6;
            this.lnlName.Text = "이름";
            // 
            // btConnect
            // 
            this.btConnect.Image = global::ChatClient.Properties.Resources.connect;
            this.btConnect.Location = new System.Drawing.Point(558, 12);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(185, 88);
            this.btConnect.TabIndex = 4;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPort.Location = new System.Drawing.Point(6, 58);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(47, 16);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port :";
            // 
            // lblIpAddr
            // 
            this.lblIpAddr.AutoSize = true;
            this.lblIpAddr.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIpAddr.Location = new System.Drawing.Point(6, 21);
            this.lblIpAddr.Name = "lblIpAddr";
            this.lblIpAddr.Size = new System.Drawing.Size(95, 16);
            this.lblIpAddr.TabIndex = 2;
            this.lblIpAddr.Text = "IP Address :";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(107, 58);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(120, 21);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "10050";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(107, 21);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(120, 21);
            this.txtIpAddress.TabIndex = 0;
            this.txtIpAddress.Text = "220.67.174.71";
            // 
            // CFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.grpConnect);
            this.Name = "CFormMain";
            this.Text = "chat client";
            this.grpConnect.ResumeLayout(false);
            this.grpConnect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnect;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIpAddr;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Timer timerReceive;
        private System.Windows.Forms.Label lnlName;
        private System.Windows.Forms.TextBox txtName;
    }
}

