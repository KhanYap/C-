namespace Morse_Code
{
    partial class Legend
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
            this.txt_legend = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_legend
            // 
            this.txt_legend.Location = new System.Drawing.Point(12, 12);
            this.txt_legend.Multiline = true;
            this.txt_legend.Name = "txt_legend";
            this.txt_legend.ReadOnly = true;
            this.txt_legend.Size = new System.Drawing.Size(246, 598);
            this.txt_legend.TabIndex = 0;
            // 
            // Legend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 622);
            this.Controls.Add(this.txt_legend);
            this.Name = "Legend";
            this.Text = "Legend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_legend;
    }
}