using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Metodlar
{
    public partial class Form1 : Form
    {
        #region Değişkenler

        double s1, s2, sonuç;

        string işlem;

        #endregion

        #region Metodlar 

        public void işlemyap()
        {
            if (radioButton1.Checked == true)
            {
                işlem = radioButton1.Text;
                sonuç = s1 + s2;
            }

            else if (radioButton2.Checked == true)
            {
                işlem = radioButton2.Text;
                sonuç = s1 - s2;
            }

            else if (radioButton3.Checked == true)
            {
                işlem = radioButton3.Text;
                sonuç = s1 * s2;
            }

            else if (radioButton4.Checked == true)
            {
                işlem = radioButton4.Text;
                sonuç = s1 / s2;
            }

            label3.Text =sonuç.ToString();
        
        }


        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            s1 = double.Parse(textBox1.Text);
            s2 = double.Parse(textBox2.Text);

            işlemyap();
           

        }


    }
}
