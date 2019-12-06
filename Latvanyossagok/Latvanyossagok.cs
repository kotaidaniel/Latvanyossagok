using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latvanyossagok
{
    public partial class Latvanyossagok : Form
    {
        MySqlConnection conn;
        int varosKivalasztottIndex;
        int latvanyossagKivalasztottIndex;
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
            if (varosHozzaadasButton.Enabled == true && varosLakossagNumericUpDown.Value > 0) 
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
            var lakossag = varos.Lakossag;
            varosKivalasztottIndex = varos.Id;
            kivalasztottVarosLabel.Text = nev;
            latvanyossagModositottVarosValtas.Text = nev;
            varosModositottNevTextBox.Text = nev;
            varosModositottLakossagNumericUpDown.Value = lakossag;
            varosTorlesButton.Enabled = true;
            varosModositasButton.Enabled = true;
            LatvanyossagListazas(varosKivalasztottIndex);
            LatvanyossagEllenorzo();
    }

        private void VarosTorlesButton_Click(object sender, EventArgs e)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM latvanyossagok WHERE varos_id = @id";
            cmd.Parameters.AddWithValue("@id", varosKivalasztottIndex);
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DELETE FROM varosok WHERE id = @latid";
            cmd.Parameters.AddWithValue("@latid", varosKivalasztottIndex);
            cmd.ExecuteNonQuery();
            VarosListazas();
            LatvanyossagListazas(-1);
        }

        private void LatvanyossagHozzaadasButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(latvanyossagNeveTextBox.Text) && !string.IsNullOrWhiteSpace(latvanyossagLeirasaTextBox.Text) && latvanyossagNumericUpDown.Value >= 0 && varosokListBox.SelectedIndex != -1)
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT nev FROM latvanyossagok";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var nev = reader.GetString("nev").ToUpper();
                        var megadottnev = latvanyossagNeveTextBox.Text.ToUpper();
                        if (nev.Equals(megadottnev))
                        {
                            MessageBox.Show("Ilyen látványosság már van felvéve");
                            return;
                        }
                    }
                }
                cmd.CommandText = "INSERT INTO latvanyossagok(id, nev, leiras, ar, varos_id) VALUES (null, @nev, @leiras, @ar, @varos_id)";
                cmd.Parameters.AddWithValue("@nev", latvanyossagNeveTextBox.Text);
                cmd.Parameters.AddWithValue("@leiras", latvanyossagLeirasaTextBox.Text);
                cmd.Parameters.AddWithValue("@ar", latvanyossagNumericUpDown);
                cmd.Parameters.AddWithValue("@varos_id", varosKivalasztottIndex);

                cmd.ExecuteNonQuery();
                latvanyossagNeveTextBox.Clear();
                latvanyossagLeirasaTextBox.Clear();
                latvanyossagNumericUpDown.Value = 0;
                LatvanyossagListazas(varosKivalasztottIndex);
            }
            else
            {
                MessageBox.Show("Kérjük töltse ki érvényes adatokkal az ívet, valamint válasszon ki egy várost a listából");
            }
        }

        private void LatvanyossagTorlesButton_Click(object sender, EventArgs e)
        {
            var cmd = conn.CreateCommand();
            var latvanyossag = (Latvanyossag)latvanyossagokListBox.SelectedItem;
            var id = latvanyossag.Id;
            cmd.CommandText = "DELETE FROM latvanyossagok WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            LatvanyossagListazas(varosKivalasztottIndex);
        }

        private void VarosModositasButton_Click(object sender, EventArgs e)
        {
            varosGroupBox.Visible = false;
            varosModositasGroupBox.Visible = true;
            var varos = (Varos)varosokListBox.SelectedItem;
            varosModositottNevTextBox.Text = varos.Nev;
            varosModositottLakossagNumericUpDown.Value = varos.Lakossag;
            
        }

        private void VarosNeveTextBox_TextChanged(object sender, EventArgs e)
        {
            VarosEllenorzo();
        }


        private void LatvanyossagLeirasaTextBox_TextChanged(object sender, EventArgs e)
        {
            LatvanyossagEllenorzo();
        }


        public void LatvanyossagEllenorzo() {
            var regexItem = new Regex("^[A-Za-záéiíoóöőuúüűÁÉIÍOÓÖŐUÚÜŰä ]*$");
            if (regexItem.IsMatch(latvanyossagNeveTextBox.Text) && !string.IsNullOrWhiteSpace(latvanyossagNeveTextBox.Text) && !string.IsNullOrWhiteSpace(latvanyossagLeirasaTextBox.Text) && varosokListBox.SelectedIndex != -1)
            {
                latvanyossagHozzaadasButton.Enabled = true;
            }
            else
            {
                latvanyossagHozzaadasButton.Enabled = false;
            }
        }
        public void VarosEllenorzo()
        {
            var regexItem = new Regex("^[A-Za-záéiíoóöőuúüűÁÉIÍOÓÖŐUÚÜŰä]*$");
            if (regexItem.IsMatch(varosNeveTextBox.Text) && !string.IsNullOrWhiteSpace(varosNeveTextBox.Text) && varosLakossagNumericUpDown.Value > 0)
            {
                varosHozzaadasButton.Enabled = true;
            }
            else
            {
                varosHozzaadasButton.Enabled = false;
            }
        }
        private void LatvanyossagNeveTextBox_TextChanged(object sender, EventArgs e)
        {
            LatvanyossagEllenorzo();
        }

        private void VarosLakossagNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            VarosEllenorzo();
        }

        private void LatvanyossagokListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (latvanyossagokListBox.SelectedIndex != -1) {
                var latvanyossag = (Latvanyossag)latvanyossagokListBox.SelectedItem;
                latvanyossagKivalasztottIndex = latvanyossag.Id;
                latvanyossagModositasButton.Enabled = true;
                LatvanyossagTorlesButton.Enabled = true;
            }
        }
        private void VarosModositasVegrehajtButton_Click(object sender, EventArgs e)
        {
            var varos = (Varos)varosokListBox.SelectedItem;
            var id = varos.Id;
            var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE varosok SET nev = @nev, lakossag = @lakossag WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nev", varosModositottNevTextBox.Text);
            cmd.Parameters.AddWithValue("@lakossag", varosModositottLakossagNumericUpDown.Value);

            cmd.ExecuteNonQuery();
            varosModositasGroupBox.Visible = false;
            varosGroupBox.Visible = true;
            VarosListazas();
        }
        public void VarosModositasEllenorzes() {
            var regexItem = new Regex("^[A-Za-záéiíoóöőuúüűÁÉIÍOÓÖŐUÚÜŰä]*$");
            if (regexItem.IsMatch(varosModositottNevTextBox.Text) && !string.IsNullOrWhiteSpace(varosModositottNevTextBox.Text) && varosModositottLakossagNumericUpDown.Value > 0)
            {
                varosModositasVegrehajtButton.Enabled = true;
            }
            else
            {
                varosModositasVegrehajtButton.Enabled = false;
            }
        }

        private void VarosModositottNevTextBox_TextChanged(object sender, EventArgs e)
        {
            VarosModositasEllenorzes();
        }

        private void VarosModositottLakossagNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            VarosModositasEllenorzes();
        }

        private void LatvanyossagModositasButton_Click(object sender, EventArgs e)
        {
            latvanyossagokGroupBox.Visible = false;
            latvanyossagModositasGroupBox.Visible = true;
            var latvanyossag = (Latvanyossag)latvanyossagokListBox.SelectedItem;
            var nev = latvanyossag.Nev;
            var leiras = latvanyossag.Leiras;
            var ar = latvanyossag.Ar;
            latvanyossagModositottNevTextBox.Text = nev;
            latvanyossagModositottLeirasTextBox.Text = leiras;
            latvanyossagModositottArNumericUpDown.Value = ar;

        }

        private void LatvanyossagModositasVegrehajtButton_Click(object sender, EventArgs e)
        {
                var latvanyossag = (Latvanyossag)latvanyossagokListBox.SelectedItem;
                var id = latvanyossag.Id;
                var varos = (Varos)varosokListBox.SelectedItem;
                var varid = varos.Id;
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE latvanyossagok SET nev = @nev, leiras = @leiras, ar = @ar WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nev", latvanyossagModositottNevTextBox.Text);
                cmd.Parameters.AddWithValue("@leiras", latvanyossagModositottLeirasTextBox.Text);
                cmd.Parameters.AddWithValue("@ar", latvanyossagModositottArNumericUpDown.Value);
                cmd.ExecuteNonQuery();

                latvanyossagModositasGroupBox.Visible = false;
                latvanyossagokGroupBox.Visible = true;
                LatvanyossagListazas(varosKivalasztottIndex);
        }

        private void LatvanyossagModositottNevTextBox_TextChanged(object sender, EventArgs e)
        {
            LatvanyossagModositasEllenorzes();
        }

        private void LatvanyossagModositottLeirasTextBox_TextChanged(object sender, EventArgs e)
        {
            LatvanyossagModositasEllenorzes();
        }
        public void LatvanyossagModositasEllenorzes() {
            if (!string.IsNullOrWhiteSpace(latvanyossagModositottNevTextBox.Text) && !string.IsNullOrWhiteSpace(latvanyossagModositottLeirasTextBox.Text))
            {
                latvanyossagModositasVegrehajtButton.Enabled = true;
            }
            else
            {
                latvanyossagModositasVegrehajtButton.Enabled = false;
            }
        }
    }
}
