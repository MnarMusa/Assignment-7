using static Assignment_7.Program;

namespace Assignment_7
{

    public class HireDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate(int day, int month, int year)
        {
            if (day < 1 || day > 31)
                throw new ArgumentException("Invalid day");
            if (month < 1 || month > 12)
                throw new ArgumentException("Invalid month");
            if (year < 1)
                throw new ArgumentException("Invalid year");

            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }


    public class Employee
    {
        public static readonly string GUEST = "Guest";
        public static readonly string DEVELOPER = "Developer";
        public static readonly string SECRETARY = "Secretary";
        public static readonly string DBA = "DBA";
        public static readonly string SECURITY_OFFICER = "SecurityOfficer";

        public int ID { get; set; }
        public string Name { get; set; }
        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value != "M" && value != "F")
                    throw new ArgumentException("Gender must be 'M' or 'F'");
                gender = value;
            }
        }
        private string securityLevel;
        public string SecurityLevel
        {
            get { return securityLevel; }
            set
            {
                if (value != GUEST && value != DEVELOPER && value != SECRETARY && value != DBA && value != SECURITY_OFFICER)
                    throw new ArgumentException("Invalid security level");
                securityLevel = value;
            }
        }
        public decimal Salary { get; set; }
        public HireDate HireDate { get; set; }

        public Employee(int id, string name, string gender, string securityLevel, decimal salary, HireDate hireDate)
        {
            ID = id;
            Name = name;
            Gender = gender;
            SecurityLevel = securityLevel; 
            Salary = salary;
            HireDate = hireDate;
        }

        private string FormatSalary(decimal salary)
        {
            return string.Format("${0:N2}", salary);
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Security Level: {SecurityLevel}, Salary: {FormatSalary(Salary)}, Hire Date: {HireDate}";
        }
    }
    internal class Program
    {


       



        static void Main(string[] args)
        {


            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "John Doe", "M", Employee.DBA, 75000m, new HireDate(1, 1, 2020));
            EmpArr[1] = new Employee(2, "Jane Smith", "F", Employee.GUEST, 40000m, new HireDate(15, 5, 2021));
            EmpArr[2] = new Employee(3, "Alice Johnson", "F", Employee.SECURITY_OFFICER, 90000m, new HireDate(10, 8, 2019));

            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine(EmpArr[i]);
            }


        }
    }

}