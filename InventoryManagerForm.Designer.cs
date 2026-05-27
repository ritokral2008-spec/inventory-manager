namespace InventoryManager
{
    partial class InventoryManagerForm
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
            if(disposing && (components != null))
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
            lblName = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            tbxName = new TextBox();
            tbxCategory = new TextBox();
            tbxPrice = new TextBox();
            tbxQuantity = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            textBox1 = new TextBox();
            lblSearch = new Label();
            dataGridViewProducts = new DataGridView();
            btnExport = new Button();
            lblSearch2 = new Label();
            tbxSearch = new TextBox();
            cbCategory = new ComboBox();
            lblCategory2 = new Label();
            lblMinPrice = new Label();
            cbDirection = new ComboBox();
            numMinPrice = new NumericUpDown();
            lblSort = new Label();
            cbSort = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinPrice).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(24, 29);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(24, 75);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(50, 20);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "label2";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(24, 124);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(50, 20);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "label3";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(24, 171);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(50, 20);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "label4";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(127, 26);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(178, 27);
            tbxName.TabIndex = 4;
            // 
            // tbxCategory
            // 
            tbxCategory.Location = new Point(127, 168);
            tbxCategory.Name = "tbxCategory";
            tbxCategory.Size = new Size(178, 27);
            tbxCategory.TabIndex = 5;
            // 
            // tbxPrice
            // 
            tbxPrice.Location = new Point(127, 124);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(178, 27);
            tbxPrice.TabIndex = 6;
            // 
            // tbxQuantity
            // 
            tbxQuantity.Location = new Point(127, 75);
            tbxQuantity.Name = "tbxQuantity";
            tbxQuantity.Size = new Size(178, 27);
            tbxQuantity.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 221);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 40);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(145, 221);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 40);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(290, 221);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 40);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(427, 221);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 40);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 286);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 27);
            textBox1.TabIndex = 12;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(22, 289);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 13;
            lblSearch.Text = "Search";
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(24, 343);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(705, 386);
            dataGridViewProducts.TabIndex = 14;
            dataGridViewProducts.CellClick += dataGridViewProducts_CellClick;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(24, 750);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(112, 48);
            btnExport.TabIndex = 15;
            btnExport.Text = "Export to Excel";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // lblSearch2
            // 
            lblSearch2.AutoSize = true;
            lblSearch2.Location = new Point(858, 43);
            lblSearch2.Name = "lblSearch2";
            lblSearch2.Size = new Size(53, 20);
            lblSearch2.TabIndex = 16;
            lblSearch2.Text = "Search";
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(954, 40);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(181, 27);
            tbxSearch.TabIndex = 17;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(861, 124);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 28);
            cbCategory.TabIndex = 19;
            // 
            // lblCategory2
            // 
            lblCategory2.AutoSize = true;
            lblCategory2.Location = new Point(861, 94);
            lblCategory2.Name = "lblCategory2";
            lblCategory2.Size = new Size(69, 20);
            lblCategory2.TabIndex = 21;
            lblCategory2.Text = "Category";
            // 
            // lblMinPrice
            // 
            lblMinPrice.AutoSize = true;
            lblMinPrice.Location = new Point(861, 168);
            lblMinPrice.Name = "lblMinPrice";
            lblMinPrice.Size = new Size(70, 20);
            lblMinPrice.TabIndex = 22;
            lblMinPrice.Text = "Min Price";
            // 
            // cbDirection
            // 
            cbDirection.FormattingEnabled = true;
            cbDirection.Location = new Point(861, 323);
            cbDirection.Name = "cbDirection";
            cbDirection.Size = new Size(151, 28);
            cbDirection.TabIndex = 24;
            // 
            // numMinPrice
            // 
            numMinPrice.DecimalPlaces = 2;
            numMinPrice.Location = new Point(862, 205);
            numMinPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numMinPrice.Name = "numMinPrice";
            numMinPrice.Size = new Size(150, 27);
            numMinPrice.TabIndex = 25;
            // 
            // lblSort
            // 
            lblSort.AutoSize = true;
            lblSort.Location = new Point(862, 241);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(36, 20);
            lblSort.TabIndex = 26;
            lblSort.Text = "Sort";
            // 
            // cbSort
            // 
            cbSort.FormattingEnabled = true;
            cbSort.Location = new Point(862, 279);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(151, 28);
            cbSort.TabIndex = 27;
            // 
            // InventoryManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 839);
            Controls.Add(cbSort);
            Controls.Add(lblSort);
            Controls.Add(numMinPrice);
            Controls.Add(cbDirection);
            Controls.Add(lblMinPrice);
            Controls.Add(lblCategory2);
            Controls.Add(cbCategory);
            Controls.Add(tbxSearch);
            Controls.Add(lblSearch2);
            Controls.Add(btnExport);
            Controls.Add(dataGridViewProducts);
            Controls.Add(lblSearch);
            Controls.Add(textBox1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(tbxQuantity);
            Controls.Add(tbxPrice);
            Controls.Add(tbxCategory);
            Controls.Add(tbxName);
            Controls.Add(lblCategory);
            Controls.Add(lblPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblName);
            Name = "InventoryManagerForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblCategory;
        private TextBox tbxName;
        private TextBox tbxCategory;
        private TextBox tbxPrice;
        private TextBox tbxQuantity;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private TextBox textBox1;
        private Label lblSearch;
        private DataGridView dataGridViewProducts;
        private Button btnExport;
        private Label lblSearch2;
        private TextBox tbxSearch;
        private ComboBox cbMinPrice;
        private ComboBox cbCategory;
        private ComboBox comboBox3;
        private Label lblCategory2;
        private Label lblMinPrice;
        private Label label3;
        private ComboBox cbDirection;
        private NumericUpDown numMinPrice;
        private Label lblSort;
        private ComboBox cbSort;
    }
}
