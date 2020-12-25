using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using Exercise2_004_Nanda_yudha_pratama;

namespace ServerConfigRest_004_Nanda_yudha_pratama
{
    public partial class Form1 : Form
    {
        ServiceHost hostObjek;

        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hostObjek = null;

            try
            {
                Task.Factory.StartNew(() =>
                {
                    hostObjek = new ServiceHost(typeof(TI_UMY));
                    hostObjek.Open();
                });
                label3.Text = "ON";
                label4.Text = "Tekan OFF Untuk Mematikan";
                button1.Enabled = false;
                button2.Enabled = true;
            }
            catch (Exception ex)
            {
                hostObjek = null;
                label2.Text = "Server Error";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                hostObjek.Abort();
                label3.Text = "OFF";
                label4.Text = "Tekan ON Untuk Menghidupkan";
                button1.Enabled = true;
                button2.Enabled = false;
            }
            catch (Exception ex)
            {
                button1.Enabled = false;
                button2.Enabled = true;
                label2.Text = "Server Error";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
