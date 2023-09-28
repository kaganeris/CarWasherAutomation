namespace Program.UI.Forms
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
            label4 = new Label();
            label3 = new Label();
            lblNewProductStock = new Label();
            label5 = new Label();
            label2 = new Label();
            lblCriticalWarning = new Label();
            label1 = new Label();
            lblCurrentStock = new Label();
            lblInfo = new Label();
            btnUpdateStock = new Button();
            btnDelete = new Button();
            btnAddProduct = new Button();
            listBoxProducts = new ListBox();
            progressBarSelectedProductStock = new ProgressBar();
            progressBarCurrentStock = new ProgressBar();
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
            grpStockInfo.Controls.Add(btnDelete);
            grpStockInfo.Controls.Add(btnAddProduct);
            grpStockInfo.Controls.Add(listBoxProducts);
            grpStockInfo.Controls.Add(progressBarSelectedProductStock);
            grpStockInfo.Controls.Add(progressBarCurrentStock);
            grpStockInfo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpStockInfo.Location = new Point(17, 17);
            grpStockInfo.Margin = new Padding(4);
            grpStockInfo.Name = "grpStockInfo";
            grpStockInfo.Padding = new Padding(4);
            grpStockInfo.Size = new Size(859, 667);
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
            txtStockToUpdate.Location = new Point(169, 617);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 570);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 3;
            label4.Text = "Supplier";
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
            // lblNewProductStock
            // 
            lblNewProductStock.AutoSize = true;
            lblNewProductStock.Location = new Point(424, 613);
            lblNewProductStock.Name = "lblNewProductStock";
            lblNewProductStock.Size = new Size(0, 21);
            lblNewProductStock.TabIndex = 3;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 462);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 3;
            label2.Text = "Stock to add";
            // 
            // lblCriticalWarning
            // 
            lblCriticalWarning.AutoSize = true;
            lblCriticalWarning.Location = new Point(424, 557);
            lblCriticalWarning.Name = "lblCriticalWarning";
            lblCriticalWarning.Size = new Size(0, 21);
            lblCriticalWarning.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 620);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 3;
            label1.Text = "Stock to update";
            // 
            // lblCurrentStock
            // 
            lblCurrentStock.AutoSize = true;
            lblCurrentStock.Location = new Point(424, 500);
            lblCurrentStock.Name = "lblCurrentStock";
            lblCurrentStock.Size = new Size(0, 21);
            lblCurrentStock.TabIndex = 3;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(424, 438);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 21);
            lblInfo.TabIndex = 3;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.Location = new Point(513, 272);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(302, 38);
            btnUpdateStock.TabIndex = 2;
            btnUpdateStock.Text = "Update Stock";
            btnUpdateStock.UseVisualStyleBackColor = true;
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(513, 377);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(302, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Product";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(513, 324);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(302, 38);
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
            listBoxProducts.SelectedIndexChanged += listBoxProducts_SelectedIndexChanged;
            // 
            // progressBarSelectedProductStock
            // 
            progressBarSelectedProductStock.Location = new Point(513, 43);
            progressBarSelectedProductStock.Margin = new Padding(4);
            progressBarSelectedProductStock.Name = "progressBarSelectedProductStock";
            progressBarSelectedProductStock.Size = new Size(302, 70);
            progressBarSelectedProductStock.TabIndex = 0;
            // 
            // progressBarCurrentStock
            // 
            progressBarCurrentStock.Location = new Point(513, 164);
            progressBarCurrentStock.Margin = new Padding(4);
            progressBarCurrentStock.Maximum = 10000;
            progressBarCurrentStock.Name = "progressBarCurrentStock";
            progressBarCurrentStock.Size = new Size(302, 70);
            progressBarCurrentStock.TabIndex = 0;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 697);
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
        private Button btnAddProduct;
        private ListBox listBoxProducts;
        private ProgressBar progressBarSelectedProductStock;
        private TextBox txtStockToAdd;
        private TextBox txtProductName;
        private TextBox txtStockToUpdate;
        private Label lblCurrentStock;
        private Label lblNewProductStock;
        private Button btnUpdateStock;
        private ComboBox cmbSuppliers;
        private TextBox txtPrice;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Button btnDelete;
        private Label lblCriticalWarning;
        private Label lblInfo;
    }
}