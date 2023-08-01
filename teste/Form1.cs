using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace teste
{
    public partial class Form1 : Form
    {
        Thread t;
        string strConnection = @"Data Source=MATEUSBRANDL;Initial Catalog=teste;Integrated Security=true";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            insert(txtId.Text, txtName.Text);
        }

        private void insert(string id, string nome)
        {
            SqlConnection SqlCon = new SqlConnection(strConnection);
            string strSql = "insert into pessoa values (" + id + " , '" + nome + "')";
            SqlCommand sqlcomd = new SqlCommand(strSql, SqlCon);

            sqlcomd.Connection.Open();
            sqlcomd.ExecuteNonQuery();

            SqlCon.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update(txtId.Text, txtName.Text);
        }

        private void update(string id, string nome)
        {
            SqlConnection SqlCon = new SqlConnection(strConnection);
            string strSql = "update pessoa  set nome= '" + nome + "' where id= '" + id + "';";
            SqlCommand sqlcomd = new SqlCommand(strSql, SqlCon);

            sqlcomd.Connection.Open();
            sqlcomd.ExecuteNonQuery();
            SqlCon.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete(txtId.Text);
        }

        private void delete(string id)
        {
            SqlConnection SqlCon = new SqlConnection(strConnection);
            string strSql = "delete from pessoa where id = '" + id + "';";
            SqlCommand sqlcomd = new SqlCommand(strSql, SqlCon);

            sqlcomd.Connection.Open();
            sqlcomd.ExecuteNonQuery();
            SqlCon.Close();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            txtName.Text = serch(txtId.Text);
        }

        string serch(string id)
        {
            SqlConnection sqlCon = new SqlConnection(strConnection);
            string strsql = "select nome from pessoa where id = '" + id + "';";
            DataSet dsSQLDataSet = new DataSet();
            SqlDataAdapter daAdapter = new SqlDataAdapter(strsql, sqlCon);

            sqlCon.Open();
            daAdapter.Fill(dsSQLDataSet);
            string name = dsSQLDataSet.Tables[0].Rows[0][0].ToString();
            sqlCon.Close();
            return name;
        }

        private void allTable_Click(object sender, EventArgs e)
        {
            Form2 segundaJanela = new Form2();
            segundaJanela.Show();
        }
    }
}