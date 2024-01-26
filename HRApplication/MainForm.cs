using System;
using System.Windows.Forms;

namespace HRApplication
{
    public partial class MainForm : Form
    {
        //The external file used to store employee details.
        string employeesPermanentTextFile = "employees.txt";
        
        //The collection used to hold the employees' data. Employees objects also behave as lists.
        Employees employeesList = new Employees();
    
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!employeesList.Load(employeesPermanentTextFile))        //Creates Employee objects using data from an external .txt file.
            {
                MessageBox.Show("Unable to load employees file");
            }
            else
            {
                PopulateListBox();                                      //Uses created Employee objects to populate the program's list box.
            }
        }
        
        private void PopulateListBox()
        {
            listBoxEmployees.Items.Clear();
            employeesList.Sort();
            foreach (Employee employee in employeesList)
            {
                listBoxEmployees.Items.Add(employee.LastName + ", " + employee.FirstName);
            }
            if (listBoxEmployees.Items.Count > 0)
                listBoxEmployees.SelectedIndex = 0;
        }

        private void listBoxEmployees_DoubleClick(object sender, EventArgs e)       //You can also edit employees' personal data by double-clicking their entry.
        {
            EditOrAddEmployee();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditOrAddEmployee(buttonEdit);
        }

        //The two "New" buttons display a new window whose contents depend on whether you create a new salaried or hourly employee.
        private void buttonNewSalaried_Click(object sender, EventArgs e)
        {
            EditOrAddEmployee(buttonNewSalaried);
        }

        private void buttonNewHourly_Click(object sender, EventArgs e)
        {
            EditOrAddEmployee(buttonNewHourly);
        }

        void EditOrAddEmployee(Button buttonPressed)
        {
            EditEmployeeForm editEmployeeForm = new EditEmployeeForm();
            string previousLastName = employeesList[listBoxEmployees.SelectedIndex].LastName;        //To later compare the employee's name and surname and proceed only if they have been changed.
            string previousFirstName = employeesList[listBoxEmployees.SelectedIndex].FirstName;

            if (buttonPressed == buttonEdit)
            {
                editEmployeeForm.employee = employeesList[listBoxEmployees.SelectedIndex];          //The selected employee's details are "transferred" to the edit employee window.
                editEmployeeForm.Text = "Edit Existing Employee";
            }
            else if (buttonPressed == buttonNewSalaried)
            {
                Employee newSalariedEmployee = new SalariedEmployee();

                editEmployeeForm.employee = newSalariedEmployee;
                editEmployeeForm.Text = "Add New Salaried Employee";
            }
            else
            {
                Employee newHourlyEmployee = new HourlyEmployee();

                editEmployeeForm.employee = newHourlyEmployee;
                editEmployeeForm.Text = "Add New Hourly Employee";
            }

            editEmployeeForm.ShowDialog();

            if (buttonPressed == buttonNewSalaried || buttonPressed == buttonNewHourly)
            {
                if (editEmployeeForm.DialogResult == DialogResult.OK)
                {
                    employeesList.Add(editEmployeeForm.employee);
                    PopulateListBox();

                    if (!employeesList.Save(employeesPermanentTextFile))
                    {
                        MessageBox.Show("Unable to save to file");
                    }
                }
            }

            if (buttonPressed == buttonEdit)
            {
                if (editEmployeeForm.DialogResult == DialogResult.OK)
                {
                    if (editEmployeeForm.employee.LastName != previousLastName || editEmployeeForm.employee.FirstName != previousFirstName)     //Compares the new (sur)name with the old.
                        PopulateListBox();

                    if (!employeesList.Save(employeesPermanentTextFile))
                    {
                        MessageBox.Show("Unable to save to file");
                    }
                }
            }
            editEmployeeForm.Close();
        }

        //For editing an employee by double-clicking his/her entry.
        void EditOrAddEmployee()
        {
            EditEmployeeForm editEmployeeForm = new EditEmployeeForm();
            string previousLastName = employeesList[listBoxEmployees.SelectedIndex].LastName;
            string previousFirstName = employeesList[listBoxEmployees.SelectedIndex].FirstName;

            editEmployeeForm.employee = employeesList[listBoxEmployees.SelectedIndex];
            editEmployeeForm.Text = "Edit Existing Employee";

            editEmployeeForm.ShowDialog();

            if (editEmployeeForm.DialogResult == DialogResult.OK)
            {
                if (editEmployeeForm.employee.LastName != previousLastName || editEmployeeForm.employee.FirstName != previousFirstName)
                    PopulateListBox();

                if (!employeesList.Save(employeesPermanentTextFile))
                {
                    MessageBox.Show("Unable to save to file");
                }
            }
            editEmployeeForm.Close();
        }
    }
}