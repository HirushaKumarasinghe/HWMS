using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HWMS.classPackages
{
    class Courier
    {
        private int orderId;
        private string courierType;
        private string courierFrom;
        private string courierState;
        private string description;
        private double weight;
        private string phone;
        private int transactionId;
        private int vehicleId;
        private int driverId;
        private string destination;
        private double distance;
        private DateTime deliveryDate;
        private double cost;
        //private string deliveryDate;

        public Courier(int orderId, string courierType, string courierFrom,
         string courierState, string description, double weight, string phone, int transactionId,
         int vehicleId, int driverId, string destination, double distance,
         DateTime deliveryDate, double cost)
        {
            this.orderId = orderId;
            this.courierType = courierType;
            this.courierFrom = courierFrom;
            this.courierState = courierState;
            this.description = description;
            this.weight = weight;
            this.phone = phone;
            this.transactionId = transactionId;
            this.vehicleId = vehicleId;
            this.driverId = driverId;
            this.destination = destination;
            this.distance = distance;
            this.deliveryDate = deliveryDate;
            this.cost = cost;

        }
        public Courier()
        {

        }
        public void addCourier()
        {
            string conString = "Data Source=DESKTOP-IOIN20L;Initial Catalog=HWMS;Integrated Security=True;Pooling=False";
            string query = "Insert into Courier(orderId,courierType,courierFrom,courierState,description,weight,phone,transactionID,vehicleID,driverID,destination,distance,deliveryDate,cost) values ('" + this.orderId + "' , '" + this.courierType + "', '" + this.courierFrom + "', '" + this.courierState + "', '" + this.description + "', '" + this.weight + "', '" + this.phone + "', '" + this.transactionId + "', '" + this.vehicleId + "', '" + this.driverId + "', '" + this.destination + "', '" + this.distance + "', '" + this.deliveryDate + "', '" + this.cost + "');";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        public void serchCourier() { }
        public void updateCourier() { }
        public void deleteCourier(int orderId)
        {
            
            string conString = "Data Source=DESKTOP-IOIN20L;Initial Catalog=HWMS;Integrated Security=True;Pooling=False";
            string query = "delete from Courier where orderId = @orderId";

            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            cmdDataBase.Parameters.AddWithValue("@orderId", orderId);
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
        public void generateCourierReport() { }

    }
}
