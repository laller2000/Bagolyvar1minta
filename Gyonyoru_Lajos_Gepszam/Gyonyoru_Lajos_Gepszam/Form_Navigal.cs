using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyonyoru_Lajos_Gepszam
{
    public partial class Form_Navigal : Form
    {
        public Color betuszin = Color.FromArgb(255, 255, 128);
        public Color hatterszin = Color.FromArgb(128, 64, 0);
        public Form_Navigal()
        {
            InitializeComponent();
        }

        private void Form_Navigal_Load(object sender, EventArgs e)
        {
            
            button1_Kolcsonzes.BackColor =hatterszin;
            button1_Kolcsonzes.ForeColor = betuszin;
            button2_Visszavitel.BackColor = hatterszin;
            button2_Visszavitel.ForeColor = betuszin;
            
            
        }

        private void button1_Kolcsonzes_Click(object sender, EventArgs e)
        {
            Program.form_kolcsonzes.Show();
        }

        private void button2_Visszavitel_Click(object sender, EventArgs e)
        {
            Program.form_visszavitel.Show();
        }
    }
}
