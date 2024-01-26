using System;

namespace HRApplication
{
    //The class representing an employee. Contains virtual methods that are used by the two inheritinbg classes (Salaried and HourlyEmployee) and a method to compare two employees, which is nedded for the .Sort() method
    //in the main form to work.
    public class Employee : IComparable<Employee>
    {
        string _FirstName;
        string _LastName;
        string _Address;
        string _PostCode;
        string _PhoneNumber;        //String and not integer, in case user also enters symbols [e.g. +44, (01332)]
        DateTime _DateOfBirth;

        public Employee()
        {
            _LastName = "surname";
            _FirstName = "first name";
            _Address = "address";
            _PostCode = "post code";
            _PhoneNumber = "phone number";
        }

        public Employee(string lastName, string firstName, string address, string postCode, string phoneNumber, DateTime dateOfBirth)
        {
            _LastName = lastName;
            _FirstName = firstName;
            _Address = address;
            _PostCode = postCode;
            _PhoneNumber = phoneNumber;
            _DateOfBirth = dateOfBirth;
        }

        public Employee(string externalFileName)                        //Used with the Load Method
        {
            string[] fileContent = externalFileName.Split('|');

            _LastName = fileContent[1];
            _FirstName = fileContent[2];
            _Address = fileContent[3];
            _PostCode = fileContent[4];
            _PhoneNumber = fileContent[5];
            _DateOfBirth = new DateTime(int.Parse(fileContent[6]), int.Parse(fileContent[7]), int.Parse(fileContent[8]));
        }

        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }

        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }

        public string PostCode
        {
            get
            {
                return _PostCode;
            }
            set
            {
                _PostCode = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                _PhoneNumber = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return _DateOfBirth;
            }
            set
            {
                _DateOfBirth = value;
            }
        }

        //Creates the string that represents each Hourly or Salaried Employee object and is used to save it to the external .txt file.
        public virtual string SaveDataToFile
        {
            get
            {
                return _LastName + "|" +
                       _FirstName + "|" +
                       _Address + "|" +
                       _PostCode + "|" +
                       _PhoneNumber + "|" +
                       _DateOfBirth.Year + "|" +
                       _DateOfBirth.Month + "|" +
                       _DateOfBirth.Day;
            }
        }

        public virtual decimal GetSalary()
        {
            return 0;
        }

        public virtual decimal GetHourlyPay()
        {
            return 0;
        }

        public virtual decimal GetOvertimePay()
        {
            return 0;
        }

        //For the program's correct function, all Salaried and Hourly employee objects are created as Employee objects, creating the need for empty virtual Methods such as these to exist.
        public virtual void SetSalary(decimal salary)
        {
        }

        public virtual void SetHourlyPay(decimal hourlyPay)
        {
        }

        public virtual void SetOvertimePay(decimal overtimePay)
        {
        }

        public int CompareTo(Employee otherEmployee)
        {
            return _LastName.CompareTo(otherEmployee.LastName);

        }
    }
}
