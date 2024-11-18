using System.Data;
using System.Drawing.Text;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace SAMPLE_APP
{
    public partial class SampleApp : Form, ProductInterface
    {
        SQLClass connectionClass = new SQLClass();
        SqlCommand CommandQuery = new SqlCommand();

        private int _productID;
        private string _productName;
        private int _quantity;
        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }

        public string ProdName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public SampleApp()
        {
            InitializeComponent();
        }

        // load application
        private void SampleApp_Load(object sender, EventArgs e)
        {
            ShowSQLData(this, EventArgs.Empty);
        }

        // Update Button
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            InteractionForm.UpdateForm updateform = new InteractionForm.UpdateForm(this);
            updateform.fireShow += ShowSQLData;
            updateform.ShowDialog();
        }

        // Delete Button
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult userResult = MessageBox.Show("Are you sure you want to delete 'PRODUCT ID': " + ProductID + "", "BE CAREFUL", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (userResult)
            {
                case DialogResult.Yes:
                    string query = "DELETE FROM SampleTable WHERE ProdID = " + ProductID + " ";
                   connectionClass.InvokeExecuteQuery(query);
                    ShowSQLData(this, EventArgs.Empty);
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        // Insert button
        private void button1_Click(object sender, EventArgs e)
        {
            InteractionForm.AddForm addform = new InteractionForm.AddForm();
            addform.fireShow += ShowSQLData;
            addform.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells[0].Value != null && !string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                {
                    ProductID = Int32.Parse(row.Cells[0].Value.ToString());
                    ProdName = row.Cells[1].Value.ToString();
                    Quantity = Int32.Parse(row.Cells[2].Value.ToString());
                }

            }
        }



        // Functions 
        private void ShowSQLData(object sender, EventArgs e)
        {
            CommandQuery = connectionClass.InvokePrepareQuery("SELECT ProdID as 'Product ID', ProdName AS 'Product Name',Quantity,DateCreated as 'DATE' FROM SampleTable ORDER BY DATE DESC");

            if (CommandQuery == null)
            {
                MessageBox.Show("Failed to prepare query.");
                return;
            }

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(CommandQuery))
            {
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }

        }

     

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count >= 0)
            {
               
                dataGridView1.ClearSelection(); 
                dataGridView1.Rows[0].Selected = true;

               
                dataGridView1.FirstDisplayedScrollingRowIndex = 0;

              
                var firstRow = dataGridView1.Rows[0];
                ProductID = Convert.ToInt32(firstRow.Cells[0].Value);
                ProdName = firstRow.Cells[1].Value?.ToString();       
                Quantity = Convert.ToInt32(firstRow.Cells[2].Value); 

             
            }
        }



    }
}
