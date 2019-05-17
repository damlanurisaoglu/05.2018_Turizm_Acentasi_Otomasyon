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
    public partial class turbilgi : Form
    {
        public turbilgi()
        {
            InitializeComponent();
        }
        public string TurAdi;
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsatınal_Click(object sender, EventArgs e)
        {
            odeme a = new odeme();
            this.Hide();
            a.Show();
        }

        private void bu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            satınalgiris a = new satınalgiris();
            try
            {
                a.adsoyad = txtadsoyad.Text;
                a.tc = txttc.Text;
                a.telno = txttelno.Text;
                a.odatip = cbxoda.SelectedItem.ToString();
                a.turadi = TurAdi;
            }
            catch (Exception)
            {

                return;
            }
            
            this.Hide();
            a.Show();
        }

        private void turbilgi_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            servis s = new servis();
            DataTable dt = new DataTable();
            dt = s.turbilgi_select(TurAdi);
            lblbilgi.Text = dt.Rows[0][2].ToString()+Environment.NewLine+"    Tarih:"+ dt.Rows[0][3].ToString() + Environment.NewLine + "    Tek kişilik oda fiyatı =" + dt.Rows[0][4].ToString() + Environment.NewLine + "    Çift kişilik oda fiyatı=" + dt.Rows[0][5].ToString() + Environment.NewLine + "    Dört kişilik oda fiyatı=" + dt.Rows[0][6].ToString();
        }

        private void cbxoda_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gunubirlik a = new gunubirlik();
            a.tür = "Yurtici";
            this.Hide();
            a.Show();
        }

        private void btnbiletiptal_Click(object sender, EventArgs e)
        {
            biletiptal a = new biletiptal();
            this.Hide();
            a.Show();
        }

        private void gunubirlik_Click(object sender, EventArgs e)
        {
            gunubirlik a = new gunubirlik();
            a.tür = "Gunubirlik";
            this.Hide();
            a.Show();
        }

        private void yurtdisi_Click(object sender, EventArgs e)
        {
            gunubirlik a = new gunubirlik();
            a.tür = "Yurtdisi";
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

        private void label1_Click(object sender, EventArgs e)
        {
            anasayfa a = new anasayfa();
            this.Hide();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
        }
    }
}
