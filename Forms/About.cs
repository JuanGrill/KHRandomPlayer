using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace KHRandomPlayer
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void lLink1_Click(object sender, EventArgs e)
        {
            Process.Start(lLink1.Text);
        }

        private void lLink2_Click(object sender, EventArgs e)
        {
            Process.Start(lLink2.Text);
        }

        private void lLink3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/JuanGrill/KHRandomPlayer");
        }
    }
}
