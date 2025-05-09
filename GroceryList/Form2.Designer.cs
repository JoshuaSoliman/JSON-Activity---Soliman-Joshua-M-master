namespace GroceryList
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Label label1;

        private void InitializeComponent()
        {
            this.txtName = new TextBox();
            this.btnAddItem = new Button();
            this.btnSave = new Button();
            this.listBoxItems = new ListBox();
            this.label1 = new Label();
            this.SuspendLayout();

            // 
            // label1
            // 
            this.label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            this.label1.ForeColor = Color.Black;
            this.label1.Location = new Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new Size(600, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Grocery List Item(s)";
            this.label1.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // txtName
            // 
            this.txtName.Font = new Font("Segoe UI", 11F);
            this.txtName.Location = new Point(100, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(400, 27);
            this.txtName.TabIndex = 0;
            this.txtName.PlaceholderText = "Enter grocery item";

            // 
            // listBoxItems
            // 
            this.listBoxItems.Font = new Font("Segoe UI", 11F);
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.ItemHeight = 20;
            this.listBoxItems.Location = new Point(100, 120);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new Size(400, 144);
            this.listBoxItems.TabIndex = 3;

            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = Color.MediumSeaGreen;
            this.btnAddItem.FlatStyle = FlatStyle.Flat;
            this.btnAddItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnAddItem.ForeColor = Color.White;
            this.btnAddItem.Location = new Point(100, 280);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new Size(180, 40);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new EventHandler(this.btnAddItem_Click);

            // 
            // btnSave
            // 
            this.btnSave.BackColor = Color.SeaGreen;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.Location = new Point(320, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(180, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save List";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // 
            // Form2
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Silver;
            this.ClientSize = new Size(600, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Grocery List - Add Items";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
