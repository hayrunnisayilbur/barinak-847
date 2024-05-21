using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace hnk_bilisim
{
    public partial class YeniEkle : Form
    {
        string baglanti = "Server=localhost;Database=barinak;Uid=root;Pwd=;";
        string yeniAd = "";
        public YeniEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "INSERT INTO hayvanlar VALUES(NULL,@hayvan_adi,@yas,@cins,@engel_durumu,@fotograf_adi);";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@hayvan_adi", txtİsim.Text);
                cmd.Parameters.AddWithValue("@yas", txtYas.Text);
                cmd.Parameters.AddWithValue("@cins", cmbCins.Text);
                cmd.Parameters.AddWithValue("@engel_durumu",cbEngel.Checked);
                cmd.Parameters.AddWithValue("@fotograf_adi", pbResim.Text);


                //sorguyu çalıştırma komutu kayıt eklşenirse satır satıyısı döner
                if (cmd.ExecuteNonQuery() > 0)
                {
                    // MessageBox.Show("Kayıt Eklendi!");
                    // this.Close(); 
                }
               

            }
            


        }

        private void YeniEkle_Load(object sender, EventArgs e)
        {
            string klasorYolu = @"fotograf_adi";
            if (!Directory.Exists(klasorYolu))
            {
                Directory.CreateDirectory(klasorYolu);
            }
            CmbDoldur();
        }
        void CmbDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT DISTINCT cins FROM hayvanlar;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();




                da.Fill(dt);
                cmbCins.DataSource = dt;

                cmbCins.DisplayMember = "cins";   //ekranda kullanıcı görür
                cmbCins.ValueMember = "cins";     //veritabanına kayıt edilir
            }
        }

        private void pbResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog(this);

            if (result != DialogResult.OK) return;

            string kaynakDosya = openFileDialog.FileName;
            yeniAd= Guid.NewGuid().ToString() + Path.GetExtension(kaynakDosya);
            string hedefDosya = Path.Combine(Environment.CurrentDirectory, "fotograf_adi", yeniAd);

            File.Copy(kaynakDosya, hedefDosya);

            pbResim.ImageLocation = null;

            if (File.Exists(hedefDosya))
            {
                pbResim.ImageLocation = hedefDosya;
                pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
    }
}
