namespace AnimationApp
{
    partial class DrawingForm
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
            this.draw = new System.Windows.Forms.Button();
            this.drawButton = new System.Windows.Forms.Button();
            this.animator = new System.ComponentModel.BackgroundWorker();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.draw);
            this.panel.Location = new System.Drawing.Point(3, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1920, 1080);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_OnPaint);
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(1555, 24);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(310, 46);
            this.draw.TabIndex = 0;
            this.draw.Text = "Draw";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // drawButton
            // 
            this.drawButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drawButton.Location = new System.Drawing.Point(2843, 25);
            this.drawButton.Margin = new System.Windows.Forms.Padding(5);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(290, 58);
            this.drawButton.TabIndex = 1;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            // 
            // animator
            // 
            this.animator.WorkerReportsProgress = true;
            this.animator.WorkerSupportsCancellation = true;
            this.animator.DoWork += new System.ComponentModel.DoWorkEventHandler(this.animator_DoWork);
            this.animator.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.animator_ProgressChanged);
            this.animator.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.animator_Completed);
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Name = "DrawingForm";
            this.Text = "Drawing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button draw;
        private System.ComponentModel.BackgroundWorker animator;
    }
}

