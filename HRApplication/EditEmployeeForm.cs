using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRApplication
{
    public partial class EditEmployeeForm : Form        //The program's second window/form, used when editing an employee's personal information or adding a new employee.
    {
        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        public Employee employee { get; set; }      //So that an employee's details can be transferred from the main form to this one.

        //A vertical line separating the Save and Cancel buttons from the employee's data.
        private void EditEmployeeForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black), new Point(27, 281), new Point(969, 281));
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            ConfigureFormLayout();
            FillFieldsWithInfo();
        }

        //Salaried employees have different personal details from hourly ones.
        void ConfigureFormLayout()
        {
            if (employee is SalariedEmployee)
            {
                labelHourlyPay.Visible = false;
                labelOvertimePay.Visible = false;
                textBoxHourlyPay.Visible = false;
                textBoxOvertimePay.Visible = false;
            }
            else
            {
                labelAnnualSalary.Visible = false;
                textBoxAnnualSalary.Visible = false;
            }
        }

        //The local variables/info of the employee that was selected for editing are displayed in the form.
        void FillFieldsWithInfo()
        {
            if (employee != null)
            {
                textBoxLastName.Text = employee.LastName;
                textBoxFirstName.Text = employee.FirstName;
                textBoxAddress.Text = employee.Address;
                textBoxPostCode.Text = employee.PostCode;
                textBoxPhoneNumber.Text = employee.PhoneNumber;
                try
                {
                    dateTimePicker1.Value = employee.DateOfBirth;   //Inside a try/catch because he date assigned to Employee objects created with the default constructor was throwing an exception.
                }
                catch
                {
                    dateTimePicker1.Value = DateTime.Today;
                }
                textBoxAnnualSalary.Text = employee.GetSalary().ToString();
                textBoxHourlyPay.Text = employee.GetHourlyPay().ToString();
                textBoxOvertimePay.Text = employee.GetOvertimePay().ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            employee.LastName = textBoxLastName.Text;
            employee.FirstName = textBoxFirstName.Text;
            employee.Address = textBoxAddress.Text;
            employee.PostCode = textBoxPostCode.Text;
            employee.PhoneNumber = textBoxPhoneNumber.Text;
            employee.DateOfBirth = dateTimePicker1.Value;

            decimal salary;
            decimal hourlyPay;
            decimal OvertimePay;

            if (decimal.TryParse(textBoxAnnualSalary.Text, out salary))
                employee.SetSalary(salary);

            if (decimal.TryParse(textBoxHourlyPay.Text, out hourlyPay))
                employee.SetHourlyPay(hourlyPay);

            if (decimal.TryParse(textBoxOvertimePay.Text, out OvertimePay))
                employee.SetOvertimePay(OvertimePay);

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
