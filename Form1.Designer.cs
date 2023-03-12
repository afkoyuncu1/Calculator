namespace Hesap_Makinesi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.asagıB = new System.Windows.Forms.Label();
            this.kapamaB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonartı = new System.Windows.Forms.Button();
            this.buttoneksi = new System.Windows.Forms.Button();
            this.buttonçarpı = new System.Windows.Forms.Button();
            this.buttonbölü = new System.Windows.Forms.Button();
            this.buttonesittir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sonuçL = new System.Windows.Forms.Label();
            this.rstB = new System.Windows.Forms.Button();
            this.buttonartıeksi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.asagıB);
            this.panel1.Controls.Add(this.kapamaB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 45);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // asagıB
            // 
            this.asagıB.AutoSize = true;
            this.asagıB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.asagıB.ForeColor = System.Drawing.Color.White;
            this.asagıB.Location = new System.Drawing.Point(234, 6);
            this.asagıB.Name = "asagıB";
            this.asagıB.Size = new System.Drawing.Size(24, 32);
            this.asagıB.TabIndex = 1;
            this.asagıB.Text = "-";
            this.asagıB.Click += new System.EventHandler(this.asagıB_Click);
            // 
            // kapamaB
            // 
            this.kapamaB.AutoSize = true;
            this.kapamaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapamaB.ForeColor = System.Drawing.Color.White;
            this.kapamaB.Location = new System.Drawing.Point(274, 6);
            this.kapamaB.Name = "kapamaB";
            this.kapamaB.Size = new System.Drawing.Size(34, 32);
            this.kapamaB.TabIndex = 0;
            this.kapamaB.Text = "X";
            this.kapamaB.Click += new System.EventHandler(this.kapamaB_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(81, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(149, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SeaGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(13, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 60);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SeaGreen;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(81, 222);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 60);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SeaGreen;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(149, 222);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 60);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SeaGreen;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(13, 288);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(62, 60);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.SeaGreen;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(81, 288);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(62, 60);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.SeaGreen;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(149, 288);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(62, 60);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.SeaGreen;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button0.ForeColor = System.Drawing.Color.White;
            this.button0.Location = new System.Drawing.Point(13, 354);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(62, 60);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonartı
            // 
            this.buttonartı.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonartı.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonartı.ForeColor = System.Drawing.Color.White;
            this.buttonartı.Location = new System.Drawing.Point(217, 156);
            this.buttonartı.Name = "buttonartı";
            this.buttonartı.Size = new System.Drawing.Size(84, 60);
            this.buttonartı.TabIndex = 11;
            this.buttonartı.Text = "+";
            this.buttonartı.UseVisualStyleBackColor = false;
            this.buttonartı.Click += new System.EventHandler(this.buttonartı_Click);
            // 
            // buttoneksi
            // 
            this.buttoneksi.BackColor = System.Drawing.Color.SeaGreen;
            this.buttoneksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttoneksi.ForeColor = System.Drawing.Color.White;
            this.buttoneksi.Location = new System.Drawing.Point(217, 222);
            this.buttoneksi.Name = "buttoneksi";
            this.buttoneksi.Size = new System.Drawing.Size(84, 60);
            this.buttoneksi.TabIndex = 12;
            this.buttoneksi.Text = "-";
            this.buttoneksi.UseVisualStyleBackColor = false;
            this.buttoneksi.Click += new System.EventHandler(this.buttoneksi_Click);
            // 
            // buttonçarpı
            // 
            this.buttonçarpı.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonçarpı.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonçarpı.ForeColor = System.Drawing.Color.White;
            this.buttonçarpı.Location = new System.Drawing.Point(217, 288);
            this.buttonçarpı.Name = "buttonçarpı";
            this.buttonçarpı.Size = new System.Drawing.Size(84, 60);
            this.buttonçarpı.TabIndex = 13;
            this.buttonçarpı.Text = "x";
            this.buttonçarpı.UseVisualStyleBackColor = false;
            this.buttonçarpı.Click += new System.EventHandler(this.buttonçarpı_Click);
            // 
            // buttonbölü
            // 
            this.buttonbölü.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonbölü.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonbölü.ForeColor = System.Drawing.Color.White;
            this.buttonbölü.Location = new System.Drawing.Point(217, 354);
            this.buttonbölü.Name = "buttonbölü";
            this.buttonbölü.Size = new System.Drawing.Size(84, 60);
            this.buttonbölü.TabIndex = 14;
            this.buttonbölü.Text = "÷";
            this.buttonbölü.UseVisualStyleBackColor = false;
            this.buttonbölü.Click += new System.EventHandler(this.buttonbölü_Click);
            // 
            // buttonesittir
            // 
            this.buttonesittir.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonesittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonesittir.ForeColor = System.Drawing.Color.White;
            this.buttonesittir.Location = new System.Drawing.Point(81, 420);
            this.buttonesittir.Name = "buttonesittir";
            this.buttonesittir.Size = new System.Drawing.Size(220, 60);
            this.buttonesittir.TabIndex = 15;
            this.buttonesittir.Text = "=";
            this.buttonesittir.UseVisualStyleBackColor = false;
            this.buttonesittir.Click += new System.EventHandler(this.buttonesittir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(53, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "________________________";
            // 
            // sonuçL
            // 
            this.sonuçL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sonuçL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuçL.ForeColor = System.Drawing.Color.White;
            this.sonuçL.Location = new System.Drawing.Point(13, 55);
            this.sonuçL.Name = "sonuçL";
            this.sonuçL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sonuçL.Size = new System.Drawing.Size(288, 80);
            this.sonuçL.TabIndex = 17;
            this.sonuçL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rstB
            // 
            this.rstB.BackColor = System.Drawing.Color.SeaGreen;
            this.rstB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rstB.ForeColor = System.Drawing.Color.White;
            this.rstB.Location = new System.Drawing.Point(81, 354);
            this.rstB.Name = "rstB";
            this.rstB.Size = new System.Drawing.Size(130, 60);
            this.rstB.TabIndex = 18;
            this.rstB.Text = "Reset";
            this.rstB.UseVisualStyleBackColor = false;
            this.rstB.Click += new System.EventHandler(this.rstB_Click);
            // 
            // buttonartıeksi
            // 
            this.buttonartıeksi.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonartıeksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonartıeksi.ForeColor = System.Drawing.Color.White;
            this.buttonartıeksi.Location = new System.Drawing.Point(13, 420);
            this.buttonartıeksi.Name = "buttonartıeksi";
            this.buttonartıeksi.Size = new System.Drawing.Size(62, 60);
            this.buttonartıeksi.TabIndex = 19;
            this.buttonartıeksi.Text = "+/-";
            this.buttonartıeksi.UseVisualStyleBackColor = false;
            this.buttonartıeksi.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(314, 494);
            this.Controls.Add(this.buttonartıeksi);
            this.Controls.Add(this.rstB);
            this.Controls.Add(this.sonuçL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonesittir);
            this.Controls.Add(this.buttonbölü);
            this.Controls.Add(this.buttonçarpı);
            this.Controls.Add(this.buttoneksi);
            this.Controls.Add(this.buttonartı);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label asagıB;
        private System.Windows.Forms.Label kapamaB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonartı;
        private System.Windows.Forms.Button buttoneksi;
        private System.Windows.Forms.Button buttonçarpı;
        private System.Windows.Forms.Button buttonbölü;
        private System.Windows.Forms.Button buttonesittir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sonuçL;
        private System.Windows.Forms.Button rstB;
        private System.Windows.Forms.Button buttonartıeksi;
    }
}

