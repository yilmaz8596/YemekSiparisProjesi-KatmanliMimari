namespace YemekSiparişProjesi_KatmanlıMimari.UI
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Linen;
            button1.Font = new Font("Snap ITC", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(388, 413);
            button1.Name = "button1";
            button1.Size = new Size(175, 47);
            button1.TabIndex = 0;
            button1.Text = "Kayıt Ol";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(292, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(384, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(292, 25);
            label1.Name = "label1";
            label1.Size = new Size(35, 23);
            label1.TabIndex = 2;
            label1.Text = "Ad";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(292, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(384, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(292, 105);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 4;
            label2.Text = "Soyad";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(292, 209);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(384, 27);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(292, 183);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 6;
            label3.Text = "E-Posta";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(292, 289);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(384, 27);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Snap ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(292, 263);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 8;
            label4.Text = "Şifre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Snap ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(292, 340);
            label5.Name = "label5";
            label5.Size = new Size(136, 23);
            label5.TabIndex = 9;
            label5.Text = "Şifre Tekrar";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(292, 366);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(384, 27);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(954, 472);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Register";
            Text = "Form1";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
    }
}
