using System;
namespace StackAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue problem Statement");
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("1. Pushing the Node to Stack\n2. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                Stacks stacks = new Stacks();
                switch (choice)
                {
                    case 1:
                        stacks.Push(56);
                        stacks.Push(30);
                        stacks.Push(70);
                        stacks.Display();
                        break;
                    default:
                        condition = false;
                        break;
                }
            }
        }
    }
}