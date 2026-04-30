namespace Timer
{
    partial class Timer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            lblScreen = new Label();
            CountdownTimer = new System.Windows.Forms.Timer(components);
            Start = new Button();
            SuspendLayout();
            // 
            // lblScreen
            // 
            resources.ApplyResources(lblScreen, "lblScreen");
            lblScreen.BackColor = SystemColors.Control;
            lblScreen.Name = "lblScreen";
            lblScreen.Click += label1_Click;
            // 
            // CountdownTimer
            // 
            CountdownTimer.Interval = 1000;
            CountdownTimer.Tick += CountdownTimer_Tick;
            // 
            // Start
            // 
            resources.ApplyResources(Start, "Start");
            Start.BackColor = SystemColors.ButtonHighlight;
            Start.ForeColor = Color.Coral;
            Start.Name = "Start";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click_1;
            // 
            // Timer
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Start);
            Controls.Add(lblScreen);
            Name = "Timer";
            ResumeLayout(false);
        }

        #endregion

        private Label lblScreen;
        private System.Windows.Forms.Timer CountdownTimer;
        private Button Start;
    }
}
