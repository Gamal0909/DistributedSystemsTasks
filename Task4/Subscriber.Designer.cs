namespace Task4
{
    partial class Subscriber
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
            button1 = new Button();
            Nametxt = new TextBox();
            Namelbl = new Label();
            Startbtn = new Button();
            Subscriberbtn = new Button();
            SLogtxt = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(96, 12);
            button1.Name = "button1";
            button1.Size = new Size(431, 72);
            button1.TabIndex = 0;
            button1.Text = "Subscriber";
            button1.UseVisualStyleBackColor = true;
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(158, 115);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(125, 27);
            Nametxt.TabIndex = 1;
            // 
            // Namelbl
            // 
            Namelbl.AutoSize = true;
            Namelbl.Location = new Point(96, 118);
            Namelbl.Name = "Namelbl";
            Namelbl.Size = new Size(56, 20);
            Namelbl.TabIndex = 2;
            Namelbl.Text = "Name :";
            // 
            // Startbtn
            // 
            Startbtn.Location = new Point(309, 113);
            Startbtn.Name = "Startbtn";
            Startbtn.Size = new Size(94, 29);
            Startbtn.TabIndex = 3;
            Startbtn.Text = "Start";
            Startbtn.UseVisualStyleBackColor = true;
            Startbtn.Click += Startbtn_Click;
            // 
            // Subscriberbtn
            // 
            Subscriberbtn.BackColor = Color.Red;
            Subscriberbtn.ForeColor = Color.Transparent;
            Subscriberbtn.Location = new Point(158, 323);
            Subscriberbtn.Name = "Subscriberbtn";
            Subscriberbtn.Size = new Size(125, 51);
            Subscriberbtn.TabIndex = 4;
            Subscriberbtn.Text = "Subscriber";
            Subscriberbtn.UseVisualStyleBackColor = false;
            Subscriberbtn.Click += Subscriberbtn_Click;
            // 
            // SLogtxt
            // 
            SLogtxt.Location = new Point(96, 172);
            SLogtxt.Multiline = true;
            SLogtxt.Name = "SLogtxt";
            SLogtxt.Size = new Size(364, 125);
            SLogtxt.TabIndex = 5;
            // 
            // Subscriber
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SLogtxt);
            Controls.Add(Subscriberbtn);
            Controls.Add(Startbtn);
            Controls.Add(Namelbl);
            Controls.Add(Nametxt);
            Controls.Add(button1);
            Name = "Subscriber";
            Text = "Subscriber";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Nametxt;
        private Label Namelbl;
        private Button Startbtn;
        private Button Subscriberbtn;
        private TextBox SLogtxt;
    }
}