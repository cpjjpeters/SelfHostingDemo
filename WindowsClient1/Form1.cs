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

namespace WindowsClient1
{
    public partial class Form1 : Form
    {
        private IMathService channel = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var endPoint = new EndpointAddress("http://localhost:4444/MathService");

            channel = ChannelFactory<IMathService>.CreateChannel(new BasicHttpBinding(), endPoint);
        }
    }
}
