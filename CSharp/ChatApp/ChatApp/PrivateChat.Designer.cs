namespace ChatApp
{
    partial class PrivateChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivateChat));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textLocalIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textRemotePort = new System.Windows.Forms.TextBox();
            this.textRemoteIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.listMessages = new System.Windows.Forms.ListBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.btnSwitchPorts = new System.Windows.Forms.Button();
            this.listViewMSG = new System.Windows.Forms.ListView();
            this.listViewColNAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewColMSG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewColTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.textLocalIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // textLocalPort
            // 
            resources.ApplyResources(this.textLocalPort, "textLocalPort");
            this.textLocalPort.Name = "textLocalPort";
            // 
            // textLocalIP
            // 
            resources.ApplyResources(this.textLocalIP, "textLocalIP");
            this.textLocalIP.Name = "textLocalIP";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textRemotePort);
            this.groupBox2.Controls.Add(this.textRemoteIP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // textRemotePort
            // 
            resources.ApplyResources(this.textRemotePort, "textRemotePort");
            this.textRemotePort.Name = "textRemotePort";
            // 
            // textRemoteIP
            // 
            resources.ApplyResources(this.textRemoteIP, "textRemoteIP");
            this.textRemoteIP.Name = "textRemoteIP";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // buttonConnect
            // 
            resources.ApplyResources(this.buttonConnect, "buttonConnect");
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textMessage
            // 
            resources.ApplyResources(this.textMessage, "textMessage");
            this.textMessage.Name = "textMessage";
            this.textMessage.TextChanged += new System.EventHandler(this.textMessage_TextChanged);
            // 
            // listMessages
            // 
            this.listMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.listMessages, "listMessages");
            this.listMessages.FormattingEnabled = true;
            this.listMessages.Name = "listMessages";
            this.listMessages.SelectionMode = System.Windows.Forms.SelectionMode.None;
            // 
            // buttonSend
            // 
            resources.ApplyResources(this.buttonSend, "buttonSend");
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // btnSwitchPorts
            // 
            resources.ApplyResources(this.btnSwitchPorts, "btnSwitchPorts");
            this.btnSwitchPorts.Name = "btnSwitchPorts";
            this.btnSwitchPorts.UseVisualStyleBackColor = true;
            this.btnSwitchPorts.Click += new System.EventHandler(this.btnSwitchPorts_Click);
            // 
            // listViewMSG
            // 
            this.listViewMSG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMSG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listViewColNAME,
            this.listViewColMSG,
            this.listViewColTime});
            resources.ApplyResources(this.listViewMSG, "listViewMSG");
            this.listViewMSG.Name = "listViewMSG";
            this.listViewMSG.UseCompatibleStateImageBehavior = false;
            this.listViewMSG.View = System.Windows.Forms.View.List;
            // 
            // listViewColNAME
            // 
            resources.ApplyResources(this.listViewColNAME, "listViewColNAME");
            // 
            // listViewColMSG
            // 
            resources.ApplyResources(this.listViewColMSG, "listViewColMSG");
            // 
            // listViewColTime
            // 
            resources.ApplyResources(this.listViewColTime, "listViewColTime");
            // 
            // PrivateChat
            // 
            this.AcceptButton = this.buttonSend;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.listViewMSG);
            this.Controls.Add(this.btnSwitchPorts);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.listMessages);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PrivateChat";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Tag = "";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textLocalIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textRemotePort;
        private System.Windows.Forms.TextBox textRemoteIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.ListBox listMessages;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button btnSwitchPorts;
        private System.Windows.Forms.ListView listViewMSG;
        private System.Windows.Forms.ColumnHeader listViewColMSG;
        private System.Windows.Forms.ColumnHeader listViewColTime;
        private System.Windows.Forms.ColumnHeader listViewColNAME;
    }
}

