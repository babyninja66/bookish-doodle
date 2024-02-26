namespace IMSR
{
    partial class productList
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
            productSearchTextBox = new TextBox();
            listView1 = new ListView();
            productName = new ColumnHeader();
            SuspendLayout();
            // 
            // productSearchTextBox
            // 
            productSearchTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            productSearchTextBox.ImeMode = ImeMode.On;
            productSearchTextBox.Location = new Point(82, 70);
            productSearchTextBox.Margin = new Padding(6, 6, 4, 4);
            productSearchTextBox.Name = "productSearchTextBox";
            productSearchTextBox.PlaceholderText = "Search by product name";
            productSearchTextBox.Size = new Size(620, 61);
            productSearchTextBox.TabIndex = 0;
            productSearchTextBox.TextChanged += productSearchTextBox_TextChanged;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { productName });
            listView1.ImeMode = ImeMode.On;
            listView1.Location = new Point(82, 214);
            listView1.Margin = new Padding(4);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(620, 524);
            listView1.Sorting = SortOrder.Ascending;
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // productName
            // 
            productName.Text = "Product Names";
            productName.Width = 550;
            // 
            // productList
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 832);
            Controls.Add(listView1);
            Controls.Add(productSearchTextBox);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "productList";
            Text = "Product List";
            Shown += productList_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox productSearchTextBox;
        private ListView listView1;
        private ColumnHeader productName;
    }
}