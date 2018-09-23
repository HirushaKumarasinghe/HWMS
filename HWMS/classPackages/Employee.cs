using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HWMS.classPackages
{
    class Employee
    {
        private int empId;
        private String empFName;
        private String empMName = "null";
        private String empLName;
        private String empType;
        private int age;
        private String city;
        private String addressLine1;
        private String addressLine2;
        private String contact;
        private String employeeType;

        public Employee() {
        }
        public Employee(String empFName, String empLName, String empType,
        int age,
        String city,
        String addressLine1,
        String addressLine2,
        String phone) {
            this.empFName = empFName;
            this.empLName = empLName;
            this.empType = empType;
            this.age = age;
            this.city = city;
            this.addressLine1 = addressLine1;
            this.addressLine2 = addressLine2;
            this.contact = phone;
        }
        public void updateEmployee(int empId) { }
        public void searchEmployee(int empId) { }
        Employee getemployeeById(int empId) {
            return null;
        }
        public void generateEmployeeReport(int empID) { }
        public void employeeIn(int empId) { }
        public void employeeOut(int empID) { }
        void removeEmployee(int empID) { }
        public void addEmployee() {
            DBConnection newCon = new DBConnection();
            newCon.OpenConection();
            String password = empFName + "123";
            newCon.ExecuteQueries("INSERT INTO Employee(employeeID,FName,MName,LName,employeeType,addressLine1,addressLine2,city,age,phone) values ('" + this.getNewEmployeeID() + "','" + this.empFName + "','"+ this.empMName +"','" + this.empLName + "','" + this.empType + "','" + this.addressLine1 + "','" + this.addressLine2 + "','" + this.city + "'," + this.age + ",'" + this.contact + "')");
            //newCon.ExecuteQueries("INSERT INTO UserLogin(employeeID,userType,userName,password,attempt) values ('" + this.getNewEmployeeID() + "','" + this.empType + "','" + this.empFName + "','" + password + "',0)");


        }


        public int getNewEmployeeID() {
            int val = 0;
            DBConnection newCon = new DBConnection();
            newCon.OpenConection();
            SqlDataReader dataSet = newCon.DataReader("select top 1 employeeID from Employee order by employeeID DESC");
            while (dataSet.Read())
            {
                string input = dataSet["employeeID"].ToString();
                val = int.Parse(input) + 1;
            }
            return val;
        }
    }
}
