using System;

namespace HRApplication
{
    //A class representing hourly-paid employees. Contains a method that returns the employee's personal information as a string.
    public class HourlyEmployee : Employee
    {
        decimal _HourlyPay;
        decimal _OvertimePay;

        public HourlyEmployee()         //saved as: "H"|Last Name|First Name|Address|Post code|Phone Number|Year of birth|Month of birth|Day of birth|Hourly Pay|Overtime Pay
        {
        }
        
        public HourlyEmployee(string lastName, string firstName, string address, string postCode, string phoneNumber, DateTime dateOfBirth, decimal hourlyPay, decimal overtimePay) :
                              base(firstName, lastName, address, postCode, phoneNumber, dateOfBirth)
        {
            _HourlyPay = hourlyPay;
            _OvertimePay = overtimePay;
        }

        public HourlyEmployee(string externalFileName) : base(externalFileName)      //Used with the Load Method
        {
            string[] fileContent = externalFileName.Split('|');

            _HourlyPay = decimal.Parse(fileContent[9]);
            _OvertimePay = decimal.Parse(fileContent[10]);
        }

        public decimal HourlyPay
        {
            get
            {
                return _HourlyPay;
            }
            set
            {
                _HourlyPay = value;
            }
        }

        public decimal OvertimePay
        {
            get
            {
                return _OvertimePay;
            }
            set
            {
                _OvertimePay = value;
            }
        }

        //Creates the string that represents each HourlyEmployee object and is used to save it to the external .txt file.
        public override string SaveDataToFile
        {
            get
            {
                return "H|" +
                       base.SaveDataToFile + "|" +
                       _HourlyPay + "|" +
                       _OvertimePay;
            }
        }

        public override decimal GetHourlyPay()
        {
            return _HourlyPay;
        }

        public override decimal GetOvertimePay()
        {
            return _OvertimePay;
        }

        public override void SetHourlyPay(decimal hourlyPay)
        {
            _HourlyPay = hourlyPay;
        }

        public override void SetOvertimePay(decimal overtimePay)
        {
            _OvertimePay = overtimePay;
        }
    }
}
