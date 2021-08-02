using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void p1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            p1.Height = btnHome.Height;
            position(btnHome);
            Active(btnHome);
        }
        private void position(Button b)
        {
            p1.Location = new Point(b.Location.X - p1.Width, b.Location.Y);
        }

        private void btnQuizz_Click(object sender, EventArgs e)
        {
            new Quizz().Show();
            this.Hide();
            position(btnQuizz);
            Active(btnQuizz);


        }

        private void btnPhotoQuizz_Click(object sender, EventArgs e)
        {
            new PhotoQuizz().Show();
            this.Hide();
            position(btnPhotoQuizz);
            Active(btnPhotoQuizz);
        }

       

        private void btnHome_Click(object sender, EventArgs e)
        {
            position(btnHome);
            Active(btnHome);
            new Main().Show();
            this.Hide();
        }
        private void Active(Button b)
        {
            foreach(Control ctr in p1.Controls)
            {
                if(ctr.GetType() == typeof(Button))
                {
                    if(ctr.Name==b.Name)
                    {
                        b.BackColor = Color.FromArgb(76, 76, 60);
                        b.ForeColor = Color.FromArgb(242,215,213);
                    }
                    else
                    {
                        ctr.BackColor = Color.FromArgb(77,86,86);
                        b.ForeColor = Color.White;
                    }

                }
            }
        }

        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblunknown.Text = cboCity.Text;
        }
    }
}
