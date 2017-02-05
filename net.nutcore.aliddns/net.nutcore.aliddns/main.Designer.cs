namespace net.nutcore.aliddns
{
    partial class mainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.localIP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.domainIP = new System.Windows.Forms.Label();
            this.timeSetGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nextUpdateSeconds = new System.Windows.Forms.Label();
            this.updateNow = new System.Windows.Forms.Button();
            this.autoUpdateOff = new System.Windows.Forms.RadioButton();
            this.autoUpdateOn = new System.Windows.Forms.RadioButton();
            this.debugMessage = new System.Windows.Forms.GroupBox();
            this.recordId = new System.Windows.Forms.TextBox();
            this.globalValue = new System.Windows.Forms.Label();
            this.globalDomainType = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.globalRR = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.globalSetGroup = new System.Windows.Forms.GroupBox();
            this.checkAndSaveConfig = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.newSeconds = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fullDomainName = new System.Windows.Forms.TextBox();
            this.accessKeySecret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.accessKeyId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.authorInformation = new System.Windows.Forms.GroupBox();
            this.personalWebsite = new System.Windows.Forms.LinkLabel();
            this.helpPage = new System.Windows.Forms.Button();
            this.autoUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.networkStatus = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.timeSetGroup.SuspendLayout();
            this.debugMessage.SuspendLayout();
            this.globalSetGroup.SuspendLayout();
            this.authorInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "本机IP:";
            // 
            // localIP
            // 
            this.localIP.AutoSize = true;
            this.localIP.Location = new System.Drawing.Point(67, 13);
            this.localIP.Name = "localIP";
            this.localIP.Size = new System.Drawing.Size(47, 12);
            this.localIP.TabIndex = 1;
            this.localIP.Text = "0.0.0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "域名IP:";
            // 
            // domainIP
            // 
            this.domainIP.AutoSize = true;
            this.domainIP.Location = new System.Drawing.Point(67, 29);
            this.domainIP.Name = "domainIP";
            this.domainIP.Size = new System.Drawing.Size(47, 12);
            this.domainIP.TabIndex = 3;
            this.domainIP.Text = "0.0.0.0";
            // 
            // timeSetGroup
            // 
            this.timeSetGroup.Controls.Add(this.label3);
            this.timeSetGroup.Controls.Add(this.nextUpdateSeconds);
            this.timeSetGroup.Controls.Add(this.updateNow);
            this.timeSetGroup.Controls.Add(this.autoUpdateOff);
            this.timeSetGroup.Controls.Add(this.autoUpdateOn);
            this.timeSetGroup.Location = new System.Drawing.Point(15, 44);
            this.timeSetGroup.Name = "timeSetGroup";
            this.timeSetGroup.Size = new System.Drawing.Size(168, 88);
            this.timeSetGroup.TabIndex = 4;
            this.timeSetGroup.TabStop = false;
            this.timeSetGroup.Text = "定时更新";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "秒后更新记录";
            // 
            // nextUpdateSeconds
            // 
            this.nextUpdateSeconds.AutoSize = true;
            this.nextUpdateSeconds.Location = new System.Drawing.Point(37, 40);
            this.nextUpdateSeconds.Name = "nextUpdateSeconds";
            this.nextUpdateSeconds.Size = new System.Drawing.Size(17, 12);
            this.nextUpdateSeconds.TabIndex = 3;
            this.nextUpdateSeconds.Text = "60";
            // 
            // updateNow
            // 
            this.updateNow.Location = new System.Drawing.Point(6, 55);
            this.updateNow.Name = "updateNow";
            this.updateNow.Size = new System.Drawing.Size(156, 23);
            this.updateNow.TabIndex = 2;
            this.updateNow.Text = "立即更新";
            this.updateNow.UseVisualStyleBackColor = true;
            this.updateNow.Click += new System.EventHandler(this.updateNow_Click);
            // 
            // autoUpdateOff
            // 
            this.autoUpdateOff.AutoSize = true;
            this.autoUpdateOff.Location = new System.Drawing.Point(115, 20);
            this.autoUpdateOff.Name = "autoUpdateOff";
            this.autoUpdateOff.Size = new System.Drawing.Size(47, 16);
            this.autoUpdateOff.TabIndex = 1;
            this.autoUpdateOff.Text = "关闭";
            this.autoUpdateOff.UseVisualStyleBackColor = true;
            // 
            // autoUpdateOn
            // 
            this.autoUpdateOn.AutoSize = true;
            this.autoUpdateOn.Checked = true;
            this.autoUpdateOn.Location = new System.Drawing.Point(7, 21);
            this.autoUpdateOn.Name = "autoUpdateOn";
            this.autoUpdateOn.Size = new System.Drawing.Size(47, 16);
            this.autoUpdateOn.TabIndex = 0;
            this.autoUpdateOn.TabStop = true;
            this.autoUpdateOn.Text = "开启";
            this.autoUpdateOn.UseVisualStyleBackColor = true;
            // 
            // debugMessage
            // 
            this.debugMessage.Controls.Add(this.label13);
            this.debugMessage.Controls.Add(this.networkStatus);
            this.debugMessage.Controls.Add(this.recordId);
            this.debugMessage.Controls.Add(this.globalValue);
            this.debugMessage.Controls.Add(this.globalDomainType);
            this.debugMessage.Controls.Add(this.label12);
            this.debugMessage.Controls.Add(this.label11);
            this.debugMessage.Controls.Add(this.globalRR);
            this.debugMessage.Controls.Add(this.label10);
            this.debugMessage.Controls.Add(this.label9);
            this.debugMessage.Location = new System.Drawing.Point(15, 138);
            this.debugMessage.Name = "debugMessage";
            this.debugMessage.Size = new System.Drawing.Size(168, 111);
            this.debugMessage.TabIndex = 5;
            this.debugMessage.TabStop = false;
            this.debugMessage.Text = "调试信息";
            // 
            // recordId
            // 
            this.recordId.Location = new System.Drawing.Point(68, 18);
            this.recordId.Name = "recordId";
            this.recordId.Size = new System.Drawing.Size(94, 21);
            this.recordId.TabIndex = 8;
            this.recordId.Text = "<null>";
            // 
            // globalValue
            // 
            this.globalValue.AutoSize = true;
            this.globalValue.Location = new System.Drawing.Point(7, 78);
            this.globalValue.Name = "globalValue";
            this.globalValue.Size = new System.Drawing.Size(41, 12);
            this.globalValue.TabIndex = 7;
            this.globalValue.Text = "<null>";
            // 
            // globalDomainType
            // 
            this.globalDomainType.AutoSize = true;
            this.globalDomainType.Location = new System.Drawing.Point(66, 54);
            this.globalDomainType.Name = "globalDomainType";
            this.globalDomainType.Size = new System.Drawing.Size(41, 12);
            this.globalDomainType.TabIndex = 6;
            this.globalDomainType.Text = "<null>";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 5;
            this.label12.Text = "Value";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "Type";
            // 
            // globalRR
            // 
            this.globalRR.AutoSize = true;
            this.globalRR.Location = new System.Drawing.Point(66, 42);
            this.globalRR.Name = "globalRR";
            this.globalRR.Size = new System.Drawing.Size(41, 12);
            this.globalRR.TabIndex = 3;
            this.globalRR.Text = "<null>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "RR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "RecordId";
            // 
            // globalSetGroup
            // 
            this.globalSetGroup.Controls.Add(this.checkAndSaveConfig);
            this.globalSetGroup.Controls.Add(this.label8);
            this.globalSetGroup.Controls.Add(this.newSeconds);
            this.globalSetGroup.Controls.Add(this.label7);
            this.globalSetGroup.Controls.Add(this.label6);
            this.globalSetGroup.Controls.Add(this.fullDomainName);
            this.globalSetGroup.Controls.Add(this.accessKeySecret);
            this.globalSetGroup.Controls.Add(this.label5);
            this.globalSetGroup.Controls.Add(this.accessKeyId);
            this.globalSetGroup.Controls.Add(this.label4);
            this.globalSetGroup.Location = new System.Drawing.Point(189, 12);
            this.globalSetGroup.Name = "globalSetGroup";
            this.globalSetGroup.Size = new System.Drawing.Size(225, 181);
            this.globalSetGroup.TabIndex = 6;
            this.globalSetGroup.TabStop = false;
            this.globalSetGroup.Text = "设置";
            // 
            // checkAndSaveConfig
            // 
            this.checkAndSaveConfig.Location = new System.Drawing.Point(8, 152);
            this.checkAndSaveConfig.Name = "checkAndSaveConfig";
            this.checkAndSaveConfig.Size = new System.Drawing.Size(209, 23);
            this.checkAndSaveConfig.TabIndex = 10;
            this.checkAndSaveConfig.Text = "验证并保存";
            this.checkAndSaveConfig.UseVisualStyleBackColor = true;
            this.checkAndSaveConfig.Click += new System.EventHandler(this.checkConfig_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "秒更新一次";
            // 
            // newSeconds
            // 
            this.newSeconds.Location = new System.Drawing.Point(41, 125);
            this.newSeconds.Name = "newSeconds";
            this.newSeconds.Size = new System.Drawing.Size(60, 21);
            this.newSeconds.TabIndex = 7;
            this.newSeconds.Text = "60";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "每隔";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "完整域名";
            // 
            // fullDomainName
            // 
            this.fullDomainName.Location = new System.Drawing.Point(65, 98);
            this.fullDomainName.Name = "fullDomainName";
            this.fullDomainName.Size = new System.Drawing.Size(152, 21);
            this.fullDomainName.TabIndex = 4;
            this.fullDomainName.Text = "www.xxx.com";
            // 
            // accessKeySecret
            // 
            this.accessKeySecret.Location = new System.Drawing.Point(8, 71);
            this.accessKeySecret.Name = "accessKeySecret";
            this.accessKeySecret.Size = new System.Drawing.Size(209, 21);
            this.accessKeySecret.TabIndex = 3;
            this.accessKeySecret.Text = "null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "accessKeySecret";
            // 
            // accessKeyId
            // 
            this.accessKeyId.Location = new System.Drawing.Point(8, 32);
            this.accessKeyId.Name = "accessKeyId";
            this.accessKeyId.Size = new System.Drawing.Size(211, 21);
            this.accessKeyId.TabIndex = 1;
            this.accessKeyId.Text = "null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "accessKeyId";
            // 
            // authorInformation
            // 
            this.authorInformation.Controls.Add(this.personalWebsite);
            this.authorInformation.Controls.Add(this.helpPage);
            this.authorInformation.Location = new System.Drawing.Point(190, 199);
            this.authorInformation.Name = "authorInformation";
            this.authorInformation.Size = new System.Drawing.Size(224, 50);
            this.authorInformation.TabIndex = 7;
            this.authorInformation.TabStop = false;
            this.authorInformation.Text = "作者信息";
            // 
            // personalWebsite
            // 
            this.personalWebsite.AutoSize = true;
            this.personalWebsite.Location = new System.Drawing.Point(106, 25);
            this.personalWebsite.Name = "personalWebsite";
            this.personalWebsite.Size = new System.Drawing.Size(95, 12);
            this.personalWebsite.TabIndex = 1;
            this.personalWebsite.TabStop = true;
            this.personalWebsite.Text = "www.nutcore.net";
            this.personalWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.personalWebsite_LinkClicked);
            // 
            // helpPage
            // 
            this.helpPage.Location = new System.Drawing.Point(7, 20);
            this.helpPage.Name = "helpPage";
            this.helpPage.Size = new System.Drawing.Size(93, 23);
            this.helpPage.TabIndex = 0;
            this.helpPage.Text = "发布页面";
            this.helpPage.UseVisualStyleBackColor = true;
            this.helpPage.Click += new System.EventHandler(this.helpPage_Click);
            // 
            // autoUpdateTimer
            // 
            this.autoUpdateTimer.Enabled = true;
            this.autoUpdateTimer.Interval = 1000;
            this.autoUpdateTimer.Tick += new System.EventHandler(this.autoUpdateTimer_Tick);
            // 
            // networkStatus
            // 
            this.networkStatus.AutoSize = true;
            this.networkStatus.Location = new System.Drawing.Point(68, 77);
            this.networkStatus.Name = "networkStatus";
            this.networkStatus.Size = new System.Drawing.Size(41, 12);
            this.networkStatus.TabIndex = 9;
            this.networkStatus.Text = "已连接";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(7, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "出错请手动修改config.xml!";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 261);
            this.Controls.Add(this.authorInformation);
            this.Controls.Add(this.globalSetGroup);
            this.Controls.Add(this.debugMessage);
            this.Controls.Add(this.timeSetGroup);
            this.Controls.Add(this.domainIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.localIP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Aliddns - By DTSDAO";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.timeSetGroup.ResumeLayout(false);
            this.timeSetGroup.PerformLayout();
            this.debugMessage.ResumeLayout(false);
            this.debugMessage.PerformLayout();
            this.globalSetGroup.ResumeLayout(false);
            this.globalSetGroup.PerformLayout();
            this.authorInformation.ResumeLayout(false);
            this.authorInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label localIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label domainIP;
        private System.Windows.Forms.GroupBox timeSetGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nextUpdateSeconds;
        private System.Windows.Forms.Button updateNow;
        private System.Windows.Forms.RadioButton autoUpdateOff;
        private System.Windows.Forms.RadioButton autoUpdateOn;
        private System.Windows.Forms.GroupBox debugMessage;
        private System.Windows.Forms.GroupBox globalSetGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox newSeconds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fullDomainName;
        private System.Windows.Forms.TextBox accessKeySecret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox accessKeyId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox authorInformation;
        private System.Windows.Forms.LinkLabel personalWebsite;
        private System.Windows.Forms.Button helpPage;
        private System.Windows.Forms.Timer autoUpdateTimer;
        private System.Windows.Forms.Button checkAndSaveConfig;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label globalRR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label globalDomainType;
        private System.Windows.Forms.Label globalValue;
        private System.Windows.Forms.TextBox recordId;
        private System.Windows.Forms.Label networkStatus;
        private System.Windows.Forms.Label label13;
    }
}

