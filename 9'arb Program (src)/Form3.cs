using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_arb_Program__src_
{
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double txtbox1 = Convert.ToDouble(textBox1.Text);
            double txtbox2 = Convert.ToDouble(textBox2.Text);
            double result = txtbox1 * txtbox2; // اضرب رقم 1 في رقم 2

            MessageBox.Show("يساوي " + result.ToString()); // اظهر النتيجة الله يسعدك
        }
    }
}
