using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMST4_TASK1_IPS.ISP
{
    public interface IWork //por convenção, as interfaces são escritas assim para se diferenciarem das classes
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
            Console.WriteLine("Essa ação pode ser realizada");
        }
         public void Eat()
        {
            Console.WriteLine("Essa ação pode ser realizada");
        }
    }

    public class Robot : IWork
    {
        public void Work()
        {
            Console.WriteLine("Essa ação pode ser realizada");
        }        
    }
}