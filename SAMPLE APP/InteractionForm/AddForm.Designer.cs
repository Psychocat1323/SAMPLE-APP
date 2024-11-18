namespace SAMPLE_APP.InteractionForm
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnAdd = new Button();
            txtProdName = new TextBox();
            txtQuantity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(63, 116);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 39);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtProdName
            // 
            txtProdName.Location = new Point(103, 21);
            txtProdName.Name = "txtProdName";
            txtProdName.Size = new Size(131, 23);
            txtProdName.TabIndex = 1;
            txtProdName.Validating += txtProdName_Validating;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(100, 69);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(131, 23);
            txtQuantity.TabIndex = 2;
            txtQuantity.Validating += txtQuantity_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 29);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 3;
            label1.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 77);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "Quantity:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 159);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQuantity);
            Controls.Add(txtProdName);
            Controls.Add(btnAdd);
            Name = "AddForm";
            Text = "Update Product";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtProdName;
        private TextBox txtQuantity;
        private Label label1;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}