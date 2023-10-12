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
            btnActionStartOne = new Button();
            SuspendLayout();
            // 
            // btnOpenWeb
            // 
            btnOpenWeb.Location = new Point(15, 20);
            btnOpenWeb.Margin = new Padding(5);
            btnOpenWeb.Name = "btnOpenWeb";
            btnOpenWeb.Size = new Size(205, 25);
            btnOpenWeb.TabIndex = 0;
            btnOpenWeb.Text = "開啟Chrome";
            btnOpenWeb.UseVisualStyleBackColor = true;
            btnOpenWeb.Click += btnOpenWeb_Click;
            // 
            // btnActionStart
            // 
            btnActionStart.Location = new Point(15, 100);
            btnActionStart.Margin = new Padding(5);
            btnActionStart.Name = "btnActionStart";
            btnActionStart.Size = new Size(205, 25);
            btnActionStart.TabIndex = 1;
            btnActionStart.Text = "執行暫緩排程";
            btnActionStart.UseVisualStyleBackColor = true;
            btnActionStart.Click += btnActionStart_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(15, 140);
            progressBar.Margin = new Padding(5);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(205, 50);
            progressBar.TabIndex = 2;
            // 
            // labProcess
            // 
            labProcess.AutoSize = true;
            labProcess.Location = new Point(107, 158);
            labProcess.Name = "labProcess";
            labProcess.Size = new Size(32, 15);
            labProcess.TabIndex = 3;
            labProcess.Text = "0 / 0";
            labProcess.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnActionStartOne
            // 
            btnActionStartOne.Location = new Point(15, 60);
            btnActionStartOne.Margin = new Padding(5);
            btnActionStartOne.Name = "btnActionStartOne";
            btnActionStartOne.Size = new Size(205, 25);
            btnActionStartOne.TabIndex = 4;
            btnActionStartOne.Text = "執行暫緩一筆";
            btnActionStartOne.UseVisualStyleBackColor = true;
            btnActionStartOne.Click += btnActionStartOne_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 211);
            Controls.Add(btnActionStartOne);
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
        private Button btnActionStartOne;
    }
}