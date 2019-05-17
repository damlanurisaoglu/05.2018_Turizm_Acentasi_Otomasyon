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
    public partial class gunubirlik : Form
    {
        public gunubirlik()
        {
            InitializeComponent();
        }
        public string tür;
        private void gunubirlikk_Click(object sender, EventArgs e)
        {
            lbltur1.Enabled = false;
            lbltur2.Enabled = false;
            lbltur3.Enabled = false;
            lbltur4.Enabled = false;
            lbltur1.Text = "";
            lbltur2.Text = "";
            lbltur3.Text = "";
            lbltur4.Text = "";
            servis s = new servis();
            DataTable dt = new DataTable();
            dt = s.tur_select("Gunubirlik");
            try
            {
                lbltur1.Text = dt.Rows[0][1].ToString();
                lbltur2.Text = dt.Rows[1][1].ToString();
                lbltur3.Text = dt.Rows[2][1].ToString();
                lbltur4.Text = dt.Rows[3][1].ToString();
            }
            catch (Exception)
            {
            }
            if (lbltur1.Text != "")
            {
                lbltur1.Enabled = true;
            }
            if (lbltur2.Text != "")
            {
                lbltur2.Enabled = true;
            }
            if (lbltur3.Text != "")
            {
                lbltur3.Enabled = true;
            }
            if (lbltur4.Text != "")
            {
                lbltur4.Enabled = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            anasayfa a = new anasayfa();
            this.Hide();
            a.Show();
        }

        private void yurtici_Click(object sender, EventArgs e)
        {
            lbltur1.Enabled = false;
            lbltur2.Enabled = false;
            lbltur3.Enabled = false;
            lbltur4.Enabled = false;
            lbltur1.Text = "";
            lbltur2.Text = "";
            lbltur3.Text = "";
            lbltur4.Text = "";
            servis s = new servis();
            DataTable dt = new DataTable();
            dt = s.tur_select("Yurtici");
            try
            {
                lbltur1.Text = dt.Rows[0][1].ToString();
                lbltur2.Text = dt.Rows[1][1].ToString();
                lbltur3.Text = dt.Rows[2][1].ToString();
                lbltur4.Text = dt.Rows[3][1].ToString();
            }
            catch (Exception)
            {
            }
            if (lbltur1.Text != "")
            {
                lbltur1.Enabled = true;
            }
            if (lbltur2.Text != "")
            {
                lbltur2.Enabled = true;
            }
            if (lbltur3.Text != "")
            {
                lbltur3.Enabled = true;
            }
            if (lbltur4.Text != "")
            {
                lbltur4.Enabled = true;
            }
        }

        private void yurtdisi_Click(object sender, EventArgs e)
        {
            lbltur1.Enabled = false;
            lbltur2.Enabled = false;
            lbltur3.Enabled = false;
            lbltur4.Enabled = false;
            lbltur1.Text = "";
            lbltur2.Text = "";
            lbltur3.Text = "";
            lbltur4.Text = "";
            servis s = new servis();
            DataTable dt = new DataTable();
            dt = s.tur_select("Yurtdısı");
            try
            {
                lbltur1.Text = dt.Rows[0][1].ToString();
                lbltur2.Text = dt.Rows[1][1].ToString();
                lbltur3.Text = dt.Rows[2][1].ToString();
                lbltur4.Text = dt.Rows[3][1].ToString();
            }
            catch (Exception)
            {
            }
            if (lbltur1.Text != "")
            {
                lbltur1.Enabled = true;
            }
            if (lbltur2.Text != "")
            {
                lbltur2.Enabled = true;
            }
            if (lbltur3.Text != "")
            {
                lbltur3.Enabled = true;
            }
            if (lbltur4.Text != "")
            {
                lbltur4.Enabled = true;
            }
        }

        private void erkenrez_Click(object sender, EventArgs e)
        {
            lbltur1.Enabled = false;
            lbltur2.Enabled = false;
            lbltur3.Enabled = false;
            lbltur4.Enabled = false;
            lbltur1.Text = "";
            lbltur2.Text = "";
            lbltur3.Text = "";
            lbltur4.Text = "";

            servis s = new servis();
            DataTable dt = new DataTable();
            dt = s.tur_select("Erken Rezervasyon");
            try
            {
                lbltur1.Text = dt.Rows[0][1].ToString();
                lbltur2.Text = dt.Rows[1][1].ToString();
                lbltur3.Text = dt.Rows[2][1].ToString();
                lbltur4.Text = dt.Rows[3][1].ToString();
            }
            catch (Exception)
            {
            }
            if (lbltur1.Text != "")
            {
                lbltur1.Enabled = true;
            }
            if (lbltur2.Text != "")
            {
                lbltur2.Enabled = true;
            }
            if (lbltur3.Text != "")
            {
                lbltur3.Enabled = true;
            }
            if (lbltur4.Text != "")
            {
                lbltur4.Enabled = true;
            }

        }

      

        private void gunubirlik_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lbltur1.Enabled = false;
            lbltur2.Enabled = false;
            lbltur3.Enabled = false;
            lbltur4.Enabled = false;

            lbltur1.Text = "";
            lbltur2.Text = "";
            lbltur3.Text = "";
            lbltur4.Text = "";
            servis s = new servis();
            DataTable dt = new DataTable();
            dt = s.tur_select(tür);
            try
            {
                lbltur1.Text = dt.Rows[0][1].ToString();
                lbltur2.Text = dt.Rows[1][1].ToString();
                lbltur3.Text = dt.Rows[2][1].ToString();
                lbltur4.Text = dt.Rows[3][1].ToString();
            }
            catch (Exception)
            {
            }
            if (lbltur1.Text != "")
            {
                lbltur1.Enabled = true;
            }
            if (lbltur2.Text != "")
            {
                lbltur2.Enabled = true;
            }
            if (lbltur3.Text != "")
            {
                lbltur3.Enabled = true;
            }
            if (lbltur4.Text != "")
            {
                lbltur4.Enabled = true;
            }
        }

        private void lbltur1_Click(object sender, EventArgs e)
        {
            turbilgi a = new turbilgi();
            a.TurAdi = lbltur1.Text;
            this.Hide();
            a.Show();
        }

        private void lbltur2_Click(object sender, EventArgs e)
        {
            turbilgi a = new turbilgi();
            a.TurAdi = lbltur2.Text;
            this.Hide();
            a.Show();
        }

        private void lbltur3_Click(object sender, EventArgs e)
        {
            turbilgi a = new turbilgi();
            a.TurAdi = lbltur3.Text;
            this.Hide();
            a.Show();
        }

        private void lbltur4_Click(object sender, EventArgs e)
        {
            turbilgi a = new turbilgi();
            a.TurAdi = lbltur4.Text;
            this.Hide();
            a.Show();
        }
    }
}
