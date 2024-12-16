namespace Task4
{
    partial class Publisher
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
            Publicher = new Button();
            label1 = new Label();
            Logtxt = new TextBox();
            Newbtn = new Button();
            Nametxt = new TextBox();
            Startbtn = new Button();
            Msgtxt = new TextBox();
            Msglbl = new Label();
            Notifybtn = new Button();
            SuspendLayout();
            // 
            // Publicher
            // 
            Publicher.Location = new Point(30, 4);
            Publicher.Name = "Publicher";
            Publicher.Size = new Size(584, 73);
            Publicher.TabIndex = 0;
            Publicher.Text = "Publicher";
            Publicher.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 96);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // Logtxt
            // 
            Logtxt.Location = new Point(30, 133);
            Logtxt.Multiline = true;
            Logtxt.Name = "Logtxt";
            Logtxt.Size = new Size(527, 191);
            Logtxt.TabIndex = 2;
            // 
            // Newbtn
            // 
            Newbtn.Location = new Point(339, 96);
            Newbtn.Name = "Newbtn";
            Newbtn.Size = new Size(94, 29);
            Newbtn.TabIndex = 3;
            Newbtn.Text = "New";
            Newbtn.UseVisualStyleBackColor = true;
            Newbtn.Click += Newbtn_Click;
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(85, 96);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(114, 27);
            Nametxt.TabIndex = 4;
            // 
            // Startbtn
            // 
            Startbtn.Location = new Point(216, 96);
            Startbtn.Name = "Startbtn";
            Startbtn.Size = new Size(94, 29);
            Startbtn.TabIndex = 5;
            Startbtn.Text = "Start";
            Startbtn.UseVisualStyleBackColor = true;
            Startbtn.Click += Startbtn_Click;
            // 
            // Msgtxt
            // 
            Msgtxt.Location = new Point(85, 378);
            Msgtxt.Name = "Msgtxt";
            Msgtxt.Size = new Size(254, 27);
            Msgtxt.TabIndex = 6;
            // 
            // Msglbl
            // 
            Msglbl.AutoSize = true;
            Msglbl.Location = new Point(30, 385);
            Msglbl.Name = "Msglbl";
            Msglbl.Size = new Size(44, 20);
            Msglbl.TabIndex = 7;
            Msglbl.Text = "Msg :";
            // 
            // Notifybtn
            // 
            Notifybtn.Location = new Point(393, 376);
            Notifybtn.Name = "Notifybtn";
            Notifybtn.Size = new Size(94, 29);
            Notifybtn.TabIndex = 8;
            Notifybtn.Text = "Notify";
            Notifybtn.UseVisualStyleBackColor = true;
            Notifybtn.Click += Notifybtn_Click;
            // 
            // Publisher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Notifybtn);
            Controls.Add(Msglbl);
            Controls.Add(Msgtxt);
            Controls.Add(Startbtn);
            Controls.Add(Nametxt);
            Controls.Add(Newbtn);
            Controls.Add(Logtxt);
            Controls.Add(label1);
            Controls.Add(Publicher);
            Name = "Publisher";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Publicher;
        private Label label1;
        private TextBox Logtxt;
        private Button Newbtn;
        private TextBox Nametxt;
        private Button Startbtn;
        private TextBox Msgtxt;
        private Label Msglbl;
        private Button Notifybtn;
    }
}
