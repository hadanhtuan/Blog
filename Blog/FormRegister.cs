using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

using Ganss.Excel;

namespace Blog
{
    public partial class FormRegister : Form
    {
        //variables
        public static Cloudinary cl;

        OpenFileDialog o;


        //end

        public FormRegister()
        {
            InitializeComponent();
            config();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                ptb1.BackgroundImage = Image.FromFile(o.FileName);
            }
        }

        private static void config()
        {
            Account account = new Account(Class.CDConfig.CLOUD_NAME, Class.CDConfig.API_KEY, Class.CDConfig.API_SECRET);
            cl = new Cloudinary(account);
        }

        public static string uploadImage(string imgpath)
        {
            try
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(imgpath)
                };

                var uploadResult = cl.Upload(uploadParams);
                MessageBox.Show("oke babe");
                return uploadResult.SecureUrl.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txbUN.Text == "")
            {
                MessageBox.Show("Please enter user name", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbPW.Text == "")
            {
                MessageBox.Show("Please enter password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbCPW.Text == "")
            {
                MessageBox.Show("Please enter confirm password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbEmail.Text == "")
            {
                MessageBox.Show("Please enter email", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboAge.Text == "")
            {
                MessageBox.Show("Please enter age", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (o.FileName == "")
            {
                MessageBox.Show("Please choose avater", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txbPW.Text != txbCPW.Text)
            {
                MessageBox.Show("Password not confirmed", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string publicId = uploadImage(o.FileName);

            Class.User user = new Class.User(Class.ListUser.Instance.List.Count, txbUN.Text, txbPW.Text, txbEmail.Text, Int32.Parse(cboAge.Text), publicId);
            Class.ListUser.Instance.List.Add(user);
            MessageBox.Show("Register success");
          
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }


        void WriteData()
        {
            var execl1 = new ExcelMapper();

            execl1.Save(Application.StartupPath + @"\assets\User.xlsx", Class.ListUser.Instance.List);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }
    }
}
