using System;
using System.Collections.Generic;
using System.IO;

namespace HRApplication
{
    //A Class that also behaves as a list. Contains methods for saving and loading the list from a permanent file.
    public class Employees : List<Employee>
    {
        public Employees()
        {
        }

        //Opens a data stream and creates Salaried or Hourly employee objects using data from an external .txt file. The objects are created by the EmployeeFactory class according to the first letter of each employee's
        //entry ("H" for hourly and "S" for salaried employees).
        public bool Load(string externalFileName)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(externalFileName);
                string readFromFile = streamReader.ReadLine();

                while (readFromFile != null)
                {
                    Add(EmployeeFactory.CreateEmployeeEntry(readFromFile));
                    readFromFile = streamReader.ReadLine();
                }
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Close();
            }
        }

        //Opens a data stream and saves each employee object's details in an external .txt file. The objects are saved in such a way as to allow for automatically re-creating them by running the Load Method above [the first letter
        //of each employee's entry denotes the object type ("H" for hourly and "S" for salaried employees)].
        public bool Save(string externalFileName)
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(externalFileName, false);

                foreach (Employee employee in this)
                    streamWriter.WriteLine(employee.SaveDataToFile);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (streamWriter != null)
                    streamWriter.Close();
            }
        }
    }
}
