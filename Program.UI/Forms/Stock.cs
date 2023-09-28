using Program.Business.Repositories;
using Program.DAL.Context;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.UI.Forms
{
    public partial class Stock : Form
    {
        private const int CriticalStockThreshold = 10;
        public Stock()
        {
            InitializeComponent();
            ShowCurrentStocks();
            cmbSuppliers.DisplayMember = "CompanyName";
            cmbSuppliers.DataSource = GetSuppliers();
            MessageBox.Show("Maximum capacity for one product is 100, Warehouse capacity is maximum 10000 items!");
            txtStockToUpdate.Enabled = false;
            btnUpdateStock.Enabled = false;
        }

        private List<Supplier> GetSuppliers()
        {
            using (var dbContext = new ProjectContext())
            {
                return dbContext.Suppliers.ToList();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string materialName = txtProductName.Text;
            decimal materialPrice;
            int stock;

            if (!decimal.TryParse(txtPrice.Text, out materialPrice) || !int.TryParse(txtStockToAdd.Text, out stock))
            {
                MessageBox.Show("Please enter a valid price and stock quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (stock>100)
            {
                MessageBox.Show("Maximum capacity for one product is 100!");
                return;
            }

            AddMaterialWithSelectedSupplier(materialName, materialPrice, stock);
            ShowCurrentStocks();
        }
        private void AddMaterialWithSelectedSupplier(string materialName, decimal materialPrice, int stock)
        {
            Supplier selectedSupplier = cmbSuppliers.SelectedItem as Supplier;

            if (selectedSupplier != null)
            {
                using (var dbContext = new ProjectContext())
                {
                    var existingProduct = dbContext.Materials
                        .FirstOrDefault(p => p.MaterialName == materialName);

                    if (existingProduct != null)
                    {
                        MessageBox.Show("A product with the same name already exists. Please choose a different name.",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    dbContext.Materials.Add(new Material
                    {
                        MaterialName = materialName,
                        MaterialPrice = materialPrice,
                        Stock = stock,
                        SupplierID = selectedSupplier.ID,
                        CreatedDate = DateTime.Now,
                        IsActive = true
                    });

                    dbContext.SaveChanges();
                }

                MessageBox.Show("The material has been added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a supplier.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ShowSelectedProductStock();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)

        {
            int selectedProductIndex = listBoxProducts.SelectedIndex;

            if (selectedProductIndex >= 0)
            {
                string selectedProductName = listBoxProducts.SelectedItem.ToString();
                int newStock;

                if (int.TryParse(txtStockToUpdate.Text, out newStock))
                {
                    UpdateProductStock(selectedProductName, newStock);
                    ShowCurrentStocks();
                    ShowUpdatedProductStock(selectedProductName);
                    lblInfo.Text = $"Stock information of the \"{selectedProductName}\" has been updated.";
                }
                else
                {
                    MessageBox.Show("Please enter a valid price and stock quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a product to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowCurrentStocks()
        {
            using (var dbContext = new ProjectContext())
            {
                var products = dbContext.Materials.ToList();

                listBoxProducts.Items.Clear();

                foreach (var product in products)
                {
                    listBoxProducts.Items.Add(product.MaterialName);
                }

                ShowCurrentStockProgressBar(products);
            }
        }

        private void ShowCurrentStockProgressBar(List<Material> products)
        {
            int totalStock = products.Sum(p => p.Stock);
            bool isCritical = totalStock < CriticalStockThreshold;

            progressBarCurrentStock.Maximum = 10000;
            progressBarCurrentStock.Value = isCritical ? CriticalStockThreshold : totalStock;
            progressBarCurrentStock.ForeColor = isCritical ? System.Drawing.Color.Red : System.Drawing.Color.Green;

            lblCurrentStock.Text = $"Total Stock: {totalStock}";

            lblCriticalWarning.Visible = isCritical;
        }

        private void ShowSelectedProductStock()
        {
            using (var dbContext = new ProjectContext())
            {
                var newProduct = dbContext.Materials.OrderByDescending(p => p.ID).FirstOrDefault();

                if (newProduct != null)
                {
                    progressBarSelectedProductStock.Maximum = 100;
                    progressBarSelectedProductStock.Value = newProduct.Stock;
                    progressBarSelectedProductStock.ForeColor = newProduct.Stock < CriticalStockThreshold ? System.Drawing.Color.Red : System.Drawing.Color.Green;

                    lblNewProductStock.Text = $"Stock: {newProduct.Stock}";
                }
            }
        }

        private void ShowUpdatedProductStock(string productName)
        {
            using (var dbContext = new ProjectContext())
            {
                var updatedProduct = dbContext.Materials.FirstOrDefault(p => p.MaterialName == productName);

                if (updatedProduct != null)
                {
                    progressBarSelectedProductStock.Maximum = 100;
                    progressBarSelectedProductStock.Value = updatedProduct.Stock;
                    progressBarSelectedProductStock.ForeColor = updatedProduct.Stock < CriticalStockThreshold ? System.Drawing.Color.Red : System.Drawing.Color.Green;

                    lblNewProductStock.Text = $"Stock: {updatedProduct.Stock}";
                }
            }
        }

        private void UpdateProductStock(string productName, int newStock)
        {
            using (var dbContext = new ProjectContext())
            {
                var productToUpdate = dbContext.Materials.FirstOrDefault(p => p.MaterialName == productName);

                if (productToUpdate != null)
                {
                    productToUpdate.Stock = newStock;
                    productToUpdate.ModifiedDate = DateTime.Now;

                    dbContext.SaveChanges();
                }
            }
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex >= 0)
            {
                txtStockToUpdate.Enabled = true;
                btnUpdateStock.Enabled = true;
                string selectedProductName = listBoxProducts.SelectedItem.ToString();
                ShowSelectedProductStock(selectedProductName);
            }
        }

        private void ShowSelectedProductStock(string productName)
        {
            using (var dbContext = new ProjectContext())
            {
                var selectedProduct = dbContext.Materials.FirstOrDefault(p => p.MaterialName == productName);

                if (selectedProduct != null)
                {
                    progressBarSelectedProductStock.Maximum = 100;
                    progressBarSelectedProductStock.Value = selectedProduct.Stock;
                    progressBarSelectedProductStock.ForeColor = selectedProduct.Stock < CriticalStockThreshold ? Color.Red : Color.Green;

                    lblNewProductStock.Text = $"Stock: {selectedProduct.Stock}";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedProduct();
        }

        private void DeleteSelectedProduct()
        {
            if (listBoxProducts.SelectedIndex >= 0)
            {
                string selectedProductName = listBoxProducts.SelectedItem.ToString();

                using (var dbContext = new ProjectContext())
                {
                    var productToDelete = dbContext.Materials.FirstOrDefault(p => p.MaterialName == selectedProductName);

                    if (productToDelete != null)
                    {
                        dbContext.Materials.Remove(productToDelete);
                        dbContext.SaveChanges();

                        ShowCurrentStocks(listBoxProducts);

                        MessageBox.Show("The product has been deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to be deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ShowCurrentStocks(ListBox listBox)
        {
            using (var dbContext = new ProjectContext())
            {
                var products = dbContext.Materials.ToList();

                listBox.Items.Clear();

                foreach (var product in products)
                {
                    listBox.Items.Add(product.MaterialName);
                }

                ShowCurrentStockProgressBar(products);
            }
        }

    }
}
