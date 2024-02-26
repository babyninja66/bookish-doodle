namespace IMSR
{
    partial class CheckInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dateTimePicker1 = new DateTimePicker();
            scanIdDataGridView = new DataGridView();
            CartonId = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductionDate = new DataGridViewTextBoxColumn();
            CartonWeight = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            saveDataBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)scanIdDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 180);
            label2.Name = "label2";
            label2.Size = new Size(137, 45);
            label2.TabIndex = 3;
            label2.Text = "Supplier";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(740, 178);
            label3.Name = "label3";
            label3.Size = new Size(131, 45);
            label3.TabIndex = 4;
            label3.Text = "Product";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(95, 269);
            label4.Name = "label4";
            label4.Size = new Size(251, 45);
            label4.TabIndex = 5;
            label4.Text = "Production Date";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(907, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(486, 50);
            textBox3.TabIndex = 7;
            textBox3.MouseDoubleClick += textBox3_MouseDoubleClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(838, 201);
            button1.Name = "button1";
            button1.Size = new Size(200, 65);
            button1.TabIndex = 9;
            button1.Text = "Insert All";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(64, 57);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Scan or enter barcode #";
            textBox5.Size = new Size(559, 61);
            textBox5.TabIndex = 11;
            textBox5.TextChanged += textBox5_TextChanged;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(926, 269);
            label6.Name = "label6";
            label6.Size = new Size(122, 45);
            label6.TabIndex = 12;
            label6.Text = "Weight";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(1114, 267);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(273, 50);
            textBox6.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(274, 170);
            comboBox1.MaxLength = 10;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(411, 53);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 14;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(418, 264);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(461, 50);
            dateTimePicker1.TabIndex = 15;
            // 
            // scanIdDataGridView
            // 
            scanIdDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scanIdDataGridView.Columns.AddRange(new DataGridViewColumn[] { CartonId, SupplierName, ProductName, ProductionDate, CartonWeight });
            scanIdDataGridView.Location = new Point(67, 466);
            scanIdDataGridView.Name = "scanIdDataGridView";
            scanIdDataGridView.RowHeadersWidth = 62;
            scanIdDataGridView.RowTemplate.Height = 33;
            scanIdDataGridView.Size = new Size(1361, 308);
            scanIdDataGridView.TabIndex = 16;
            scanIdDataGridView.CellDoubleClick += scanIdDataGridView_CellDoubleClick;
            scanIdDataGridView.RowHeaderMouseClick += scanIdDataGridView_RowHeaderMouseClick;
            // 
            // CartonId
            // 
            CartonId.Frozen = true;
            CartonId.HeaderText = "Carton ID";
            CartonId.MinimumWidth = 8;
            CartonId.Name = "CartonId";
            CartonId.Resizable = DataGridViewTriState.False;
            CartonId.Width = 200;
            // 
            // SupplierName
            // 
            SupplierName.Frozen = true;
            SupplierName.HeaderText = "Supplier";
            SupplierName.MinimumWidth = 8;
            SupplierName.Name = "SupplierName";
            SupplierName.Resizable = DataGridViewTriState.False;
            SupplierName.Width = 250;
            // 
            // ProductName
            // 
            ProductName.Frozen = true;
            ProductName.HeaderText = "Product Name";
            ProductName.MinimumWidth = 8;
            ProductName.Name = "ProductName";
            ProductName.Resizable = DataGridViewTriState.False;
            ProductName.Width = 500;
            // 
            // ProductionDate
            // 
            ProductionDate.Frozen = true;
            ProductionDate.HeaderText = "Production Date";
            ProductionDate.MinimumWidth = 8;
            ProductionDate.Name = "ProductionDate";
            ProductionDate.Resizable = DataGridViewTriState.False;
            ProductionDate.Width = 200;
            // 
            // CartonWeight
            // 
            CartonWeight.Frozen = true;
            CartonWeight.HeaderText = "Carton Weight (kg)";
            CartonWeight.MinimumWidth = 8;
            CartonWeight.Name = "CartonWeight";
            CartonWeight.Resizable = DataGridViewTriState.False;
            CartonWeight.Width = 150;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(64, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(1364, 288);
            panel1.TabIndex = 17;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(1094, 201);
            button3.Name = "button3";
            button3.Size = new Size(200, 65);
            button3.TabIndex = 19;
            button3.Text = "Insert";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(563, 201);
            button2.Name = "button2";
            button2.Size = new Size(200, 65);
            button2.TabIndex = 18;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // saveDataBtn
            // 
            saveDataBtn.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            saveDataBtn.Location = new Point(1225, 814);
            saveDataBtn.Name = "saveDataBtn";
            saveDataBtn.Size = new Size(200, 65);
            saveDataBtn.TabIndex = 18;
            saveDataBtn.Text = "Save";
            saveDataBtn.UseVisualStyleBackColor = true;
            saveDataBtn.Click += saveDataBtn_Click;
            // 
            // CheckInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1477, 920);
            Controls.Add(saveDataBtn);
            Controls.Add(scanIdDataGridView);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "CheckInForm";
            Text = "Enter Barcode Information";
            Load += CheckInForm_Load;
            Shown += CheckInForm_Shown;
            ((System.ComponentModel.ISupportInitialize)scanIdDataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox textBox3; //change from private to public 
        private Button button1;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DateTimePicker dateTimePicker1;
        private DataGridView scanIdDataGridView;
        private DataGridViewTextBoxColumn CartonId;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductionDate;
        private DataGridViewTextBoxColumn CartonWeight;
        private Panel panel1;
        private Button button2;
        private Button button3;
        private Button saveDataBtn;
    }
}