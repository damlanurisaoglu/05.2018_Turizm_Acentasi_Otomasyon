using System;
using anaekran;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp4
{
    public partial class biletiptal : Form
    {
        public biletiptal()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int müsid;
        int kayitid;
        private void biletiptal_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            this.WindowState = FormWindowState.Maximized;
            if (id==1)
            {
                DataTable dt = new DataTable();
                servis s = new servis();
                dt = s.Kayitlar_select();
                dataGridView1.DataSource = dt;

            }
            else
            {
                DataTable dt = new DataTable();
                servis s = new servis();
                dt = s.MusKayitlar_select(müsid);
                dataGridView1.DataSource = dt;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {
            anasayfa a = new anasayfa();
            this.Hide();
            a.Show();
        }

        private void btnad_Click(object sender, EventArgs e)
        {
            if (id==1)
            {
                if (txtad.Text=="")
                {
                    DataTable dt = new DataTable();
                    servis s = new servis();
                    dt = s.Kayitlar_select();
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    DataTable dt1 = new DataTable();
                    servis s1 = new servis();
                    dt1 = s1.adminara_select("AdSoyad", txtad.Text);
                    dataGridView1.DataSource = dt1;
                }
                
            }
            else
            {
                if (txtad.Text=="")
                {
                    DataTable dt = new DataTable();
                    servis s = new servis();
                    dt = s.MusKayitlar_select(müsid);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    DataTable dt = new DataTable();
                    servis s = new servis();
                    dt = s.ara_select(müsid, "AdSoyad", txtad.Text);
                    dataGridView1.DataSource = dt;
                }
               
            }
            
        }

        private void btntc_Click(object sender, EventArgs e)
        {
            if (id == 1)
            {
                if (txttc.Text == "")
                {
                    DataTable dt = new DataTable();
                    servis s = new servis();
                    dt = s.Kayitlar_select();
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    DataTable dt1 = new DataTable();
                    servis s1 = new servis();
                    dt1 = s1.adminara_select("Tc", txttc.Text);
                    dataGridView1.DataSource = dt1;
                }

            }
            else
            {
                if (txttc.Text == "")
                {
                    DataTable dt = new DataTable();
                    servis s = new servis();
                    dt = s.MusKayitlar_select(müsid);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    DataTable dt = new DataTable();
                    servis s = new servis();
                    dt = s.ara_select(müsid, "Tc", txttc.Text);
                    dataGridView1.DataSource = dt;
                }

            }

        }

        private void btntel_Click(object sender, EventArgs e)
        {
            if (id == 1)
            {
                if (txttel.Text == "")
                {
                    DataTable dt = new DataTable();
                    servis s = new servis();
                    dt = s.Kayitlar_select();
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    DataTable dt1 = new DataTable();
                    servis s1 = new servis();
                    dt1 = s1.adminara_select("TelNo", txttel.Text);
                    dataGridView1.DataSource = dt1;
                }

            }
            else
            {
                if (txttel.Text == "")
                {
                    DataTable dt = new DataTable();
                    servis s = new servis();
                    dt = s.MusKayitlar_select(müsid);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    DataTable dt = new DataTable();
                    servis s = new servis();
                    dt = s.ara_select(müsid, "TelNo", txttel.Text);
                    dataGridView1.DataSource = dt;
                }

            }

        }

        private void btnoda_Click(object sender, EventArgs e)
        {
            if (id == 1)
            {
                try
                {
                    if (cboda.SelectedItem.ToString() == null)
                    {
                        DataTable dt = new DataTable();
                        servis s = new servis();
                        dt = s.Kayitlar_select();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        DataTable dt1 = new DataTable();
                        servis s1 = new servis();
                        dt1 = s1.adminara_select("OdaTipi", cboda.SelectedItem.ToString());
                        dataGridView1.DataSource = dt1;
                    }
                }
                catch (Exception)
                {
                    DataTable dt = new DataTable();
                    servis s = new servis();
                    dt = s.Kayitlar_select();
                    dataGridView1.DataSource = dt;
                }
               

            }
            else
            {
                try
                {
                    if (cboda.SelectedItem.ToString() == null)
                    {
                        DataTable dt = new DataTable();
                        servis s = new servis();
                        dt = s.MusKayitlar_select(müsid);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        servis s = new servis();
                        dt = s.ara_select(müsid, "OdaTipi", cboda.SelectedItem.ToString());
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception)
                {
                    DataTable dt = new DataTable();
                    servis s = new servis();
                    dt = s.MusKayitlar_select(müsid);
                    dataGridView1.DataSource = dt;
                }
                

            }

        }

        private void btntur_Click(object sender, EventArgs e)
        {
            if (id == 1)
            {
                if (txttur.Text == "")
                {
                    DataTable dt = new DataTable();
                    servis s = new servis();
                    dt = s.Kayitlar_select();
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    DataTable dt1 = new DataTable();
                    servis s1 = new servis();
                    dt1 = s1.adminara2_select("Kayitlar.TurID", txttur.Text);
                    dataGridView1.DataSource = dt1;
                }

            }
            else
            {
                if (txttur.Text == "")
                {
                    DataTable dt = new DataTable();
                    servis s = new servis();
                    dt = s.MusKayitlar_select(müsid);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    DataTable dt = new DataTable();
                    servis s = new servis();
                    dt = s.ara2_select(müsid, "Kayitlar.TurID", txttur.Text);
                    dataGridView1.DataSource = dt;
                }

            }
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            try
            {
                servis s = new servis();
                s.kayit_delete(kayitid);

                DialogResult secenek = MessageBox.Show("Silme İşleminiz Başarıyla Gerçekleşmiştir.", "Tebrikler..!!", MessageBoxButtons.OK);
                if (secenek == DialogResult.OK)
                {
                    biletiptal_Load(null, null);
                }
            }
            catch (Exception)
            {

                return;
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kayitid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            this.Hide();
            a.Show();
        }
    }
}
