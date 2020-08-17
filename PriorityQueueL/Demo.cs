using System;

namespace PriorityQueue
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, x, elementPriority;

            PriorityQueueL pql = new PriorityQueueL();

            while(true)
            {
                Console.WriteLine("1.Insert Element");
                Console.WriteLine("2.Delete Element");
                Console.WriteLine("3.Front Element in Queue");
                Console.WriteLine("4.Display all elements fron Queue");
                Console.WriteLine("5.Quit");
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                    break;

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter the element to insert: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter its priority: ");
                        elementPriority = Convert.ToInt32(Console.ReadLine());
                        pql.Insert(x, elementPriority);
                        break;
                    case 2:
                        Console.WriteLine("Deleted Element is: " + pql.Delete());
                        break;
                    case 3:
                        Console.WriteLine("Front Element is: " + pql.Peek());
                        break;
                    case 4:
                        pql.Display();
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
                Console.WriteLine("");
            }
        }
    }
}
