using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Gyonyoru_Lajos_Gepszam
{
    public partial class Form_Kolcsonzes : Form
    {
        public Color betuszin = Color.FromArgb(255, 255, 128);
        public Color hatterszin = Color.FromArgb(128, 64, 0);
         List<Konyv> konyvek = new List<Konyv>();
        public Form_Kolcsonzes()
        {
            InitializeComponent();
        }

        private void Form_Kolcsonzes_Load(object sender, EventArgs e)
        {
            button1_Listaba.BackColor = hatterszin;
            button1_Listaba.ForeColor = betuszin;
            button2_Adatbazisba.BackColor = hatterszin;
            button2_Adatbazisba.ForeColor = betuszin;
            KonyvAdatokBetoltese();
            BerloAdatokBetoltese();
        }

        private void BerloAdatokBetoltese()
        {
            comboBox2_Berlo.Items.Clear();
            Program.sql.CommandText = "SELECT `ID`, `nev` FROM `kolcsonzo` WHERE 1";
            using (MySqlDataReader dr = Program.sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    comboBox2_Berlo.Items.Add(new Berlo(dr.GetInt32("ID"), dr.GetString("nev")));

                }
            }
        }

        private void KonyvAdatokBetoltese()
        {
            comboBox1_Konyv.Items.Clear();
            Program.sql.CommandText = "SELECT `Kod`, `Szerzo`, `Cím`, `KiadasEve`, `Ar`, `ISBN` FROM `konyvek` WHERE 1";
            using (MySqlDataReader dr=Program.sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    comboBox1_Konyv.Items.Add(new Konyv(dr.GetString("Kod"),dr.GetString("Szerzo"),dr.GetString("Cím"),dr.GetInt32("KiadasEve"),dr.GetInt32("Ar"),dr.GetString("ISBN")));

                }
            }
        }

        private void button1_Listaba_Click(object sender, EventArgs e)
        {
            if (comboBox1_Konyv.SelectedIndex<0)
            {
                MessageBox.Show("Nincs kiválaszott könyv!");
                return;
            }
            if (comboBox2_Berlo.SelectedIndex<0)
            {
                MessageBox.Show("Nincs kiválasztott bérlő!");
                return;
            }
            Konyv kivesz=(Konyv)comboBox1_Konyv.SelectedItem;
            Berlo berlo=(Berlo)comboBox2_Berlo.SelectedItem;
            DateTime kivitelDatum = DateTime.Now;
            decimal peldany=numericUpDown1_Peldany.Value;
            Kolcsonzes kolcsonzes = new Kolcsonzes(kivesz.Kod,berlo.Id,kivitelDatum,peldany);
            kolcsonzes.addBerlo(berlo);
            kolcsonzes.addKonyv(kivesz);
            listBox1_Kolcsonzesadatok.Items.Add(kolcsonzes);
        }

        private void button2_Adatbazisba_Click(object sender, EventArgs e)
        {
            if (listBox1_Kolcsonzesadatok.Items.Count<1)
            {
                MessageBox.Show("Nincsennek kölcsönzések");
                return;
            }
            try
            {
                foreach (Kolcsonzes item in listBox1_Kolcsonzesadatok.Items)
                {
                    Program.sql.CommandText = "INSERT INTO `kolcsonzes` (`konyvID`, `kolcsonzoID`, `kivetelDatum`, `peldany`) VALUES ('"+item.KonyvID+"', '"+item.KolcsonzoID+"', '"+DateTime.Now.ToString("yyyy-MM-dd")+"', '"+item.Peldany+"');";
                    Program.sql.ExecuteNonQuery();
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
            listBox1_Kolcsonzesadatok.Items.Clear();
            MessageBox.Show("Az adatok rögzítése megtörtént");
        }
    }
}
