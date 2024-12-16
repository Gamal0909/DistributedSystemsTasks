namespace Task2
{
    partial class Client
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
            Iptxt = new TextBox();
            button1 = new Button();
            Iplb = new Label();
            Connectbtn = new Button();
            Portlb = new Label();
            portnumtxt = new TextBox();
            logtxt = new TextBox();
            label1 = new Label();
            msgtxt = new TextBox();
            Sendbtn = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // Iptxt
            // 
            Iptxt.Location = new Point(125, 134);
            Iptxt.Name = "Iptxt";
            Iptxt.Size = new Size(128, 27);
            Iptxt.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(58, 12);
            button1.Name = "button1";
            button1.Size = new Size(646, 91);
            button1.TabIndex = 1;
            button1.Text = "Client";
            button1.UseVisualStyleBackColor = true;
            // 
            // Iplb
            // 
            Iplb.AutoSize = true;
            Iplb.Location = new Point(75, 134);
            Iplb.Name = "Iplb";
            Iplb.Size = new Size(28, 20);
            Iplb.TabIndex = 2;
            Iplb.Text = "IP :";
            // 
            // Connectbtn
            // 
            Connectbtn.Location = new Point(321, 134);
            Connectbtn.Name = "Connectbtn";
            Connectbtn.Size = new Size(195, 75);
            Connectbtn.TabIndex = 3;
            Connectbtn.Text = "Connect to Server";
            Connectbtn.UseVisualStyleBackColor = true;
            Connectbtn.Click += Connectbtn_Click;
            // 
            // Portlb
            // 
            Portlb.AutoSize = true;
            Portlb.Location = new Point(75, 182);
            Portlb.Name = "Portlb";
            Portlb.Size = new Size(42, 20);
            Portlb.TabIndex = 5;
            Portlb.Text = "Port :";
            // 
            // portnumtxt
            // 
            portnumtxt.Location = new Point(125, 182);
            portnumtxt.Name = "portnumtxt";
            portnumtxt.Size = new Size(128, 27);
            portnumtxt.TabIndex = 4;
            // 
            // logtxt
            // 
            logtxt.Location = new Point(58, 226);
            logtxt.Multiline = true;
            logtxt.Name = "logtxt";
            logtxt.Size = new Size(458, 162);
            logtxt.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 424);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 9;
            label1.Text = "Send To Server";
            // 
            // msgtxt
            // 
            msgtxt.Location = new Point(175, 426);
            msgtxt.Name = "msgtxt";
            msgtxt.Size = new Size(239, 27);
            msgtxt.TabIndex = 8;
            // 
            // Sendbtn
            // 
            Sendbtn.Location = new Point(438, 420);
            Sendbtn.Name = "Sendbtn";
            Sendbtn.Size = new Size(117, 38);
            Sendbtn.TabIndex = 7;
            Sendbtn.Text = "Send";
            Sendbtn.UseVisualStyleBackColor = true;
            Sendbtn.Click += Sendbtn_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(4, 458);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(99, 20);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Disconnected";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(lblStatus);
            Controls.Add(label1);
            Controls.Add(msgtxt);
            Controls.Add(Sendbtn);
            Controls.Add(logtxt);
            Controls.Add(Portlb);
            Controls.Add(portnumtxt);
            Controls.Add(Connectbtn);
            Controls.Add(Iplb);
            Controls.Add(button1);
            Controls.Add(Iptxt);
            Name = "Client";
            Text = "Client";
            Load += Client_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Iptxt;
        private Button button1;
        private Label Iplb;
        private Button Connectbtn;
        private Label Portlb;
        private TextBox portnumtxt;
        private TextBox logtxt;
        private Label label1;
        private TextBox msgtxt;
        private Button Sendbtn;
        private Label lblStatus;
    }
}
