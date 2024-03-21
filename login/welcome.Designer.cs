namespace login
{
    partial class welcome
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
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(244, 60);
            label1.Name = "label1";
            label1.Size = new Size(77, 23);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Indigo;
            textBox1.ForeColor = SystemColors.MenuBar;
            textBox1.Location = new Point(106, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(374, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "gran pendejo";
            // 
            // welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(587, 322);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "welcome";
            Text = "welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
    }
}