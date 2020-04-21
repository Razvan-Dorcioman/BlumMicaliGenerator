namespace BigNumberGenerator
{
    partial class MainForm
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
            this.generateButton = new System.Windows.Forms.Button();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mbLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(12, 12);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 20);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(146, 16);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(30, 13);
            this.sizeLabel.TabIndex = 1;
            this.sizeLabel.Text = "Size:";
            // 
            // sizeNumericUpDown
            // 
            this.sizeNumericUpDown.Location = new System.Drawing.Point(182, 12);
            this.sizeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sizeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeNumericUpDown.Name = "sizeNumericUpDown";
            this.sizeNumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.sizeNumericUpDown.TabIndex = 2;
            this.sizeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mbLabel
            // 
            this.mbLabel.AutoSize = true;
            this.mbLabel.Location = new System.Drawing.Point(249, 16);
            this.mbLabel.Name = "mbLabel";
            this.mbLabel.Size = new System.Drawing.Size(23, 13);
            this.mbLabel.TabIndex = 3;
            this.mbLabel.Text = "MB";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 52);
            this.Controls.Add(this.mbLabel);
            this.Controls.Add(this.sizeNumericUpDown);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.generateButton);
            this.Name = "MainForm";
            this.Text = "Big Number Generator";
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.NumericUpDown sizeNumericUpDown;
        private System.Windows.Forms.Label mbLabel;
    }
}

