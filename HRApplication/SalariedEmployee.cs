using System;

namespace HRApplication
{
    //A class representing salaried employees. Contains a method that returns the employee's personal information as a string.
    public class SalariedEmployee : Employee
    {
        decimal _Salary;

        public SalariedEmployee()   //saved as: "S"|Last Name|First Name|Address|Post code|Phone Number|Year of birth|Month of birth|Day of birth|Salary
        {
        }
        
        public SalariedEmployee(string lastName, string firstName,  string address, string postCode, string phoneNumber, DateTime dateOfBirth, decimal salary) :
                                base (firstName, lastName, address, postCode, phoneNumber, dateOfBirth)
        {
            _Salary = salary;
        }

        public SalariedEmployee(string externalFileName) : base (externalFileName)      //Used with the Load Method
        {
            string[] fileContent = externalFileName.Split('|');

            _Salary = decimal.Parse(fileContent[9]);
        }

        public decimal Salary
        {
            get
            {
                return _Salary;
            }
            set
            {
                _Salary = value;
            }
        }

        //Creates the string that represents each SalariedEmployee object and is used to save it to the external .txt file.
        public override string SaveDataToFile
        {
            get
            {
                return "S|" +
                       base.SaveDataToFile + "|" +
                       _Salary;
            }
        }

        public override decimal GetSalary()
        {
            return Salary;
        }

        public override void SetSalary(decimal salary)
        {
            Salary = salary;
        }
    }
}
