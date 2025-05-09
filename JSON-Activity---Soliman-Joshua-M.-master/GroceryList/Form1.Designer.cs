namespace GroceryList
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing"
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

        private void InitializeComponent()
        {
            listBoxProducts = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxProducts
            // 
            listBoxProducts.BackColor = SystemColors.Info;
            listBoxProducts.Font = new Font("STSong", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.Location = new Point(134, 112);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(407, 184);
            listBoxProducts.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonFace;
            btnAdd.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(173, 312);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(156, 40);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Groceries";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonFace;
            btnDelete.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(352, 312);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(156, 40);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Select and Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 48);
            label1.Name = "label1";
            label1.Size = new Size(270, 48);
            label1.TabIndex = 3;
            label1.Text = "Shopping List";
            // 
            // Form1
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(685, 420);
            Controls.Add(label1);
            Controls.Add(listBoxProducts);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Name = "Form1";
            Text = "Shopping List Viewer";
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
    }
}
