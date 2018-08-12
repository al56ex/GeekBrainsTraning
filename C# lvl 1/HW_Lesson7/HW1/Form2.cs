using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            btnCommand1.Text = "Угадать";
            txtNumber.Text = null;
            lblCommandNumber.Text = "0";
            lblCheck.Text = Value.LblString();
            this.Text = "Угадай число";
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblCommandNumber.Text = (int.Parse(lblCommandNumber.Text) + 1).ToString();
           
            if (txtNumber.Text == lblCheck.Text)
            {
                MessageBox.Show("Победа!");
            }
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            txtNumber.Text = int.Parse(txtNumber.Text).ToString();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            lblCommandNumber.Text = "0";
            lblCheck.Text = Value.LblString();
        }
    }
}
