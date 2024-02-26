using IMSR.Classes;
using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Windows.Forms;



namespace IMSR
{
    public partial class CheckInForm : Form
    {
        DateTimePicker productionDateTimePicker = new DateTimePicker();


        public CheckInForm()
        {
            InitializeComponent();
            comboBoxSupplier_binding();
            scanIdDataGridView.Controls.Add(productionDateTimePicker);

        }

        // updates the scanned barcode into listview
        public void UpdateList()
        {
            // add function here to check if scanned barcode is existing in db

            string connectionString = "Data Source=DESKTOP-8H7S2TP\\BARTENDER;Initial Catalog=imsDb;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "Select count(*) As ReturnCount FROM dbo.rStockLedgerByCarton WHERE cartonId = @CartonId";
            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);
            cmd.Parameters.Add("@CartonId", SqlDbType.NVarChar).Value = Convert.ToString(textBox5.Text);
            int ReturnCount = (int)cmd.ExecuteScalar();


            // if barcode exists in ledger, then open up WeightInfo show dialog 
            if (ReturnCount > 0)
            {
                string scannedCartonId = textBox5.Text;
                WeightInfo weightInfo = new WeightInfo(scannedCartonId);
                weightInfo.ShowDialog();
                
            }

            // if barcode does not exist in ledger, then perform adding to datagridview
            else
            {
                /* code for adding to listview (archive)
                ListViewItem listItem = new ListViewItem(new String[] { textBox5.Text });
                this.listView1.Items.Add(listItem);
                textBox1.Text = listView1.Items.Count.ToString();
                */
                // add barcode ID to carton Id column in DGV on next available row
                var index = this.scanIdDataGridView.Rows.Add();
                scanIdDataGridView.Rows[index].Cells[0].Value = textBox5.Text;

            }
            cmd.ExecuteNonQuery();
            con.Close();


        }

        // bulk update of Supplier, Product, Production Date, Weight
        private void BulkUpdateFields()
        {
            foreach (DataGridViewRow row in scanIdDataGridView.Rows)
            {
                if (row.Cells[0].Value != null) //check if barcode id is populated
                {
                    row.Cells[1].Value = comboBox1.Text; //supplier, what if null value
                    row.Cells[2].Value = textBox3.Text; //product name
                    row.Cells[3].Value = dateTimePicker1.Value; //production date
                    row.Cells[4].Value = textBox6.Text; //carton weight
                }
            }

        }

        // puts the scanned barcode textbox to focus on form shown
        private void CheckInForm_Shown(object sender, EventArgs e)
        {
            textBox5.Focus();
        }

        // executes UpdateList method once the barcode is scanned and keyPress ENTER
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                UpdateList();
                textBox5.Clear();
                textBox5.Focus();
            }

        }

        // binds the Supplier field dropdown to list of suppliers in SQL rSupplier db
        private void comboBoxSupplier_binding()
        {
            try
            {

                string connectionString = "Data Source=DESKTOP-8H7S2TP\\BARTENDER;Initial Catalog=imsDb;Integrated Security=True;TrustServerCertificate=True";
                SqlConnection con = new SqlConnection(connectionString);
                string selectSQL = "Select * from dbo.rSupplier";
                con.Open();

                SqlCommand cmd = new SqlCommand(selectSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("Suppliers", typeof(string));


                dt.Load(reader);
                comboBox1.ValueMember = "SupplierName";
                comboBox1.DataSource = dt;
                comboBox1.SelectedItem = null;
                comboBox1.SelectedText = "--select--";
                con.Close();
            }
            catch (Exception)
            {

            }
        }

        //save button to send data to SQL rStockIn db
        /* 
        private void saveDataBtn_Click(object sender, EventArgs e)
         {
             string connectionString = "Data Source=DESKTOP-8H7S2TP\\BARTENDER;Initial Catalog=imsDb;Integrated Security=True;TrustServerCertificate=True";

             SqlConnection con = new SqlConnection(connectionString);
             SqlCommand cmd = new SqlCommand("CheckInR$", con);
             cmd.CommandType = System.Data.CommandType.StoredProcedure;

             //create parameters
             cmd.Parameters.Add("@CartonId", SqlDbType.NVarChar);
             cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar);
             cmd.Parameters.Add("@SupplierName", SqlDbType.NVarChar);
             cmd.Parameters.Add("@ProductionDate", SqlDbType.Date);
             cmd.Parameters.Add("@CheckInWeight", SqlDbType.Float);
             con.Open();

             for (int i = 0; i < listView1.Items.Count; i++)
             {
                 cmd.Parameters["@CartonId"].Value = listView1.Items[i].Text;
                 cmd.Parameters["@ProductName"].Value = textBox3.Text;
                 cmd.Parameters["@SupplierName"].Value = comboBox1.Text.ToString();
                 cmd.Parameters["@ProductionDate"].Value = dateTimePicker1.Text;
                 cmd.Parameters["@CheckInWeight"].Value = textBox6.Text;
                 cmd.ExecuteNonQuery();
             }
             con.Close();
             MessageBox.Show("Data has been saved.");
         }
        */


        // pops up the productlist form when double click on field
        private void textBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (var productList = new productList())
            {
                productList.ShowDialog();
                textBox3.Text = productList.passProductName;
            }
        }

        //for user editing of the Production Date cell
        private void scanIdDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //initialize a new DateTimePicker control 
            //DateTimePicker productionDateTimePicker = new DateTimePicker();

            if (e.ColumnIndex == 3)

            {

                //Adding DateTimePicker control into DataGridView
                //scanIdDataGridView.Controls.Add(productionDateTimePicker);

                // setting the format (e.g. yyyy-mm-dd)
                productionDateTimePicker.Format = DateTimePickerFormat.Short;

                //Returns the rectangular area that represents the Display area for a cell
                Rectangle productionDateRectangle = scanIdDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker control
                productionDateTimePicker.Size = new Size(productionDateRectangle.Width, productionDateRectangle.Height);

                //Setting location
                productionDateTimePicker.Location = new Point(productionDateRectangle.X, productionDateRectangle.Y);

                //An event attached to DateTimePicker control which is fired when DateTimePicker is closed
                productionDateTimePicker.CloseUp += new EventHandler(productionDateTimePicker_CloseUp);

                //An event attached to DateTimePicker control which is fired when date is selected
                productionDateTimePicker.TextChanged += new EventHandler(productionDateTimePicker_OnTextChanged);

                //Make it visible
                productionDateTimePicker.Visible = true;
            }
            // event handler for when user selects in productionDateTimePicker
            void productionDateTimePicker_OnTextChanged(object sender, EventArgs e)
            {
                scanIdDataGridView.CurrentCell.Value = productionDateTimePicker.Text.ToString();
            }

            // event handler for when user closes productionDateTimePicker
            void productionDateTimePicker_CloseUp(object sender, EventArgs e)
            {
                //hiding the control after use
                productionDateTimePicker.Visible = false;
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckInForm_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            BulkUpdateFields();
        }

        //button to clear all fields 
        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox6.Text = "";

        }

        int rowIndex;
        // button to edit data in single field
        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = scanIdDataGridView.Rows[rowIndex];
            newDataRow.Cells[1].Value = comboBox1.Text;
            newDataRow.Cells[2].Value = textBox3.Text;
            newDataRow.Cells[3].Value = dateTimePicker1.Text;
            newDataRow.Cells[4].Value = textBox6.Text;

        }

        //to set the values in the form to the values in selected row in datagridview
        private void scanIdDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // get the index of the select datagridview row 
            rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = new DataGridViewRow();

            //display data from datagridview selected row to textboxes
            selectedRow = scanIdDataGridView.Rows[rowIndex];
            if (selectedRow.Cells[1].Value != null) { comboBox1.Text = selectedRow.Cells[1].Value.ToString(); }
            if (selectedRow.Cells[2].Value != null) { textBox3.Text = selectedRow.Cells[2].Value.ToString(); }
            if (selectedRow.Cells[3].Value != null) { dateTimePicker1.Text = selectedRow.Cells[3].Value.ToString(); }
            if (selectedRow.Cells[4].Value != null) { textBox6.Text = selectedRow.Cells[4].Value.ToString(); }

        }
        //button to save datagridview to sql 
        private void saveDataBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-8H7S2TP\\BARTENDER;Initial Catalog=imsDb;Integrated Security=True;TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("CheckInR$", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //create parameters
            cmd.Parameters.Add("@CartonId", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@SupplierName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ProductionDate", SqlDbType.Date);
            cmd.Parameters.Add("@CheckInWeight", SqlDbType.Float);
            cmd.Parameters.Add("@CartonType", SqlDbType.NVarChar);
            con.Open();

            for (int i = 0; i < scanIdDataGridView.RowCount; i++)
            {
                if (scanIdDataGridView.Rows[i].Cells["CartonId"].Value != null && scanIdDataGridView.Rows[i].Cells["ProductName"].Value
                    != null && scanIdDataGridView.Rows[i].Cells["SupplierName"].Value != null)
                {
                    cmd.Parameters["@CartonId"].Value = Convert.ToString(scanIdDataGridView.Rows[i].Cells["CartonId"].Value);
                    cmd.Parameters["@ProductName"].Value = Convert.ToString(scanIdDataGridView.Rows[i].Cells["ProductName"].Value);
                    cmd.Parameters["@SupplierName"].Value = Convert.ToString(scanIdDataGridView.Rows[i].Cells["SupplierName"].Value);
                    cmd.Parameters["@ProductionDate"].Value = Convert.ToDateTime(scanIdDataGridView.Rows[i].Cells["ProductionDate"].Value);
                    cmd.Parameters["@CheckInWeight"].Value = Convert.ToDouble(scanIdDataGridView.Rows[i].Cells["CartonWeight"].Value);
                    cmd.Parameters["@CartonType"].Value = "Carton";
                    cmd.ExecuteNonQuery();
                }
            }
            
            con.Close();
            MessageBox.Show("Data has been saved.");
        }
    }
}