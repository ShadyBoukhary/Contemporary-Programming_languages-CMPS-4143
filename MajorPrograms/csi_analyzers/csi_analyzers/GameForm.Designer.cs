namespace csi_analyzers
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.hurryLabel = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.timerBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.timerProgressBar = new csi_analyzers.CustomProgressBar();
            this.caseInformation = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.caseInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BackgroundImage = global::csi_analyzers.Properties.Resources.room3;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Location = new System.Drawing.Point(989, 156);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(900, 866);
            this.panel.TabIndex = 0;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(982, 92);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(238, 42);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "Time Left:";
            // 
            // hurryLabel
            // 
            this.hurryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hurryLabel.AutoSize = true;
            this.hurryLabel.BackColor = System.Drawing.Color.Transparent;
            this.hurryLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hurryLabel.ForeColor = System.Drawing.Color.White;
            this.hurryLabel.Location = new System.Drawing.Point(1739, 92);
            this.hurryLabel.Name = "hurryLabel";
            this.hurryLabel.Size = new System.Drawing.Size(150, 42);
            this.hurryLabel.TabIndex = 1;
            this.hurryLabel.Text = "Hurry!";
            this.hurryLabel.Visible = false;
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLeftLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLabel.ForeColor = System.Drawing.Color.White;
            this.timeLeftLabel.Location = new System.Drawing.Point(1226, 92);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(110, 42);
            this.timeLeftLabel.TabIndex = 1;
            // 
            // timerBackgroundWorker
            // 
            this.timerBackgroundWorker.WorkerReportsProgress = true;
            this.timerBackgroundWorker.WorkerSupportsCancellation = true;
            this.timerBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.timerBackgroundWorker_DoWork);
            this.timerBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.timerBackgroundWorker_ProgressChanged);
            this.timerBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.timerBackgroundWorker_Completed);
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.timerProgressBar.ForeColor = System.Drawing.Color.Red;
            this.timerProgressBar.Location = new System.Drawing.Point(1342, 92);
            this.timerProgressBar.Name = "timerProgressBar";
            this.timerProgressBar.Size = new System.Drawing.Size(329, 42);
            this.timerProgressBar.Step = 1;
            this.timerProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.timerProgressBar.TabIndex = 2;
            this.timerProgressBar.Value = 100;
            // 
            // caseInformation
            // 
            this.caseInformation.AutoSize = true;
            this.caseInformation.BackColor = System.Drawing.Color.Transparent;
            this.caseInformation.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseInformation.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.caseInformation.Location = new System.Drawing.Point(32, 34);
            this.caseInformation.Name = "caseInformation";
            this.caseInformation.Size = new System.Drawing.Size(678, 42);
            this.caseInformation.TabIndex = 1;
            this.caseInformation.Text = "Officer Max Payne Murder Scene";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(39, 457);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 277);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // caseInformationGroupBox
            // 
            this.caseInformationGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.caseInformationGroupBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseInformationGroupBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.caseInformationGroupBox.Location = new System.Drawing.Point(39, 156);
            this.caseInformationGroupBox.Name = "caseInformationGroupBox";
            this.caseInformationGroupBox.Size = new System.Drawing.Size(434, 277);
            this.caseInformationGroupBox.TabIndex = 3;
            this.caseInformationGroupBox.TabStop = false;
            this.caseInformationGroupBox.Text = "Case Information";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(34, 995);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Press Escape to open menu";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::csi_analyzers.Properties.Resources.backgroung;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.caseInformationGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.timerProgressBar);
            this.Controls.Add(this.hurryLabel);
            this.Controls.Add(this.timeLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caseInformation);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label hurryLabel;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.ComponentModel.BackgroundWorker timerBackgroundWorker;
        private CustomProgressBar timerProgressBar;
        private System.Windows.Forms.Label caseInformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox caseInformationGroupBox;
        private System.Windows.Forms.Label label1;
    }
}