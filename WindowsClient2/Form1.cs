using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathfServiceLibrary;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WindowsClient2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MathServiceReference.MyNumbers obj = new MathServiceReference.MyNumbers();
            obj.Number1 = Convert.ToInt32(textBox1.Text);
            obj.Number2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = proxy.Add(obj).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MathServiceReference.MyNumbers obj = new MathServiceReference.MyNumbers();
            obj.Number1 = Convert.ToInt32(textBox1.Text);
            obj.Number2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = proxy.Subtract(obj).ToString();
        }
    }
}
