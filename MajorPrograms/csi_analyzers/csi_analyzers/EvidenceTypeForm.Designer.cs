namespace csi_analyzers
{
    partial class EvidenceTypeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.fingerprintsButton = new System.Windows.Forms.Button();
            this.hairButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(62, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1074, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "What type of evidence would you like to collect?";
            // 
            // fingerprintsButton
            // 
            this.fingerprintsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fingerprintsButton.BackColor = System.Drawing.Color.Transparent;
            this.fingerprintsButton.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.fingerprintsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.fingerprintsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fingerprintsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fingerprintsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fingerprintsButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fingerprintsButton.ForeColor = System.Drawing.Color.White;
            this.fingerprintsButton.Location = new System.Drawing.Point(146, 422);
            this.fingerprintsButton.Name = "fingerprintsButton";
            this.fingerprintsButton.Size = new System.Drawing.Size(209, 55);
            this.fingerprintsButton.TabIndex = 1;
            this.fingerprintsButton.Text = "Fingerprints";
            this.fingerprintsButton.UseVisualStyleBackColor = false;
            this.fingerprintsButton.Click += new System.EventHandler(this.buttons_Click);
            this.fingerprintsButton.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.fingerprintsButton.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // hairButton
            // 
            this.hairButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hairButton.BackColor = System.Drawing.Color.Transparent;
            this.hairButton.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.hairButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.hairButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hairButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hairButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hairButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hairButton.ForeColor = System.Drawing.Color.White;
            this.hairButton.Location = new System.Drawing.Point(496, 422);
            this.hairButton.Name = "hairButton";
            this.hairButton.Size = new System.Drawing.Size(209, 55);
            this.hairButton.TabIndex = 1;
            this.hairButton.Text = "Hair";
            this.hairButton.UseVisualStyleBackColor = false;
            this.hairButton.Click += new System.EventHandler(this.buttons_Click);
            this.hairButton.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.hairButton.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(839, 422);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 55);
            this.button3.TabIndex = 1;
            this.button3.Text = "Something";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttons_Click);
            this.button3.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // EvidenceTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::csi_analyzers.Properties.Resources.backgroung;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1185, 660);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.hairButton);
            this.Controls.Add(this.fingerprintsButton);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EvidenceTypeForm";
            this.Text = "EvidenceTypeForm";
            this.Click += new System.EventHandler(this.buttons_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fingerprintsButton;
        private System.Windows.Forms.Button hairButton;
        private System.Windows.Forms.Button button3;
    }
}