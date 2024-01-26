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

namespace Form1
{
    public partial class hosgeldiniz : Form
    {
        SqlCommand com;
        SqlConnection con;
        SqlDataReader dr;
        public hosgeldiniz()
        {
            InitializeComponent();
        }

        private void hosgeldiniz_Load(object sender, EventArgs e)
        {
            string str = Form1.add.ToString();
            string gunn = Form1.gun.ToString();
            string saaat = Form1.saat.ToString();
            /*con = new SqlConnection(@"Data Source=\SQLEXPRESS;Initial Catalog=EEE;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = conn
            com.CommandText = "select ad from personel where sifre='"+str+"'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                label3.Text =  ;
            }
            con.Close();*/ // bunlara gerek olmadı 
            label3.Text = str;
            label4.Text = gunn;
            label5.Text = saaat;

        }

      
    }
}
