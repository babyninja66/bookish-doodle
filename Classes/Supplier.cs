using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSR.Classes
{
    public class Supplier
    {
        public string SupplierCode { get; set; } = string.Empty;
        public string SupplierName { get; set; } = string.Empty;
        
        public List <Supplier> GetSuppliers()
        
        {
            List<Supplier> suppliers = new List<Supplier>();
            string connectionString = "Data Source=DESKTOP-8H7S2TP\\BARTENDER;Initial Catalog=imsDb;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "Select * from dbo.supplier";
            con.Open();

            SqlCommand cmd = new SqlCommand (selectSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            
            while (reader !=null)
            {
                while (reader.Read())
                {
                    Supplier supplier = new Supplier();
                    supplier.SupplierCode = reader["supplierCode"].ToString(); // think this is the problem
                    supplier.SupplierName = reader["supplierName"].ToString();
                    suppliers.Add(supplier);
                    
                }
                
            }
            con.Close();
            return suppliers;
            

        }
    }
}
