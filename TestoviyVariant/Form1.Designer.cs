namespace TestoviyVariant
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.warehouseName = new System.Windows.Forms.Label();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.btnAddWarehouse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtProductWarehouse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSellWarehouse = new System.Windows.Forms.TextBox();
            this.txtSellProduct = new System.Windows.Forms.TextBox();
            this.btnSellProduct = new System.Windows.Forms.Button();
            this.txtSellQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnShowInventory = new System.Windows.Forms.Button();
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // warehouseName
            // 
            this.warehouseName.AutoSize = true;
            this.warehouseName.Location = new System.Drawing.Point(12, 9);
            this.warehouseName.Name = "warehouseName";
            this.warehouseName.Size = new System.Drawing.Size(109, 13);
            this.warehouseName.TabIndex = 0;
            this.warehouseName.Text = "Добавление склада";
            this.warehouseName.Click += new System.EventHandler(this.warehouseName_Click);
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Location = new System.Drawing.Point(89, 44);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(188, 20);
            this.txtWarehouseName.TabIndex = 1;
            this.txtWarehouseName.TextChanged += new System.EventHandler(this.txtWarehouseName_TextChanged);
            // 
            // btnAddWarehouse
            // 
            this.btnAddWarehouse.Location = new System.Drawing.Point(301, 44);
            this.btnAddWarehouse.Name = "btnAddWarehouse";
            this.btnAddWarehouse.Size = new System.Drawing.Size(108, 21);
            this.btnAddWarehouse.TabIndex = 2;
            this.btnAddWarehouse.Text = "Добавить Склад";
            this.btnAddWarehouse.UseVisualStyleBackColor = true;
            this.btnAddWarehouse.Click += new System.EventHandler(this.btnAddWarehouse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя склада";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя склада";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AutoSize = true;
            this.btnAddProduct.Location = new System.Drawing.Point(301, 177);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(112, 23);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Text = "Добавить Продукт";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtProductWarehouse
            // 
            this.txtProductWarehouse.Location = new System.Drawing.Point(96, 127);
            this.txtProductWarehouse.Name = "txtProductWarehouse";
            this.txtProductWarehouse.Size = new System.Drawing.Size(181, 20);
            this.txtProductWarehouse.TabIndex = 5;
            this.txtProductWarehouse.TextChanged += new System.EventHandler(this.txtProductWarehouse_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Добавление товара";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(96, 153);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(181, 20);
            this.txtProductName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Имя продукта";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(96, 179);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(181, 20);
            this.txtProductQuantity.TabIndex = 5;
            this.txtProductQuantity.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Продажа товара";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSellWarehouse
            // 
            this.txtSellWarehouse.Location = new System.Drawing.Point(96, 263);
            this.txtSellWarehouse.Name = "txtSellWarehouse";
            this.txtSellWarehouse.Size = new System.Drawing.Size(181, 20);
            this.txtSellWarehouse.TabIndex = 5;
            this.txtSellWarehouse.TextChanged += new System.EventHandler(this.txtProductWarehouse_TextChanged);
            // 
            // txtSellProduct
            // 
            this.txtSellProduct.Location = new System.Drawing.Point(96, 289);
            this.txtSellProduct.Name = "txtSellProduct";
            this.txtSellProduct.Size = new System.Drawing.Size(181, 20);
            this.txtSellProduct.TabIndex = 5;
            // 
            // btnSellProduct
            // 
            this.btnSellProduct.AutoSize = true;
            this.btnSellProduct.Location = new System.Drawing.Point(301, 313);
            this.btnSellProduct.Name = "btnSellProduct";
            this.btnSellProduct.Size = new System.Drawing.Size(112, 23);
            this.btnSellProduct.TabIndex = 6;
            this.btnSellProduct.Text = "Продать Продукт";
            this.btnSellProduct.UseVisualStyleBackColor = true;
            this.btnSellProduct.Click += new System.EventHandler(this.btnSellProduct_Click);
            // 
            // txtSellQuantity
            // 
            this.txtSellQuantity.Location = new System.Drawing.Point(96, 315);
            this.txtSellQuantity.Name = "txtSellQuantity";
            this.txtSellQuantity.Size = new System.Drawing.Size(181, 20);
            this.txtSellQuantity.TabIndex = 5;
            this.txtSellQuantity.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Имя склада";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Имя продукта";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Количество";
            // 
            // btnShowInventory
            // 
            this.btnShowInventory.AutoSize = true;
            this.btnShowInventory.Location = new System.Drawing.Point(518, 156);
            this.btnShowInventory.Name = "btnShowInventory";
            this.btnShowInventory.Size = new System.Drawing.Size(112, 23);
            this.btnShowInventory.TabIndex = 8;
            this.btnShowInventory.Text = "Просмотр";
            this.btnShowInventory.UseVisualStyleBackColor = true;
            this.btnShowInventory.Click += new System.EventHandler(this.btnShowInventory_Click);
            // 
            // lstInventory
            // 
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.Location = new System.Drawing.Point(518, 195);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(270, 238);
            this.lstInventory.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstInventory);
            this.Controls.Add(this.btnShowInventory);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSellQuantity);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.btnSellProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtSellProduct);
            this.Controls.Add(this.txtSellWarehouse);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProductWarehouse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddWarehouse);
            this.Controls.Add(this.txtWarehouseName);
            this.Controls.Add(this.warehouseName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label warehouseName;
        private System.Windows.Forms.TextBox txtWarehouseName;
        private System.Windows.Forms.Button btnAddWarehouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtProductWarehouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSellWarehouse;
        private System.Windows.Forms.TextBox txtSellProduct;
        private System.Windows.Forms.Button btnSellProduct;
        private System.Windows.Forms.TextBox txtSellQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnShowInventory;
        private System.Windows.Forms.ListBox lstInventory;
    }
}

