using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hnk_bilisim
{
    public partial class Form1 : Form
    {
        string baglanti = "Server=localhost;Database=hayvanlar;Uid=root;Pwd=;";
        string yeniAd = "";
        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnYeniğ_Click(object sender, EventArgs e)
        {
            YeniEkle yeniekle=new YeniEkle();
            yeniekle.ShowDialog();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele listele = new listele();
           listele.ShowDialog();
        }
       
    }
}
