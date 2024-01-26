using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Management.Instrumentation;

namespace Form1
{
    public partial class Form1 : Form
    {
        
        SqlConnection conn;
        SqlCommand com;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }
        
        Control ActiveControl;
        //static public string passw;
        static public string add;
        static public string abc;
        static public string gun;
        static public string saat;

        string t1,t2,t3,t4,t5;
        private void girisyap_Click(object sender, EventArgs e)
        {
            //passw = textBox1.Text; /// fazladan
            conn = new SqlConnection(@"Data Source=your pc name;Initial Catalog=EEE;Integrated Security=True");
            com = new SqlCommand();
            conn.Open();
            com.Connection = conn;
            com.CommandText = "Select * from personel where sifre = '" + textBox1.Text + "'";
            dr = com.ExecuteReader();
            /*
            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = "insert into tarih values('" + dr["tc"] + "','girdi','" + t1 + "','" + t2 + "','" + t3 + "','" + t4 + "','" + t5 + "')";
                SqlCommand com1 = new SqlCommand(query,conn);
                com1.ExecuteNonQuery();
            }*/
            
            //com.CommandText = "insert into tarih values('" + dr["tc"] + "','girdi','" + t1 + "','" + t2 + "','" + t3 + "','" + t4 + "','" + t5 + "')"
            if (dr.Read())
            {         
                add = dr["ad"].ToString();
                abc = dr["tc"].ToString();
                gun = label2.Text;
                saat = label3.Text;
                hosgeldiniz h1 = new hosgeldiniz();
                h1.Show();
            }
            else
            {
                MessageBox.Show("yanlış ");
            }
            conn.Close();

            //textBox1.Clear();
            /*SqlCommand komut = new SqlCommand("insert into tarih values('" + dr["tc"] + "','girdi','" + t1 + "','" + t2 + "','" + t3 + "','" + t4 + "','" + t5 + "')");
            komut.ExecuteNonQuery();*/
          
            SqlCommand com1 = new SqlCommand();
            conn.Open();
            com1.Connection = conn;
            com1.CommandText= ("insert into tarih values('" + abc + "','girdi','" + t1 + "','" + t2 + "','" + t3 + "','" + t4 + "','" + t5 + "')");
            try 
            {
                com1.ExecuteNonQuery();
            }
            catch 
            {
                MessageBox.Show("ÖNCE ÇIKIŞ YAPINIZ.");
                
            }
            conn.Close();
            
        } 
        
        private void buton1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ActiveControl.Focus();
            SendKeys.Send(btn.Text);
           

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) 
            {
                MessageBox.Show("rakam gir");
                e.Handled = true;
            }
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            // Buradaki fonksiyon(KeyPress) klavyeden yazacağımız rakam dışındaki karakterleri yazamamamızı sağlıyor.
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

        private void clr_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
                {
                    timer1.Start();
                }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t1 = DateTime.Now.Year.ToString();
            t2 = DateTime.Now.Month.ToString();
            t3 = DateTime.Now.Day.ToString();
            t4 = DateTime.Now.Hour.ToString();
            t5 = DateTime.Now.Minute.ToString();
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
            
        }

        
    }
}
