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
    public partial class satınalgiris : Form
    {
        public satınalgiris()
        {
            InitializeComponent();
        }
        public string adsoyad,  odatip, turadi;
        public string tc, telno;
        private void btngiris_Click(object sender, EventArgs e)
        {
            if (kullaniciaditxt.Text == "admin")
            {
                servis a = new servis();
                DataTable dt = new DataTable();
                dt = a.login_select(kullaniciaditxt.Text, sifretxt.Text);
                if (dt.Rows.Count > 0)
                {
                    DialogResult secenek = MessageBox.Show("Rezerve yapmak ister misiniz??", "????", MessageBoxButtons.YesNo);
                    if (secenek == DialogResult.Yes)
                    {
                        DialogResult secenek2 = MessageBox.Show("Rezerve Yapma işleminiz Gerçekleştirildi!!", "Tebrikler!!", MessageBoxButtons.OK);
                        if (secenek2 == DialogResult.OK)
                        {
                            anasayfa lgn1 = new anasayfa();
                            servis c = new servis();
                            c.Kayit_insert_DataReader(turadi,0,adsoyad,tc.ToString(),telno.ToString(),odatip);
                            lgn1.Show();
                            this.Hide();
                        }
                        
                    }
                    else
                    {
                        DialogResult secenek1 = MessageBox.Show("Satın Alma işleminiz Gerçekleştirildi!!", "Tebrikler!!", MessageBoxButtons.OK);
                        if (secenek1 == DialogResult.OK)
                        {
                            anasayfa lgn = new anasayfa();
                            servis c = new servis();
                            c.Kayit_insert_DataReader(turadi, 1, adsoyad, tc.ToString(), telno.ToString(), odatip);
                            //OracleConnection baglanti = new OracleConnection("Data Source=XE; User ID=tur;Password=tur ");

                            //OracleCommand komut = new OracleCommand("SP_Kayit_INSERT", baglanti);
                            //komut.CommandType = CommandType.StoredProcedure;
                            //komut.Parameters.Add(new OracleParameter("turadi ", turadi));
                            //komut.Parameters.Add(new OracleParameter("durum", 1));
                            //komut.Parameters.Add(new OracleParameter("adsoyad", adsoyad));
                            //komut.Parameters.Add(new OracleParameter("tc", tc.ToString()));
                            //komut.Parameters.Add(new OracleParameter("telno", telno.ToString()));
                            //komut.Parameters.Add(new OracleParameter("odatipi", odatip));
                            //baglanti.Open();
                            //OracleDataReader dr = komut.ExecuteReader(CommandBehavior.CloseConnection);


                            lgn.Show();
                            this.Hide();
                        }
                    }
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
                    odeme b = new odeme();
                    b.adsoyad = adsoyad;
                    b.tc = tc;
                    b.telno = telno;
                    b.odatip = odatip;
                    b.turadi = turadi;
                    b.kullaniciadi = kullaniciaditxt.Text;
                    b.sifre = sifretxt.Text;
                    this.Hide();
                    b.Show();
                }
                else
                {
                    MessageBox.Show("Şifre yanlış. Tekrar deneyin!!!");
                }
            }
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

        private void btnuyeol_Click(object sender, EventArgs e)
        {
            uyeol a = new uyeol();
            this.Hide();

            a.adsoyad = adsoyad;
            a.tc = tc;
            a.telno = telno;
            a.odatip = odatip;
            a.turadi = turadi;
            a.müsıd = 1;
            a.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odeme a = new odeme();

            a.adsoyad = adsoyad;
            a.tc = tc;
            a.telno = telno;
            a.odatip = odatip;
            a.turadi = turadi;
            this.Hide();
            a.Show();
        }

        private void satınalgiris_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
