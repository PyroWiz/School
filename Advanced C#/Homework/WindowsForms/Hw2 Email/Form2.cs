using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using MailKit.Net.Smtp;

namespace Hw2_Email
{
    public partial class Form2 : Form
    {
        string Subject, Body, From, To;



        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string Subject, string Body)
        {
            InitializeComponent();
            SetSubject(Subject);
            SetBody(Body);

            label1.Text = $"[ Preview: ]\n\n{Subject}\n\n{Body}";
        }

        #region setget

        public void SetSubject(string Subject)
        {
            this.Subject = Subject;
        }
        public void SetBody(string Body)
        {
            this.Body = Body;
        }
        public void SetFrom(string From)
        {
            this.From = From;
        }
        public void SetTo(string To)
        {
            this.To = To;
        }

        public string GetSubject()
        {
            return Subject;
        }
        public string GetBody()
        {
            return Body;
        }



        public string GetFrom()
        {
            return From;
        }
        public string GetTo()
        {
            return To;
        }

        #endregion
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (!Tools.EmailFormatCheck(FromBox.Text, ToBox.Text))
            {
                MessageBox.Show("wrong email format");
                return;
            }
            SetFrom(FromBox.Text);
            SetTo(ToBox.Text);
            for (int i = 0; i < 10; i++) //DDOsing or
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress(GetFrom(), GetFrom()));
                message.To.Add(new MailboxAddress(GetTo(), GetTo()));
                message.Subject = GetSubject();
                message.Body = new TextPart("plain")
                {
                    Text = GetBody()
                };

                using (SmtpClient client = new SmtpClient())
                {
                    // Connect to Gmail (587 is for STARTTLS)
                    client.Connect("smtp.gmail.com", 587, false);

                    // Authenticate using the App Password mentioned in your image
                    client.Authenticate(GetFrom(), "vmgx jsuj gnbm nzbo");

                    client.Send(message);
                    client.Disconnect(true);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
