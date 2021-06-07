using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fuku0520
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tya_Click(object sender, EventArgs e)
        {
            tya.Text = "2000円";
            kyaku.Left = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kyaku.Text = "高いわ！";
        }

        private void senbe_Click(object sender, EventArgs e)
        {
            senbe.Text = "6000円";
            kyaku.Left = +128;
        }
    }
}
