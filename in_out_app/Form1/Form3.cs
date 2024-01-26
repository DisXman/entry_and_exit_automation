using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=your pc name;Initial Catalog=EEE;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            if (txb_ad.Text=="" || String.IsNullOrEmpty(txb_soyad.Text) || String.IsNullOrEmpty(txb_telefon.Text) || String.IsNullOrEmpty(txb_mail.Text) || String.IsNullOrEmpty(txb_tc.Text))
            {
                MessageBox.Show("Her alan doldurulmalıdır.");
            }
            else
            {
                SqlConnection baglanti = new SqlConnection(conString);
                baglanti.Open();
                if ( baglanti.State == System.Data.ConnectionState.Open)
                {
                    
                    string query = "insert into personel values('" + txb_ad.Text + "','" + txb_soyad.Text + "', '" + txb_tc.Text + "','" + txb_telefon.Text + "','" + txb_mail.Text + "','" + txb_sifre.Text + "','" +textBox1.Text+"')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarıyla oluşturulmuştur.");
                    txb_ad.Clear();
                    txb_tc.Clear();
                    txb_soyad.Clear();
                    txb_telefon.Clear();
                    txb_mail.Clear();
                    txb_sifre.Clear();
                    textBox1.Clear();
                }
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kayıt ol kısmındaki şifre bölmesine sadece sayı yazılmasını sağlar.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txb_mail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
