using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latvanyossagok
{
    public partial class Latvanyossagok : Form
    {
        MySqlConnection conn;
        int varosKivalasztottIndex;
        public Latvanyossagok()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database=latvanyossagokdb; Uid = root; Pwd=;");
            conn.Open();
            VarosListazas();
        }

        void VarosListazas() {
            varosokListBox.Items.Clear();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, nev, lakossag FROM varosok";
            using (var reader = cmd.ExecuteReader()) {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var lakossag = reader.GetInt32("lakossag");
                    var varos = new Varos(id, nev, lakossag);
                    varosokListBox.Items.Add(varos);
                }
            }
        }
        void LatvanyossagListazas(int varosid) {
            latvanyossagokListBox.Items.Clear();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, nev, leiras, ar, varos_id FROM latvanyossagok WHERE varos_id = @varosid";
            cmd.Parameters.AddWithValue("@varosid", varosid);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var leiras = reader.GetString("leiras");
                    var ar = reader.GetInt32("ar");
                    var varos_id = reader.GetInt32("varos_id");
                    var latvanyossag = new Latvanyossag(id, nev, leiras, ar, varosid);
                    latvanyossagokListBox.Items.Add(latvanyossag);
                }
            }
        }


        private void VarosHozzaadasButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(varosNeveTextBox.Text) && varosLakossagNumericUpDown.Value > 0) 
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT nev FROM varosok";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var nev = reader.GetString("nev").ToUpper();
                        var megadottnev = varosNeveTextBox.Text.ToUpper();
                        if (nev.Equals(megadottnev))
                        {
                            MessageBox.Show("Ilyen város már van felvéve");
                            return;
                        }
                    }
                }
                cmd.CommandText = "INSERT INTO varosok(id, nev, lakossag) VALUES (null, @nev, @lakossag)";
                cmd.Parameters.AddWithValue("@nev", varosNeveTextBox.Text);
                cmd.Parameters.AddWithValue("@lakossag", varosLakossagNumericUpDown.Value);
                cmd.ExecuteNonQuery();

                VarosListazas();
                varosNeveTextBox.Clear();
                varosLakossagNumericUpDown.Value = 0;
            }
            else {
                MessageBox.Show("Kérjük töltse ki a mezőket");
            }
        }

        private void VarosokListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var varos = (Varos)varosokListBox.SelectedItem;
            var nev = varos.Nev;
            varosKivalasztottIndex = varos.Id;
            kivalasztottVarosLabel.Text = nev;
            LatvanyossagListazas(varosKivalasztottIndex);
        }

        private void VarosTorlesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
