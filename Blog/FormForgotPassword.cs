using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blog
{
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text == "")
            {
                MessageBox.Show("Please enter email", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool check = false;
            foreach (Class.User user in Class.ListUser.Instance.List)
            {
                if(user.Email ==txbEmail.Text)
                {
                    check = true;
                    user.Password = randomPassword().ToString();
                    Class.SendMail.send(txbEmail.Text, "Reset password", "your new password is: " + user.Password);
                    break;
                }
            }
            if(!check)
            {
                MessageBox.Show("Email not true", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
   
        private int randomPassword()
        {
            Random rd = new Random();
            return rd.Next(1000001, 9999999);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }
    }
}






