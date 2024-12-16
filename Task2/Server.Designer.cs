namespace Task2
{
    partial class Server
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
            serverbtn = new Button();
            Porttxt = new TextBox();
            Portlb = new Label();
            Startbtn = new Button();
            Sendbtn = new Button();
            txtLog = new TextBox();
            msgtxt = new TextBox();
            label1 = new Label();
            Newbtn = new Button();
            lblStatus = new Label();
            clientListcbox = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // serverbtn
            // 
            serverbtn.Location = new Point(71, 12);
            serverbtn.Name = "serverbtn";
            serverbtn.Size = new Size(613, 85);
            serverbtn.TabIndex = 0;
            serverbtn.Text = "Server";
            serverbtn.UseVisualStyleBackColor = true;
            // 
            // Porttxt
            // 
            Porttxt.Location = new Point(187, 140);
            Porttxt.Name = "Porttxt";
            Porttxt.Size = new Size(125, 27);
            Porttxt.TabIndex = 1;
            // 
            // Portlb
            // 
            Portlb.AutoSize = true;
            Portlb.Location = new Point(71, 147);
            Portlb.Name = "Portlb";
            Portlb.Size = new Size(42, 20);
            Portlb.TabIndex = 2;
            Portlb.Text = "Port :";
            // 
            // Startbtn
            // 
            Startbtn.Location = new Point(420, 124);
            Startbtn.Name = "Startbtn";
            Startbtn.Size = new Size(215, 59);
            Startbtn.TabIndex = 3;
            Startbtn.Text = "Start Server";
            Startbtn.UseVisualStyleBackColor = true;
            Startbtn.Click += Startbtn_Click;
            // 
            // Sendbtn
            // 
            Sendbtn.Location = new Point(555, 413);
            Sendbtn.Name = "Sendbtn";
            Sendbtn.Size = new Size(94, 29);
            Sendbtn.TabIndex = 4;
            Sendbtn.Text = "Send";
            Sendbtn.UseVisualStyleBackColor = true;
            Sendbtn.Click += Sendbtn_Click;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(71, 229);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(613, 159);
            txtLog.TabIndex = 5;
            // 
            // msgtxt
            // 
            msgtxt.Location = new Point(168, 420);
            msgtxt.Name = "msgtxt";
            msgtxt.Size = new Size(125, 27);
            msgtxt.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 422);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 7;
            label1.Text = "Message :";
            // 
            // Newbtn
            // 
            Newbtn.Location = new Point(555, 462);
            Newbtn.Name = "Newbtn";
            Newbtn.Size = new Size(94, 29);
            Newbtn.TabIndex = 8;
            Newbtn.Text = "New";
            Newbtn.UseVisualStyleBackColor = true;
            Newbtn.Click += Newbtn_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(3, 483);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(99, 20);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Disconnected";
            // 
            // clientListcbox
            // 
            clientListcbox.FormattingEnabled = true;
            clientListcbox.Location = new Point(381, 419);
            clientListcbox.Name = "clientListcbox";
            clientListcbox.Size = new Size(151, 28);
            clientListcbox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 422);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 13;
            label2.Text = "User :";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 503);
            Controls.Add(label2);
            Controls.Add(clientListcbox);
            Controls.Add(lblStatus);
            Controls.Add(Newbtn);
            Controls.Add(label1);
            Controls.Add(msgtxt);
            Controls.Add(txtLog);
            Controls.Add(Sendbtn);
            Controls.Add(Startbtn);
            Controls.Add(Portlb);
            Controls.Add(Porttxt);
            Controls.Add(serverbtn);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button serverbtn;
        private TextBox Porttxt;
        private Label Portlb;
        private Button Startbtn;
        private Button Sendbtn;
        private TextBox txtLog;
        private TextBox msgtxt;
        private Label label1;
        private Button Newbtn;
        private Label lblStatus;
        private ComboBox clientListcbox;
        private Label label2;
    }
}