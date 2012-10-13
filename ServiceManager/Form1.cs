using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;

namespace ServiceManager
{
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();
        }


        private void btnService_Click(object sender, EventArgs e)
        {
            Form fmService = new FmService();
            fmService.Show();
        }

        private void btnDevice_Click(object sender, EventArgs e)
        {
            Form fmDevice = new FmDevice();
            fmDevice.Show();
        }

        private void FmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
