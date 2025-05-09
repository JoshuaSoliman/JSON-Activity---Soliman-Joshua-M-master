namespace GroceryList
{
    partial class Form2
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

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBoxItems;

        private void InitializeComponent()
        {
            txtName = new TextBox();
            btnAddItem = new Button();
            btnSave = new Button();
            listBoxItems = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ButtonFace;
            txtName.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            txtName.Location = new Point(149, 117);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Product Name";
            txtName.Size = new Size(218, 27);
            txtName.TabIndex = 0;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = SystemColors.ButtonFace;
            btnAddItem.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            btnAddItem.Location = new Point(431, 117);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(70, 27);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "Add";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ButtonFace;
            btnSave.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            btnSave.Location = new Point(290, 301);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // listBoxItems
            // 
            listBoxItems.BackColor = SystemColors.Info;
            listBoxItems.Location = new Point(149, 151);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(352, 144);
            listBoxItems.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 22);
            label1.Name = "label1";
            label1.Size = new Size(327, 62);
            label1.TabIndex = 5;
            label1.Text = "Add Groceries";
            // 
            // Form2
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(680, 380);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnAddItem);
            Controls.Add(listBoxItems);
            Controls.Add(btnSave);
            Name = "Form2";
            Text = "Add Groceries";
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
    }
}
