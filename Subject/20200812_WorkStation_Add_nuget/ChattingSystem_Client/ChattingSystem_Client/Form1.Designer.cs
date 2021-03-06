﻿namespace ChattingSystem_Client
{
    partial class Client_Form
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
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxChannel = new System.Windows.Forms.ComboBox();
            this.tbxLocalIpAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLocalIPAddress = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbxReceivedData = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxSendData = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(1760, 31);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(188, 61);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(1548, 31);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(188, 61);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(850, 43);
            this.tbxPort.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(196, 39);
            this.tbxPort.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxChannel);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.tbxPort);
            this.groupBox1.Controls.Add(this.tbxLocalIpAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblLocalIPAddress);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(2012, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1098, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Channel : ";
            // 
            // cbxChannel
            // 
            this.cbxChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChannel.FormattingEnabled = true;
            this.cbxChannel.Location = new System.Drawing.Point(1250, 43);
            this.cbxChannel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbxChannel.Name = "cbxChannel";
            this.cbxChannel.Size = new System.Drawing.Size(238, 35);
            this.cbxChannel.TabIndex = 6;
            // 
            // tbxLocalIpAddress
            // 
            this.tbxLocalIpAddress.Location = new System.Drawing.Point(292, 43);
            this.tbxLocalIpAddress.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbxLocalIpAddress.Name = "tbxLocalIpAddress";
            this.tbxLocalIpAddress.Size = new System.Drawing.Size(378, 39);
            this.tbxLocalIpAddress.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port : ";
            // 
            // lblLocalIPAddress
            // 
            this.lblLocalIPAddress.AutoSize = true;
            this.lblLocalIPAddress.Location = new System.Drawing.Point(12, 49);
            this.lblLocalIPAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLocalIPAddress.Name = "lblLocalIPAddress";
            this.lblLocalIPAddress.Size = new System.Drawing.Size(249, 27);
            this.lblLocalIPAddress.TabIndex = 0;
            this.lblLocalIPAddress.Text = "Local IP Address : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbxReceivedData);
            this.groupBox2.Location = new System.Drawing.Point(24, 153);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Size = new System.Drawing.Size(2012, 416);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Received data";
            // 
            // rtbxReceivedData
            // 
            this.rtbxReceivedData.Location = new System.Drawing.Point(18, 43);
            this.rtbxReceivedData.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rtbxReceivedData.Name = "rtbxReceivedData";
            this.rtbxReceivedData.ReadOnly = true;
            this.rtbxReceivedData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbxReceivedData.Size = new System.Drawing.Size(1960, 369);
            this.rtbxReceivedData.TabIndex = 0;
            this.rtbxReceivedData.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxSendData);
            this.groupBox3.Location = new System.Drawing.Point(24, 569);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox3.Size = new System.Drawing.Size(2000, 416);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send data";
            // 
            // tbxSendData
            // 
            this.tbxSendData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSendData.Location = new System.Drawing.Point(18, 43);
            this.tbxSendData.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbxSendData.Multiline = true;
            this.tbxSendData.Name = "tbxSendData";
            this.tbxSendData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxSendData.Size = new System.Drawing.Size(1960, 359);
            this.tbxSendData.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSend.Location = new System.Drawing.Point(24, 1003);
            this.btnSend.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(2000, 61);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Client_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2044, 1085);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Client_Form";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnDisconnect;
        public System.Windows.Forms.Button btnConnect;
        public System.Windows.Forms.TextBox tbxPort;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox tbxLocalIpAddress;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblLocalIPAddress;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox tbxSendData;
        public System.Windows.Forms.Button btnSend;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxChannel;
        private System.Windows.Forms.RichTextBox rtbxReceivedData;
    }
}

