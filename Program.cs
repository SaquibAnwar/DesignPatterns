using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Singleton Pattern
            Console.WriteLine("Let's start with the Singleton pattern!");

            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance\n");
            }

            Console.WriteLine("Let's start with the ThreadSafeSingleton pattern!");

            ThreadSafeSingleton ts1 = ThreadSafeSingleton.Instance;
            ThreadSafeSingleton ts2 = ThreadSafeSingleton.Instance;
            // Test for same instance
            if (ts1 == ts2)
            {
                Console.WriteLine("Objects are the same instance\n");
            }
            #endregion

        
            #region Fluent Builder
            Student student = StudentBuilder.Init().SetName("Saquib")
                .SetCollege("SRM").Build();

            System.Console.WriteLine("Student Name : " + student.Name);
            System.Console.WriteLine("Student College : " + student.College);
            #endregion
        }
    }
}
