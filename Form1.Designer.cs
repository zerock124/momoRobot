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
            btnOpenWeb = new Button();
            btnActionStart = new Button();
            progressBar = new ProgressBar();
            labProcess = new Label();
            SuspendLayout();
            // 
            // btnOpenWeb
            // 
            btnOpenWeb.Location = new Point(12, 12);
            btnOpenWeb.Name = "btnOpenWeb";
            btnOpenWeb.Size = new Size(219, 23);
            btnOpenWeb.TabIndex = 0;
            btnOpenWeb.Text = "開啟Chrome";
            btnOpenWeb.UseVisualStyleBackColor = true;
            btnOpenWeb.Click += btnOpenWeb_Click;
            // 
            // btnActionStart
            // 
            btnActionStart.Location = new Point(13, 45);
            btnActionStart.Name = "btnActionStart";
            btnActionStart.Size = new Size(218, 23);
            btnActionStart.TabIndex = 1;
            btnActionStart.Text = "開始暫緩排程";
            btnActionStart.UseVisualStyleBackColor = true;
            btnActionStart.Click += btnActionStart_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(14, 85);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(217, 43);
            progressBar.TabIndex = 2;
            // 
            // labProcess
            // 
            labProcess.AutoSize = true;
            labProcess.Location = new Point(103, 98);
            labProcess.Name = "labProcess";
            labProcess.Size = new Size(32, 15);
            labProcess.TabIndex = 3;
            labProcess.Text = "0 / 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 140);
            Controls.Add(labProcess);
            Controls.Add(progressBar);
            Controls.Add(btnActionStart);
            Controls.Add(btnOpenWeb);
            Name = "Form1";
            Text = "暫緩機器人";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenWeb;
        private Button btnActionStart;
        private ProgressBar progressBar;
        private Label labProcess;
    }
}