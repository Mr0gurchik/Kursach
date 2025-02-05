using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestoviyVariant
{
    public partial class Form1 : Form
    {
        private MultiWarehouseSystem system;

        public Form1()
        {
            InitializeComponent();
            system = new MultiWarehouseSystem();
        }


        private void warehouseName_Click(object sender, EventArgs e)
        {

        }

        private void txtWarehouseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtProductWarehouse_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            string warehouseName = txtWarehouseName.Text;
            if (!string.IsNullOrWhiteSpace(warehouseName))
            {
                system.AddWarehouse(warehouseName);
                MessageBox.Show($"Склад '{warehouseName}' добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtWarehouseName.Clear();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное имя склада.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string warehouseName = txtProductWarehouse.Text;
            string productName = txtProductName.Text;
            if (int.TryParse(txtProductQuantity.Text, out int quantity) && quantity > 0)
            {
                system.AddProductToWarehouse(warehouseName, productName, quantity);
                MessageBox.Show($"Добавлено {quantity} ед. '{productName}' на склад '{warehouseName}'.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductWarehouse.Clear();
                txtProductName.Clear();
                txtProductQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные данные о товаре.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSellProduct_Click(object sender, EventArgs e)
        {
            string warehouseName = txtSellWarehouse.Text;
            string productName = txtSellProduct.Text;
            if (int.TryParse(txtSellQuantity.Text, out int quantity) && quantity > 0)
            {
                system.SellProduct(warehouseName, productName, quantity);
                txtSellWarehouse.Clear();
                txtSellProduct.Clear();
                txtSellQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные данные о продаже.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowInventory_Click(object sender, EventArgs e)
        {
            var inventories = system.GetAllInventories();
            lstInventory.Items.Clear();

            foreach (var inventory in inventories)
            {
                lstInventory.Items.Add($"Склад: {inventory.Key}");
                foreach (var item in inventory.Value)
                {
                    lstInventory.Items.Add($"- {item.Key}: {item.Value}");
                }
                lstInventory.Items.Add("");
            }
        }
        public class Warehouse
        {
            public string Name { get; private set; }
            private Dictionary<string, int> inventory;

            public Warehouse(string name)
            {
                Name = name;
                inventory = new Dictionary<string, int>();
            }

            public void AddProduct(string productName, int quantity)
            {
                if (inventory.ContainsKey(productName))
                {
                    inventory[productName] += quantity;
                }
                else
                {
                    inventory[productName] = quantity;
                }
            }

            public bool SellProduct(string productName, int quantity)
            {
                if (inventory.ContainsKey(productName) && inventory[productName] >= quantity)
                {
                    inventory[productName] -= quantity;
                    return true;
                }
                return false;
            }

            public Dictionary<string, int> GetInventory()
            {
                return new Dictionary<string, int>(inventory);
            }
        }

        public class MultiWarehouseSystem
        {
            private Dictionary<string, Warehouse> warehouses;

            public MultiWarehouseSystem()
            {
                warehouses = new Dictionary<string, Warehouse>();
            }

            public void AddWarehouse(string warehouseName)
            {
                if (!warehouses.ContainsKey(warehouseName))
                {
                    warehouses[warehouseName] = new Warehouse(warehouseName);
                }
            }

            public void AddProductToWarehouse(string warehouseName, string productName, int quantity)
            {
                if (warehouses.ContainsKey(warehouseName))
                {
                    warehouses[warehouseName].AddProduct(productName, quantity);
                }
                else
                {
                    MessageBox.Show($"Склад '{warehouseName}' не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void SellProduct(string warehouseName, string productName, int quantity)
            {
                if (warehouses.ContainsKey(warehouseName))
                {
                    bool success = warehouses[warehouseName].SellProduct(productName, quantity);
                    if (success)
                    {
                        MessageBox.Show($"Продано {quantity} ед. '{productName}' со склада '{warehouseName}'.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Не удалось продать {quantity} ед. '{productName}' со склада '{warehouseName}'. Недостаточно товара.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Склад '{warehouseName}' не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public Dictionary<string, Dictionary<string, int>> GetAllInventories()
            {
                var allInventories = new Dictionary<string, Dictionary<string, int>>();

                foreach (var warehouse in warehouses)
                {
                    allInventories[warehouse.Key] = warehouse.Value.GetInventory();
                }

                return allInventories;
            }
        }
    }
}
