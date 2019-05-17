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
    public partial class tur : Form
    {
        public tur()
        {
            InitializeComponent();
        }

        private void tur_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            servis s = new servis();
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            dt = s.aktif_select();
            dataGridView1.DataSource = dt;
            dt2 = s.pasif_select();
            dataGridView2.DataSource = dt2;
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnresim_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.ShowDialog();
            string file = a.FileName;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbaktif.Checked)
                {
                    servis a = new servis();
                    a.Tur_insert(txtturadi.Text, txtbilgi.Text, txttarih.Text, 1, int.Parse(txttek.Text), int.Parse(txtcift.Text), int.Parse(txtdort.Text), int.Parse(txtkont.Text), comboBox1.SelectedItem.ToString());
                }
                else
                {
                    servis a = new servis();
                    a.Tur_insert(txtturadi.Text, txtbilgi.Text, txttarih.Text, 0, int.Parse(txttek.Text), int.Parse(txtcift.Text), int.Parse(txtdort.Text), int.Parse(txtkont.Text), comboBox1.SelectedItem.ToString());

                }

                DialogResult secenek = MessageBox.Show("Kayıt İşleminiz Başarıyla Gerçekleşmiştir.", "Tebrikler..!!", MessageBoxButtons.OK);
                if (secenek == DialogResult.OK)
                {
                    tur_Load(null,null);
                    sil();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Tüm alanları doldurunuz.");
            }
           
            

        }
        private void sil()
        {
            txtturadi.Text = "";
            txtbilgi.Text = "";
            txtkont.Text = "";
            txttarih.Text = "";
            txtcift.Text = "";
            txtdort.Text = "";
            txttek.Text = "";
            comboBox1.Text = "";
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            servis s = new servis();
            s.Tur_delete(txtturadi.Text, comboBox1.SelectedItem.ToString());
            //OracleConnection baglanti = new OracleConnection("Data Source=XE; User ID=tur;Password=tur ");

            //OracleCommand komut = new OracleCommand("SP_tur_delete", baglanti);
            //komut.CommandType = CommandType.StoredProcedure;
            //komut.Parameters.Add(new OracleParameter("adi ", txtturadi.Text));
            //komut.Parameters.Add(new OracleParameter("tip", comboBox1.SelectedItem.ToString()));
            //baglanti.Open();
            //OracleDataReader dr = komut.ExecuteReader(CommandBehavior.CloseConnection);

            DialogResult secenek = MessageBox.Show("Silme İşleminiz Başarıyla Gerçekleşmiştir.", "Tebrikler..!!", MessageBoxButtons.OK);
            if (secenek == DialogResult.OK)
            {
                tur_Load(null,null);
                sil();
            }
        }
        int id;
        int durum;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id= int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtturadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtbilgi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txttarih.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txttek.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtcift.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtdort.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtkont.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            rbpasif.Checked = false;
            rbaktif.Checked=true;
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtturadi.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtbilgi.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            txttarih.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            txttek.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtcift.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtdort.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtkont.Text = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
            comboBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[9].Value.ToString();
            rbaktif.Checked = false;
            rbpasif.Checked = true;
            
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            
                if (rbaktif.Checked)
                {
                    durum = 1;
                }
                else
                {
                    durum = 0;
                }
                if (id.ToString() == "0")
                {

                    MessageBox.Show("Güncellemek için tur Seçiniz!");

                }
                else
                {
                
                    servis s = new servis();
                    s.Tur_updata(txtturadi.Text, txtbilgi.Text, txttarih.Text, durum, int.Parse(txttek.Text), int.Parse(txtcift.Text), int.Parse(txtdort.Text), int.Parse(txtkont.Text), comboBox1.SelectedItem.ToString(), id);

                    //OracleConnection baglanti = new OracleConnection("Data Source=XE; User ID=tur;Password=tur ");

                    //OracleCommand komut = new OracleCommand("SP_TUR_UPDATE", baglanti);
                    //komut.CommandType = CommandType.StoredProcedure;
                    //komut.Parameters.Add(new OracleParameter("adi", txtturadi.Text));
                    //komut.Parameters.Add(new OracleParameter("bilgi", txtbilgi.Text));
                    //komut.Parameters.Add(new OracleParameter("tarih", txttarih.Text));
                    //komut.Parameters.Add(new OracleParameter("durum", durum));
                    //komut.Parameters.Add(new OracleParameter("tek", int.Parse(txttek.Text)));
                    //komut.Parameters.Add(new OracleParameter("cift", int.Parse(txtcift.Text)));
                    //komut.Parameters.Add(new OracleParameter("dort", int.Parse(txtdort.Text)));
                    //komut.Parameters.Add(new OracleParameter("kont", int.Parse(txtkont.Text)));
                    //komut.Parameters.Add(new OracleParameter("tip", comboBox1.SelectedItem.ToString()));
                    //komut.Parameters.Add(new OracleParameter("id", id));
                    //baglanti.Open();
                    //OracleDataReader dr = komut.ExecuteReader(CommandBehavior.CloseConnection);


                    DialogResult secenek = MessageBox.Show("Güncelleme İşleminiz Başarıyla Gerçekleşmiştir.", "Tebrikler..!!", MessageBoxButtons.OK);
                    if (secenek == DialogResult.OK)
                    {
                        tur_Load(null, null);
                        sil();
                    }
                
                
                }
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)//Dışarı aktar
        {
            Microsoft.Office.Interop.Excel.Application objexcelapp = new Microsoft.Office.Interop.Excel.Application();
            objexcelapp.Application.Workbooks.Add(Type.Missing);
            objexcelapp.Columns.ColumnWidth = 25;
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                objexcelapp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        objexcelapp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            MessageBox.Show("Çıktı Başarıyla Alındı C:\\YEDEK/" + "Turlar" + ".xlsx");
            objexcelapp.ActiveWorkbook.SaveCopyAs("C:\\YEDEK/" + "Turlar" + ".xlsx");
            objexcelapp.ActiveWorkbook.Saved = true;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            this.Hide();
            a.Show();

        }
    }
}
