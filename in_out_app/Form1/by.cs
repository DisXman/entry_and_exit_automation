using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class by : Form
    {
        public by()
        {
            InitializeComponent();
        }

        private void by_Load(object sender, EventArgs e)
        {
            label4.Text = Form5.tarihh.ToString();
            label5.Text = Form5.saat.ToString();
            string str = Form5.add.ToString();
            label3.Text = str;
        }
    }
}
