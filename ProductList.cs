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
using IMSR.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Identity.Client;
using System.Runtime.CompilerServices;

namespace IMSR
{
    public partial class productList : Form
    {
        public productList()
        {
            InitializeComponent();
        }

        public string? passProductName
        {
            get 
                {  
                    if (listView1.SelectedItems.Count == 0) return null;
                    else return listView1.SelectedItems[0].Text; 
                }
        }

        // for loading of product list in listview
        private void productListLoad()
        {
            List<Product> products = new List<Product>();

            string connectionString = "Data Source=DESKTOP-8H7S2TP\\BARTENDER;Initial Catalog=imsDb;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string selectSQL = "Select * from dbo.rProduct WHERE productName LIKE '%' + @ProductName + '%'";

                // create parameters to search using inputs from the productSearchTextBox 
                SqlCommand cmd = new SqlCommand(selectSQL, con);
                cmd.Parameters.AddWithValue("@ProductName", productSearchTextBox.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Product product = new Product();
                    product.Name = (string)dr["productName"];
                    ListViewItem listViewItem = new ListViewItem(product.Name);
                    this.listView1.Items.Add(listViewItem);
                }


            }
        }

        private void productSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            productListLoad();
        }

        public void listView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        //loads the product list when the form is shown
        private void productList_Shown(object sender, EventArgs e)
        {
            productListLoad();
        }
    }
}
