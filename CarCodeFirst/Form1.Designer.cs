namespace CarCodeFirst
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
            label1 = new Label();
            txtVIN = new TextBox();
            btnRefresh = new Button();
            carGrid = new DataGridView();
            btnAddNew = new Button();
            txtMake = new TextBox();
            label2 = new Label();
            btnSubmit = new Button();
            txtModel = new TextBox();
            label3 = new Label();
            btnSelect = new Button();
            txtYear = new TextBox();
            label4 = new Label();
            btnUpdate = new Button();
            txtPrice = new TextBox();
            label5 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)carGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 210);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 0;
            label1.Text = "VIN";
            // 
            // txtVIN
            // 
            txtVIN.Location = new Point(259, 210);
            txtVIN.Name = "txtVIN";
            txtVIN.Size = new Size(125, 27);
            txtVIN.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(436, 252);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // carGrid
            // 
            carGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carGrid.Location = new Point(31, 12);
            carGrid.Name = "carGrid";
            carGrid.RowHeadersWidth = 51;
            carGrid.Size = new Size(731, 157);
            carGrid.TabIndex = 3;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(436, 298);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(94, 29);
            btnAddNew.TabIndex = 6;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(259, 256);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(125, 27);
            txtMake.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 256);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 4;
            label2.Text = "Make";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(546, 298);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(259, 307);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 307);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 7;
            label3.Text = "Model";
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(436, 349);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 12;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(259, 358);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 358);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 10;
            label4.Text = "Year";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(546, 349);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(259, 411);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 411);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 13;
            label5.Text = "Price";
            // 
            // button1
            // 
            button1.Location = new Point(546, 252);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 512);
            Controls.Add(button1);
            Controls.Add(btnUpdate);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(btnSelect);
            Controls.Add(txtYear);
            Controls.Add(label4);
            Controls.Add(btnSubmit);
            Controls.Add(txtModel);
            Controls.Add(label3);
            Controls.Add(btnAddNew);
            Controls.Add(txtMake);
            Controls.Add(label2);
            Controls.Add(carGrid);
            Controls.Add(btnRefresh);
            Controls.Add(txtVIN);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)carGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtVIN;
        private Button btnRefresh;
        private DataGridView carGrid;
        private Button btnAddNew;
        private TextBox txtMake;
        private Label label2;
        private Button btnSubmit;
        private TextBox txtModel;
        private Label label3;
        private Button btnSelect;
        private TextBox txtYear;
        private Label label4;
        private Button btnUpdate;
        private TextBox txtPrice;
        private Label label5;
        private Button button1;
    }
}
