using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BRAINBLOBBER_FINAL.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Dock = DockStyle.Fill;
            start.TopLevel = false;

            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(start);
            start.Show();

        }
    }
}
