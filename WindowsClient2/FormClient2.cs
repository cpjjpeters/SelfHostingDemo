﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathServiceLibrary;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WindowsClient2
{
    public partial class FormClient2 : Form
    {
        private IMathService channel = null;

        public FormClient2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var endPoint = new EndpointAddress("http://localhost:5555/MathService");

            channel = ChannelFactory<IMathService>.CreateChannel(new BasicHttpBinding(), endPoint);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyNumbers obj = new MyNumbers();
            obj.Number1 = Convert.ToInt32(textBox1.Text);
            obj.Number2 = Convert.ToInt32(textBox2.Text);
            try
            {
                textBox3.Text = channel.Add(obj).ToString();
            }
            catch (Exception)
            {

                Console.WriteLine("exception  ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyNumbers obj = new MyNumbers();
            obj.Number1 = Convert.ToInt32(textBox1.Text);
            obj.Number2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = channel.Subtract(obj).ToString();
        }
    }
}