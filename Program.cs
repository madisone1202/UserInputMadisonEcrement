using System;

namespace UserInputMadisonEcrement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pause to display my name
            Console.WriteLine("Hi, This is Madison Ecrement! Let me know how you are doing, type your answer below and hit enter:");
            string name = Console.ReadLine();
            Console.WriteLine("You typed: " + name);
            Console.ReadKey();
        }
    }
}
