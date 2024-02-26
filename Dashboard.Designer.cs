namespace IMSR
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(533, 22);
            label1.Name = "label1";
            label1.Size = new Size(88, 32);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(82, 98);
            button1.Name = "button1";
            button1.Size = new Size(299, 180);
            button1.TabIndex = 1;
            button1.Text = "Check-In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(448, 99);
            button2.Name = "button2";
            button2.Size = new Size(299, 179);
            button2.TabIndex = 2;
            button2.Text = "Check-Out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(82, 344);
            button3.Name = "button3";
            button3.Size = new Size(299, 180);
            button3.TabIndex = 3;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(448, 344);
            button4.Name = "button4";
            button4.Size = new Size(299, 180);
            button4.TabIndex = 4;
            button4.Text = "View Ledger";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 22);
            label2.Name = "label2";
            label2.Size = new Size(468, 32);
            label2.TabIndex = 5;
            label2.Text = "Inventory Management System  v1.0";
            label2.Click += label2_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 594);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
    }
}