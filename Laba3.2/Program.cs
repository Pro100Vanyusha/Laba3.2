using System;

namespace Laba3._2
{
    
        class User
        {
            protected string name;
            protected int age;
            public string setName
            {
                set { name = value; }
            }
            public string getName
            {
                get { return name; }
            }
            public int setAge
            {
                set { age = value; }
            }
            public int getAge
            {
                get { return age; }
            }
            public User(int age, string name)
            {
                this.age = age;
                this.name = name;
            }
        }
        class Worker : User
        {
            private int salary;
            public int getSalary
            {
                get { return salary; }
            }
            public int setSalary
            {
                set { salary = value; }
            }
            public Worker(int age, string name, int salary) : base(age, name)
            {
                this.salary = salary;
            }
        }
        class Student : User
        {
            private int scholarship;
            private int course;
            public int getStipend
            {
                get { return scholarship; }
            }
            public int getCourse
            {
                get { return course; }
            }
            public Student(int age, string name, int scholarship, int course) : base(age, name)
            {
                this.scholarship = scholarship;
                this.course = course;
            }
        }
        class Driver : Worker
        {
            private int drivingExperience;
            private string category;
            public int getCategory
            {
                get { return drivingExperience; }
            }
            public string getExperience
            {
                get { return category; }
            }
            public Driver(int age, string name, int salary, int drivingExperience, string category) : base(age, name, salary)
            {
                this.drivingExperience = drivingExperience;
                this.category = category;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                var maxi = new Worker(45, "Maxim", 15000);
                var Evgen = new Worker(29, "Evgeniy", 18500);
                Console.WriteLine("Name: " + maxi.getName + ", Age: " + maxi.getAge + ", Salary: " + maxi.getSalary);
                Console.WriteLine("Name: " + Evgen.getName + ", Age: " + Evgen.getAge + ", salary: " + Evgen.getSalary);
                Console.WriteLine("The amount of salaries - " + (maxi.getSalary + Evgen.getSalary));

                var den = new Student(21, "Denis", 1200, 4);
                Console.Write("Studant: " + den.getName + ", Age: " + den.getAge);
                Console.WriteLine(", Scholarship: " + den.getStipend + ", Сourse: " + den.getCourse);

                var ev = new Driver(34, "Oleg", 40000, 12, "A,B,C,C2,D");
                Console.Write("Name: " + ev.getName + ", Age: " + ev.getAge + ", salary: " + ev.getSalary);
                Console.WriteLine(", Driving experience: " + ev.getCategory + ", Driver category: " + ev.getExperience);
            }
        }
    
}
