using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BRAINBLOBBER_FINAL.Forms;

namespace BRAINBLOBBER_FINAL
{
    public partial class MainForm : Form
    {
        public static Panel MainPanel;
        public MainForm()
        {
            InitializeComponent();
            MainPanel = panel1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Attach the start display to main form like a frame, so it doesn't open
            //a new window...
            Start start = new Start();
            start.Dock = DockStyle.Fill;
            start.TopLevel = false;

            panel1.Controls.Clear();
            panel1.Controls.Add(start);
            start.Show();
            

        }
    }
}
