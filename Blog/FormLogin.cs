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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string un = txbUN.Text;
            string pw = txbPW.Text;

            bool check = false;
            foreach (Class.User user in Class.ListUser.Instance.List)
            {
                if (user.UserName == un)
                {
                    if (user.Password == pw)
                    {
                        Class.CurrUser.ins = user;
                        Class.CurrUser.isLogin = true;
                        check = true;
                        break;
                    }
                }
            }
            if(!check)
            {
                MessageBox.Show("Wrong user name or password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           // MessageBox.Show("ok", "ok");
            FormDisplayPost frm = new FormDisplayPost();
            this.Hide();
            frm.Show();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister reg = new FormRegister();
            reg.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormForgotPassword frm = new FormForgotPassword();
            frm.Show();
            this.Hide();
        }
    }
}
