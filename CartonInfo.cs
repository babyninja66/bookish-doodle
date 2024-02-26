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

namespace IMSR
{
    public partial class CartonInfo : Form
    {
        public CartonInfo()
        {
            InitializeComponent();
            textBox6.Focus();

        }

        public void GetCartonProductInformation()
        {
            // insert function for getting product information 
            string connectionString = "Data Source=DESKTOP-8H7S2TP\\BARTENDER;Initial Catalog=imsDb;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "Select [******] from dbo.rStockLedgerByCarton WHERE cartonId = @CartonId;";
            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);
            cmd.Parameters.Add("@CartonId", SqlDbType.NVarChar).Value = textBox6.Text;
        }


        /*
        public void FillGridView()
        {
            //stockInDGV.Columns["checkInWeight"].DataPropertyName = "checkInWeight";
            //stockInDGV.Columns["lastUpdate"].DataPropertyName = "lastUpdate";
            //stockInDGV.DataSource = GetCartonTransactionHistory();
        }
        */

        /*public void GetCartonTransactionHistoryIn()
        {
            string connectionString = "Data Source=DESKTOP-8H7S2TP\\BARTENDER;Initial Catalog=imsDb;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQLForStockIn = "Select lastUpdate as lastUpdate, checkInWeight as checkInWeight from dbo.rStockIn WHERE rStockIn.cartonId = @CartonId UNION " +
                "Select lastUpdate as lastUpdate, checkOutWeight as checkOutWeight from dbo.rStockOut WHERE rStockOut.cartonId = @CartonId";

            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQLForStockIn, con);
            cmd.Parameters.Add("@CartonId", SqlDbType.NVarChar).Value = (textBox6.Text == "") ? 1 : Convert.ToInt32(textBox6.Text);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            sqlDataAdapter.Fill(ds);
            //stockInDGV.DataSource = ds.Tables[0];

            con.Close();


            //need SQL to return message if no data found for carton id. 

        }
        */

        /*
        public void GetCartonTransactionHistoryOut()
        {
            string connectionString = "Data Source=DESKTOP-8H7S2TP\\BARTENDER;Initial Catalog=imsDb;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQLForStockIn = "Select lastUpdate, checkOutWeight from dbo.rStockOut WHERE rStockOut.cartonId = @CartonId;";
            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQLForStockIn, con);
            cmd.Parameters.Add("@CartonId", SqlDbType.NVarChar).Value = (textBox6.Text == "") ? 1 : Convert.ToInt32(textBox6.Text);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            sqlDataAdapter.Fill(ds);
            stockOutDGV.DataSource = ds.Tables[0];

            con.Close();


            //need SQL to return message if no data found for carton id. 

        }
        */

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //GetCartonTransactionHistoryIn();
        }

        private void CartonInfo_Shown(object sender, EventArgs e)
        {
            textBox6.Focus();
        }
    }
}
