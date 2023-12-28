namespace Assignment5
{
    interface GovtRules
    {
        public double EmployeePF(double basicSalary);
        public string LeaveDetails();
        public double gratuityAmount(float serviceCompleted, double basicSalary);

    }
    class TCS : GovtRules
    {
        int empid;
        string name;
        string dept;
        string desg;
        double bs;

        public TCS(int empid,string name,string dept,string desg,double bs)
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

        double GovtRules.EmployeePF(double basicSalary)
        {
            throw new NotImplementedException();
        }

        double GovtRules.gratuityAmount(float serviceCompleted, double basicSalary)
        {
            throw new NotImplementedException();
        }

        string GovtRules.LeaveDetails()
        {
            throw new NotImplementedException();
        }
    }
    class Accenture : GovtRules
    {
        int empid;
        string name;
        string dept;
        string desg;
        double bs;

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

        double GovtRules.EmployeePF(double basicSalary)
        {
            throw new NotImplementedException();
        }

        double GovtRules.gratuityAmount(float serviceCompleted, double basicSalary)
        {
            throw new NotImplementedException();
        }

        string GovtRules.LeaveDetails()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {      
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
