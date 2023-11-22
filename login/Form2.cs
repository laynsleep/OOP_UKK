using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace login
{
    public partial class Form2 : Form
    {
        MySqlConnection conn = connectionservice.getConnection();
        DataTable dataTable = new DataTable();

        public Form2()
        {
            InitializeComponent();
        }

        public DataTable getDataPenduduk()
        {
            dataTable.Reset();
            dataTable = new DataTable();

            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
            check.ValueType = typeof(bool);
            check.Name = "Check";
            this.dataGridView1.Columns.Add(check);

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM data_orang", conn))
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;

        }

        public void filldataTable()
        {
            dataGridView1.DataSource = getDataPenduduk();
            resetIncrement();

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            edit.Name = "";
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;
            this.dataGridView1.Columns.Add(edit);

            hapusDataPenduduk();
        }

        private void resetIncrement()
        {
            int id = 1;
            int maxInc = int.Parse(dataTable.Rows.Count.ToString());
            for (int i = 0; i < maxInc; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;
                string idinc = $"update data_orang set id = '{id}' where id = '{dataGridView1.Rows[i].Cells[1].Value}'";
                MySqlCommand cmd = new MySqlCommand(idinc, conn);
                cmd.ExecuteNonQuery();
                id++;
            }
            maxIncrement();
            conn.Close();
            dataGridView1.Columns.Clear();
            dataTable.Clear();
            dataGridView1.DataSource = getDataPenduduk();
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 70;
            for (int i = 1; i == 4; i++)
            {
                dataGridView1.Columns[i].ReadOnly = true;
            }
        }

        private void maxIncrement()
        {
            int maxInc = int.Parse(dataTable.Rows.Count.ToString());
            string resetMax = $"ALTER TABLE data_orang AUTO_INCREMENT = {maxInc}";
            MySqlCommand cmd = new MySqlCommand(resetMax, conn);
            cmd.ExecuteNonQuery();
        }

        private void hapusDataPenduduk()
        {
            DataGridViewButtonColumn hapusButtonKolom = new DataGridViewButtonColumn();
            hapusButtonKolom.Name = "";
            hapusButtonKolom.Text = "Hapus";
            hapusButtonKolom.UseColumnTextForButtonValue = true;
            this.dataGridView1.Columns.Add(hapusButtonKolom);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            filldataTable();
            /*textNama.Enabled = false;
            textUmur.Enabled = false;
            textAsal.Enabled = false;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inNama = textNama.Text;
            string inUmur = textUmur.Text;
            string inAsal = textAsal.Text;
            string insert = $"insert into data_orang values ('', '{inNama}', '{inUmur}', '{inAsal}');";

            MySqlCommand cmd = new MySqlCommand(insert, conn);
            cmd.ExecuteReader();
            conn.Close();
            dataGridView1.Columns.Clear();
            dataTable.Clear();
            filldataTable();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            
            MySqlCommand cmd;
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "update data_orang set nama = @nama, umur = @umur, asal = @asal where id = @id";
                cmd.Parameters.AddWithValue("@id", textId.Text);
                cmd.Parameters.AddWithValue("@nama", textNama.Text);
                cmd.Parameters.AddWithValue("@umur", textUmur.Text);
                cmd.Parameters.AddWithValue("@asal", textAsal.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                dataGridView1.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception ex)
            {
                // ex.Message.Endswith("")
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());
                textId.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
                textNama.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
                textUmur.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
                textAsal.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();

                textId.Enabled = true;
                textNama.Enabled = true;
                textUmur.Enabled = true;
                textAsal.Enabled = true;
            }

            if (e.ColumnIndex == 6)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());
                string delId = dataGridView1.Rows[id].Cells[1].Value.ToString();
                string delete = $"delete from data_orang where id = {delId}";

                MySqlCommand cmd = new MySqlCommand(delete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                dataGridView1.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchData(searchBox.Text);
        }

        private void searchData (string ValueToFind)
        {
            string searchQuery = "select * from data_orang where concat(nama, umur, asal) like '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            Form3 confirm = new Form3();
            DialogResult konfirmasi = confirm.ShowDialog();

            if (konfirmasi == DialogResult.Yes)
            {
                int row = int.Parse(dataTable.Rows.Count.ToString());
                for (int i = 0; i < row; i++)
                {
                    var cbCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells["Check"];
                    if (cbCell.Value != null && (bool)cbCell.Value)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "True")
                        {
                            string idinc = $"delete from data_orang where id = '{dataGridView1.Rows[i].Cells[1].Value}'";
                            MySqlCommand cmd = new MySqlCommand(idinc, conn);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            else if (konfirmasi == DialogResult.Cancel)
            {
                string idinc = $"delete from data_orang";
                MySqlCommand cmd = new MySqlCommand(idinc, conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
            dataGridView1.Columns.Clear();
            dataTable.Clear();
            filldataTable();
        }
    }
}
