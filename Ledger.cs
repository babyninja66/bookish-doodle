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
    public partial class Ledger : Form
    {
        public Ledger()
        {
            InitializeComponent();
            loadLedgerData();
        }

        private void loadLedgerData()
        {
            string connectionString = "Data Source=DESKTOP-8H7S2TP\\BARTENDER;Initial Catalog=imsDb;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "Select productName, SUM(cartonWeight), cartonType FROM dbo.rStockLedgerByCarton GROUP BY productName, cartonType";
            con.Open();
            var dataAdapter = new SqlDataAdapter(selectSQL, con);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

        }

    }
}
