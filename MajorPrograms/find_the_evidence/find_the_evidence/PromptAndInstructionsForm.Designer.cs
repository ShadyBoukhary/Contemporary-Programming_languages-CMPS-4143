namespace find_the_evidence
{
    partial class PromptAndInstructionsForm
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
            this.gameLabel = new System.Windows.Forms.Label();
            this.rowSlider = new System.Windows.Forms.TrackBar();
            this.playButton = new System.Windows.Forms.Button();
            this.rowSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.columnSizeIndicatorLabel = new System.Windows.Forms.Label();
            this.rowSizeIndicatorLabel = new System.Windows.Forms.Label();
            this.columnSlider = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.randomCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.rowSlider)).BeginInit();
            this.rowSizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gameLabel.Location = new System.Drawing.Point(180, 9);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(286, 31);
            this.gameLabel.TabIndex = 0;
            this.gameLabel.Text = "Find the Evidence";
            // 
            // rowSlider
            // 
            this.rowSlider.Location = new System.Drawing.Point(15, 49);
            this.rowSlider.Minimum = 3;
            this.rowSlider.Name = "rowSlider";
            this.rowSlider.Size = new System.Drawing.Size(250, 45);
            this.rowSlider.TabIndex = 1;
            this.rowSlider.Value = 3;
            this.rowSlider.Scroll += new System.EventHandler(this.rowSlider_Scroll);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(342, 322);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(271, 51);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // rowSizeGroupBox
            // 
            this.rowSizeGroupBox.Controls.Add(this.columnSizeIndicatorLabel);
            this.rowSizeGroupBox.Controls.Add(this.rowSizeIndicatorLabel);
            this.rowSizeGroupBox.Controls.Add(this.columnSlider);
            this.rowSizeGroupBox.Controls.Add(this.label2);
            this.rowSizeGroupBox.Controls.Add(this.label1);
            this.rowSizeGroupBox.Controls.Add(this.rowSlider);
            this.rowSizeGroupBox.Location = new System.Drawing.Point(342, 88);
            this.rowSizeGroupBox.Name = "rowSizeGroupBox";
            this.rowSizeGroupBox.Size = new System.Drawing.Size(271, 194);
            this.rowSizeGroupBox.TabIndex = 5;
            this.rowSizeGroupBox.TabStop = false;
            this.rowSizeGroupBox.Text = "Options";
            // 
            // columnSizeIndicatorLabel
            // 
            this.columnSizeIndicatorLabel.Location = new System.Drawing.Point(218, 164);
            this.columnSizeIndicatorLabel.Name = "columnSizeIndicatorLabel";
            this.columnSizeIndicatorLabel.Size = new System.Drawing.Size(47, 12);
            this.columnSizeIndicatorLabel.TabIndex = 7;
            this.columnSizeIndicatorLabel.Text = "3";
            this.columnSizeIndicatorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rowSizeIndicatorLabel
            // 
            this.rowSizeIndicatorLabel.Location = new System.Drawing.Point(230, 81);
            this.rowSizeIndicatorLabel.Name = "rowSizeIndicatorLabel";
            this.rowSizeIndicatorLabel.Size = new System.Drawing.Size(35, 13);
            this.rowSizeIndicatorLabel.TabIndex = 5;
            this.rowSizeIndicatorLabel.Text = "3";
            this.rowSizeIndicatorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // columnSlider
            // 
            this.columnSlider.Location = new System.Drawing.Point(15, 131);
            this.columnSlider.Minimum = 3;
            this.columnSlider.Name = "columnSlider";
            this.columnSlider.Size = new System.Drawing.Size(250, 45);
            this.columnSlider.TabIndex = 4;
            this.columnSlider.Value = 3;
            this.columnSlider.Scroll += new System.EventHandler(this.columnSlider_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Columns";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Rows";
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.ForeColor = System.Drawing.Color.Black;
            this.instructionsLabel.Location = new System.Drawing.Point(12, 88);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(280, 273);
            this.instructionsLabel.TabIndex = 6;
            this.instructionsLabel.Text = "Instructions";
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // randomCheckBox
            // 
            this.randomCheckBox.AutoSize = true;
            this.randomCheckBox.Location = new System.Drawing.Point(512, 288);
            this.randomCheckBox.Name = "randomCheckBox";
            this.randomCheckBox.Size = new System.Drawing.Size(101, 16);
            this.randomCheckBox.TabIndex = 5;
            this.randomCheckBox.Text = "Random Size";
            this.randomCheckBox.UseVisualStyleBackColor = true;
            this.randomCheckBox.CheckedChanged += new System.EventHandler(this.randomCheckBox_CheckedChanged);
            // 
            // PromptAndInstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 385);
            this.Controls.Add(this.randomCheckBox);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.rowSizeGroupBox);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.gameLabel);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PromptAndInstructionsForm";
            this.Text = "Find the Evidence";
            ((System.ComponentModel.ISupportInitialize)(this.rowSlider)).EndInit();
            this.rowSizeGroupBox.ResumeLayout(false);
            this.rowSizeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.TrackBar rowSlider;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.GroupBox rowSizeGroupBox;
        private System.Windows.Forms.CheckBox randomCheckBox;
        private System.Windows.Forms.TrackBar columnSlider;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label columnSizeIndicatorLabel;
        private System.Windows.Forms.Label rowSizeIndicatorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

