using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstform_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lbl_result_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //.below coding for add
        private void Btn1_Click(object sender, EventArgs e)
        {
            int firstnumber = int.Parse(txt_firstnumber.Text);
            int secondnumber = int.Parse(txt_secondnumber.Text);
            int result = firstnumber + secondnumber;
            txt_result.Text = result.ToString();

        }
        //.below coding for subtract
        private void Btn_sub_Click(object sender, EventArgs e)
        {
            int firstnumber = int.Parse(txt_firstnumber.Text);
            int secondnumber = int.Parse(txt_secondnumber.Text);
            int result = firstnumber - secondnumber;
            txt_result.Text = result.ToString();

        }
        //.below coding for clear
        private void Clear_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }
        //.below coding for multiply
        private void Btn3_Click(object sender, EventArgs e)
        {
            int firstnumber = int.Parse(txt_firstnumber.Text);
            int secondnumber = int.Parse(txt_secondnumber.Text);
            int result = firstnumber * secondnumber;
            txt_result.Text = result.ToString();

        }
        //.below coding for division
        private void Btn4_Click(object sender, EventArgs e)
        {
            int firstnumber = int.Parse(txt_firstnumber.Text);
            int secondnumber = int.Parse(txt_secondnumber.Text);
            int result = firstnumber / secondnumber;
            txt_result.Text = result.ToString();

        }
    }
}
