using InventoryManager.Models;
using InventoryManager.Services;
using System.Xml.Linq;

namespace InventoryManager
{
    public partial class InventoryManagerForm: Form
    {
        private readonly DatabaseService _database;
        private int _selectedProductId = 0;
        public InventoryManagerForm()
        {
            InitializeComponent();

            _database = new DatabaseService();

            ApplyDarkTheme();

            LoadProducts();

            dataGridViewProducts.AutoSizeColumnsMode =
    DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewProducts.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridViewProducts.MultiSelect = false;

            dataGridViewProducts.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblName.Text = "Name";
            lblQuantity.Text = "Quantity";
            lblPrice.Text = "Price";
            lblCategory.Text = "Category";

            cbCategory.Items.Add("All");
            cbCategory.Items.Add("Electronics");
            cbCategory.Items.Add("Office");
            cbCategory.Items.Add("Accessories");

            cbCategory.SelectedIndex = 0;

            cbSort.Items.Add("Name");
            cbSort.Items.Add("Price");
            cbSort.Items.Add("Quantity");

            cbSort.SelectedIndex = 0;

            cbDirection.Items.Add("DESC");
            cbDirection.Items.Add("ASC");

            cbDirection.SelectedIndex = 0;

            tbxSearch.TextChanged += (s, e) => ApplyFilters();
            cbCategory.SelectedIndexChanged += (s, e) => ApplyFilters();
            numMinPrice.ValueChanged += (s, e) => ApplyFilters();
            cbSort.SelectedIndexChanged += (s, e) => ApplyFilters();
            cbDirection.SelectedIndexChanged += (s, e) => ApplyFilters();

            
        }



        private void LoadProducts()
        {
            ApplyFilters();

            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = _database.GetProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {
                    Name = tbxName.Text,
                    Quantity = int.Parse(tbxQuantity.Text),
                    Price = decimal.Parse(tbxPrice.Text),
                    Category = tbxCategory.Text
                };

                _database.AddProduct(product);

                LoadProducts();

                ClearFields();

                MessageBox.Show("Product added successfully!");
            }
            catch
            {
                MessageBox.Show("Please enter valid data.");
            }
        }
        private void ClearFields()
        {
            tbxName.Clear();
            tbxQuantity.Clear();
            tbxPrice.Clear();
            tbxCategory.Clear();

            _selectedProductId = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];

                _selectedProductId = Convert.ToInt32(row.Cells["Id"].Value);

                tbxName.Text = row.Cells["Name"].Value.ToString();
                tbxQuantity.Text = row.Cells["Quantity"].Value.ToString();
                tbxPrice.Text = row.Cells["Price"].Value.ToString();
                tbxCategory.Text = row.Cells["Category"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(_selectedProductId == 0)
            {
                MessageBox.Show("Select a product first.");
                return;
            }

            try
            {
                var product = new Product
                {
                    Id = _selectedProductId,
                    Name = tbxName.Text,
                    Quantity = int.Parse(tbxQuantity.Text),
                    Price = decimal.Parse(tbxPrice.Text),
                    Category = tbxCategory.Text
                };

                _database.UpdateProduct(product);

                LoadProducts();
                ClearFields();

                _selectedProductId = 0;

                MessageBox.Show("Product updated successfully!");
            }
            catch
            {
                MessageBox.Show("Invalid data.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(_selectedProductId == 0)
            {
                MessageBox.Show("Select a product first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure?",
                "Delete",
                MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                _database.DeleteProduct(_selectedProductId);

                LoadProducts();
                ClearFields();

                _selectedProductId = 0;

                MessageBox.Show("Product deleted successfully!");
            }
        }
        private void ApplyFilters()
        {
            var products = _database.GetProducts();

            // SEARCH
            if(!string.IsNullOrWhiteSpace(tbxSearch.Text))
            {
                products = products.Where(p =>
                    p.Name.Contains(
                        tbxSearch.Text,
                        StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            // CATEGORY
            if(cbCategory.Text != "All")
            {
                products = products.Where(p =>
                    p.Category.Contains(cbCategory.Text))
                    .ToList();
            }

            // MIN PRICE
            products = products.Where(p =>
                p.Price >= numMinPrice.Value)
                .ToList();

            // SORT
            bool desc = cbDirection.Text == "DESC";

            products = cbSort.Text switch
            {
                "Name" => desc
                    ? products.OrderByDescending(p => p.Name).ToList()
                    : products.OrderBy(p => p.Name).ToList(),

                "Price" => desc
                    ? products.OrderByDescending(p => p.Price).ToList()
                    : products.OrderBy(p => p.Price).ToList(),

                "Quantity" => desc
                    ? products.OrderByDescending(p => p.Quantity).ToList()
                    : products.OrderBy(p => p.Quantity).ToList(),

                _ => products
            };

            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = products;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                var products = _database.GetProducts();

                var excelService = new ExcelExportService();

                excelService.ExportProducts(
                    products,
                    "products.xlsx");

                MessageBox.Show("Excel file exported!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ApplyDarkTheme()
        {
            BackColor = Color.FromArgb(30, 30, 30);

            foreach(Control control in Controls)
            {
                if(control is Label)
                {
                    control.ForeColor = Color.White;
                }

                if(control is TextBox)
                {
                    control.BackColor = Color.FromArgb(45, 45, 48);
                    control.ForeColor = Color.White;
                }

                if(control is ComboBox)
                {
                    control.BackColor = Color.FromArgb(45, 45, 48);
                    control.ForeColor = Color.White;
                }

                if(control is NumericUpDown)
                {
                    control.BackColor = Color.FromArgb(45, 45, 48);
                    control.ForeColor = Color.White;
                }

                if(control is Button)
                {
                    control.BackColor = Color.FromArgb(70, 70, 70);
                    control.ForeColor = Color.White;

                    ((Button)control).FlatStyle = FlatStyle.Flat;
                }
            }

            dataGridViewProducts.BackgroundColor =
                Color.FromArgb(30, 30, 30);

            dataGridViewProducts.DefaultCellStyle.BackColor =
                Color.FromArgb(45, 45, 48);

            dataGridViewProducts.DefaultCellStyle.ForeColor =
                Color.White;

            dataGridViewProducts.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(60, 60, 60);

            dataGridViewProducts.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dataGridViewProducts.EnableHeadersVisualStyles = false;
        }
    }
}
