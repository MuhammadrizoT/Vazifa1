namespace Vazifa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public void CalculatePerimeter()
        {
            Console.WriteLine((Width + Height) * 2);
        }

        public void CalculateArea()
        {
            Console.WriteLine(Width * Height);
        }
        public void CalculateDiagonal()
        {
            Console.WriteLine(Math.Sqrt((Math.Pow(Width,2) + Math.Pow(Height, 2))));
        }
    }

    class Circle
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 0;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public void CalculatePerimeter()
        {
            Console.WriteLine( 2 * Math.PI * Radius);
        }
        public void CalculateArea()
        {
            Console.WriteLine( Math.PI * Math.Pow(Radius, 2));
        }
    }

    class Person
    { 
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public Person()
        {
            Id = 0;
            FullName = "";
            PhoneNumber = "";
        }

        public Person(int id, string fullname, string phoneNumber)
        {
            Id = id;
            FullName = fullname;
            PhoneNumber = phoneNumber;
        }
    }

    class Student : Person
    {
        public double AverageGrade { get; set; }
        public int[] MarksArray { get; set; }

        public Student()
        {
            Id = 0;
            FullName = string.Empty;
            PhoneNumber = string.Empty;
            AverageGrade = 0;
        }

        public Student(int id, string fullname, string phoneNumber, double averageGrade, int[] marksArray)
            : base(id, fullname, phoneNumber)
        {
            AverageGrade = averageGrade;
            MarksArray = marksArray;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}\nFullname: {FullName}\nPhoneNumber: {PhoneNumber}\nAverageGrade: {AverageGrade}");
            Console.WriteLine();
            for(int i = 0; i < MarksArray.Length; i++)
            {
                Console.Write($"{i}. {MarksArray[i]}  ");
            }
            Console.WriteLine();
        }
    }

    class Employee : Person
    {
        public decimal Salary { get; set; }

        public Employee()
        {
            Id = 0;
            FullName = string.Empty;
            PhoneNumber = string.Empty;
        }

        public Employee(int id, string fullname, string phoneNumber, decimal salary)
            : base(id, fullname, phoneNumber)
        {
            Salary = salary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}\nFullname: {FullName}\nPhoneNumber: {PhoneNumber}\nSalary: {Salary}");
        }

        public void CalculateTax()
        {
            decimal tax = Salary / 100 * 13;
            Console.WriteLine($"Tax: {tax}");
        }
    }

    class Teacher : Person
    {
        public decimal HourlyRate { get; set; }

        public Teacher()
        {
            Id = 0;
            FullName = string.Empty;
            PhoneNumber = string.Empty;
        }

        public Teacher(int id, string fullname, string phoneNumber, decimal hourlyRate)
            : base(id, fullname, phoneNumber)
        {
            HourlyRate = hourlyRate; ;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}\nFullname: {FullName}\nPhoneNumber: {PhoneNumber}\nHourly rate: {HourlyRate}");
        }

        public void CalculateMontlyIncome(int hours)
        {
            Console.WriteLine($"The teacher monthly income: {HourlyRate * hours}");
        }
    }
}