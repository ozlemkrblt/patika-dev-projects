class Program
{
    static void Main(string[] args)
    {


        Employee employeeOne = new Employee("Özlem", "Karabulut", 123456, "Mobile Development");
        employeeOne.GetEmployeeInfo();

        Console.WriteLine("************");

        Employee employeeTwo = new Employee("Güneş", "Solmaz");
        employeeTwo.GetEmployeeInfo();

    }

    class Employee
    {
        public string Name;
        public string LastName;
        public int No;
        public string Department;

        public Employee(string name, string lastName, int no, string department)
        {
            this.Name = name;
            this.LastName = lastName;
            this.No = no;
            this.Department = department;
        }


        public Employee(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
        }

        public void GetEmployeeInfo()
        {
            Console.WriteLine("Name of the employee: {0}", Name);
            Console.WriteLine("Last Name of the employee: {0}", LastName);
            Console.WriteLine("Id of the employee: {0}", No);
            Console.WriteLine("Department of the employee: {0}", Department);
        }
    }
}