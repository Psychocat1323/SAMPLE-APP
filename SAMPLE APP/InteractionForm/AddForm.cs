using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SAMPLE_APP.InteractionForm
{
    public partial class AddForm : Form
    {
        SQLClass sQLClass = new SQLClass();
        public event EventHandler fireShow;
        public AddForm()
        {
            InitializeComponent();
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO SampleTable VALUES(" + GenerateId(2, 999999) + "," + Int32.Parse(txtQuantity.Text) + ",'" + txtProdName.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            sQLClass.InvokeExecuteQuery(query);
            fireShow?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private int GenerateId(int minValue, int maxValue)
        {
            HashSet<int> usedIds = new HashSet<int>();
            Random random = new Random();
            int newId;
            do
            {
                newId = random.Next(minValue, maxValue);
            } while (!usedIds.Add(newId));


            return newId;
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

            } else if (!int.TryParse(txtQuantity.Text, out int result))
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
