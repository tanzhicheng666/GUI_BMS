
namespace CsharpPractise
{
    partial class BmsGui
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
            this.btnSerialPortOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbLog = new System.Windows.Forms.CheckBox();
            this.ckbPolling = new System.Windows.Forms.CheckBox();
            this.cbbPortName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbDebugWindow = new System.Windows.Forms.RichTextBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSerialPortOpen
            // 
            this.btnSerialPortOpen.Location = new System.Drawing.Point(116, 109);
            this.btnSerialPortOpen.Name = "btnSerialPortOpen";
            this.btnSerialPortOpen.Size = new System.Drawing.Size(75, 23);
            this.btnSerialPortOpen.TabIndex = 0;
            this.btnSerialPortOpen.Text = "OPEN";
            this.btnSerialPortOpen.UseVisualStyleBackColor = true;
            this.btnSerialPortOpen.Click += new System.EventHandler(this.btnSerialPortOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbLog);
            this.groupBox1.Controls.Add(this.ckbPolling);
            this.groupBox1.Controls.Add(this.cbbPortName);
            this.groupBox1.Controls.Add(this.btnSerialPortOpen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbBaudRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uart Configure";
            // 
            // ckbLog
            // 
            this.ckbLog.AutoSize = true;
            this.ckbLog.Location = new System.Drawing.Point(11, 115);
            this.ckbLog.Name = "ckbLog";
            this.ckbLog.Size = new System.Drawing.Size(44, 17);
            this.ckbLog.TabIndex = 5;
            this.ckbLog.Text = "Log";
            this.ckbLog.UseVisualStyleBackColor = true;
            // 
            // ckbPolling
            // 
            this.ckbPolling.AutoSize = true;
            this.ckbPolling.Location = new System.Drawing.Point(11, 91);
            this.ckbPolling.Name = "ckbPolling";
            this.ckbPolling.Size = new System.Drawing.Size(57, 17);
            this.ckbPolling.TabIndex = 4;
            this.ckbPolling.Text = "Polling";
            this.ckbPolling.UseVisualStyleBackColor = true;
            // 
            // cbbPortName
            // 
            this.cbbPortName.FormattingEnabled = true;
            this.cbbPortName.Location = new System.Drawing.Point(70, 17);
            this.cbbPortName.Name = "cbbPortName";
            this.cbbPortName.Size = new System.Drawing.Size(121, 21);
            this.cbbPortName.TabIndex = 3;
            this.cbbPortName.DropDown += new System.EventHandler(this.SerialPortRefresh);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PortName:";
            // 
            // cbbBaudRate
            // 
            this.cbbBaudRate.FormattingEnabled = true;
            this.cbbBaudRate.Location = new System.Drawing.Point(70, 53);
            this.cbbBaudRate.Name = "cbbBaudRate";
            this.cbbBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cbbBaudRate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BaudRate:";
            // 
            // rtbDebugWindow
            // 
            this.rtbDebugWindow.Location = new System.Drawing.Point(244, 254);
            this.rtbDebugWindow.Name = "rtbDebugWindow";
            this.rtbDebugWindow.Size = new System.Drawing.Size(654, 96);
            this.rtbDebugWindow.TabIndex = 2;
            this.rtbDebugWindow.Text = "";
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(528, 225);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(75, 23);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "Send";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.SerialPortSendData);
            // 
            // BmsGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 566);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.rtbDebugWindow);
            this.Controls.Add(this.groupBox1);
            this.Name = "BmsGui";
            this.Text = "BmsGui";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSerialPortOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbPortName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox ckbPolling;
        private System.Windows.Forms.CheckBox ckbLog;
        private System.Windows.Forms.RichTextBox rtbDebugWindow;
        private System.Windows.Forms.Button btnSendData;
    }
}

