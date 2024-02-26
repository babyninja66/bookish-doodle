using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;

namespace IMSR
{
    public partial class CheckOutForm : Form
    {
        public CheckOutForm()
        {
            InitializeComponent();
        }

        /* these methods for delete single item or bulk delete
        // delete button
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
                listView1.Items.Remove(eachItem);

            textBox2.Text = listView1.Items.Count.ToString();
        }
        //delete all button
        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox2.Text = listView1.Items.Count.ToString();
        }
        */

        /* this method is to add the barcode scanned into listview. for bulk update or checkout function
        private void UpdateList()
        {
            ListViewItem listItem = new ListViewItem(new String[] { textBox1.Text });
            this.listView1.Items.Add(listItem);
            textBox2.Text = listView1.Items.Count.ToString();
        }
        */

        // this method executes once barcode scanned and ENTER key pressed
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //UpdateList();
                checkCartonExists();
                textBox1.Clear();
                textBox1.Focus();

            }
        }

        private void CheckOutForm_Shown(object sender, EventArgs e)
        {
            textBox1.Focus(); //for input of barcode number
        }

        //this method will check scanned barcode carton ID to check if it exists on the ledger
        private void checkCartonExists()
        {
            //create variables for sql data
            double? cartonWeight = null;
            string productName = "";
            string supplierName = "";
            string cartonId = "";
            string cartonType = "";
            DateTime? productionDate = null;

            //create sql connection
            string connectionString = "Data Source=DESKTOP-8H7S2TP\\BARTENDER;Initial Catalog=imsDb;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "Select * FROM dbo.rStockLedgerByCarton WHERE cartonId = @CartonId";
            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);
            cmd.Parameters.Add("@CartonId", SqlDbType.NVarChar).Value = Convert.ToString(textBox1.Text);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    textBox6.Text = ((double)reader["cartonWeight"]).ToString(); //need to modify if null value returned, currently throwing exception
                    textBox2.Text = (string)reader["cartonId"];
                    textBox3.Text = (string)reader["productName"];
                    textBox4.Text = (string)reader["supplierName"];
                    textBox5.Text = ((DateTime)reader["productionDate"]).ToString();
                    cartonWeight = ((double)reader["cartonWeight"]);
                    textBox7.Text = (string)reader["cartonType"];
                    productName = (string)reader["productName"];
                    supplierName = (string)reader["supplierName"];
                }
            }
            cmd.ExecuteNonQuery();
            con.Close();

            if (cartonWeight > 0)
            { // if the inventory exists, then bring the user to another form to confirm checkout
                
                DialogResult result = MessageBox.Show((String.Format("{0}, {1}", productName, supplierName)), "确认取货 Confirm to checkout?", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                
                if (result == DialogResult.Yes)
                {
                    //insert code for stored procedure 
                    checkOutCarton();
                    textBox2.Text = cartonId;

                }

                else if (result == DialogResult.No)
                {
                    // no code, closes the Message Box
                }
            }
            else if (cartonWeight == 0)
            {
                MessageBox.Show("Carton ID has no items for checkout", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Carton ID does not exist!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //to send data to rStockOut in SQL upon confirming YES to confirmm checkout
        private void checkOutCarton()
        {
            string connectionString= "Data Source=DESKTOP-8H7S2TP\\BARTENDER;Initial Catalog=imsDb;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("CheckOutR$", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@CartonId", SqlDbType.NVarChar);
            /*
            cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@SupplierName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ProductionDate", SqlDbType.Date);
            cmd.Parameters.Add("@CheckOutWeight", SqlDbType.Float);
            cmd.Parameters.Add("@CartonType", SqlDbType.NVarChar);
            */
            con.Open();

            cmd.Parameters["@CartonId"].Value = Convert.ToString(textBox2.Text);
            /*
            cmd.Parameters["@ProductName"].Value;
            cmd.Parameters["@SupplierName"].Value;
            cmd.Parameters["@ProductionDate"].Vale;
            cmd.Parameters["@CheckOutWeight"].Value;
            cmd.Parameters["@CartonType"].Value;
            */

            // code to capture the print message from sql db 
            con.InfoMessage += new SqlInfoMessageEventHandler(conForCheckOut_InfoMessage);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Item checked out.");

        }

        //code to show SQL print statement. 
        void conForCheckOut_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show(e.Message);
        }
    }
}
