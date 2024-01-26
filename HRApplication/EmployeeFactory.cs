namespace HRApplication
{
    public static class EmployeeFactory
    {
        //A factory class that creates new Salaried or Hourly employee objects, given a string with their personal details. The latter always begins with a specific letter ("S" for salaried and "H" for hourly employees),
        //which determines the object type that is going to be created.
        public static Employee CreateEmployeeEntry(string externalFileData)
        {
            switch (externalFileData[0])
            {
                case 'S':
                    return new SalariedEmployee(externalFileData);
                case 'H':
                    return new HourlyEmployee(externalFileData);
                default:
                    return null;
            }
        }
    }
}