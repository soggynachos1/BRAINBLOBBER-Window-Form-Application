namespace BRAINBLOBBER_FINAL.Forms
{
    partial class Choose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 37);
            label1.TabIndex = 0;
            label1.Text = "Choose";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1732, 1256);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 255);
            label2.Font = new Font("Times New Roman", 22F, FontStyle.Bold);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(569, 193);
            label2.Name = "label2";
            label2.Size = new Size(566, 74);
            label2.TabIndex = 2;
            label2.Text = "Choose a Category";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(64, 0, 64);
            button1.Location = new Point(177, 467);
            button1.Name = "button1";
            button1.Size = new Size(331, 101);
            button1.TabIndex = 3;
            button1.Text = "Video Games";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 224, 192);
            button2.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(64, 0, 64);
            button2.Location = new Point(655, 467);
            button2.Name = "button2";
            button2.Size = new Size(331, 101);
            button2.TabIndex = 4;
            button2.Text = "Pop Culture";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 224, 192);
            button3.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(64, 0, 64);
            button3.Location = new Point(1150, 467);
            button3.Name = "button3";
            button3.Size = new Size(331, 101);
            button3.TabIndex = 5;
            button3.Text = "Music";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 224, 192);
            button4.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(64, 0, 64);
            button4.Location = new Point(395, 703);
            button4.Name = "button4";
            button4.Size = new Size(331, 101);
            button4.TabIndex = 6;
            button4.Text = "Movies";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 224, 192);
            button5.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(64, 0, 64);
            button5.Location = new Point(970, 703);
            button5.Name = "button5";
            button5.Size = new Size(331, 101);
            button5.TabIndex = 7;
            button5.Text = "TV Shows";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 128, 255);
            button6.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.MistyRose;
            button6.Location = new Point(63, 79);
            button6.Name = "button6";
            button6.Size = new Size(245, 81);
            button6.TabIndex = 8;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Choose
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1732, 1256);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Choose";
            Text = "Choose";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}