
namespace Gyonyoru_Lajos_Gepszam
{
    partial class Form_Kolcsonzes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kolcsonzes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1_Peldany = new System.Windows.Forms.NumericUpDown();
            this.comboBox2_Berlo = new System.Windows.Forms.ComboBox();
            this.comboBox1_Konyv = new System.Windows.Forms.ComboBox();
            this.button2_Adatbazisba = new System.Windows.Forms.Button();
            this.button1_Listaba = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1_Kolcsonzesadatok = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Peldany)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1_Peldany);
            this.groupBox1.Controls.Add(this.comboBox2_Berlo);
            this.groupBox1.Controls.Add(this.comboBox1_Konyv);
            this.groupBox1.Controls.Add(this.button2_Adatbazisba);
            this.groupBox1.Controls.Add(this.button1_Listaba);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kölcsönzés adatok";
            // 
            // numericUpDown1_Peldany
            // 
            this.numericUpDown1_Peldany.Location = new System.Drawing.Point(132, 164);
            this.numericUpDown1_Peldany.Name = "numericUpDown1_Peldany";
            this.numericUpDown1_Peldany.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1_Peldany.TabIndex = 7;
            this.numericUpDown1_Peldany.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox2_Berlo
            // 
            this.comboBox2_Berlo.FormattingEnabled = true;
            this.comboBox2_Berlo.Location = new System.Drawing.Point(132, 100);
            this.comboBox2_Berlo.Name = "comboBox2_Berlo";
            this.comboBox2_Berlo.Size = new System.Drawing.Size(238, 24);
            this.comboBox2_Berlo.TabIndex = 6;
            // 
            // comboBox1_Konyv
            // 
            this.comboBox1_Konyv.FormattingEnabled = true;
            this.comboBox1_Konyv.Location = new System.Drawing.Point(132, 54);
            this.comboBox1_Konyv.Name = "comboBox1_Konyv";
            this.comboBox1_Konyv.Size = new System.Drawing.Size(238, 24);
            this.comboBox1_Konyv.TabIndex = 5;
            // 
            // button2_Adatbazisba
            // 
            this.button2_Adatbazisba.Location = new System.Drawing.Point(101, 301);
            this.button2_Adatbazisba.Name = "button2_Adatbazisba";
            this.button2_Adatbazisba.Size = new System.Drawing.Size(231, 23);
            this.button2_Adatbazisba.TabIndex = 4;
            this.button2_Adatbazisba.Text = "Rögzítés az adatbázisba";
            this.button2_Adatbazisba.UseVisualStyleBackColor = true;
            this.button2_Adatbazisba.Click += new System.EventHandler(this.button2_Adatbazisba_Click);
            // 
            // button1_Listaba
            // 
            this.button1_Listaba.Location = new System.Drawing.Point(52, 213);
            this.button1_Listaba.Name = "button1_Listaba";
            this.button1_Listaba.Size = new System.Drawing.Size(290, 23);
            this.button1_Listaba.TabIndex = 3;
            this.button1_Listaba.Text = "Listában tárolja az adatokat";
            this.button1_Listaba.UseVisualStyleBackColor = true;
            this.button1_Listaba.Click += new System.EventHandler(this.button1_Listaba_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Példány";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bérlő";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Könyv";
            // 
            // listBox1_Kolcsonzesadatok
            // 
            this.listBox1_Kolcsonzesadatok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1_Kolcsonzesadatok.FormattingEnabled = true;
            this.listBox1_Kolcsonzesadatok.ItemHeight = 16;
            this.listBox1_Kolcsonzesadatok.Location = new System.Drawing.Point(411, 0);
            this.listBox1_Kolcsonzesadatok.Name = "listBox1_Kolcsonzesadatok";
            this.listBox1_Kolcsonzesadatok.Size = new System.Drawing.Size(389, 450);
            this.listBox1_Kolcsonzesadatok.TabIndex = 3;
            // 
            // Form_Kolcsonzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1_Kolcsonzesadatok);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Kolcsonzes";
            this.Text = "Form_Kolcsonzes";
            this.Load += new System.EventHandler(this.Form_Kolcsonzes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Peldany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1_Kolcsonzesadatok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1_Listaba;
        private System.Windows.Forms.Button button2_Adatbazisba;
        private System.Windows.Forms.ComboBox comboBox1_Konyv;
        private System.Windows.Forms.ComboBox comboBox2_Berlo;
        private System.Windows.Forms.NumericUpDown numericUpDown1_Peldany;
    }
}