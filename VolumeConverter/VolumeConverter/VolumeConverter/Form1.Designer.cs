
using System;

namespace VolumeConverter
{
    partial class volumeConverter
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
            this.convertClTitleLabel = new System.Windows.Forms.Label();
            this.clLabel = new System.Windows.Forms.Label();
            this.litreLabel = new System.Windows.Forms.Label();
            this.clTextBox = new System.Windows.Forms.TextBox();
            this.litreTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // convertClTitleLabel
            // 
            this.convertClTitleLabel.AutoSize = true;
            this.convertClTitleLabel.Location = new System.Drawing.Point(270, 91);
            this.convertClTitleLabel.Name = "convertClTitleLabel";
            this.convertClTitleLabel.Size = new System.Drawing.Size(95, 13);
            this.convertClTitleLabel.TabIndex = 0;
            this.convertClTitleLabel.Text = "Convert CL to Litre";
            // 
            // clLabel
            // 
            this.clLabel.AutoSize = true;
            this.clLabel.Location = new System.Drawing.Point(446, 152);
            this.clLabel.Name = "clLabel";
            this.clLabel.Size = new System.Drawing.Size(20, 13);
            this.clLabel.TabIndex = 1;
            this.clLabel.Text = "CL";
            this.clLabel.Click += new System.EventHandler(this.clTextBox_Click);
            // 
            // litreLabel
            // 
            this.litreLabel.AutoSize = true;
            this.litreLabel.Location = new System.Drawing.Point(446, 222);
            this.litreLabel.Name = "litreLabel";
            this.litreLabel.Size = new System.Drawing.Size(27, 13);
            this.litreLabel.TabIndex = 2;
            this.litreLabel.Text = "Litre";
            // 
            // clTextBox
            // 
            this.clTextBox.Location = new System.Drawing.Point(273, 152);
            this.clTextBox.Name = "clTextBox";
            this.clTextBox.Size = new System.Drawing.Size(100, 20);
            this.clTextBox.TabIndex = 3;
            this.clTextBox.TextChanged += new System.EventHandler(this.clTextBox_TextChanged);
            // 
            // litreTextBox
            // 
            this.litreTextBox.Location = new System.Drawing.Point(273, 222);
            this.litreTextBox.Name = "litreTextBox";
            this.litreTextBox.Size = new System.Drawing.Size(100, 20);
            this.litreTextBox.TabIndex = 4;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(273, 289);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(376, 289);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // volumeConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.litreTextBox);
            this.Controls.Add(this.clTextBox);
            this.Controls.Add(this.litreLabel);
            this.Controls.Add(this.clLabel);
            this.Controls.Add(this.convertClTitleLabel);
            this.Name = "volumeConverter";
            this.Text = "Volume Converter CL to Litre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void clTextBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void clTextBox_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label convertClTitleLabel;
        private System.Windows.Forms.Label clLabel;
        private System.Windows.Forms.Label litreLabel;
        private System.Windows.Forms.TextBox clTextBox;
        private System.Windows.Forms.TextBox litreTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
    }
}

