﻿namespace Program.UI.Forms
{
    partial class Stock
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
            grpStockInfo = new GroupBox();
            cmbSuppliers = new ComboBox();
            txtPrice = new TextBox();
            txtStockToUpdate = new TextBox();
            txtStockToAdd = new TextBox();
            txtProductName = new TextBox();
            lblNewProductStock = new Label();
            lblCriticalWarning = new Label();
            lblCurrentStock = new Label();
            lblInfo = new Label();
            btnUpdateStock = new Button();
            btnAddProduct = new Button();
            listBoxProducts = new ListBox();
            progressBarNewProductStock = new ProgressBar();
            progressBarCurrentStock = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            grpStockInfo.SuspendLayout();
            SuspendLayout();
            // 
            // grpStockInfo
            // 
            grpStockInfo.Controls.Add(cmbSuppliers);
            grpStockInfo.Controls.Add(txtPrice);
            grpStockInfo.Controls.Add(txtStockToUpdate);
            grpStockInfo.Controls.Add(txtStockToAdd);
            grpStockInfo.Controls.Add(txtProductName);
            grpStockInfo.Controls.Add(label4);
            grpStockInfo.Controls.Add(label3);
            grpStockInfo.Controls.Add(lblNewProductStock);
            grpStockInfo.Controls.Add(label5);
            grpStockInfo.Controls.Add(label2);
            grpStockInfo.Controls.Add(lblCriticalWarning);
            grpStockInfo.Controls.Add(label1);
            grpStockInfo.Controls.Add(lblCurrentStock);
            grpStockInfo.Controls.Add(lblInfo);
            grpStockInfo.Controls.Add(btnUpdateStock);
            grpStockInfo.Controls.Add(btnAddProduct);
            grpStockInfo.Controls.Add(listBoxProducts);
            grpStockInfo.Controls.Add(progressBarNewProductStock);
            grpStockInfo.Controls.Add(progressBarCurrentStock);
            grpStockInfo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpStockInfo.Location = new Point(17, 17);
            grpStockInfo.Margin = new Padding(4);
            grpStockInfo.Name = "grpStockInfo";
            grpStockInfo.Padding = new Padding(4);
            grpStockInfo.Size = new Size(992, 667);
            grpStockInfo.TabIndex = 2;
            grpStockInfo.TabStop = false;
            grpStockInfo.Text = "Stock Information";
            // 
            // cmbSuppliers
            // 
            cmbSuppliers.FormattingEnabled = true;
            cmbSuppliers.Location = new Point(169, 567);
            cmbSuppliers.Name = "cmbSuppliers";
            cmbSuppliers.Size = new Size(195, 29);
            cmbSuppliers.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(169, 512);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(195, 27);
            txtPrice.TabIndex = 4;
            // 
            // txtStockToUpdate
            // 
            txtStockToUpdate.Location = new Point(556, 404);
            txtStockToUpdate.Name = "txtStockToUpdate";
            txtStockToUpdate.PlaceholderText = "Stock to update";
            txtStockToUpdate.Size = new Size(195, 27);
            txtStockToUpdate.TabIndex = 4;
            // 
            // txtStockToAdd
            // 
            txtStockToAdd.Location = new Point(169, 459);
            txtStockToAdd.Name = "txtStockToAdd";
            txtStockToAdd.PlaceholderText = "Stock to add";
            txtStockToAdd.Size = new Size(195, 27);
            txtStockToAdd.TabIndex = 4;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(169, 404);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Product Name";
            txtProductName.Size = new Size(195, 27);
            txtProductName.TabIndex = 4;
            // 
            // lblNewProductStock
            // 
            lblNewProductStock.AutoSize = true;
            lblNewProductStock.Location = new Point(796, 586);
            lblNewProductStock.Name = "lblNewProductStock";
            lblNewProductStock.Size = new Size(159, 21);
            lblNewProductStock.TabIndex = 3;
            lblNewProductStock.Text = "New Product Stock";
            // 
            // lblCriticalWarning
            // 
            lblCriticalWarning.AutoSize = true;
            lblCriticalWarning.Location = new Point(796, 530);
            lblCriticalWarning.Name = "lblCriticalWarning";
            lblCriticalWarning.Size = new Size(134, 21);
            lblCriticalWarning.TabIndex = 3;
            lblCriticalWarning.Text = "Critical Warning";
            // 
            // lblCurrentStock
            // 
            lblCurrentStock.AutoSize = true;
            lblCurrentStock.Location = new Point(796, 473);
            lblCurrentStock.Name = "lblCurrentStock";
            lblCurrentStock.Size = new Size(117, 21);
            lblCurrentStock.TabIndex = 3;
            lblCurrentStock.Text = "Current Stock";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(796, 411);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(44, 21);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "Info ";
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.Location = new Point(516, 272);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(439, 38);
            btnUpdateStock.TabIndex = 2;
            btnUpdateStock.Text = "Update Stock";
            btnUpdateStock.UseVisualStyleBackColor = true;
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(516, 324);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(439, 38);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 21;
            listBoxProducts.Location = new Point(23, 43);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(454, 319);
            listBoxProducts.TabIndex = 1;
            // 
            // progressBarNewProductStock
            // 
            progressBarNewProductStock.Location = new Point(516, 43);
            progressBarNewProductStock.Margin = new Padding(4);
            progressBarNewProductStock.Name = "progressBarNewProductStock";
            progressBarNewProductStock.Size = new Size(439, 70);
            progressBarNewProductStock.TabIndex = 0;
            // 
            // progressBarCurrentStock
            // 
            progressBarCurrentStock.Location = new Point(516, 164);
            progressBarCurrentStock.Margin = new Padding(4);
            progressBarCurrentStock.Name = "progressBarCurrentStock";
            progressBarCurrentStock.Size = new Size(439, 70);
            progressBarCurrentStock.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(402, 407);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 3;
            label1.Text = "Stock to update";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 462);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 3;
            label2.Text = "Stock to add";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 407);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 3;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 570);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 3;
            label4.Text = "Supplier";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 515);
            label5.Name = "label5";
            label5.Size = new Size(47, 21);
            label5.TabIndex = 3;
            label5.Text = "Price";
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 697);
            Controls.Add(grpStockInfo);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Stock";
            Text = "Stock";
            grpStockInfo.ResumeLayout(false);
            grpStockInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpStockInfo;
        private ProgressBar progressBarCurrentStock;
        private Label lblInfo;
        private Button btnAddProduct;
        private ListBox listBoxProducts;
        private ProgressBar progressBarNewProductStock;
        private TextBox txtStockToAdd;
        private TextBox txtProductName;
        private TextBox txtStockToUpdate;
        private Label lblCurrentStock;
        private Label lblCriticalWarning;
        private Label lblNewProductStock;
        private Button btnUpdateStock;
        private ComboBox cmbSuppliers;
        private TextBox txtPrice;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
    }
}