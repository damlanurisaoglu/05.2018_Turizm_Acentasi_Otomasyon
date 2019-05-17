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
    public partial class odeme : Form
    {
        public string adsoyad, odatip, turadi, kullaniciadi, sifre;
        public string tc, telno;
        public odeme()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btngünübirlik_Click(object sender, EventArgs e)
        {
            gunubirlik a = new gunubirlik();
            a.tür = "Gunubirlik";
            this.Hide();
            a.Show();
        }

        private void btnyurtici_Click(object sender, EventArgs e)
        {
            gunubirlik a = new gunubirlik();
            a.tür = "Yurtici";
            this.Hide();
            a.Show();
        }

        private void btnyurtdisi_Click(object sender, EventArgs e)
        {
            gunubirlik a = new gunubirlik();
            a.tür = "Yurtdisi";
            this.Hide();
            a.Show();
        }

        private void btnerkenrez_Click(object sender, EventArgs e)
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

        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void odeme_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            servis c = new servis();
            c.MüsKayit_insert_DataReader(turadi, 1, adsoyad, tc.ToString(), telno.ToString(), odatip,kullaniciadi,sifre);
            DialogResult secenek1 = MessageBox.Show("Satın Alma işleminiz Gerçekleştirildi!!", "Tebrikler!!", MessageBoxButtons.OK);
            if (secenek1 == DialogResult.OK)
            {
                anasayfa lgn = new anasayfa();
                lgn.Show();
                this.Hide();
            }
        }
    }
}
