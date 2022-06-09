using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Blog
{
    public partial class FormPost : Form
    {
        int index;
        Class.Post post;
        public FormPost()
        {
            InitializeComponent();
        }

        public FormPost(int i)
        {
            index = i;
            InitializeComponent();
            post = Class.ListPost.Instance.List[index];

            lblTitle.Text = post.Title;
            lblUN.Text = post.UserName;
            lblDate.Text = post.Date;
            lblTag.Text = "#" + post.Tag;
            lblContent.Text = post.Content;

            if (post.Is2Image)
            {
                //var request = WebRequest.Create();
                ptbImage21.Visible = true;
                ptbImage22.Visible = true;
                load2Image();
            }
            else
                load1Image();




        }
        private void load2Image()
        {
            var request1 = WebRequest.Create(post.Image1);
            using (var response1 = request1.GetResponse()) 
            using(var stream1 = response1.GetResponseStream())
            {
                ptbImage21.BackgroundImage = Bitmap.FromStream(stream1);
            }

            var request2 = WebRequest.Create(post.Image2);
            using (var response2 = request2.GetResponse())
            using (var stream2 = response2.GetResponseStream())
            {
                ptbImage22.BackgroundImage = Bitmap.FromStream(stream2);
            }
        }

        private void load1Image()
        {
            var request = WebRequest.Create(post.Image1);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                ptbImage1.BackgroundImage = Bitmap.FromStream(stream);
            }

          
        }
    }
}
