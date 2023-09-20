class Program
{
    static void Main(string[] args)
    {


        Student studentOne = new Student("Özlem", "Karabulut", 123456, 1);
        studentOne.GetStudentInfo();

        Student studentTwo = new Student("Güneş", "Solmaz",2);
        studentTwo.GetStudentInfo();

        Student studentThree = new Student();
        studentThree.Name="Can";
        studentThree.LastName = "Yılmaz";
        studentThree.No = 125321;
        studentThree.Classroom = 3;
        
        studentThree.GetStudentInfo();

        Console.WriteLine();
        studentThree.lowerClassroom();
        Console.WriteLine(studentThree.Name +" " + studentThree.LastName + "'s new classroom is: " + studentThree.Classroom);

        studentThree.upperClassroom();

        Console.WriteLine();
        studentOne.lowerClassroom();
        studentOne.GetStudentInfo();

    }

    class Student
    {
        private string name;
        private string lastName;
        private int no;
        private int classroom;

        public string Name { 
            get { return name; }
            set { name = value; } 
        }
        public string LastName { get => lastName; set => lastName = value; }
        public int No { get => no; set => no = value; }
        public int Classroom
        {
            get => classroom;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Classroom can be at least 1! ");
                    this.classroom = 1;
                }
                else
                {
                    classroom = value;
                }
            }
        }


        public Student(string name, string lastName, int no, int classroom)
        {
            this.Name = name;
            this.LastName = lastName;
            this.No = no;
            this.Classroom = classroom;
        }


        public Student(string name, string lastName,int classroom)
        {
            this.Name = name;
            this.LastName = lastName;
        }

        public Student()
        {
        }

        public void GetStudentInfo()
        {
            Console.WriteLine("--------------Student Info:-------------");
            Console.WriteLine("Name of the student: {0}", Name);
            Console.WriteLine("Last Name of the student: {0}", LastName);
            Console.WriteLine("Id of the student: {0}", No);
            Console.WriteLine("Classroom of the student: {0}", Classroom);
        }

        public void lowerClassroom()
        {
            this.Classroom =this.Classroom-1;
        }

        public void upperClassroom() {
            this.Classroom = this.Classroom + 1;

            Console.WriteLine("Classroom level of " + this.name +" " + this.lastName +" is succesfully uppered. Current classroom is: " + this.Classroom);
        }
    }
}