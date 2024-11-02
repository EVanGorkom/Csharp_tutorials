using System;

namespace To_Do_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the 'To-Do List'");
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to add a task to the To-Do List.");
                Console.WriteLine("Enter 2 to remove a task from the To-Do List.");
                Console.WriteLine("Enter 3 to view the list.");
                Console.WriteLine("Enter 'e' to exit the program.");
                
                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Please enter the name of the task to add to the list.");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Task added to the list!\n");
                }

                else if (option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine((i + 1) + " : " + taskList[i]);
                    }
                    Console.WriteLine("Please enter the number of the task to remove from the list.");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskNumber -= 1;
                    
                    taskList.RemoveAt(taskNumber);
                    Console.WriteLine("Task removed successfully!\n");
                }
                
                else if (option == "3")
                {
                    if (taskList.Count == 0)
                    {
                        Console.WriteLine("No tasks in the To-Do List yet. Press option '1' to enter your first task.\n");
                    }
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine((i + 1) + " : " + (taskList[i]));
                    }
                    Console.WriteLine("");
                }

                else if (option == "e")
                {
                    Console.WriteLine("Exiting program.");
                }

                else
                {
                    Console.WriteLine("Invalid option, please try again.\n");
                }
            }
            Console.WriteLine("Thank you for using the To-Do List.");
        }
    }
}