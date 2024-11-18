using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMPLE_APP.InteractionForm
{
    public partial class UpdateForm : Form
    {

        private ProductInterface Product_Interface;
        public event EventHandler fireShow;
        SQLClass sQLClass = new SQLClass();


        public UpdateForm(ProductInterface Iprod)
        {
            InitializeComponent();
            Product_Interface = Iprod;
        }

        // Executing update query when button is clicked
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text) && !string.IsNullOrEmpty(txtProdID.Text))
            {
                string query = "UPDATE SampleTable SET Quantity = " + Int32.Parse(txtQuantity.Text) + ", ProdName ='" + txtProdName.Text + "' WHERE ProdID =" + Product_Interface.ProductID + " ";
                sQLClass.InvokeExecuteQuery(query);
                fireShow?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            txtProdID.Text = Product_Interface.ProductID.ToString();
            txtProdName.Text = Product_Interface.ProdName;
            txtQuantity.Text = Product_Interface.Quantity.ToString();
        }

       
        // TextBox Validation
        private void txtProdName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtProdName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtProdName, "Please put a product name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtQuantity, "Please put a Quantity");

            }
            else if (!int.TryParse(txtQuantity.Text, out int result))
            {
                errorProvider1.SetError(txtQuantity, "Data inputed is not a number");
                e.Cancel = true;
                txtQuantity.Text = string.Empty;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }
    }
}
