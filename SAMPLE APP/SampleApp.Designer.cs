namespace SAMPLE_APP
{
    partial class SampleApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Addbutton = new Button();
            Updatebtn = new Button();
            deleteBtn = new Button();
            LABEL1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(737, 343);
            dataGridView1.TabIndex = 0;
            dataGridView1.DataSourceChanged += dataGridView1_DataSourceChanged;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Addbutton
            // 
            Addbutton.BackColor = Color.MediumSeaGreen;
            Addbutton.Location = new Point(36, 399);
            Addbutton.Name = "Addbutton";
            Addbutton.Size = new Size(96, 39);
            Addbutton.TabIndex = 1;
            Addbutton.Text = "ADD";
            Addbutton.UseVisualStyleBackColor = false;
            Addbutton.Click += button1_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.BackColor = Color.Aqua;
            Updatebtn.Location = new Point(138, 399);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(96, 39);
            Updatebtn.TabIndex = 2;
            Updatebtn.Text = "UPDATE";
            Updatebtn.UseVisualStyleBackColor = false;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Firebrick;
            deleteBtn.Location = new Point(653, 399);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(96, 39);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // LABEL1
            // 
            LABEL1.AutoSize = true;
            LABEL1.Font = new Font("Constantia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LABEL1.Location = new Point(298, 4);
            LABEL1.Name = "LABEL1";
            LABEL1.Size = new Size(159, 29);
            LABEL1.TabIndex = 4;
            LABEL1.Text = "SAMPLE APP";
            // 
            // SampleApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LABEL1);
            Controls.Add(deleteBtn);
            Controls.Add(Updatebtn);
            Controls.Add(Addbutton);
            Controls.Add(dataGridView1);
            Name = "SampleApp";
            Text = "APP";
            Load += SampleApp_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Addbutton;
        private Button Updatebtn;
        private Button deleteBtn;
        private Label LABEL1;
    }
}
