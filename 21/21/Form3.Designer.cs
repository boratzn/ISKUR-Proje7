namespace _21
{
    partial class Form3
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
            this.btnBeniYakala = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBasla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBeniYakala
            // 
            this.btnBeniYakala.Location = new System.Drawing.Point(240, 195);
            this.btnBeniYakala.Name = "btnBeniYakala";
            this.btnBeniYakala.Size = new System.Drawing.Size(75, 23);
            this.btnBeniYakala.TabIndex = 0;
            this.btnBeniYakala.Text = "Beni Yakala";
            this.btnBeniYakala.UseVisualStyleBackColor = true;
            this.btnBeniYakala.Click += new System.EventHandler(this.btnBeniYakala_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(379, 206);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(88, 36);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.Text = "Oyuna Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.btnBeniYakala);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Click += new System.EventHandler(this.Form3_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBeniYakala;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBasla;
    }
}