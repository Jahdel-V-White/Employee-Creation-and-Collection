using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace White_10._4
{
    public partial class EmployeeDataCollection : Form
    {
        //created an object list so that employee data can be stored and view a little easier 
        private List<Employee> employeeList = new List<Employee>();
        public EmployeeDataCollection()
        {
            InitializeComponent();

        }

        //create method for collecting User Data 
        private void CreateEmployee()
        {

			//when creating an object you must make a name for the object and sat new
            Employee employee = new Employee(NameBox.Text, IDBOX.Text, PosBox.Text, DepartBox.Text);

            //if the user does not enter information for all boxes
            if (string.IsNullOrWhiteSpace(NameBox.Text) ||
                string.IsNullOrWhiteSpace(IDBOX.Text) ||
                string.IsNullOrWhiteSpace(PosBox.Text) ||
                string.IsNullOrWhiteSpace(DepartBox.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all the information.");
                return; // Exit the method if any field is empty
            }


            //data is added to the list
            MessageBox.Show(employee.ToString());
            employeeList.Add(employee);

            //new employees will be added to a file and stores

            try
            {
                string File = "Employees.txt";

                using (StreamWriter writer = new StreamWriter(File, true))
                {
                    writer.WriteLine(employee.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FILE ERROR: \n" + ex.Message);
            }



        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void RunBtn_Click_1(object sender, EventArgs e)
        {
            //once button is pressed method to create an employee is ran
            // user data has been stored in a list for better display will now be added to list box for stakeholders to view
            CreateEmployee();
            foreach (Employee var in employeeList)
            {
                UserList.Items.Add(var.ToString());

            }
        }
    }


    //class creation
    class Employee
    {
        //class attributes
        public string Ename;
        public string EID;
        public string EPosition;
        public string EDepartment;

        //constructor that is called when an object is created
        public Employee(string aEname, string aEID, string aPostion, string aDepartment)
        {
            Ename = aEname;
            EID = aEID;
            EPosition = aPostion;
            EDepartment = aDepartment;
        }

        //constrcutor 


        public Employee() { }

        public override string ToString()
        {
            //better data display that I found online
            return $"{Ename} - {EID} - {EPosition} - {EDepartment}";
        }
    }
}
