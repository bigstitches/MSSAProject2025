namespace YarnCodeFirst
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            yarnContextBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnRefresh = new Button();
            comboWeight = new ComboBox();
            txtYarnId = new TextBox();
            txtYarnName = new TextBox();
            txtManufacturerId = new TextBox();
            txtManufacturerName = new TextBox();
            txtColor = new TextBox();
            btnAddNew = new Button();
            btnSubmit = new Button();
            btnSelectUpdate = new Button();
            yarnGrid = new DataGridView();
            yarnContextBindingSource1 = new BindingSource(components);
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)yarnContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yarnGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yarnContextBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // yarnContextBindingSource
            // 
            yarnContextBindingSource.DataSource = typeof(Data.YarnContext);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 185);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "Yarn ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 230);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Yarn Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 277);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 3;
            label3.Text = "Manufacturer Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 325);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 4;
            label4.Text = "Manufacturer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 430);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 5;
            label5.Text = "Weight";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(151, 378);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 6;
            label6.Text = "Color";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(583, 182);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(203, 49);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // comboWeight
            // 
            comboWeight.FormattingEnabled = true;
            comboWeight.Location = new Point(225, 427);
            comboWeight.Name = "comboWeight";
            comboWeight.Size = new Size(233, 28);
            comboWeight.TabIndex = 8;
            // 
            // txtYarnId
            // 
            txtYarnId.Location = new Point(225, 182);
            txtYarnId.Name = "txtYarnId";
            txtYarnId.Size = new Size(243, 27);
            txtYarnId.TabIndex = 9;
            // 
            // txtYarnName
            // 
            txtYarnName.Location = new Point(225, 230);
            txtYarnName.Name = "txtYarnName";
            txtYarnName.Size = new Size(243, 27);
            txtYarnName.TabIndex = 10;
            // 
            // txtManufacturerId
            // 
            txtManufacturerId.Location = new Point(225, 277);
            txtManufacturerId.Name = "txtManufacturerId";
            txtManufacturerId.Size = new Size(243, 27);
            txtManufacturerId.TabIndex = 11;
            // 
            // txtManufacturerName
            // 
            txtManufacturerName.Location = new Point(225, 325);
            txtManufacturerName.Name = "txtManufacturerName";
            txtManufacturerName.Size = new Size(243, 27);
            txtManufacturerName.TabIndex = 12;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(225, 375);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(243, 27);
            txtColor.TabIndex = 13;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(583, 249);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(203, 48);
            btnAddNew.TabIndex = 14;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(583, 314);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(203, 48);
            btnSubmit.TabIndex = 15;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnSelectUpdate
            // 
            btnSelectUpdate.Location = new Point(583, 375);
            btnSelectUpdate.Name = "btnSelectUpdate";
            btnSelectUpdate.Size = new Size(203, 48);
            btnSelectUpdate.TabIndex = 16;
            btnSelectUpdate.Text = "Select To Update";
            btnSelectUpdate.UseVisualStyleBackColor = true;
            // 
            // yarnGrid
            // 
            yarnGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            yarnGrid.Location = new Point(52, 14);
            yarnGrid.Name = "yarnGrid";
            yarnGrid.RowHeadersWidth = 51;
            yarnGrid.Size = new Size(895, 127);
            yarnGrid.TabIndex = 17;
            // 
            // yarnContextBindingSource1
            // 
            yarnContextBindingSource1.DataSource = typeof(Data.YarnContext);
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(583, 440);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(203, 48);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(583, 508);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(203, 48);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 708);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(yarnGrid);
            Controls.Add(btnSelectUpdate);
            Controls.Add(btnSubmit);
            Controls.Add(btnAddNew);
            Controls.Add(txtColor);
            Controls.Add(txtManufacturerName);
            Controls.Add(txtManufacturerId);
            Controls.Add(txtYarnName);
            Controls.Add(txtYarnId);
            Controls.Add(comboWeight);
            Controls.Add(btnRefresh);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)yarnContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)yarnGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)yarnContextBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource yarnContextBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnRefresh;
        private ComboBox comboWeight;
        private TextBox txtYarnId;
        private TextBox txtYarnName;
        private TextBox txtManufacturerId;
        private TextBox txtManufacturerName;
        private TextBox txtColor;
        private Button btnAddNew;
        private Button btnSubmit;
        private Button btnSelectUpdate;
        private DataGridView yarnGrid;
        private BindingSource yarnContextBindingSource1;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
