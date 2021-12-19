using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeGeneration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qR = new QRCodeGenerator();
            QRCodeData data = qR.CreateQrCode(txtText.Text,QRCodeGenerator.ECCLevel.Q);
            QRCode rCode = new QRCode(data);
            picQRCode.Image = rCode.GetGraphic(5);
        }

        private void picQRCode_Click(object sender, EventArgs e)
        {
            if(picQRCode.Image!=null)
            {
                Process.Start(txtText.Text);
            }
        }
    }
}
