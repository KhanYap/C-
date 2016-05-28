namespace Morse_Code
{
    partial class Morse_Win
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
            this.components = new System.ComponentModel.Container();
            this.txt_character = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_morse = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_string = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.legendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.legendToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.legendToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_character
            // 
            this.txt_character.Location = new System.Drawing.Point(127, 62);
            this.txt_character.Name = "txt_character";
            this.txt_character.Size = new System.Drawing.Size(176, 26);
            this.txt_character.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Morse Code";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(12, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Character";
            // 
            // txt_morse
            // 
            this.txt_morse.Location = new System.Drawing.Point(127, 159);
            this.txt_morse.Name = "txt_morse";
            this.txt_morse.Size = new System.Drawing.Size(179, 26);
            this.txt_morse.TabIndex = 4;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(76, 94);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(173, 38);
            this.btn_convert.TabIndex = 5;
            this.btn_convert.Text = "Convert to Morse";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // btn_string
            // 
            this.btn_string.Location = new System.Drawing.Point(76, 205);
            this.btn_string.Name = "btn_string";
            this.btn_string.Size = new System.Drawing.Size(173, 38);
            this.btn_string.TabIndex = 6;
            this.btn_string.Text = "Convert to Character";
            this.btn_string.UseVisualStyleBackColor = true;
            this.btn_string.Click += new System.EventHandler(this.btn_string_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.legendToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 34);
            // 
            // legendToolStripMenuItem
            // 
            this.legendToolStripMenuItem.Name = "legendToolStripMenuItem";
            this.legendToolStripMenuItem.Size = new System.Drawing.Size(155, 30);
            this.legendToolStripMenuItem.Text = "Legend";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.legendToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(356, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // legendToolStripMenuItem1
            // 
            this.legendToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.legendToolStripMenuItem2});
            this.legendToolStripMenuItem1.Name = "legendToolStripMenuItem1";
            this.legendToolStripMenuItem1.Size = new System.Drawing.Size(61, 29);
            this.legendToolStripMenuItem1.Text = "Help";
            // 
            // legendToolStripMenuItem2
            // 
            this.legendToolStripMenuItem2.Name = "legendToolStripMenuItem2";
            this.legendToolStripMenuItem2.Size = new System.Drawing.Size(211, 30);
            this.legendToolStripMenuItem2.Text = "Legend";
            this.legendToolStripMenuItem2.Click += new System.EventHandler(this.legendToolStripMenuItem2_Click);
            // 
            // Morse_Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 272);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_string);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_morse);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_character);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Morse_Win";
            this.Text = "Morse Code";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_character;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_morse;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_string;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem legendToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem legendToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem legendToolStripMenuItem2;
    }
}

