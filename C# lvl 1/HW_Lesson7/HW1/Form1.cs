using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HW1.Value;

namespace HW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            lblCommandNumber.Text = "0";
            lblName.Text = "Получите число: ";
            lblValue.Text = Value.LblString();
            this.Text = "Удвоитель";

            MessageBox.Show("Для победы в игре вам необходимо получить заданное число!");
        }

        private bool flag;

        /// <summary>
        /// Обрабатываем нажатие на bthCommand1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            flag = true;
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lblCommandNumber.Text = (int.Parse(lblCommandNumber.Text) + 1).ToString();
            if (lblNumber.Text == lblValue.Text)
            {
                MessageBox.Show("Победа!");
            }
        }

        /// <summary>
        /// Обрабатываем нажатие на bthCommand2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            flag = false;
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            lblCommandNumber.Text = (int.Parse(lblCommandNumber.Text) + 1).ToString();
            if (lblNumber.Text == lblValue.Text)
            {
                MessageBox.Show("Победа!");
            }
        }

        /// <summary>
        /// Обрабатываем нажатие на bthReset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            lblCommandNumber.Text = (int.Parse(lblCommandNumber.Text) + 1).ToString();
        }

        /// <summary>
        /// Обрабатываем нажатие на NewGame (элемент меню)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGame_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            lblCommandNumber.Text = "0";
            lblValue.Text = Value.LblString();
        }

        /// <summary>
        /// Обрабатывем нажатие на bthCancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Отменяет только последний ход
            if (flag == true)
            {
                lblNumber.Text = (int.Parse(lblNumber.Text) - 1).ToString();
            }
            else
            {
                lblNumber.Text = (int.Parse(lblNumber.Text) / 2).ToString();
            }

            lblCommandNumber.Text = (int.Parse(lblCommandNumber.Text) + 1).ToString();
        }
    }
}
