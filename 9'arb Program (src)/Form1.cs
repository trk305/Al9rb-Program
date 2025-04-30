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
    public partial class Form1: Form
    {
        bool english = false;
        public Form1()
        {
            InitializeComponent();
            UpdateLanguage(); // حدث اللغة
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 jdwal = new Form2(); // بكل بساطة Form2.Show(); لأن ما يمديك تسوي

            jdwal.Show(); // اظهر لي جدول الضرب لما اضغط زر 1
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 edrb = new Form3();
            edrb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            english = !english;
            UpdateLanguage(); // حدث اللغة لما اضغط على الزر
        }
    private void UpdateLanguage()
    {
        if (english)
        {
            // English UI
            this.RightToLeft = RightToLeft.No;
            label1.Text = "Multiplication Program made by Turki Al Mutairi";
            button1.Text = "Multiplication table";
            button2.Text = "Multiply";
            this.RightToLeft = RightToLeft.Yes;
            button3.Text = "هيه! اضغطني عشان احول اللغة الى عربي!"; // معليه بيتصلح النص لا تغير
        }
        else
        {
            // Arabic UI
            this.RightToLeft = RightToLeft.Yes;
            label1.Text = "برنامج الضرب من صنع تركي المطيري";
            button1.Text = "جدول الضرب";
            button2.Text = "اضرب";
            this.RightToLeft = RightToLeft.No;
            button3.Text = "Hey! Click me to change the language to English!";
        }
    }
    }
}
