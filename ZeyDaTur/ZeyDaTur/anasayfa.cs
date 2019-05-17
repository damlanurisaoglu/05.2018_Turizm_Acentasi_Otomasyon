using System;
using anaekran;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            anasayfa a = new anasayfa();
            this.Hide();
            a.Show();
        }
        
        private void anasayfa_Load(object sender, EventArgs e)
        {
         

            this.WindowState = FormWindowState.Maximized;
            //this.pictureBox1.Image=new Bitmap ("‪C:/Users/Damla/Desktop/5.jpg");
           // this.pictureBox1.Image = new Bitmap("‪C://Users//Damla//Desktop//5.jpg");
        }

        private void gunubirlik_Click(object sender, EventArgs e)
        {
            gunubirlik a = new gunubirlik();
            a.tür = "Gunubirlik";
            this.Hide();
            a.Show();
            
        }

        private void yurtici_Click(object sender, EventArgs e)
        {
            gunubirlik a = new gunubirlik();
            a.tür = "Yurtici";
            this.Hide();
            a.Show();
        }

        private void yurtdisi_Click(object sender, EventArgs e)
        {
            gunubirlik a = new gunubirlik();
            a.tür = "Yurtdısı";
            this.Hide();
            a.Show();
        }

        private void erkenrez_Click(object sender, EventArgs e)
        {
            gunubirlik a = new gunubirlik();
            a.tür = "Erken Rezervasyon";
            this.Hide();
            a.Show();
        }

        private void uyeol_Click(object sender, EventArgs e)
        {
            uyeol a = new uyeol();
            this.Hide();
            a.Show();
        }

        private void hesabim_Click(object sender, EventArgs e)
        {
            gırıs a = new gırıs();
            this.Hide();
            a.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
}
