namespace ClientProxy_P4_015_Form
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.htambah = new System.Windows.Forms.TextBox();
            this.hkurang = new System.Windows.Forms.TextBox();
            this.hkali = new System.Windows.Forms.TextBox();
            this.hbagi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hKoordinat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasil Tambah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasil Kurang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasil Bagi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil Kali";
            // 
            // htambah
            // 
            this.htambah.Location = new System.Drawing.Point(144, 31);
            this.htambah.Name = "htambah";
            this.htambah.Size = new System.Drawing.Size(141, 22);
            this.htambah.TabIndex = 4;
            this.htambah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hkurang
            // 
            this.hkurang.Location = new System.Drawing.Point(144, 69);
            this.hkurang.Name = "hkurang";
            this.hkurang.Size = new System.Drawing.Size(141, 22);
            this.hkurang.TabIndex = 5;
            this.hkurang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hkali
            // 
            this.hkali.Location = new System.Drawing.Point(144, 112);
            this.hkali.Name = "hkali";
            this.hkali.Size = new System.Drawing.Size(141, 22);
            this.hkali.TabIndex = 6;
            this.hkali.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hbagi
            // 
            this.hbagi.Location = new System.Drawing.Point(144, 159);
            this.hbagi.Name = "hbagi";
            this.hbagi.Size = new System.Drawing.Size(141, 22);
            this.hbagi.TabIndex = 7;
            this.hbagi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hasil Koordinat";
            // 
            // hKoordinat
            // 
            this.hKoordinat.Location = new System.Drawing.Point(153, 212);
            this.hKoordinat.Name = "hKoordinat";
            this.hKoordinat.Size = new System.Drawing.Size(314, 22);
            this.hKoordinat.TabIndex = 9;
            this.hKoordinat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hKoordinat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hbagi);
            this.Controls.Add(this.hkali);
            this.Controls.Add(this.hkurang);
            this.Controls.Add(this.htambah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client Froxy Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox htambah;
        private System.Windows.Forms.TextBox hkurang;
        private System.Windows.Forms.TextBox hkali;
        private System.Windows.Forms.TextBox hbagi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hKoordinat;
    }
}

