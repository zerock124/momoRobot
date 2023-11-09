namespace momorobots
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenWeb = new System.Windows.Forms.Button();
            this.btnActionStart = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labProcess = new System.Windows.Forms.Label();
            this.btnActionStartOne = new System.Windows.Forms.Button();
            this.btn_GetCoupon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenWeb
            // 
            this.btnOpenWeb.Location = new System.Drawing.Point(15, 20);
            this.btnOpenWeb.Margin = new System.Windows.Forms.Padding(5);
            this.btnOpenWeb.Name = "btnOpenWeb";
            this.btnOpenWeb.Size = new System.Drawing.Size(205, 25);
            this.btnOpenWeb.TabIndex = 0;
            this.btnOpenWeb.Text = "開啟Chrome";
            this.btnOpenWeb.UseVisualStyleBackColor = true;
            this.btnOpenWeb.Click += new System.EventHandler(this.btnOpenWeb_Click);
            // 
            // btnActionStart
            // 
            this.btnActionStart.Location = new System.Drawing.Point(15, 100);
            this.btnActionStart.Margin = new System.Windows.Forms.Padding(5);
            this.btnActionStart.Name = "btnActionStart";
            this.btnActionStart.Size = new System.Drawing.Size(205, 25);
            this.btnActionStart.TabIndex = 1;
            this.btnActionStart.Text = "執行暫緩排程";
            this.btnActionStart.UseVisualStyleBackColor = true;
            this.btnActionStart.Click += new System.EventHandler(this.btnActionStart_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 140);
            this.progressBar.Margin = new System.Windows.Forms.Padding(5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(205, 50);
            this.progressBar.TabIndex = 2;
            // 
            // labProcess
            // 
            this.labProcess.AutoSize = true;
            this.labProcess.Location = new System.Drawing.Point(107, 158);
            this.labProcess.Name = "labProcess";
            this.labProcess.Size = new System.Drawing.Size(32, 15);
            this.labProcess.TabIndex = 3;
            this.labProcess.Text = "0 / 0";
            this.labProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnActionStartOne
            // 
            this.btnActionStartOne.Location = new System.Drawing.Point(15, 60);
            this.btnActionStartOne.Margin = new System.Windows.Forms.Padding(5);
            this.btnActionStartOne.Name = "btnActionStartOne";
            this.btnActionStartOne.Size = new System.Drawing.Size(205, 25);
            this.btnActionStartOne.TabIndex = 4;
            this.btnActionStartOne.Text = "執行暫緩一筆";
            this.btnActionStartOne.UseVisualStyleBackColor = true;
            this.btnActionStartOne.Click += new System.EventHandler(this.btnActionStartOne_Click);
            // 
            // btn_GetCoupon
            // 
            this.btn_GetCoupon.Location = new System.Drawing.Point(15, 247);
            this.btn_GetCoupon.Margin = new System.Windows.Forms.Padding(5);
            this.btn_GetCoupon.Name = "btn_GetCoupon";
            this.btn_GetCoupon.Size = new System.Drawing.Size(205, 25);
            this.btn_GetCoupon.TabIndex = 5;
            this.btn_GetCoupon.Text = "點擊優惠劵";
            this.btn_GetCoupon.UseVisualStyleBackColor = true;
            this.btn_GetCoupon.Click += new System.EventHandler(this.btn_GetCoupon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 286);
            this.Controls.Add(this.btn_GetCoupon);
            this.Controls.Add(this.btnActionStartOne);
            this.Controls.Add(this.labProcess);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnActionStart);
            this.Controls.Add(this.btnOpenWeb);
            this.Name = "Form1";
            this.Text = "暫緩機器人";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOpenWeb;
        private Button btnActionStart;
        private ProgressBar progressBar;
        private Label labProcess;
        private Button btnActionStartOne;
        private Button btn_GetCoupon;
    }
}