namespace Form1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.girisyap = new System.Windows.Forms.Button();
            this.buton1 = new System.Windows.Forms.Button();
            this.buton3 = new System.Windows.Forms.Button();
            this.buton5 = new System.Windows.Forms.Button();
            this.buton7 = new System.Windows.Forms.Button();
            this.buton2 = new System.Windows.Forms.Button();
            this.buton4 = new System.Windows.Forms.Button();
            this.buton6 = new System.Windows.Forms.Button();
            this.buton8 = new System.Windows.Forms.Button();
            this.buton9 = new System.Windows.Forms.Button();
            this.buton0 = new System.Windows.Forms.Button();
            this.clr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(184, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "4 Haneli Şifrenizi Giriniz.";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(180, 63);
            this.textBox1.MaxLength = 4;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(225, 42);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // girisyap
            // 
            this.girisyap.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisyap.Location = new System.Drawing.Point(342, 111);
            this.girisyap.Name = "girisyap";
            this.girisyap.Size = new System.Drawing.Size(63, 188);
            this.girisyap.TabIndex = 3;
            this.girisyap.Text = "Giriş Yap";
            this.girisyap.UseVisualStyleBackColor = true;
            this.girisyap.Click += new System.EventHandler(this.girisyap_Click);
            // 
            // buton1
            // 
            this.buton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton1.Location = new System.Drawing.Point(180, 111);
            this.buton1.Name = "buton1";
            this.buton1.Size = new System.Drawing.Size(48, 43);
            this.buton1.TabIndex = 4;
            this.buton1.Text = "1";
            this.buton1.UseVisualStyleBackColor = true;
            this.buton1.Click += new System.EventHandler(this.buton1_Click);
            // 
            // buton3
            // 
            this.buton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton3.Location = new System.Drawing.Point(288, 111);
            this.buton3.Name = "buton3";
            this.buton3.Size = new System.Drawing.Size(48, 43);
            this.buton3.TabIndex = 5;
            this.buton3.Text = "3";
            this.buton3.UseVisualStyleBackColor = true;
            this.buton3.Click += new System.EventHandler(this.buton1_Click);
            // 
            // buton5
            // 
            this.buton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton5.Location = new System.Drawing.Point(234, 160);
            this.buton5.Name = "buton5";
            this.buton5.Size = new System.Drawing.Size(48, 43);
            this.buton5.TabIndex = 6;
            this.buton5.Text = "5";
            this.buton5.UseVisualStyleBackColor = true;
            this.buton5.Click += new System.EventHandler(this.buton1_Click);
            // 
            // buton7
            // 
            this.buton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton7.Location = new System.Drawing.Point(180, 209);
            this.buton7.Name = "buton7";
            this.buton7.Size = new System.Drawing.Size(48, 43);
            this.buton7.TabIndex = 7;
            this.buton7.Text = "7";
            this.buton7.UseVisualStyleBackColor = true;
            this.buton7.Click += new System.EventHandler(this.buton1_Click);
            // 
            // buton2
            // 
            this.buton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton2.Location = new System.Drawing.Point(234, 111);
            this.buton2.Name = "buton2";
            this.buton2.Size = new System.Drawing.Size(48, 43);
            this.buton2.TabIndex = 8;
            this.buton2.Text = "2";
            this.buton2.UseVisualStyleBackColor = true;
            this.buton2.Click += new System.EventHandler(this.buton1_Click);
            // 
            // buton4
            // 
            this.buton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton4.Location = new System.Drawing.Point(180, 160);
            this.buton4.Name = "buton4";
            this.buton4.Size = new System.Drawing.Size(48, 43);
            this.buton4.TabIndex = 9;
            this.buton4.Text = "4";
            this.buton4.UseVisualStyleBackColor = true;
            this.buton4.Click += new System.EventHandler(this.buton1_Click);
            // 
            // buton6
            // 
            this.buton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton6.Location = new System.Drawing.Point(288, 160);
            this.buton6.Name = "buton6";
            this.buton6.Size = new System.Drawing.Size(48, 43);
            this.buton6.TabIndex = 10;
            this.buton6.Text = "6";
            this.buton6.UseVisualStyleBackColor = true;
            this.buton6.Click += new System.EventHandler(this.buton1_Click);
            // 
            // buton8
            // 
            this.buton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton8.Location = new System.Drawing.Point(234, 209);
            this.buton8.Name = "buton8";
            this.buton8.Size = new System.Drawing.Size(48, 43);
            this.buton8.TabIndex = 11;
            this.buton8.Text = "8";
            this.buton8.UseVisualStyleBackColor = true;
            this.buton8.Click += new System.EventHandler(this.buton1_Click);
            // 
            // buton9
            // 
            this.buton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton9.Location = new System.Drawing.Point(288, 209);
            this.buton9.Name = "buton9";
            this.buton9.Size = new System.Drawing.Size(48, 43);
            this.buton9.TabIndex = 12;
            this.buton9.Text = "9";
            this.buton9.UseVisualStyleBackColor = true;
            this.buton9.Click += new System.EventHandler(this.buton1_Click);
            // 
            // buton0
            // 
            this.buton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton0.Location = new System.Drawing.Point(180, 256);
            this.buton0.Name = "buton0";
            this.buton0.Size = new System.Drawing.Size(48, 43);
            this.buton0.TabIndex = 13;
            this.buton0.Text = "0";
            this.buton0.UseVisualStyleBackColor = true;
            this.buton0.Click += new System.EventHandler(this.buton1_Click);
            // 
            // clr
            // 
            this.clr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clr.Location = new System.Drawing.Point(234, 256);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(102, 43);
            this.clr.TabIndex = 14;
            this.clr.Text = "Sil";
            this.clr.UseVisualStyleBackColor = true;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.buton0);
            this.Controls.Add(this.buton9);
            this.Controls.Add(this.buton8);
            this.Controls.Add(this.buton6);
            this.Controls.Add(this.buton4);
            this.Controls.Add(this.buton2);
            this.Controls.Add(this.buton7);
            this.Controls.Add(this.buton5);
            this.Controls.Add(this.buton3);
            this.Controls.Add(this.buton1);
            this.Controls.Add(this.girisyap);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "başlangıç";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button girisyap;
        private System.Windows.Forms.Button buton1;
        private System.Windows.Forms.Button buton3;
        private System.Windows.Forms.Button buton5;
        private System.Windows.Forms.Button buton7;
        private System.Windows.Forms.Button buton2;
        private System.Windows.Forms.Button buton4;
        private System.Windows.Forms.Button buton6;
        private System.Windows.Forms.Button buton8;
        private System.Windows.Forms.Button buton9;
        private System.Windows.Forms.Button buton0;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

