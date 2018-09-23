using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWMS.classPackages
{
    class CustomerOrder
    {
        private int row;
        private int orderID;
        private DateTime dateOfOrder;
        private DateTime timeOfOrder;
        private int itemID;
        private double quantity;
        private string orderDestination;
        private int customerID;
        private string customerName;
        private int contactNo;
        private double weight;




        public CustomerOrder(int itemID, double quantity, string orderDestination, int customerID, string customerName, int contactNo, double weight)
        {
            this.itemID = itemID;
            this.quantity = quantity;
            this.orderDestination = orderDestination;
            this.customerID = customerID;
            this.customerName = customerName;
            this.contactNo = contactNo;
            this.weight = weight;
        }
        public CustomerOrder() { }

        public int setCustomerOrderID()
        {
            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "Select top 1 orderID from CustomerOrder order by orderID DESC";
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

        public void addCustomerOrder()
        {
            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "Insert into CustomerOrder(row,orderID,transactionID,dateOfOrder,timeOfOrder,itemID,quantity,orderDestination,customerID,customerName,contactNo,weight,status) values (" + this.setCustomerOrderRowID() + " , " + this.setCustomerOrderID() + " , " + this.setCustomerOrderID() + ", " + "GETUTCDATE()" + ", " + "CURRENT_TIMESTAMP" + ", " + this.itemID + ", " + this.quantity + ",' " + this.orderDestination + "'," + this.customerID + ",'" + this.customerName + "'," + this.contactNo + "," + this.weight + ", 'Incomplete' );";
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
        //public void addCustomerOrderDetails()
        //{
        //    string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
        //    string query = "Insert into CustomerOrder(orderID,customerID,customerName,destinationAddress,customerPhone,transactionID,dateOfOrder,timeOfOrder,itemID,quantity,orderDestination,customerID,customerName,contactNo,weight) values (" + this.setCustomerOrderRowID() + " , " + this.setCustomerOrderID() + " , " + this.setCustomerOrderID() + ", " + "GETUTCDATE()" + ", " + "CURRENT_TIMESTAMP" + ", " + this.itemID + ", " + this.quantity + ",' " + this.orderDestination + "'," + this.customerID + ",'" + this.customerName + "'," + this.contactNo + "," + this.weight + ");";
        //    SqlConnection conDataBase = new SqlConnection(conString);
        //    SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
        //    //SqlDataReader myReader;
        //    try
        //    {
        //        conDataBase.Open();
        //        //myReader = cmdDataBase.ExecuteReader();
        //        cmdDataBase.ExecuteNonQuery();
        //        DialogResult result = MessageBox.Show("Saved");

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);

        //    }


        //}

        public void removeCustomerOrder(int orderID)
        {


            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "delete from CustomerOrder where orderID = @orderID";

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


        public void updateCustomerOrder(int orderID)
        {
            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "select * from CustomerOrder where orderID = @orderID";

            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            cmdDataBase.Parameters.AddWithValue("@orderID", orderID);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                this.itemID = myReader.GetInt32(0);
                this.quantity = myReader.GetInt32(6); ;
                this.orderDestination = myReader.GetString(7);
                this.customerID = myReader.GetInt32(8);
                this.customerName = myReader.GetString(9);
                this.contactNo = myReader.GetInt32(10);
                this.weight = myReader.GetDouble(11);
                MessageBox.Show("Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        /*public void updateCustomerOrder(int itemID,double quantity,string orderDestination,int customerID,string customerName,int contactNo,double weight)
        {
            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "update CustomerOrder set itemID = @itemID,quantity = @quantity,orderDestination = @orderDestination,customerID = @customerID,customerName = @customerName,contactName = @contactName,weight = @weight where orderID = @orderID";

            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            cmdDataBase.Parameters.AddWithValue("@itemID", itemID);
            cmdDataBase.Parameters.AddWithValue("@quantity", quantity);
            cmdDataBase.Parameters.AddWithValue("@orderDestination", orderDestination);
            cmdDataBase.Parameters.AddWithValue("@customerID", customerID);
            cmdDataBase.Parameters.AddWithValue("@customerName", customerName);
            cmdDataBase.Parameters.AddWithValue("@contactNo", contactNo);
            cmdDataBase.Parameters.AddWithValue("@weight", weight);

            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }*/
        public int setCustomerOrderRowID()
        {
            string conString = @"Data Source=DESKTOP-K75LPR3\MSSQL2014;Initial Catalog=HWMSN;Integrated Security=True;Pooling=False";
            string query = "Select top 1 row from  CustomerOrder order by row DESC";
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
        public void searchCustomerOrder(int customerId) { }

        public void getCustomerOrderById(int customerId) { }

        public void generateCustomerOrderReport(int customerId) { }
    }
}
