using demo19.Models;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace demo19
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public static User User { get; set; }
        public static login Instanse;

        private void button1_Click(object sender, EventArgs e)
        {
            using (Demo19dbContext db = new Demo19dbContext())
            {
                User user = db.Users.FirstOrDefault(p => p.Login == textBox1.Text);
                if (user != null)
                {
                    if (user.Password == textBox2.Text)
                    {
                        User = user;
                        Form1 form = new Form1();
                        form.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}