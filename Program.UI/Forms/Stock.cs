using Program.DAL.Context;
using Program.DATA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                MessageBox.Show("Lütfen geçerli bir fiyat ve stok miktarı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddMaterialWithSelectedSupplier(materialName, materialPrice, stock);
        }
        private void AddMaterialWithSelectedSupplier(string materialName, decimal materialPrice, int stock)
        {
            Supplier selectedSupplier = cmbSuppliers.SelectedItem as Supplier;

            if (selectedSupplier != null)
            {
                using (var dbContext = new ProjectContext())
                {
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

                MessageBox.Show("Malzeme başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir tedarikçi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ShowNewProductStock();
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
                    lblInfo.Text = $"\"{selectedProductName}\" adlı ürünün stok bilgisi güncellendi.";
                }
                else
                {
                    MessageBox.Show("Geçerli bir stok miktarı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir ürün seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            progressBarCurrentStock.Maximum = 100;
            progressBarCurrentStock.Value = isCritical ? CriticalStockThreshold : totalStock;
            progressBarCurrentStock.ForeColor = isCritical ? System.Drawing.Color.Red : System.Drawing.Color.Green;

            lblCurrentStock.Text = $"Toplam Stok: {totalStock}";

            lblCriticalWarning.Visible = isCritical;
        }

        private void ShowNewProductStock()
        {
            using (var dbContext = new ProjectContext())
            {
                var newProduct = dbContext.Materials.OrderByDescending(p => p.ID).FirstOrDefault();

                if (newProduct != null)
                {
                    progressBarNewProductStock.Maximum = 100;
                    progressBarNewProductStock.Value = newProduct.Stock;
                    progressBarNewProductStock.ForeColor = newProduct.Stock < CriticalStockThreshold ? System.Drawing.Color.Red : System.Drawing.Color.Green;

                    lblNewProductStock.Text = $"Stok: {newProduct.Stock}";
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
                    progressBarNewProductStock.Maximum = 100;
                    progressBarNewProductStock.Value = updatedProduct.Stock;
                    progressBarNewProductStock.ForeColor = updatedProduct.Stock < CriticalStockThreshold ? System.Drawing.Color.Red : System.Drawing.Color.Green;

                    lblNewProductStock.Text = $"Stok: {updatedProduct.Stock}";
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
    }
}
