using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace İdeal_Kilom
{
    public partial class Form1 : Form
    {

        #region Tanımlamalar

        string cinsiyet;

        double kilo, boy, yaş;

        double idealkilo, kilo2;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cinsiyet = comboBox1.Text;
            boy = double.Parse(maskedTextBox1.Text);
            kilo = double.Parse(maskedTextBox2.Text);
            yaş = DateTime.Now.Year - Convert.ToInt32(maskedTextBox3.Text);

            groupBox2.Visible = true;

            if (cinsiyet == "Kadın")
            {
                idealkilo = (boy - 100 + (yaş / 10)) * 0.8;

                if (idealkilo == kilo)
                    label6.Text = "İdeal Kilodasınız";
                else
                {
                    if (idealkilo > kilo)
                    {
                        label6.Text = idealkilo.ToString();
                        kilo2 = idealkilo - kilo;
                        label9.Text = +kilo2 + " Almalısınız.";

                    }

                    else if (idealkilo < kilo)
                    {
                        label6.Text = idealkilo.ToString();
                        kilo2 = kilo - idealkilo;
                        label9.Text = +kilo2 + " Vermelisiniz.";

                    }
                }
            }

            else if (cinsiyet == "Erkek")
            {

                idealkilo = (boy - 100 + (yaş / 10)) * 0.9;

                if (idealkilo == kilo)
                    label6.Text = "İdeal Kilodasınız";
                else
                {
                    if (idealkilo > kilo)
                    {
                        label6.Text = idealkilo.ToString();
                        kilo2 = idealkilo - kilo;
                        label9.Text = kilo2.ToString("F") + " Kilo Almalısınız.";

                    }

                    else if (idealkilo < kilo)
                    {
                        label6.Text = idealkilo.ToString();
                        kilo2 = kilo - idealkilo;
                        label9.Text = kilo2.ToString("F") + " Kilo Vermelisiniz.";

                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }
    }
}