namespace login
{
    partial class registrar
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
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            linkLabel2 = new LinkLabel();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(19, 308);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(316, 23);
            textBox3.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(19, 282);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 31;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(83, 530);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 30;
            label4.Text = "¿No tienes una cuenta?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.FromArgb(255, 128, 0);
            linkLabel2.Location = new Point(218, 530);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(53, 15);
            linkLabel2.TabIndex = 29;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Registrar";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(80, 485);
            button1.Name = "button1";
            button1.Size = new Size(204, 29);
            button1.TabIndex = 28;
            button1.Text = "Restablecer";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 232);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(316, 23);
            textBox2.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 23);
            textBox1.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(21, 206);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 25;
            label3.Text = "Email addres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(19, 129);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 24;
            label2.Text = "Name user";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(127, 46);
            label1.Name = "label1";
            label1.Size = new Size(108, 27);
            label1.TabIndex = 23;
            label1.Text = "Registrate";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(19, 381);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(316, 23);
            textBox4.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(19, 355);
            label6.Name = "label6";
            label6.Size = new Size(144, 23);
            label6.TabIndex = 33;
            label6.Text = "Repetir Password";
            // 
            // registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(371, 595);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(linkLabel2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "registrar";
            Text = "registrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private LinkLabel linkLabel2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private Label label6;
    }
}