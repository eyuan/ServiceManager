using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Windows.Forms;

namespace ServiceManager
{
    public partial class FmDevice : Form
    {
        public FmDevice()
        {
            InitializeComponent();
        }

        private void FmDevice_Load(object sender, EventArgs e)
        {
            dgvDevice.DataSource = ServiceController.GetDevices();
        }
    }
}
