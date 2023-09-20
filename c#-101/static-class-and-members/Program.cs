
namespace static_class_and_members
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Employee population is: {0}", Employee.EmployeeCount);

            Employee employeeOne = new Employee("Özlem", "Karabulut", "Mobile Development");
            Console.WriteLine("Employee population is: {0}", Employee.EmployeeCount);

            Employee employeeTwo = new Employee("Ezgi", "Kaya", "IT");
            Employee employeeThree = new Employee("Yılmaz", "Cemil", "HR");
            Console.WriteLine("Employee population is: {0}", Employee.EmployeeCount);


            Console.WriteLine("Sum of two numbers are : {0}", MathOperations.Sum(100, 200));
            Console.WriteLine("Extraction of two numbers are : {0}", MathOperations.Substract(200, 50));

        }


        class Employee
        {
            private static int employeeCount;

            public static int EmployeeCount { get => employeeCount; set => employeeCount = value; }

            private string Name;
            private string LastName;
            private string Department;


            static Employee()
            {
                EmployeeCount = 0;
            }

            public Employee(string name, string lastName, string department)
            {
                this.Name = name;
                this.LastName = lastName;
                this.Department = department;
                EmployeeCount++;
            }



        }


        static class MathOperations
        {
            public static long Sum(int num1, int num2)
            {
                return num1 + num2;
            }

            public static long Substract(int num1, int num2)
            {
                return num1 - num2;
            }
        }
    }
}