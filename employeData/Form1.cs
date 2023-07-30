using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace employeData
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        void reset()
        {
            txtid.Clear();
            txtName.Clear();
            cmbDesig.Text = null;
            ageField.Value = 22;
            txtSalary.Clear();
            txtid.Focus();

        }
        void display()
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\divya\OneDrive\Documents\Database1.accdb");

            string query = "select * from Employee";
            OleDbDataAdapter da = new OleDbDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text) == true)
            {
                txtid.Focus();
                errorProvider1.SetError(this.txtid, "Please Enter Employee Id");
            }
            else if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                txtName.Focus();
                errorProvider2.SetError(txtName, "Please Enter Employee Name");
            }
            else if (string.IsNullOrEmpty(ageField.Text) == true)
            {
                ageField.Focus();
                errorProvider3.SetError(ageField, "Please Enter Employee Age");
            }
            else if (string.IsNullOrEmpty(txtSalary.Text) == true)
            {
                txtSalary.Focus();
                errorProvider4.SetError(txtSalary, "Please Enter Employee Salary");
            }
            else if (string.IsNullOrEmpty(cmbDesig.Text) == true)
            {
                cmbDesig.Focus();
                errorProvider5.SetError(cmbDesig, "Please Enter Employee Id");
            }
            else
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
                errorProvider5.Clear();

                OleDbConnection con = new OleDbConnection(cs);
                con.Open();
                string query2 = "select * from employee where id = @id";
                OleDbCommand cmd2 = new OleDbCommand(query2, con);
                cmd2.Parameters.AddWithValue("@id", txtid.Text);
                OleDbDataReader dr = cmd2.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show(txtid.Text + " ID Already Exists!!");
                }
                else
                {
                    string query = "insert into employee values(@id, @ename, @age, @designation, @salary)";
                    OleDbCommand cmd = new OleDbCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", txtid.Text);
                    cmd.Parameters.AddWithValue("@ename", txtName.Text);
                    cmd.Parameters.AddWithValue("@age", ageField.Value);
                    cmd.Parameters.AddWithValue("@designation", cmbDesig.Text);
                    cmd.Parameters.AddWithValue("@salary", txtSalary.Text);

                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Record Saved Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("FAILED", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    display();
                    reset();
                    con.Close();
                }
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            display();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            cmbDesig.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtSalary.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            ageField.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();

            string query = "update  employee set id =@id,ename=@ename,age =@age,designation=@designation,salary = @salary where id =@id";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", txtid.Text);
            cmd.Parameters.AddWithValue("@ename", txtName.Text);
            cmd.Parameters.AddWithValue("@age", ageField.Value);
            cmd.Parameters.AddWithValue("@designation", cmbDesig.Text);
            cmd.Parameters.AddWithValue("@salary", txtSalary.Text);

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Record Updated Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();
                reset();
            }
            else
            {
                MessageBox.Show("FAILED", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();

            string query = "delete from  employee where id =@id";
            OleDbCommand Cmd = new OleDbCommand(query, con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@id", txtid.Text);
            int a = Cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Record DELETED Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();
                reset();
            }
            else
            {
                MessageBox.Show("FAILED", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();

            string query = "select * from  employee where ename like @ename";
            OleDbDataAdapter da = new OleDbDataAdapter(query,con);
            da.SelectCommand.Parameters.AddWithValue("@ename", txtSearch.Text); 
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            if(dt.Rows.Count > 0) { 
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Record Found!!!");
            }
        }
    }
}