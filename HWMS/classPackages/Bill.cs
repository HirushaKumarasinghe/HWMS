using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWMS.classPackages
{
    class Bill
    {
        private int billID;
        private DateTime billDate;
        private DateTime billTime;
        private int row;
        private int itemId;
        private double quantity;
        private string quantityType;
        private bool discountAdd;
        private double discount;
        private string itemName;
        private int customerId;
        private int unitPrice;
        private double total;
        private double cash;
        private double balance;

        public Bill(int itemId, String itemName, int quantity, int customerId, string quantityType, bool discountAdd, double total)
        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.customerId = customerId;
            this.quantity = quantity;
            this.quantityType = quantityType;
            this.discountAdd = discountAdd;
            this.total = total;
        }

        public Bill() { }

        public int setBillID()
        {
            string conString = "Data Source=DESKTOP-IOIN20L;Initial Catalog=HWMS;Integrated Security=True;Pooling=False";
            string query = "Select top 1 billID from Bill order by billID DESC";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                //int billID = myReader.GetInt32(0);
                int i = 0, val = 0;
                while (myReader.Read())
                {
                    val = int.Parse(myReader["billID"].ToString());
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
        public void addTemporyBill()
        {
            string conString = "Data Source=DESKTOP-IOIN20L;Initial Catalog=HWMS;Integrated Security=True;Pooling=False";
            string query1 = "Insert into billTemp(row,billID,itemId,itemName,quantity,quantityType,total) values (" + this.setRowID() + " , " + this.setBillID() + ", " + this.itemId + ",'" + this.itemName + "'," + this.quantity + ",'" + this.quantityType + "'," + this.total + ");";
            SqlConnection conDataBase1 = new SqlConnection(conString);
            SqlCommand cmdDataBase1 = new SqlCommand(query1, conDataBase1);
            SqlDataReader myReader1;
            try
            {
                conDataBase1.Open();
                myReader1 = cmdDataBase1.ExecuteReader();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding :" + ex.Message);

            }
        }

        public void removeTemporyBill()
        {
            string conString = "Data Source=DESKTOP-IOIN20L;Initial Catalog=HWMS;Integrated Security=True;Pooling=False";
            string query1 = "DELETE FROM billTemp";
            SqlConnection conDataBase1 = new SqlConnection(conString);
            SqlCommand cmdDataBase1 = new SqlCommand(query1, conDataBase1);
            SqlDataReader myReader1;
            try
            {
                conDataBase1.Open();
                myReader1 = cmdDataBase1.ExecuteReader();
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Deleteing :" + ex.Message);

            }
        }

        public void searchBill(int billId) { }



        public Bill getBillById(int billId) { return null; }

        public void generateBillReport(int billId) { }

        public int setRowID()
        {
            string conString = "Data Source=DESKTOP-IOIN20L;Initial Catalog=HWMS;Integrated Security=True;Pooling=False";
            string query = "Select top 1 row from billTemp order by row DESC";
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
    }
}
