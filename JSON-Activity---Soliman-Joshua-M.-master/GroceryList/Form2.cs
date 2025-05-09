using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace GroceryList
{
    public partial class Form2 : Form
    {
        private readonly string filePath;
        private List<Product> groceryList;
        private bool hasChanges = false; 

        public Form2(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                groceryList = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
            }
            else
            {
                groceryList = new List<Product>();
            }

            foreach (var product in groceryList)
            {
                listBoxItems.Items.Add($"{product.Id}: {product.Name}");
            }

            if (groceryList.Count >= 5)
            {
                btnAddItem.Enabled = false;
                MessageBox.Show("Maximum of 5 items already reached.");
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a product name.");
                return;
            }

            int id = groceryList.Count + 1;
            var product = new Product { Id = id, Name = txtName.Text };

            listBoxItems.Items.Add($"{product.Id}: {product.Name}");
            groceryList.Add(product);

            txtName.Clear();
            hasChanges = true;

            if (groceryList.Count >= 5)
            {
                MessageBox.Show("Maximum of 5 items allowed.");
                btnAddItem.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!hasChanges)
            {
                MessageBox.Show("Add new items.");
                return;
            }

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                string json = JsonSerializer.Serialize(groceryList, new JsonSerializerOptions { WriteIndented = true });

                await File.WriteAllTextAsync(filePath, json);

                MessageBox.Show("Shopping list saved successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}");
            }
        }
    }
}
