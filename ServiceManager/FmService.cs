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
    public partial class FmService : Form
    {
        public FmService()
        {
            InitializeComponent();
        }

        private void FmService_Load(object sender, EventArgs e)
        {
            dgvService.DataSource = ServiceController.GetServices();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ServiceController sc = new ServiceController();
            string serviceName = dgvService.CurrentRow.Cells["ServiceName"].Value.ToString();
            sc.ServiceName = serviceName;
            try
            {
                if (sc.Status == ServiceControllerStatus.Stopped)
                {
                    //开启服务
                    sc.Start();
                    MessageBox.Show(sc.ServiceName + "服务开启成功");
                }
                else
                {
                    MessageBox.Show(sc.ServiceName + "服务没有停止");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("无法启动该服务");
            }
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ServiceController sc = new ServiceController();
            string serviceName = dgvService.CurrentRow.Cells["ServiceName"].Value.ToString();
            sc.ServiceName = serviceName;
            //如果能关闭
            if (sc.CanStop)
            {
                //如果服务开始了
                if (sc.Status == ServiceControllerStatus.Running)
                {
                    //停止
                    sc.Stop();
                    MessageBox.Show(sc.ServiceName + "服务停止成功");
                }
                else
                {
                    MessageBox.Show(sc.ServiceName + "服务没有运行");
                }
            }
            else
            {
                MessageBox.Show(sc.ServiceName + "服务不能停止");
            }
        
        }
    }
}
