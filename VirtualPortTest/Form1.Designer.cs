namespace VirtualPortTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStatusCaption = new Label();
            lblStatus = new Label();
            lblCom4Caption = new Label();
            tboxCom4 = new TextBox();
            tboxCom5 = new TextBox();
            lblCom5Caption = new Label();
            btnOpenConnection = new Button();
            tboxCom4Send = new TextBox();
            tboxCom5Send = new TextBox();
            SuspendLayout();
            // 
            // lblStatusCaption
            // 
            lblStatusCaption.AutoSize = true;
            lblStatusCaption.Location = new Point(12, 9);
            lblStatusCaption.Name = "lblStatusCaption";
            lblStatusCaption.Size = new Size(58, 15);
            lblStatusCaption.TabIndex = 0;
            lblStatusCaption.Text = "연결상태:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(76, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(59, 15);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "연결 안됨";
            // 
            // lblCom4Caption
            // 
            lblCom4Caption.AutoSize = true;
            lblCom4Caption.Location = new Point(12, 37);
            lblCom4Caption.Name = "lblCom4Caption";
            lblCom4Caption.Size = new Size(42, 15);
            lblCom4Caption.TabIndex = 2;
            lblCom4Caption.Text = "COM4";
            // 
            // tboxCom4
            // 
            tboxCom4.BackColor = Color.Black;
            tboxCom4.Enabled = false;
            tboxCom4.ForeColor = Color.White;
            tboxCom4.Location = new Point(12, 60);
            tboxCom4.Multiline = true;
            tboxCom4.Name = "tboxCom4";
            tboxCom4.ReadOnly = true;
            tboxCom4.Size = new Size(536, 242);
            tboxCom4.TabIndex = 4;
            // 
            // tboxCom5
            // 
            tboxCom5.BackColor = Color.Black;
            tboxCom5.Enabled = false;
            tboxCom5.ForeColor = Color.White;
            tboxCom5.Location = new Point(12, 342);
            tboxCom5.Multiline = true;
            tboxCom5.Name = "tboxCom5";
            tboxCom5.ReadOnly = true;
            tboxCom5.Size = new Size(536, 242);
            tboxCom5.TabIndex = 6;
            // 
            // lblCom5Caption
            // 
            lblCom5Caption.AutoSize = true;
            lblCom5Caption.Location = new Point(12, 319);
            lblCom5Caption.Name = "lblCom5Caption";
            lblCom5Caption.Size = new Size(42, 15);
            lblCom5Caption.TabIndex = 5;
            lblCom5Caption.Text = "COM5";
            // 
            // btnOpenConnection
            // 
            btnOpenConnection.Location = new Point(473, 5);
            btnOpenConnection.Name = "btnOpenConnection";
            btnOpenConnection.Size = new Size(75, 23);
            btnOpenConnection.TabIndex = 7;
            btnOpenConnection.Tag = "";
            btnOpenConnection.Text = "포트연결";
            btnOpenConnection.UseVisualStyleBackColor = true;
            btnOpenConnection.Click += btnOpenConnection_Clicked;
            // 
            // tboxCom4Send
            // 
            tboxCom4Send.Enabled = false;
            tboxCom4Send.Location = new Point(60, 34);
            tboxCom4Send.Name = "tboxCom4Send";
            tboxCom4Send.Size = new Size(488, 23);
            tboxCom4Send.TabIndex = 8;
            tboxCom4Send.KeyDown += tboxSendKeyDown;
            // 
            // tboxCom5Send
            // 
            tboxCom5Send.Enabled = false;
            tboxCom5Send.Location = new Point(60, 316);
            tboxCom5Send.Name = "tboxCom5Send";
            tboxCom5Send.Size = new Size(488, 23);
            tboxCom5Send.TabIndex = 9;
            tboxCom5Send.KeyDown += tboxSendKeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 596);
            Controls.Add(tboxCom5Send);
            Controls.Add(tboxCom4Send);
            Controls.Add(btnOpenConnection);
            Controls.Add(tboxCom5);
            Controls.Add(lblCom5Caption);
            Controls.Add(tboxCom4);
            Controls.Add(lblCom4Caption);
            Controls.Add(lblStatus);
            Controls.Add(lblStatusCaption);
            Name = "Form1";
            Text = "com0com Test";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatusCaption;
        private Label lblStatus;
        private Label lblCom4Caption;
        private TextBox tboxCom4;
        private TextBox tboxCom5;
        private Label lblCom5Caption;
        private Button btnOpenConnection;
        private TextBox tboxCom4Send;
        private TextBox tboxCom5Send;
    }
}
