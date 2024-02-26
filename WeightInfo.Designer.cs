namespace IMSR
{
    partial class WeightInfo
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
            saveBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            newWeightTextBox = new TextBox();
            label6 = new Label();
            cancelBtn = new Button();
            cartonIdTextBox = new TextBox();
            label7 = new Label();
            supplierTextBox = new TextBox();
            productTextBox = new TextBox();
            dateTextBox = new TextBox();
            quantityTextBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            saveBtn.Location = new Point(147, 203);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(235, 70);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(61, 168);
            label1.Name = "label1";
            label1.Size = new Size(119, 38);
            label1.TabIndex = 2;
            label1.Text = "Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(61, 266);
            label2.Name = "label2";
            label2.Size = new Size(113, 38);
            label2.TabIndex = 3;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(61, 362);
            label3.Name = "label3";
            label3.Size = new Size(218, 38);
            label3.TabIndex = 4;
            label3.Text = "Production Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(61, 456);
            label4.Name = "label4";
            label4.Size = new Size(179, 38);
            label4.TabIndex = 5;
            label4.Text = "Available Qty";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(61, 79);
            label5.Name = "label5";
            label5.Size = new Size(125, 32);
            label5.TabIndex = 10;
            label5.Text = "Carton ID";
            // 
            // panel1
            // 
            panel1.Controls.Add(newWeightTextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(saveBtn);
            panel1.Location = new Point(707, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 350);
            panel1.TabIndex = 12;
            // 
            // newWeightTextBox
            // 
            newWeightTextBox.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            newWeightTextBox.ForeColor = SystemColors.ActiveCaption;
            newWeightTextBox.Location = new Point(185, 103);
            newWeightTextBox.Name = "newWeightTextBox";
            newWeightTextBox.Size = new Size(150, 77);
            newWeightTextBox.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(19, 20);
            label6.Name = "label6";
            label6.Size = new Size(158, 32);
            label6.TabIndex = 13;
            label6.Text = "Enter weight";
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn.Location = new Point(977, 545);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(229, 70);
            cancelBtn.TabIndex = 14;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // cartonIdTextBox
            // 
            cartonIdTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cartonIdTextBox.Location = new Point(285, 75);
            cartonIdTextBox.Name = "cartonIdTextBox";
            cartonIdTextBox.Size = new Size(324, 39);
            cartonIdTextBox.TabIndex = 15;
            cartonIdTextBox.TextChanged += cartonIdTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(647, 66);
            label7.Name = "label7";
            label7.Size = new Size(608, 45);
            label7.TabIndex = 16;
            label7.Text = "*ONLY FOR CHECK IN ( RETURN TO R)*";
            // 
            // supplierTextBox
            // 
            supplierTextBox.BackColor = SystemColors.ControlLight;
            supplierTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            supplierTextBox.Location = new Point(285, 161);
            supplierTextBox.Name = "supplierTextBox";
            supplierTextBox.Size = new Size(324, 45);
            supplierTextBox.TabIndex = 17;
            // 
            // productTextBox
            // 
            productTextBox.BackColor = SystemColors.ControlLight;
            productTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            productTextBox.Location = new Point(285, 263);
            productTextBox.Name = "productTextBox";
            productTextBox.Size = new Size(324, 45);
            productTextBox.TabIndex = 18;
            // 
            // dateTextBox
            // 
            dateTextBox.BackColor = SystemColors.ControlLight;
            dateTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTextBox.Location = new Point(285, 359);
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(324, 45);
            dateTextBox.TabIndex = 19;
            // 
            // quantityTextBox
            // 
            quantityTextBox.BackColor = SystemColors.ControlLight;
            quantityTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            quantityTextBox.Location = new Point(285, 453);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(324, 45);
            quantityTextBox.TabIndex = 20;
            // 
            // WeightInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 637);
            Controls.Add(quantityTextBox);
            Controls.Add(dateTextBox);
            Controls.Add(productTextBox);
            Controls.Add(supplierTextBox);
            Controls.Add(label7);
            Controls.Add(cartonIdTextBox);
            Controls.Add(cancelBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "WeightInfo";
            Text = "Enter Weight";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button saveBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox supplierTextBox;
        private TextBox productTextBox;
        private TextBox dateTextBox;
        private TextBox quantityTextBox;
        private Label label5;
        private Panel panel1;
        private Label label6;
        private Button button2;
        private TextBox cartonIdTextBox;
        private Label label7;
        private TextBox newWeightTextBox;
        private Button cancelBtn;
    }
}