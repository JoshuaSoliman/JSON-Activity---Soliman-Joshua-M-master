namespace GroceryList
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;

        private void InitializeComponent()
        {
            listBoxProducts = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(200, 20);
            label1.Name = "label1";
            label1.Size = new Size(285, 54);
            label1.TabIndex = 3;
            label1.Text = "My Grocery List";
            // 
            // listBoxProducts
            // 
            listBoxProducts.BackColor = Color.WhiteSmoke;
            listBoxProducts.BorderStyle = BorderStyle.FixedSingle;
            listBoxProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 25;
            listBoxProducts.Location = new Point(115, 90);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(450, 180);  // Made it a bit wider
            listBoxProducts.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(480, 330);  // Positioned at bottom-right
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 45);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(480, 380);  // Positioned just below Add button
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 45);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Selected";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(684, 450);  // Adjusted form size for better space
            Controls.Add(label1);
            Controls.Add(listBoxProducts);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Shopping List Viewer";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
