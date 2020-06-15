using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Credit_card_checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BTN_Validate_Click(object sender, EventArgs e)
        {
            string number = TBX_CardNum.Text;
            int sum = 0;
            bool is2 = true;
            for(int i = number.Length-2; i > 0; i--)
            {
                if (is2 == true)
                {
                    if (int.Parse(number[i].ToString()) * 2 < 10)
                    {
                        sum += int.Parse(number[i].ToString()) * 2;
                    }
                    else
                    {
                        sum+= int.Parse((int.Parse(number[i].ToString()) * 2).ToString()[0].ToString()) + int.Parse((int.Parse(number[i].ToString()) * 2).ToString()[1].ToString());
                    }
                    is2 = false;
                }
                else
                {
                    sum += int.Parse(number[i].ToString());
                    is2 = true;
                }
            }
            int checkdigit = number[number.Length-1];
            if ((checkdigit+sum)%10 == 0)
            {
                MessageBox.Show("Your card number is valid.");
            }
            else
            {
                MessageBox.Show("Your card number is not valid.");
            }
        }
    }
}