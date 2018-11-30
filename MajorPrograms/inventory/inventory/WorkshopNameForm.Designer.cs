namespace inventory
{
    partial class WorkshopNameForm
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
            this.workshopNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createWorkshopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workshopNameTextBox
            // 
            this.workshopNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workshopNameTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.workshopNameTextBox.Location = new System.Drawing.Point(55, 115);
            this.workshopNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.workshopNameTextBox.Name = "workshopNameTextBox";
            this.workshopNameTextBox.Size = new System.Drawing.Size(319, 29);
            this.workshopNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the workshop name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // createWorkshopButton
            // 
            this.createWorkshopButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.createWorkshopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createWorkshopButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createWorkshopButton.ForeColor = System.Drawing.Color.White;
            this.createWorkshopButton.Location = new System.Drawing.Point(55, 166);
            this.createWorkshopButton.Name = "createWorkshopButton";
            this.createWorkshopButton.Size = new System.Drawing.Size(319, 56);
            this.createWorkshopButton.TabIndex = 2;
            this.createWorkshopButton.Text = "Create Workshop";
            this.createWorkshopButton.UseVisualStyleBackColor = false;
            this.createWorkshopButton.Click += new System.EventHandler(this.createWorkshopButton_Click);
            // 
            // WorkshopNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 234);
            this.Controls.Add(this.createWorkshopButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workshopNameTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WorkshopNameForm";
            this.Text = "New Workshop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox workshopNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createWorkshopButton;
    }
}