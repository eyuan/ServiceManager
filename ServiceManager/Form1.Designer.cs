namespace ServiceManager
{
    partial class FmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnService = new System.Windows.Forms.Button();
            this.btnDevice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(44, 59);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(75, 23);
            this.btnService.TabIndex = 0;
            this.btnService.Text = "服务";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnDevice
            // 
            this.btnDevice.Location = new System.Drawing.Point(206, 59);
            this.btnDevice.Name = "btnDevice";
            this.btnDevice.Size = new System.Drawing.Size(75, 23);
            this.btnDevice.TabIndex = 1;
            this.btnDevice.Text = "设备";
            this.btnDevice.UseVisualStyleBackColor = true;
            this.btnDevice.Click += new System.EventHandler(this.btnDevice_Click);
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 468);
            this.Controls.Add(this.btnDevice);
            this.Controls.Add(this.btnService);
            this.Name = "FmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnDevice;

    }
}

