using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace GroceryList
{
    public partial class Form1 : Form
    {
        private string filePath = @"C:\Users\Joshua Soliman\Desktop\JSON-Activity---Soliman-Joshua-M.-master\ClassLibrary6\jsonfiles\shoppinglist.json";


        public Form1()
        {
            InitializeComponent();
            LoadProductsAsync();
        }

        private async void LoadProductsAsync()
        {
            List<Product> products = await JsonHelper.ReadJsonFromFileAsync(filePath);
            listBoxProducts.Items.Clear();
            foreach (var product in products)
            {
                listBoxProducts.Items.Add($"{product.Id}: {product.Name}");
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            List<Product> products = await JsonHelper.ReadJsonFromFileAsync(filePath);

            if (products.Count >= 5)
            {
                MessageBox.Show("You can only add up to 5 items. Please delete an item before adding a new one.");
                return;
            }

            Form2 addForm = new Form2(filePath);
            addForm.FormClosed += (s, args) => LoadProductsAsync();
            addForm.ShowDialog();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxProducts.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("No item selected. Please select an item to delete.");
                return;
            }

            List<Product> products = await JsonHelper.ReadJsonFromFileAsync(filePath);

            if (selectedIndex >= 0 && selectedIndex < products.Count)
            {
                products.RemoveAt(selectedIndex);

                for (int i = 0; i < products.Count; i++)
                {
                    products[i].Id = i + 1;
                }

                await JsonHelper.WriteJsonToFileAsync(filePath, products);

                LoadProductsAsync();
            }
        }
    }
}
