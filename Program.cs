
using System;
class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.Work();
        emp.Eat();

        Robot rob = new Robot();
        rob.Work();
    }
        public interface IWork
        {
            public void Work ();
        }

        public interface IEat
        {
            public void Eat();
        }

        public class Employee : IWork, IEat
        {
            public void Work()
            {
                Console.Write("Employee pode trabalhar");
            }
            public void Eat()
            {
                Console.WriteLine("...e comer.");
            }
        }

        public class Robot : IWork
        {
            public void Work()
            {
                Console.WriteLine("Já Robot pode apenas trabalhar.");
            }        
        }
}

