using System;
using anaekran;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Data.Odbc;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp4
{
    public partial class uyeol : Form
    {
        public uyeol()
        {
            InitializeComponent();
        }
        public int müsıd;
        public string adsoyad, odatip, turadi;
        public string tc, telno;
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

        private void button1_Click(object sender, EventArgs e)
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

        private void sifreonaytxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (sifretxt.Text == sifreonaytxt.Text)
            {
                sifreuyarilbl.Text = "Şifreler Eşleşti";
                sifreuyarilbl.ForeColor = Color.Green;
            }
            else
            {
                sifreuyarilbl.Text = "Şifreler Eşleşmedi";
                sifreuyarilbl.ForeColor = Color.Red;
            }
        }

        private void kullaniciaditxt_KeyUp(object sender, KeyEventArgs e)
        {
            servis s = new servis();
            DataTable dt = new DataTable();
            dt = s.kullaniciadi_select(kullaniciaditxt.Text);
            if (dt.Rows.Count>0)
            {
                lblkullanici.Text = "Kullanıcı adı kullanılmaktadır!!";
                lblkullanici.ForeColor = Color.Red;
            }
            else
            {
                lblkullanici.Text = "Kullanıcı adı kullanılabilir.";
                lblkullanici.ForeColor = Color.Green;
            }
        }

        private void uyeol_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
         

        }

        private void btndevam_Click(object sender, EventArgs e)
        {
            
            if (aditxt.Text == "" || tctxt.Text == "" || kullaniciaditxt.Text == "" || sifretxt.Text == "" || telnotxt.Text == "" ||  sehirtxt.Text == "" || lblkullanici.Text == "Kullanıcı adı kullanılmaktadır!!")

            {
                uyarilbl.Text = "Boş Alanları Doldurunuz!!!";
                uyarilbl.ForeColor = Color.Red;

            }
            if (lblkullanici.Text == "Kullanıcı adı kullanılmaktadır!!")
            {
                uyarilbl.Text = "Kullanıcı adını değiştirin!!";
                uyarilbl.ForeColor = Color.Red;
            }
            else
            {
                if (müsıd == 1)
                {
                    //müsıd = 0;
                    //servis s = new servis();
                    //s.Login_insert_DataReader(aditxt.Text, tctxt.Text, kullaniciaditxt.Text, sifretxt.Text, telnotxt.Text, sehirtxt.Text);
                    
                    OracleConnection baglanti = new OracleConnection("Data Source=XE; User ID=tur;Password=tur ");

                    OracleCommand komut = new OracleCommand("SP_LOGIN_INSERT",baglanti);
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.Add(new OracleParameter( "adsoyad" ,aditxt.Text));
                    komut.Parameters.Add(new OracleParameter("tc", tctxt.Text));
                    komut.Parameters.Add(new OracleParameter("kullaniciadi", kullaniciaditxt.Text));
                    komut.Parameters.Add(new OracleParameter("sifre", sifretxt.Text));
                    komut.Parameters.Add(new OracleParameter("telno", telnotxt.Text));
                    komut.Parameters.Add(new OracleParameter("sehir", sehirtxt.Text));
                    baglanti.Open();
                    OracleDataReader dr = komut.ExecuteReader(CommandBehavior.CloseConnection);
                   
                    
                    DialogResult secenek = MessageBox.Show("Kayıt İşleminiz Başarıyla Gerçekleşmiştir.", "Tebrikler..!!", MessageBoxButtons.OK);
                    if (secenek == DialogResult.OK)
                    {
                        odeme b = new odeme();

                        b.adsoyad = adsoyad;
                        b.tc = tc;
                        b.telno = telno;
                        b.odatip = odatip;
                        b.turadi = turadi;
                        b.kullaniciadi = kullaniciaditxt.Text;
                        b.sifre = sifretxt.Text;
                        b.Show();
                        this.Hide();
                    }
                }
                else
                {
                    //servis s = new servis();
                    //s.Login_insert_DataReader(aditxt.Text, tctxt.Text, kullaniciaditxt.Text, sifretxt.Text, telnotxt.Text, sehirtxt.Text);
                    OracleConnection baglanti = new OracleConnection("Data Source=XE; User ID=tur;Password=tur ");

                    OracleCommand komut = new OracleCommand("SP_LOGIN_INSERT", baglanti);
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.Add(new OracleParameter("adsoyad", aditxt.Text));
                    komut.Parameters.Add(new OracleParameter("tc", tctxt.Text));
                    komut.Parameters.Add(new OracleParameter("kullaniciadi", kullaniciaditxt.Text));
                    komut.Parameters.Add(new OracleParameter("sifre", sifretxt.Text));
                    komut.Parameters.Add(new OracleParameter("telno", telnotxt.Text));
                    komut.Parameters.Add(new OracleParameter("sehir", sehirtxt.Text));
                    baglanti.Open();
                    OracleDataReader dr = komut.ExecuteReader(CommandBehavior.CloseConnection);

                    DialogResult secenek = MessageBox.Show("Kayıt İşleminiz Başarıyla Gerçekleşmiştir.", "Tebrikler..!!", MessageBoxButtons.OK);
                    if (secenek == DialogResult.OK)
                    {
                        anasayfa lgn = new anasayfa();
                        lgn.Show();
                        this.Hide();
                    }
                }
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string[] kayıt_girdisi = new string[7]; int i = 0;
            StreamReader oku = new StreamReader("kayıtgirdisi.txt");    //dosyamızı okumak için açıyor           
            while (!oku.EndOfStream)//while döngüsü kullanıyoruz
            {
                kayıt_girdisi[i] = oku.ReadLine();// okunan değeri kayıt_girdisine aktarıyoruz.
                i++;
            }

            aditxt.Text = kayıt_girdisi[0];
            tctxt.Text = kayıt_girdisi[1];
            kullaniciaditxt.Text = kayıt_girdisi[2];
            sifretxt.Text = kayıt_girdisi[3];
            sifreonaytxt.Text = kayıt_girdisi[4];
            telnotxt.Text = kayıt_girdisi[5];
            
            sehirtxt.Text = kayıt_girdisi[6];

            kullaniciaditxt_KeyUp(null,null);
        }
    }
}
