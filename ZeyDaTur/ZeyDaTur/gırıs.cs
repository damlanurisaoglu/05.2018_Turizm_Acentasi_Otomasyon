using System;
using anaekran;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp4
{
    public partial class gırıs : Form
    {
        public gırıs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            anasayfa a = new anasayfa();
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

        private void gırıs_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnuyeol_Click(object sender, EventArgs e)
        {
            uyeol a = new uyeol();
            this.Hide();
            a.Show();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (kullaniciaditxt.Text=="admin")
            {
                servis a = new servis();
                DataTable dt = new DataTable();
                dt = a.login_select(kullaniciaditxt.Text, sifretxt.Text);
                if (dt.Rows.Count > 0)
                {
                    admin b = new admin();
                    this.Hide();
                    b.Show();
                }
                else
                {
                    MessageBox.Show("Şifre yanlış. Tekrar deneyin!!!");
                }
            }
            else
            {
                servis a = new servis();
                DataTable dt = new DataTable();
                dt = a.login_select(kullaniciaditxt.Text, sifretxt.Text);
                if (dt.Rows.Count > 0)
                {
                    biletiptal b = new biletiptal();
                   
                    b.müsid = int.Parse(dt.Rows[0][0].ToString());
                    this.Hide();
                    b.Show();
                }
                else
                {
                    MessageBox.Show("Şifre yanlış. Tekrar deneyin!!!");
                }
            }
            
        }

        private void btnüyesil_Click(object sender, EventArgs e)
        {
            servis s = new servis();
            s.Login_delete(kullaniciaditxt.Text,sifretxt.Text);
            DialogResult secenek = MessageBox.Show("Silme İşleminiz Başarıyla Gerçekleşmiştir.", "Tebrikler..!!", MessageBoxButtons.OK);
            if (secenek == DialogResult.OK)
            {

                kullaniciaditxt.Text = "";
                sifretxt.Text = "";
                gırıs_Load(null,null);
            }
        }
    }
}
