using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT481_RebeccaDeLaney_Unit2
{
    public partial class Form1 : Form
    {
        DB DB1;
        private string user;
        private string password;
        private string server;
        private string database;
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            
            
            if (isValidated())
            {
                DB1 = new DB("Server=" + server + "\\SQLEXPRESS01; " +
                                              "Integrated Security = true; " +
                                              "Database=" + database + "; " +
                                              "User ID=" + user + "; " +
                                              "Password=" + password + ";" +
                                              "Connection timeout = 30");
                MessageBox.Show("Connection information sent.");

            }
            //DB1 = new DB("Server = LINDI\\SQLEXPRESS01; " +
            //                  "Trusted_Connection = true; " +
            //                  "Database = Northwind; " +
            //                  "User Instance = false; " +
            //                  "Connection timeout = 30");
            //MessageBox.Show("Connection information sent.");

        }

        private bool isValidated()
        {
            string user = userTextBox.Text;
            string password = passwordTextBox.Text;
            string server = serverTextBox.Text;
            string database = databaseTextBox.Text;

            string userPattern = @"^[A-Za-z_]{4,20}$";
            string passwordPattern = @"[A-Za-z0-9!@#$&_]*$";
            
            if(user == string.Empty)
            {
                MessageBox.Show("Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userTextBox.Clear();
                passwordTextBox.Clear();
                userTextBox.Focus();
                return false;
            }
            if (password == string.Empty || password.Length < 8)
            {
                MessageBox.Show("Enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Clear();
                passwordTextBox.Focus();
                return false;
            }
            if (server == string.Empty)
            {
                MessageBox.Show("Enter server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userTextBox.Clear();
                passwordTextBox.Clear();
                serverTextBox.Clear();
                databaseTextBox.Clear();
                userTextBox.Focus();
                return false;
            }
            if (database == string.Empty)
            {
                MessageBox.Show("Enter database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userTextBox.Clear();
                passwordTextBox.Clear();
                serverTextBox.Clear();
                databaseTextBox.Clear();
                userTextBox.Focus();
                return false;
            }
            if (Regex.IsMatch(user, userPattern) && Regex.IsMatch(password, passwordPattern) && server == "Lindi" && (database == "Northwind" || database == "BikeSales"))
            { return true; }

            MessageBox.Show("Please enter valid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void CompanyCountButton_Click(object sender, EventArgs e)
        {
            string count = DB1.GetCompanyCount();
            MessageBox.Show(count, "Number of Customer Companies");
        }

        private void CompanyNamesButton_Click(object sender, EventArgs e)
        {
            string names = DB1.GetCompanyNames();
            MessageBox.Show(names, "Company Names");
        }

        private void OrderCountButton_Click(object sender, EventArgs e)
        {
            string count = DB1.GetOrderCount();
            MessageBox.Show(count, "Order Count");
        }

        private void OrderIDsButton_Click(object sender, EventArgs e)
        {
            string orderid = DB1.GetOrders();
            MessageBox.Show(orderid, "OrderID");
        }

        private void EmployeeCountButton_Click(object sender, EventArgs e)
        {
            string count = DB1.GetEmployeeCount();
            MessageBox.Show(count, "Employee Count");
        }

        private void EmployeeNamesButton_Click(object sender, EventArgs e)
        {
            string names = DB1.GetEmployeeLastNames();
            MessageBox.Show(names, "Employee Last Names");
        }

        
    }
}
