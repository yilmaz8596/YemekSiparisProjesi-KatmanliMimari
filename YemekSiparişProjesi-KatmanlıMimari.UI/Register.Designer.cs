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
            Ad = new TextBox();
            label1 = new Label();
            Soyad = new TextBox();
            label2 = new Label();
            Eposta = new TextBox();
            label3 = new Label();
            Sifre = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SifreTekrar = new TextBox();
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
            button1.Click += Button1_Click;
            // 
            // Ad
            // 
            Ad.Location = new Point(292, 51);
            Ad.Name = "Ad";
            Ad.Size = new Size(384, 27);
            Ad.TabIndex = 1;
            Ad.TextChanged += TextBox1_TextChanged;
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
            // Soyad
            // 
            Soyad.Location = new Point(292, 131);
            Soyad.Name = "Soyad";
            Soyad.Size = new Size(384, 27);
            Soyad.TabIndex = 3;
            Soyad.TextChanged += TextBox2_TextChanged;
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
            // Eposta
            // 
            Eposta.Location = new Point(292, 209);
            Eposta.Name = "Eposta";
            Eposta.Size = new Size(384, 27);
            Eposta.TabIndex = 5;
            Eposta.TextChanged += TextBox3_TextChanged;
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
            // Sifre
            // 
            Sifre.Location = new Point(292, 289);
            Sifre.Name = "Sifre";
            Sifre.Size = new Size(384, 27);
            Sifre.TabIndex = 7;
            Sifre.TextChanged += TextBox4_TextChanged;
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
            // SifreTekrar
            // 
            SifreTekrar.Location = new Point(292, 366);
            SifreTekrar.Name = "SifreTekrar";
            SifreTekrar.Size = new Size(384, 27);
            SifreTekrar.TabIndex = 10;
            SifreTekrar.TextChanged += TextBox5_TextChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(954, 472);
            Controls.Add(SifreTekrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Sifre);
            Controls.Add(label3);
            Controls.Add(Eposta);
            Controls.Add(label2);
            Controls.Add(Soyad);
            Controls.Add(label1);
            Controls.Add(Ad);
            Controls.Add(button1);
            Name = "Register";
            Text = "Form1";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Ad;
        private Label label1;
        private TextBox Soyad;
        private Label label2;
        private TextBox Eposta;
        private Label label3;
        private TextBox Sifre;
        private Label label4;
        private Label label5;
        private TextBox SifreTekrar;
    }
}
