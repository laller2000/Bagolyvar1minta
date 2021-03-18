
namespace Gyonyoru_Lajos_Gepszam
{
    partial class Form_Visszavitel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Visszavitel));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1_Berlo = new System.Windows.Forms.ComboBox();
            this.listBox1_Kolcsonzottadatok = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1_Szerzo = new System.Windows.Forms.TextBox();
            this.textBox2_Konyvcim = new System.Windows.Forms.TextBox();
            this.textBox3_ISBN = new System.Windows.Forms.TextBox();
            this.numericUpDown1_Peldany = new System.Windows.Forms.NumericUpDown();
            this.button1_Visszavetel = new System.Windows.Forms.Button();
            this.textBox1_Datum = new System.Windows.Forms.TextBox();
            this.checkBox1_Kesett = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Peldany)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bérlő neve:";
            // 
            // comboBox1_Berlo
            // 
            this.comboBox1_Berlo.FormattingEnabled = true;
            this.comboBox1_Berlo.Location = new System.Drawing.Point(157, 29);
            this.comboBox1_Berlo.Name = "comboBox1_Berlo";
            this.comboBox1_Berlo.Size = new System.Drawing.Size(176, 24);
            this.comboBox1_Berlo.TabIndex = 1;
            this.comboBox1_Berlo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_Berlo_SelectedIndexChanged);
            // 
            // listBox1_Kolcsonzottadatok
            // 
            this.listBox1_Kolcsonzottadatok.FormattingEnabled = true;
            this.listBox1_Kolcsonzottadatok.ItemHeight = 16;
            this.listBox1_Kolcsonzottadatok.Location = new System.Drawing.Point(64, 92);
            this.listBox1_Kolcsonzottadatok.Name = "listBox1_Kolcsonzottadatok";
            this.listBox1_Kolcsonzottadatok.Size = new System.Drawing.Size(313, 372);
            this.listBox1_Kolcsonzottadatok.TabIndex = 2;
            this.listBox1_Kolcsonzottadatok.SelectedIndexChanged += new System.EventHandler(this.listBox1_Kolcsonzottadatok_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Szerző";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Könyvcím:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "ISBN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Példány:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Dátum:";
            // 
            // textBox1_Szerzo
            // 
            this.textBox1_Szerzo.Location = new System.Drawing.Point(539, 92);
            this.textBox1_Szerzo.Name = "textBox1_Szerzo";
            this.textBox1_Szerzo.ReadOnly = true;
            this.textBox1_Szerzo.Size = new System.Drawing.Size(220, 22);
            this.textBox1_Szerzo.TabIndex = 8;
            // 
            // textBox2_Konyvcim
            // 
            this.textBox2_Konyvcim.Location = new System.Drawing.Point(539, 145);
            this.textBox2_Konyvcim.Name = "textBox2_Konyvcim";
            this.textBox2_Konyvcim.ReadOnly = true;
            this.textBox2_Konyvcim.Size = new System.Drawing.Size(220, 22);
            this.textBox2_Konyvcim.TabIndex = 9;
            // 
            // textBox3_ISBN
            // 
            this.textBox3_ISBN.Location = new System.Drawing.Point(527, 198);
            this.textBox3_ISBN.Name = "textBox3_ISBN";
            this.textBox3_ISBN.ReadOnly = true;
            this.textBox3_ISBN.Size = new System.Drawing.Size(232, 22);
            this.textBox3_ISBN.TabIndex = 10;
            // 
            // numericUpDown1_Peldany
            // 
            this.numericUpDown1_Peldany.Location = new System.Drawing.Point(577, 251);
            this.numericUpDown1_Peldany.Name = "numericUpDown1_Peldany";
            this.numericUpDown1_Peldany.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1_Peldany.TabIndex = 11;
            this.numericUpDown1_Peldany.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1_Visszavetel
            // 
            this.button1_Visszavetel.Location = new System.Drawing.Point(459, 416);
            this.button1_Visszavetel.Name = "button1_Visszavetel";
            this.button1_Visszavetel.Size = new System.Drawing.Size(272, 46);
            this.button1_Visszavetel.TabIndex = 12;
            this.button1_Visszavetel.Text = "Visszaad";
            this.button1_Visszavetel.UseVisualStyleBackColor = true;
            this.button1_Visszavetel.Click += new System.EventHandler(this.button1_Visszavetel_Click);
            // 
            // textBox1_Datum
            // 
            this.textBox1_Datum.Location = new System.Drawing.Point(505, 304);
            this.textBox1_Datum.Name = "textBox1_Datum";
            this.textBox1_Datum.ReadOnly = true;
            this.textBox1_Datum.Size = new System.Drawing.Size(254, 22);
            this.textBox1_Datum.TabIndex = 13;
            // 
            // checkBox1_Kesett
            // 
            this.checkBox1_Kesett.AutoSize = true;
            this.checkBox1_Kesett.ForeColor = System.Drawing.Color.Red;
            this.checkBox1_Kesett.Location = new System.Drawing.Point(560, 357);
            this.checkBox1_Kesett.Name = "checkBox1_Kesett";
            this.checkBox1_Kesett.Size = new System.Drawing.Size(98, 21);
            this.checkBox1_Kesett.TabIndex = 14;
            this.checkBox1_Kesett.Text = "checkBox1";
            this.checkBox1_Kesett.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kölcsönzött könyvek:";
            // 
            // Form_Visszavitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1_Kesett);
            this.Controls.Add(this.textBox1_Datum);
            this.Controls.Add(this.button1_Visszavetel);
            this.Controls.Add(this.numericUpDown1_Peldany);
            this.Controls.Add(this.textBox3_ISBN);
            this.Controls.Add(this.textBox2_Konyvcim);
            this.Controls.Add(this.textBox1_Szerzo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1_Kolcsonzottadatok);
            this.Controls.Add(this.comboBox1_Berlo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Visszavitel";
            this.Text = "Form_Visszavitel";
            this.Load += new System.EventHandler(this.Form_Visszavitel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Peldany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1_Berlo;
        private System.Windows.Forms.ListBox listBox1_Kolcsonzottadatok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1_Szerzo;
        private System.Windows.Forms.TextBox textBox2_Konyvcim;
        private System.Windows.Forms.TextBox textBox3_ISBN;
        private System.Windows.Forms.NumericUpDown numericUpDown1_Peldany;
        private System.Windows.Forms.Button button1_Visszavetel;
        private System.Windows.Forms.TextBox textBox1_Datum;
        private System.Windows.Forms.CheckBox checkBox1_Kesett;
        private System.Windows.Forms.Label label7;
    }
}