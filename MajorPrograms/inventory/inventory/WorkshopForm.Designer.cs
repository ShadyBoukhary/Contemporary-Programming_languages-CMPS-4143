namespace inventory
{
    partial class WorkshopForm
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
            this.workshopItemsListBox = new System.Windows.Forms.ListBox();
            this.workshopNameLabel = new System.Windows.Forms.Label();
            this.numberOfItemsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // workshopItemsListBox
            // 
            this.workshopItemsListBox.FormattingEnabled = true;
            this.workshopItemsListBox.ItemHeight = 21;
            this.workshopItemsListBox.Location = new System.Drawing.Point(13, 145);
            this.workshopItemsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.workshopItemsListBox.MultiColumn = true;
            this.workshopItemsListBox.Name = "workshopItemsListBox";
            this.workshopItemsListBox.Size = new System.Drawing.Size(617, 382);
            this.workshopItemsListBox.TabIndex = 0;
            this.workshopItemsListBox.SelectedIndexChanged += new System.EventHandler(this.workshopItemsListBox_SelectedIndexChanged);
            // 
            // workshopNameLabel
            // 
            this.workshopNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workshopNameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.workshopNameLabel.Location = new System.Drawing.Point(29, 9);
            this.workshopNameLabel.Name = "workshopNameLabel";
            this.workshopNameLabel.Size = new System.Drawing.Size(601, 97);
            this.workshopNameLabel.TabIndex = 1;
            this.workshopNameLabel.Text = "Name of the workshop";
            this.workshopNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numberOfItemsLabel
            // 
            this.numberOfItemsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfItemsLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.numberOfItemsLabel.Location = new System.Drawing.Point(9, 119);
            this.numberOfItemsLabel.Name = "numberOfItemsLabel";
            this.numberOfItemsLabel.Size = new System.Drawing.Size(275, 21);
            this.numberOfItemsLabel.TabIndex = 1;
            this.numberOfItemsLabel.Text = "There are 5 items in this workshop";
            this.numberOfItemsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WorkshopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 543);
            this.Controls.Add(this.numberOfItemsLabel);
            this.Controls.Add(this.workshopNameLabel);
            this.Controls.Add(this.workshopItemsListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WorkshopForm";
            this.Text = "Workshop Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkshopForm_FormClosing);
            this.Load += new System.EventHandler(this.WorkshopForm_Load);
            this.Enter += new System.EventHandler(this.WorkshopForm_Enter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox workshopItemsListBox;
        private System.Windows.Forms.Label workshopNameLabel;
        private System.Windows.Forms.Label numberOfItemsLabel;
    }
}