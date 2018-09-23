using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWMS.classPackages
{
    class supplierOrder
    {
        private int row;
        private int orderID;
        private DateTime dateOfOrder;
        private DateTime timeOfOrder;
        private int itemID;
        private double quantity;
        private int supplierID;
        private string supplierName;
        private int contactNo;
        private double weight;

        public supplierOrder(int itemID, double quantity, int supplierID, string supplierName, int contactNo, double weight)
        {
            this.itemID = itemID;
            this.quantity = quantity;
            this.supplierID = supplierID;
            this.supplierName = supplierName;
            this.contactNo = contactNo;
            this.weight = weight;

        }
        public supplierOrder() { }

        public void addSupplierOrder(supplierOrder supplierOrder) { }

        public int setSupplierOrderID()
        {
            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "Select top 1 orderID from SupplierOrder order by orderID DESC";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                //int orderIDX = myReader.GetInt32(0);
                int i = 0, val = 0;
                while (myReader.Read())
                {
                    val = int.Parse(myReader["orderID"].ToString());
                    i++;
                }
                val++;
                myReader.Close();
                myReader.Dispose();

                return val;
            }
            catch (Exception ex)
            {
                MessageBox.Show("1: " + ex.Message);
                return 0;
            }

        }

        public void addSupplierOrder()
        {
            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "Insert into SupplierOrder(row,orderID,transactionID,dateOfOrder,timeOfOrder,itemID,quantity,supplierID,supplierName,contactNo,weight) values (" + this.setSupplierOrderRowID() + " , " + this.setSupplierOrderID() + " , " + this.setSupplierOrderID() + ", " + "GETUTCDATE()" + ", " + "CURRENT_TIMESTAMP" + ", " + this.itemID + ", " + this.quantity + "," + this.supplierID + ",'" + this.supplierName + "'," + this.contactNo + "," + this.weight + ");";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            //SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                //myReader = cmdDataBase.ExecuteReader();
                cmdDataBase.ExecuteNonQuery();
                DialogResult result = MessageBox.Show("Saved");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }






        }

        public void removeSupplierOrder(int orderID)
        {


            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "delete from SupplierOrder where orderID = @orderID";

            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            cmdDataBase.Parameters.AddWithValue("@orderID", orderID);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void updateSupplierOrder(int orderID)
        {
            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "select * from SupplierOrder where orderID = @orderID";

            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            cmdDataBase.Parameters.AddWithValue("@orderID", orderID);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                this.itemID = myReader.GetInt32(5);
                this.quantity = myReader.GetInt32(6); ;
                this.supplierID = myReader.GetInt32(7);
                this.supplierName = myReader.GetString(8);
                this.contactNo = myReader.GetInt32(9);
                this.weight = myReader.GetDouble(10);
                MessageBox.Show("Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public int setSupplierOrderRowID()
        {
            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "Select top 1 row from  SupplierOrder order by row DESC";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                //int row = myReader.GetInt32(0);
                int i = 0, val = 0;
                while (myReader.Read())
                {
                    val = int.Parse(myReader["row"].ToString());
                    i++;
                }
                val++;
                myReader.Close();
                myReader.Dispose();

                return val;

            }
            catch (Exception ex)
            {
                MessageBox.Show("1: " + ex.Message);
                return 0;
            }

        }
        public void searchSupplierOrder(int supplierId) { }

        public Order getSupplierOrderById(int supplierId) { return null; }

        public void generateSupplierOrderReport(int supplierId) { }
    }
}
