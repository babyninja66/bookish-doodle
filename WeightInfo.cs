using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IMSR
{
    public partial class WeightInfo : Form
    {
        private string? receivedBarcode;
        public WeightInfo(string barcode)
        {
            InitializeComponent();
            receivedBarcode = barcode;
            cartonIdTextBox.Text = receivedBarcode;
            cartonIdTextBox.Focus();
        }

        public string barcodeCheckIn
        {
            get { return cartonIdTextBox.Text; }
        }

        //method for loading carton Id details fromm rStockLedgerByCarton db
        private void loadCartonIdDetails()
        {
            //create sql connection
            string connectionString = "Data Source=DESKTOP-8H7S2TP\\BARTENDER;Initial Catalog=imsDb;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "Select * FROM dbo.rStockLedgerByCarton WHERE cartonId = @CartonId";
            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);
            cmd.Parameters.Add("@CartonId", SqlDbType.NVarChar).Value = Convert.ToString(cartonIdTextBox.Text);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    quantityTextBox.Text = ((double)reader["cartonWeight"]).ToString(); //need to modify if null value returned, currently throwing exception
                    productTextBox.Text = (string)reader["productName"];
                    supplierTextBox.Text = (string)reader["supplierName"];
                    dateTextBox.Text = ((DateTime)reader["productionDate"]).ToString();
                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //load carton id information once the barcode scans carton Id 
        private void cartonIdTextBox_TextChanged(object sender, EventArgs e)
        {
            loadCartonIdDetails();
        }

        //save buttons saves the new quantity information into rStockLedgerByCarton
        private void saveBtn_Click(object sender, EventArgs e)
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

            if (newWeightTextBox != null)
            {
                cmd.Parameters["@CartonId"].Value = cartonIdTextBox.Text;
                cmd.Parameters["@ProductName"].Value = productTextBox.Text;
                cmd.Parameters["@SupplierName"].Value = supplierTextBox.Text;
                cmd.Parameters["@ProductionDate"].Value = dateTextBox.Text;
                cmd.Parameters["@CheckInWeight"].Value = newWeightTextBox.Text;
                cmd.Parameters["@CartonType"].Value = "Cut";
                cmd.ExecuteNonQuery();
                MessageBox.Show("New weight has been saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newWeightTextBox.Clear();
                cartonIdTextBox.Clear();
            }
            else MessageBox.Show("Weight not entered, please enter weight before saving.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
