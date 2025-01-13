namespace YemekSiparişProjesi_KatmanlıMimari.UI
{
    partial class Login
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
            label4 = new Label();
            Sifre = new TextBox();
            label3 = new Label();
            Eposta = new TextBox();
            button1 = new Button();
            label6 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Snap ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(208, 210);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 19;
            label4.Text = "Şifre";
            // 
            // Sifre
            // 
            Sifre.Location = new Point(208, 236);
            Sifre.Name = "Sifre";
            Sifre.Size = new Size(384, 27);
            Sifre.TabIndex = 18;
            Sifre.TextChanged += Sifre_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(208, 120);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 17;
            label3.Text = "E-Posta";
            // 
            // Eposta
            // 
            Eposta.Location = new Point(208, 146);
            Eposta.Name = "Eposta";
            Eposta.Size = new Size(384, 27);
            Eposta.TabIndex = 16;
            Eposta.TextChanged += Eposta_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Linen;
            button1.Font = new Font("Snap ITC", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(301, 351);
            button1.Name = "button1";
            button1.Size = new Size(175, 47);
            button1.TabIndex = 11;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Snap ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(208, 288);
            label6.Name = "label6";
            label6.Size = new Size(190, 23);
            label6.TabIndex = 20;
            label6.Text = "Hesabınız yok mu?";
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Snap ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(431, 285);
            button2.Name = "button2";
            button2.Size = new Size(133, 29);
            button2.TabIndex = 21;
            button2.Text = "Kayıt Olun";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(Sifre);
            Controls.Add(label3);
            Controls.Add(Eposta);
            Controls.Add(button1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox Sifre;
        private Label label3;
        private TextBox Eposta;
        private Button button1;
        private Label label6;
        private Button button2;
    }
}