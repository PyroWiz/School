using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Hw1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SimpleURL(object sender, EventArgs e)
        {

        }

        private void Title(object sender, EventArgs e)
        {

        }

        private void TextBox(object sender, EventArgs e)
        {
            // Intentionally left blank; event handler for textBox1.TextChanged
        }

        private void GoNow(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(url))
            {
                try
                {
                    Process.Start(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open URL: " + ex.Message);
                }
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit App?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
