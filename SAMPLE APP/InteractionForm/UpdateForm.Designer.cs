namespace SAMPLE_APP.InteractionForm
{
    partial class UpdateForm
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
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtProdID = new TextBox();
            txtQuantity = new TextBox();
            txtProdName = new TextBox();
            btnUpdate = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 112);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 11;
            label2.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 20);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 9;
            label3.Text = "Product ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 64);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 10;
            label1.Text = "Product Name:";
            // 
            // txtProdID
            // 
            txtProdID.Enabled = false;
            txtProdID.Location = new Point(94, 17);
            txtProdID.Name = "txtProdID";
            txtProdID.Size = new Size(131, 23);
            txtProdID.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(94, 104);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(131, 23);
            txtQuantity.TabIndex = 8;
            txtQuantity.Validating += txtQuantity_Validating;
            // 
            // txtProdName
            // 
            txtProdName.Location = new Point(97, 56);
            txtProdName.Name = "txtProdName";
            txtProdName.Size = new Size(131, 23);
            txtProdName.TabIndex = 7;
            txtProdName.Validating += txtProdName_Validating;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(69, 175);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 39);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update Product";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 226);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtProdID);
            Controls.Add(txtQuantity);
            Controls.Add(txtProdName);
            Controls.Add(btnUpdate);
            Name = "UpdateForm";
            Text = "UpdateForm";
            Load += UpdateForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtProdID;
        private TextBox txtQuantity;
        private TextBox txtProdName;
        private Button btnUpdate;
        private ErrorProvider errorProvider1;
    }
}