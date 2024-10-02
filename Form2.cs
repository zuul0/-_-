using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace трпо
{
    public partial class Form2 : Form
    {
        public int money = 0;
        public int remains;
        public Form2()
        {
            InitializeComponent();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void one_Click(object sender, EventArgs e)
        {
            money++;
            label2.Text = money.ToString();
        }

        private void two_Click(object sender, EventArgs e)
        {
            money = money + 2;
            label2.Text = money.ToString();
        }

        private void five_Click(object sender, EventArgs e)
        {
            money = money + 5;
            label2.Text = money.ToString();
        }

        private void ten_Click(object sender, EventArgs e)
        {
            money = money + 10;
            label2.Text = money.ToString();
        }

        private void fifty_Click(object sender, EventArgs e)
        {
            money = money + 50;
            label2.Text = money.ToString();
        }

        private void hundred_Click(object sender, EventArgs e)
        {
            money = money + 100;
            label2.Text = money.ToString();
        }

    }
}
