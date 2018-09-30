namespace find_the_evidence
{
    partial class FindSampleGame
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
            this.gridTextBox = new System.Windows.Forms.TextBox();
            this.submitGuessButton = new System.Windows.Forms.Button();
            this.rowGuessTextBox = new System.Windows.Forms.TextBox();
            this.columnGuessTextBox = new System.Windows.Forms.TextBox();
            this.guessLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coordinatesBox = new System.Windows.Forms.GroupBox();
            this.statsBox = new System.Windows.Forms.GroupBox();
            this.hitsLabel = new System.Windows.Forms.Label();
            this.guessCounterLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitGameButton = new System.Windows.Forms.Button();
            this.coordinatesBox.SuspendLayout();
            this.statsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridTextBox
            // 
            this.gridTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridTextBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridTextBox.Location = new System.Drawing.Point(344, 36);
            this.gridTextBox.Multiline = true;
            this.gridTextBox.Name = "gridTextBox";
            this.gridTextBox.ReadOnly = true;
            this.gridTextBox.Size = new System.Drawing.Size(171, 231);
            this.gridTextBox.TabIndex = 0;
            // 
            // submitGuessButton
            // 
            this.submitGuessButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.submitGuessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitGuessButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitGuessButton.ForeColor = System.Drawing.Color.White;
            this.submitGuessButton.Location = new System.Drawing.Point(70, 286);
            this.submitGuessButton.Name = "submitGuessButton";
            this.submitGuessButton.Size = new System.Drawing.Size(226, 38);
            this.submitGuessButton.TabIndex = 1;
            this.submitGuessButton.Text = "Submit Guess";
            this.submitGuessButton.UseVisualStyleBackColor = false;
            this.submitGuessButton.Click += new System.EventHandler(this.submitGuessButton_Click);
            // 
            // rowGuessTextBox
            // 
            this.rowGuessTextBox.Location = new System.Drawing.Point(140, 24);
            this.rowGuessTextBox.Name = "rowGuessTextBox";
            this.rowGuessTextBox.Size = new System.Drawing.Size(80, 20);
            this.rowGuessTextBox.TabIndex = 2;
            // 
            // columnGuessTextBox
            // 
            this.columnGuessTextBox.Location = new System.Drawing.Point(140, 61);
            this.columnGuessTextBox.Name = "columnGuessTextBox";
            this.columnGuessTextBox.Size = new System.Drawing.Size(80, 20);
            this.columnGuessTextBox.TabIndex = 3;
            // 
            // guessLabel
            // 
            this.guessLabel.Location = new System.Drawing.Point(154, 32);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(66, 12);
            this.guessLabel.TabIndex = 4;
            this.guessLabel.Text = "none";
            this.guessLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "X-Coordinate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y-Coordinate";
            // 
            // coordinatesBox
            // 
            this.coordinatesBox.Controls.Add(this.rowGuessTextBox);
            this.coordinatesBox.Controls.Add(this.label2);
            this.coordinatesBox.Controls.Add(this.columnGuessTextBox);
            this.coordinatesBox.Controls.Add(this.label1);
            this.coordinatesBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coordinatesBox.Location = new System.Drawing.Point(70, 36);
            this.coordinatesBox.Name = "coordinatesBox";
            this.coordinatesBox.Size = new System.Drawing.Size(226, 100);
            this.coordinatesBox.TabIndex = 7;
            this.coordinatesBox.TabStop = false;
            this.coordinatesBox.Text = "Coordinates";
            // 
            // statsBox
            // 
            this.statsBox.Controls.Add(this.hitsLabel);
            this.statsBox.Controls.Add(this.guessCounterLabel);
            this.statsBox.Controls.Add(this.label5);
            this.statsBox.Controls.Add(this.label4);
            this.statsBox.Controls.Add(this.label3);
            this.statsBox.Controls.Add(this.guessLabel);
            this.statsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsBox.Location = new System.Drawing.Point(70, 142);
            this.statsBox.Name = "statsBox";
            this.statsBox.Size = new System.Drawing.Size(226, 125);
            this.statsBox.TabIndex = 8;
            this.statsBox.TabStop = false;
            this.statsBox.Text = "Stats";
            // 
            // hitsLabel
            // 
            this.hitsLabel.Location = new System.Drawing.Point(185, 95);
            this.hitsLabel.Name = "hitsLabel";
            this.hitsLabel.Size = new System.Drawing.Size(35, 13);
            this.hitsLabel.TabIndex = 9;
            this.hitsLabel.Text = "0";
            this.hitsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // guessCounterLabel
            // 
            this.guessCounterLabel.Location = new System.Drawing.Point(185, 65);
            this.guessCounterLabel.Name = "guessCounterLabel";
            this.guessCounterLabel.Size = new System.Drawing.Size(35, 13);
            this.guessCounterLabel.TabIndex = 8;
            this.guessCounterLabel.Text = "0";
            this.guessCounterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(23, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Clues Found";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Guesses #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Guess";
            // 
            // exitGameButton
            // 
            this.exitGameButton.BackColor = System.Drawing.Color.Transparent;
            this.exitGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitGameButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitGameButton.ForeColor = System.Drawing.Color.Red;
            this.exitGameButton.Location = new System.Drawing.Point(386, 296);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.Size = new System.Drawing.Size(75, 23);
            this.exitGameButton.TabIndex = 9;
            this.exitGameButton.Text = "Give Up";
            this.exitGameButton.UseVisualStyleBackColor = false;
            this.exitGameButton.Click += new System.EventHandler(this.exitGameButton_Click);
            // 
            // FindSampleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 342);
            this.Controls.Add(this.exitGameButton);
            this.Controls.Add(this.statsBox);
            this.Controls.Add(this.coordinatesBox);
            this.Controls.Add(this.submitGuessButton);
            this.Controls.Add(this.gridTextBox);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FindSampleGame";
            this.Text = "Find the Evidence";
            this.coordinatesBox.ResumeLayout(false);
            this.coordinatesBox.PerformLayout();
            this.statsBox.ResumeLayout(false);
            this.statsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gridTextBox;
        private System.Windows.Forms.Button submitGuessButton;
        private System.Windows.Forms.TextBox rowGuessTextBox;
        private System.Windows.Forms.TextBox columnGuessTextBox;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox coordinatesBox;
        private System.Windows.Forms.GroupBox statsBox;
        private System.Windows.Forms.Label hitsLabel;
        private System.Windows.Forms.Label guessCounterLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitGameButton;
    }
}