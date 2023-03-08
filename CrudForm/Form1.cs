using MySql.Data.MySqlClient;
using System.Data;

namespace CrudForm
{
    public partial class CRUD_Form : Form
    {
        private MySqlConnection con;

        public CRUD_Form()
        {
            InitializeComponent();
        }
        string connection = "server=localhost;user id=root;password=;database=crud_db";

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void lblDob_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=crud_db";
            string query = "INSERT INTO tbldetails(Name,Surname,Birthday,Salary)VALUES('" + this.txtName.Text + "','" + this.txtSurname.Text + "','" + this.cboBirthday.Text + "','" + this.cboSalary.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Record has been created !!!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=crud_db";
            string query = "UPDATE tbldetails SET NAME='" + this.txtName.Text + "',Surname='" + this.txtSurname.Text + "',Birthday='" + this.cboBirthday.Text + "',Salary='" + this.cboSalary.Text + "' WHERE ID='" + this.txtId.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Record has been updated !!!");
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=crud_db";
            string query = "DELETE FROM tbldetails WHERE ID='" + this.txtId.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Record has been deleted !!!");
            conn.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=crud_db";
            string query = "SELECT * FROM tbldetails";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void txtBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];
                txtId.Text = dgvRow.Cells[0].Value.ToString();
                txtName.Text = dgvRow.Cells[1].Value.ToString();
                txtSurname.Text = dgvRow.Cells[2].Value.ToString();
                cboBirthday.Text = dgvRow.Cells[3].Value.ToString();
                cboSalary.Text = dgvRow.Cells[4].Value.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchData(txtSearch.Text);

        }

        public void searchData(string valueToFind)
        {

            string searchQuery = "SELECT * FROM tblDetails WHERE CONCAT(id,name,surname) LIKE '%" + valueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}