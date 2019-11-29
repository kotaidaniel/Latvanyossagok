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
            }
            else {
                MessageBox.Show("Kérjük töltse ki a mezőket");
            }
        }
    }
}
