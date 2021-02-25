using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kontaktandmed
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\Faskin\Kontaktandmed\Appdata\Ryhm.mdf;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter, adapter2;
        string searchValue = "somestring";
        int rowIndex = -1;
        Form2 form2 = new Form2();

        int Id = 0;
        public Form1()
        {

            InitializeComponent();
            LoadData();
            DisplayData();

            /*foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(searchValue))
                {
                    rowIndex = row.Index;
                    break;
                }
            }
            */
        }
        private BindingSource bindingSource1 = new BindingSource();

        private void ClearData()
        {
            Nimitxt.Text = "";
            Teltxt.Text = "";
            emailtxt.Text = "";

        }

        private void LoadData()
        {
            connect.Open();
            string query = "SELECT *FROM TARpv19 ORDER BY Id";
            adapter = new SqlDataAdapter(query, connect);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connect.Close();
        }


        private void btn_new_Click(object sender, EventArgs e)
        {
            if (Nimitxt.Text != "" && Teltxt.Text != "" && emailtxt.Text != "")
            {
                try
                {
                    command = new SqlCommand("INSERT INTO TARpv19(Nimi,Tel,Email,Pilt) VALUES(@nimi,@tel,@email,@pilt)", connect);
                    connect.Open();
                    command.Parameters.AddWithValue("@nimi", Nimitxt.Text);
                    command.Parameters.AddWithValue("@tel", Teltxt.Text);
                    command.Parameters.AddWithValue("@email", emailtxt.Text);
                    string file_pilt = Nimitxt.Text + ".jpg";
                    command.Parameters.AddWithValue("@pilt", file_pilt);
                    //command.Parameters.AddWithValue("@kat", (comboBox1.SelectedIndex + 1));
                    command.ExecuteNonQuery();
                    connect.Close();
                    DisplayData();
                    ClearData();
                    MessageBox.Show("Andmed on lisatud");
                }

                catch (Exception)
                {

                    MessageBox.Show("Viga lisamisega");
                }
            }
            else
            {
                MessageBox.Show("Viga else");
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                command = new SqlCommand("DELETE TARpv19 WHERE Id=@id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.ExecuteNonQuery();
                connect.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed on kustutatud");
            }
            else
            {
                MessageBox.Show("Viga kustutamisega");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Nimitxt.Text != "" && Teltxt.Text != "" && emailtxt.Text != "")
            {
                command = new SqlCommand("UPDATE TAR SET Nimi=@nimi,Eesnimi=@ees,Foto=@foto,Telefon=@tel,Gmail=@gm WHERE Id=@id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@nimi", Nimitxt.Text);
                command.Parameters.AddWithValue("@pilt", Teltxt.Text);
                command.Parameters.AddWithValue("@tel", Teltxt.Text);
                command.Parameters.AddWithValue("@email", emailtxt.Text);
                string file_pilt = Nimitxt.Text + ".jpg";

            }
        }


        private void email_btn_Click(object sender, EventArgs e)
        {
            form2.Show();

        }

        private void DisplayData()
        {
            connect.Open();
            DataTable tabel = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM  TARpv19", connect);//, Kategooria WHERE Toodetable.Kategooria_Id=Kategooria.Id
            adapter.Fill(tabel);
            dataGridView1.DataSource = tabel;

            
            connect.Close();
        }

    }
}
