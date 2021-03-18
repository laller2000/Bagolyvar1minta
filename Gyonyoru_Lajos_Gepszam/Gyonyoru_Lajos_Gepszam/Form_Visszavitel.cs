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
    public partial class Form_Visszavitel : Form
    {
        public Color betuszin = Color.FromArgb(255, 255, 128);
        public Color hatterszin = Color.FromArgb(128, 64, 0);
        public Form_Visszavitel()
        {
            InitializeComponent();
        }

        private void Form_Visszavitel_Load(object sender, EventArgs e)
        {
            button1_Visszavetel.BackColor = hatterszin;
            button1_Visszavetel.ForeColor = betuszin;
            BerlokFeltoltese();
            
        }

        private void BerlokFeltoltese()
        {
            comboBox1_Berlo.Items.Clear();
            Program.sql.CommandText= "SELECT DISTINCT kolcsonzo.ID,kolcsonzo.nev FROM kolcsonzo JOIN kolcsonzes ON kolcsonzo.ID = kolcsonzes.kolcsonzoID; ";
            try
            {
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        comboBox1_Berlo.Items.Add(new Berlo(dr.GetInt32("ID"),dr.GetString("nev")));
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
        }

        private void ListBoxFeltoltese()
        {

            listBox1_Kolcsonzottadatok.Items.Clear();
            if (comboBox1_Berlo.SelectedIndex<0)
            {
                MessageBox.Show("Nincs kiválasztva kölcsönző!");
            }
            Program.sql.CommandText = "SELECT `konyvID`, `kolcsonzoID`, `kivetelDatum`, `peldany`,konyvek.Szerzo,konyvek.Cím,konyvek.ISBN,konyvek.KiadasEve,konyvek.Ar,kolcsonzo.nev FROM konyvek JOIN `kolcsonzes` ON kolcsonzes.konyvID = konyvek.Kod JOIN kolcsonzo ON kolcsonzes.kolcsonzoID = kolcsonzo.ID WHERE kolcsonzo.ID = " + ((Berlo)comboBox1_Berlo.SelectedItem).Id;
            try
            {
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Kolcsonzes kolcsonzes = new Kolcsonzes(dr.GetString("konyvId"), dr.GetInt32("kolcsonzoID"), DateTime.Parse(dr.GetString("kivetelDatum")), dr.GetDecimal("peldany"));
                        kolcsonzes.addKonyv(new Konyv(dr.GetString("konyvID"),dr.GetString("Szerzo"),dr.GetString("Cím"),dr.GetInt32("kiadasEve"),dr.GetInt32("Ar"),dr.GetString("ISBN")));
                        kolcsonzes.addBerlo(new Berlo(dr.GetInt32("kolcsonzoID"),dr.GetString("nev")));
                        listBox1_Kolcsonzottadatok.Items.Add(kolcsonzes);
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
        }

        private void comboBox1_Berlo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxFeltoltese();
        }

        private void listBox1_Kolcsonzottadatok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1_Kolcsonzottadatok.SelectedIndex<0)
            {
                MessageBox.Show("Nincs kiválasztot kölcsönzés!");
                return;
            }
            Kolcsonzes kiv = (Kolcsonzes)listBox1_Kolcsonzottadatok.SelectedItem;
            textBox1_Datum.Text = kiv.KivitelDatum.ToString("d");
            textBox3_ISBN.Text = kiv.Kony.Isbn;
            textBox2_Konyvcim.Text = kiv.Kony.Cim;
            textBox1_Szerzo.Text = kiv.Kony.Szerzo;
            numericUpDown1_Peldany.Value = kiv.Peldany;
            int napok = (DateTime.Now - kiv.KivitelDatum).Days;
            if (napok>30)
            {
                checkBox1_Kesett.Checked = true;
            }
            else
            {
                checkBox1_Kesett.Checked = false;
            }
        }

        private void button1_Visszavetel_Click(object sender, EventArgs e)
        {
            if (listBox1_Kolcsonzottadatok.SelectedIndex<0)
            {
                MessageBox.Show("Kérem válasszon kolcsonzott adatok!");
                return;
            }
            Kolcsonzes kiv = (Kolcsonzes)listBox1_Kolcsonzottadatok.SelectedItem;
            Program.sql.CommandText = "DELETE FROM `kolcsonzes` WHERE `konyvID`=@konyv_id AND `kolcsonzoID`=@kolcsonzo_id AND `kivetelDatum`=@datum AND `peldany`=@pld;";
            Program.sql.Parameters.Clear();
            Program.sql.Parameters.AddWithValue("@konyv_id",kiv.KonyvID);
            Program.sql.Parameters.AddWithValue("@kolcsonzo_id",kiv.KolcsonzoID);
            Program.sql.Parameters.AddWithValue("@datum",kiv.KivitelDatum);
            Program.sql.Parameters.AddWithValue("@pld",kiv.Peldany);
            try
            {
                Program.sql.ExecuteNonQuery();
                MessageBox.Show("A visszavétel sikeres!");
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message + "A visszavétel sikertelen!");
                return;
            }
            listBox1_Kolcsonzottadatok.Update();
            textBox1_Datum.Text = "";
            textBox3_ISBN.Text = "";
            textBox2_Konyvcim.Text = "";
            textBox1_Szerzo.Text = "";
            numericUpDown1_Peldany.Value = 0;
            checkBox1_Kesett.Checked = false;
        }
    }
}
