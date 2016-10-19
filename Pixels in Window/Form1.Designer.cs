namespace Pixels_in_Window
{
    partial class Form1
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
            this.pixelsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pixelsLabel
            // 
            this.pixelsLabel.AutoSize = true;
            this.pixelsLabel.Location = new System.Drawing.Point(13, 13);
            this.pixelsLabel.Name = "pixelsLabel";
            this.pixelsLabel.Size = new System.Drawing.Size(130, 20);
            this.pixelsLabel.TabIndex = 0;
            this.pixelsLabel.Text = "Pixel in window = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.pixelsLabel);
            this.Name = "Form1";
            this.Text = "Pixel Count";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pixelsLabel;
    }
}

