using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HWMS.classPackages
{
    class User
    {
        private String userName;
        private String password;
        private String userType;
        private String employeeId;
        private String messageNPF;
        private String messageCPF;
        private int attempt;
        //private DateTime firstAttempt;
        //private DateTime lastAttempt;


        public User() { }
        public User(String userName, String password, String userType, String employeeId) {
            this.userName = userName;
            this.password = password;
            this.userType = userType;
            this.employeeId = employeeId;
        }

        public bool Login(String userName, String password)
        {
            DBConnection newCon = new DBConnection();
            newCon.OpenConection();
            SqlDataReader dataSet = newCon.DataReader("Select * From UserLogin Where userName = '"+userName+"' and password = '"+password+"'");

            if (dataSet.Read())
            {
                this.userType = dataSet.GetString(1);
                this.attempt = dataSet.GetInt32(4);
                if (attempt == 0) {
                    newCon.CloseConnection();
                    newCon.OpenConection();

                    //this.firstAttempt = DateTime.Today.ToString("dd-MM-yyyy"); ;
                    //this.lastAttempt = DateTime.Today.ToString("dd-MM-yyyy"); ;
                    this.attempt = attempt + 1;
                    newCon.ExecuteQueries("UPDATE UserLogin SET attempt = '" + attempt + "', firstAttempt = GETUTCDATE(), lastAttempt = GETUTCDATE() Where userName = '" + userName + "'");
                    return true;
                }
                else {
                    this.userType = dataSet.GetString(1);
                    newCon.CloseConnection();
                    newCon.OpenConection();
                    //this.lastAttempt = DateTime.Today;
                    this.attempt = attempt + 1;
                    newCon.ExecuteQueries("UPDATE UserLogin SET attempt = '" + attempt + "', lastAttempt = GETUTCDATE() Where userName = '" + userName + "'");
                    return true;
                    
                }
                
            }
            else {
                MessageBox.Show("User Name and Passwords are invalied!");
                return false;
            }
        }

        public String setUserType() {
            return userType;
        }
        public String setMessageNPF()
        {
            return messageNPF;
        }
        public String setMessageCPF()
        {
            return messageCPF;
        }
        public int setAttempt() {
            return attempt;
        }

        public bool validateUserLogin(String userName, String password) {
            if ((userName == "" || userName == "User Name") && (password == "" || password == "Password"))
            {
                MessageBox.Show("User Name and Password Fields are empty!");
                return false;
            }
            else if (userName == "" || userName == "User Name")
            {
                MessageBox.Show("User Name Field is empty!");
                return false;
            }
            else if (password == "" || password == "Password")
            {
                MessageBox.Show("Password Field is empty!");
                return false;
            }
            else {
                return true;
            }


        }

        public bool resetPassword(String userName, String password,String newPassword, String confirmNewPassword) {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            DBConnection newCon = new DBConnection();
            newCon.OpenConection();
            SqlDataReader dataSet = newCon.DataReader("Select * From UserLogin Where userName = '" + userName + "' and password = '" + password + "'");

            if (dataSet.Read())
            {
                this.userType = dataSet.GetString(1);
                newCon.CloseConnection();
                if (newPassword == "" || newPassword == "Password")
                {
                    this.messageNPF = "New Password Field Cannot keep Empty";
                    return false;
                    
                }
                else if (confirmNewPassword == "" || confirmNewPassword == "Password") {
                    this.messageCPF = "Confirm Password Field Cannot keep Empty";
                    return false;
                }
                else
                {
                    if (newPassword == confirmNewPassword) {
                        if (newPassword.Length > 8)
                        {
                            if (hasNumber.IsMatch(newPassword) && hasLowerChar.IsMatch(newPassword) && hasSymbols.IsMatch(newPassword) && hasUpperChar.IsMatch(newPassword))
                            {
                                newCon.OpenConection();
                                newCon.ExecuteQueries("UPDATE UserLogin SET password = '" + newPassword + "' Where userName = '" + userName + "'");
                                MessageBox.Show("Password Updated!");
                                return true;
                            }
                            else {
                                MessageBox.Show("New password should contain at least one upper case letter, one lower case letter, numeric and special charaters!");
                                return false;
                            }
                            
                        }
                        else {
                            
                            this.messageNPF = "New Password should be more then 8 characters";
                            this.messageCPF = "Confirm Password should be more then 8 characters";
                            return false;
                        }
                        
                        
                    }
                    else
                    {
                        this.messageNPF = "New Password Field not equal to Confirmed Password";
                        this.messageCPF = "Confirm Password Field not equal to New Password";
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("User Name and Passwords are invalied!");
                return false;
            }
        }
        void addUser() {
            DBConnection newCon = new DBConnection();
            newCon.OpenConection();
            SqlDataReader dataSet = newCon.DataReader("INSERT INTO UserLogin(employeeID,userType,userName,password,attempt,) Where userName = '" + userName + "' and password = '" + password + "'");

        }
        void removeUser(String userName) { }
        void searchUser(String userName) { }
        User getUserByName(String name)
        {
            return null;
        }
        void generateUserReport() { }
    }
}
