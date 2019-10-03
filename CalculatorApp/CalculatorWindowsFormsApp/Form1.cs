using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CalculatorMachine;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = int.Parse(textBox1.Text);
            var b = Convert.ToInt32(textBox2.Text);

            var cal = new Calculator();

            //listBox1.Items.Clear(); //kosongkan isi listbox

            //tampilkan hasil semua hasil pemanggilan method calculator ke dalam listbox
            listBox1.Items.Add(string.Format("Hasil Penambahan : {0} + {1} = {2}", a, b, cal.Penambahan(a, b)));
            listBox1.Items.Add(string.Format("Hasil Pengurangan : {0} - {1} = {2}", a, b, cal.Pengurangan(a, b)));
            listBox1.Items.Add(string.Format("Hasil Perkalian : {0} * {1} = {2}", a, b, cal.Perkalian(a, b)));
            listBox1.Items.Add(string.Format("Hasil Pembagian : {0} / {1} = {2}", a, b, Calculator.Pembagian(a, b)));
            listBox1.Items.Add(string.Format("Hasil Pangkat : {0} ^ {1} = {2}", a, b, cal.Pangkat(a, b)));
            listBox1.Items.Add(string.Format("Hasil Modulo : {0} % {1} = {2}", a, b, Calculator.Modulo(a, b)));

        }
    }
}
