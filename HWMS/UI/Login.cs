using HWMS.classPackages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWMS.UI
{
    public partial class Login : Form
    {
        string cs = "Data Source=DESKTOP-IOIN20L;Initial Catalog=HWMS;Integrated Security=True;Pooling=False";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hWMSDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.hWMSDataSet.Employee);
            // TODO: This line of code loads data into the 'employeeDETAILS.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDETAILS.Employee);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String userType;
            classPackages.User userob1 = new classPackages.User();
            if (userob1.validateUserLogin(userName.Text,password.Text)) {
                if (userob1.Login(userName.Text, password.Text)) {
                    userType = userob1.setUserType();
                    if (userob1.setAttempt() == 1)
                    {
                        DialogResult result3 = MessageBox.Show("As this is your first loging you need to chage your current password!");
                        resetPanel.Visible = true;
                        resetUserName.Text = userName.Text;

                    }
                    else
                    {
                        switch (userType)
                        {
                            case "owner":
                                MessageBox.Show("Elama cashaa");
                                resetPanel.Visible = true;
                                ownerProfile.Visible = true;
                                break;
                            case "cashier":
                                MessageBox.Show("Elama cashaa");
                                //cashierProfile.Visible = true;
                                break;
                            case "stock":
                                MessageBox.Show("Elama stokaa");
                                //stockProfile.Visible = true
                                break;
                        default:
                                MessageBox.Show("For the Movement you cannot log in to this system!");
                        break;

                    }
                }
                    
                }


            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            resetUserName.Text = userName.Text;
            resetPanel.Visible = true;
        }

        private void resetPRestBtn_Click(object sender, EventArgs e)
        {
            classPackages.User ob1 = new classPackages.User();
            if(ob1.resetPassword(resetUserName.Text, resetPPassword.Text, resetPNewPassword.Text, resetPConfirmPassword.Text))
            {
                label2.Text = "New Password";
                label2.ForeColor = System.Drawing.Color.Black;
                label3.Text = "Confirm New Password";
                label3.ForeColor = System.Drawing.Color.Black;
                switch (ob1.setUserType())
                {
                    case "owner":
                        ownerProfile.Visible = true;
                        break;
                    case "cashier":
                        //cashierProfile.Visible = true;
                        break;
                    case "stock":
                        //stockProfile.Visible = true;
                        break;
                    default:
                        MessageBox.Show("For the Movement you cannot log in to this system!");
                        break;

                }
            }
            else
            {
                label2.Text = ob1.setMessageCPF();
                label2.ForeColor = System.Drawing.Color.Red;
                label3.Text = ob1.setMessageNPF();
                label3.ForeColor = System.Drawing.Color.Red;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void accountsF_Click(object sender, EventArgs e)
        {
            //accountsMenuP.Visible = true;
            //assertMenuP.Visible = false;
            //stockMenuP.Visible = false;
            //employeeMenuP.Visible = false;
            accountsF.BackColor = Color.FromArgb(163, 255, 245);
            stockF.BackColor = Color.White;
            employeeF.BackColor = Color.White;
            assertsF.BackColor = Color.White;
            //accountsMenuP.BackColor = Color.FromArgb(163, 255, 245);

        }

        private void assertsF_Click(object sender, EventArgs e)
        {
            //visibility of panels
            //assertMenuP.Visible = true;
            //accountsMenuP.Visible = false;
            //stockMenuP.Visible = false;
            //employeeMenuP.Visible = false;

            //colors of buttons
            assertsF.BackColor = Color.FromArgb(163, 255, 245);
            stockF.BackColor = Color.White;
            employeeF.BackColor = Color.White;
            accountsF.BackColor = Color.White;

            //color of panel
            //assertMenuP.BackColor = Color.FromArgb(163, 255, 245);
        }

        private void employeeF_Click(object sender, EventArgs e)
        {
            //assertMenuP.Visible = false;
            //accountsMenuP.Visible = false;
            //stockMenuP.Visible = false;
            //employeeMenuP.Visible = true;
            //employeeF.BackColor = Color.FromArgb(163, 255, 245);
            stockF.BackColor = Color.White;
            assertsF.BackColor = Color.White;
            accountsF.BackColor = Color.White;
            addEmployeeP.Visible = true;
            //employeeMenuP.BackColor = Color.FromArgb(163, 255, 245);
        }

        private void stockF_Click(object sender, EventArgs e)
        {
            //assertMenuP.Visible = false;
            //accountsMenuP.Visible = false;
            //stockMenuP.Visible = true;
            //employeeMenuP.Visible = false;
            stockF.BackColor = Color.FromArgb(163, 255, 245);
            employeeF.BackColor = Color.White;
            assertsF.BackColor = Color.White;
            accountsF.BackColor = Color.White;
            //stockMenuP.BackColor = Color.FromArgb(163, 255, 245);
        }

        private void assertP_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ownerProfile_Paint(object sender, PaintEventArgs e)
        {
            //assertMenuP.Visible = false;
            //accountsMenuP.Visible = false;
            //stockMenuP.Visible = false;
            //employeeMenuP.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Employee E1 = new Employee(fnameT.Text,lNameT.Text,type.Text,int.Parse(ageT.Text),city.Text,addressT1.Text,addressT2.Text,contactT.Text);
            E1.addEmployee();
            this.employeeTableAdapter1.Fill(this.hWMSDataSet.Employee);
            this.employeeTableAdapter.Fill(this.employeeDETAILS.Employee);
            // TODO: This line of code loads data into the 'hWMSDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.hWMSDataSet.Employee);
            // TODO: This line of code loads data into the 'employeeDETAILS.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDETAILS.Employee);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String empID = comboBoxEmp.Text;
            if (empID != "")
            {
                DialogResult result = MessageBox.Show("Do you want to Update Employee ?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DBConnection newCon = new DBConnection();
                    newCon.OpenConection();
                    newCon.ExecuteQueries("update Employee set employeeType = '"+type.Text+ "',addressLine1 = '" + addressT1.Text + "',addressLine2 = '" + addressT2.Text + "',city = '" + city.Text + "',phone = '" + contactT.Text + "'  where employeeID = '" + empID + "'");
                    MessageBox.Show("Empployee Updated!");
                }
            }
            else
            {
                MessageBox.Show("There is no any selected Employee!");
            }
            // TODO: This line of code loads data into the 'hWMSDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.hWMSDataSet.Employee);
            // TODO: This line of code loads data into the 'employeeDETAILS.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDETAILS.Employee);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fnameT.ReadOnly = true;
            mNameT.ReadOnly = true;
            lNameT.ReadOnly = true;

            String empID = comboBoxEmp.Text;
            DBConnection newCon = new DBConnection();
            newCon.OpenConection();
            SqlDataReader dataSet = newCon.DataReader("select * from Employee where employeeID = '"+empID+"'");
            while (dataSet.Read())
            {
                
                fnameT.Text = dataSet["FName"].ToString();
                mNameT.Text = dataSet["MName"].ToString();
                lNameT.Text = dataSet["LName"].ToString();
                type.Text = dataSet["employeeType"].ToString();
                addressT1.Text = dataSet["addressLine1"].ToString();
                addressT2.Text = dataSet["addressLine2"].ToString();
                city.Text = dataSet["city"].ToString();
                ageT.Text = dataSet["age"].ToString();
                contactT.Text = dataSet["phone"].ToString();

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            String empID = comboBoxEmp.Text;
            if (empID != "")
            {
                DialogResult result = MessageBox.Show("Do you want to Delete Employee ?", "Confirmation", MessageBoxButtons.YesNo );
                if (result == DialogResult.Yes) { 
                DBConnection newCon = new DBConnection();
                newCon.OpenConection();
                newCon.ExecuteQueries("Delete Employee where employeeID = '" + empID + "'");
                    MessageBox.Show("Empployee Deleted!");
                }
            }
            else {
                MessageBox.Show("There is no any selected Employee!");
            }
            // TODO: This line of code loads data into the 'hWMSDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.hWMSDataSet.Employee);
            // TODO: This line of code loads data into the 'employeeDETAILS.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDETAILS.Employee);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Employee where FName like '" + textBox9.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void addEmployeeP_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
    

