namespace _21
{
    partial class Form2
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDepoNo = new System.Windows.Forms.TextBox();
            this.tbDepoAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDepoAdres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDepoTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDepoyuGetir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(16, 123);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(72, 55);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Depo No";
            // 
            // tbDepoNo
            // 
            this.tbDepoNo.Location = new System.Drawing.Point(78, 10);
            this.tbDepoNo.Name = "tbDepoNo";
            this.tbDepoNo.Size = new System.Drawing.Size(100, 20);
            this.tbDepoNo.TabIndex = 2;
            // 
            // tbDepoAdi
            // 
            this.tbDepoAdi.Location = new System.Drawing.Point(78, 36);
            this.tbDepoAdi.Name = "tbDepoAdi";
            this.tbDepoAdi.Size = new System.Drawing.Size(100, 20);
            this.tbDepoAdi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Depo Adı";
            // 
            // tbDepoAdres
            // 
            this.tbDepoAdres.Location = new System.Drawing.Point(78, 62);
            this.tbDepoAdres.Name = "tbDepoAdres";
            this.tbDepoAdres.Size = new System.Drawing.Size(100, 20);
            this.tbDepoAdres.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Depo Adres";
            // 
            // tbDepoTel
            // 
            this.tbDepoTel.Location = new System.Drawing.Point(78, 88);
            this.tbDepoTel.Name = "tbDepoTel";
            this.tbDepoTel.Size = new System.Drawing.Size(100, 20);
            this.tbDepoTel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Depo Tel";
            // 
            // btnDepoyuGetir
            // 
            this.btnDepoyuGetir.Location = new System.Drawing.Point(106, 123);
            this.btnDepoyuGetir.Name = "btnDepoyuGetir";
            this.btnDepoyuGetir.Size = new System.Drawing.Size(72, 55);
            this.btnDepoyuGetir.TabIndex = 0;
            this.btnDepoyuGetir.Text = "Depoyu Getir";
            this.btnDepoyuGetir.UseVisualStyleBackColor = true;
            this.btnDepoyuGetir.Click += new System.EventHandler(this.btnDepoyuGetir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbDepoTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDepoAdres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDepoAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDepoNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDepoyuGetir);
            this.Controls.Add(this.btnKaydet);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDepoNo;
        private System.Windows.Forms.TextBox tbDepoAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDepoAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDepoTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDepoyuGetir;
    }
}