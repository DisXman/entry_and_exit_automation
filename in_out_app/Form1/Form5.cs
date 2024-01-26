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

    
    public partial class Form5 : Form
    {   
        Control ActiveControl;
        SqlConnection conn;
        SqlCommand com;
        SqlCommand com1;
        //SqlCommand com2;
        SqlDataReader dr;

        public static string t1, t2, t3, t4, t5;
        public static string tarihh,saat;
        public static string kimlik;
        public static string tccc;

        public Form5()
        {
            InitializeComponent();
        }
        static public string add;
        private void button12_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection(@"Data Source=your pc name;Initial Catalog=EEE;Integrated Security=True");
            com = new SqlCommand();
            conn.Open();
            com.Connection = conn;       
            com.CommandText = "select * from personel where sifre ='" + textBox1.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                tarihh = label1.Text;
                saat = label2.Text; 
                add = dr["ad"].ToString();
                tccc = dr["tc"].ToString();
                by b1 = new by();
                b1.Show();
            }
            else 
                MessageBox.Show("Yanlış şifre.");
            conn.Close();

            SqlCommand com1 = new SqlCommand();
            //com2 = new SqlCommand();
            conn.Open();
            com1.Connection = conn;////////////// buralarda kaldık
            //com2.Connection = conn;
            //com1.CommandText = "select tc from personel where sifre = '"+textBox1.Text+"'";
            //dr = com2.ExecuteReader();
            //kimlik = com1.ToString();
            com1.CommandText = "delete from tarih where tc='" + tccc +"'";
            com1.ExecuteNonQuery();
            conn.Close();
            //com1.CommandText = "insert into tarih values('"++)"
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ActiveControl.Focus();
            SendKeys.Send(btn.Text);
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("rakam gir");
                e.Handled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t1 = DateTime.Now.Year.ToString();
            t2 = DateTime.Now.Month.ToString();
            t3 = DateTime.Now.Day.ToString();
            t4 = DateTime.Now.Hour.ToString();
            t5 = DateTime.Now.Minute.ToString();
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}