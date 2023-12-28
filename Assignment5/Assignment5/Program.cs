namespace Assignment5
{
   internal class Program
{
    interface GovtRules
    {
        double EmployeePF(double basicSalary);
        string LeaveDetails();
        double gratuityAmount(float serviceCompleted, double basicSalary);

    }
    public class TCS : GovtRules
    {
        public int empid;
        public string name;
        public string dept;
        public string desg;
        public double bs;

        public TCS(int empid, string name, string dept, string desg, double bs)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.bs = bs;
        }

        public int Id
        { get { return empid; } }
        public string Name
        { get { return name; } }
        public string Dept
        { get { return dept; } }
        public string Desg
        { get { return desg; } }
        public double Bs
        { get { return bs; } }

        public double EmployeePF(double basicSalary)
        {
            return 0.12 * bs;
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted > 20)
                return 3 * basicSalary;
            else if (serviceCompleted > 10)
                return 2 * basicSalary;
            else if (serviceCompleted > 5)
                return basicSalary;
            else
                return 0;
        }

        public string LeaveDetails()
        {
            return "Casual Leave: 1 day/month\nSick Leave: 12 days/year\nPrivilege Leave: 10 days/year";
        }
    }
    public class Accenture : GovtRules
    {
        public int empid;
        public string name;
        public string dept;
        public string desg;
        public double bs;

        public Accenture(int empid, string name, string dept, string desg, double bs)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.bs = bs;
        }

        public int Id
        { get { return empid; } }
        public string Name
        { get { return name; } }
        public string Dept
        { get { return dept; } }
        public string Desg
        { get { return desg; } }
        public double Bs
        { get { return bs; } }

        public double EmployeePF(double basicSalary)
        {
            return 0.12 * basicSalary;
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0;
        }

        public string LeaveDetails()
        {
            return "Casual Leave: 2 days/month\nSick Leave: 5 days/year\nPrivilege Leave: 5 days/year";
        }
    }
}
internal class Test_Program
{
    static void Main(string[] args)
    {
        Program.TCS tcsEmployee = new Program.TCS(1, "John", "IT", "Developer", 50000);
        Program.Accenture accentureEmployee = new Program.Accenture(2, "Alice", "HR", "Manager", 60000);

        Console.WriteLine("TCS Employee Details:");
        Console.WriteLine($"Employee ID: {tcsEmployee.empid}");
        Console.WriteLine($"Name: {tcsEmployee.Name}");
        Console.WriteLine($"Department: {tcsEmployee.Dept}");
        Console.WriteLine($"Designation: {tcsEmployee.Desg}");
        Console.WriteLine($"Basic Salary: {tcsEmployee.bs:C}");
        Console.WriteLine($"PF Contribution: {tcsEmployee.EmployeePF(tcsEmployee.bs):C}");
        Console.WriteLine($"Leave Details: {tcsEmployee.LeaveDetails()}");
        Console.WriteLine($"Gratuity Amount: {tcsEmployee.gratuityAmount(10, tcsEmployee.bs):C}");

        Console.WriteLine("\nAccenture Employee Details:");
        Console.WriteLine($"Employee ID: {accentureEmployee.empid}");
        Console.WriteLine($"Name: {accentureEmployee.Name}");
        Console.WriteLine($"Department: {accentureEmployee.Dept}");
        Console.WriteLine($"Designation: {accentureEmployee.Desg}");
        Console.WriteLine($"Basic Salary: {accentureEmployee.bs:C}");
        Console.WriteLine($"PF Contribution: {accentureEmployee.EmployeePF(accentureEmployee.bs):C}");
        Console.WriteLine($"Leave Details: {accentureEmployee.LeaveDetails()}");
        Console.WriteLine($"Gratuity Amount: {accentureEmployee.gratuityAmount(8, accentureEmployee.bs):C}");
    }
}
}
