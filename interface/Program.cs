using System;
using System.Collections.Generic;


namespace InterfaceEmployee
{
    class Program
    {
       static public List<employeeid> em = new List<employeeid>();
        static void Main(string[] args)
        {
            Console.WriteLine("Employee App");
            Console.WriteLine("Id, role, Name");
           em.Add(new employee("Sue", "Manager", 3));
            displayData();
            createEmployee();


            Console.ReadLine();

        }

        static public void createEmployee()
        {
            Console.WriteLine("Would you like to add a new employee Y or N");
            if (Console.ReadLine() == "Y")
            {
                Console.WriteLine("Add new employee, press enter Name");
                string name = Console.ReadLine();
                Console.WriteLine("Now enter Role");
                string role = Console.ReadLine();
                Console.WriteLine("Now enter Id");
                int ID = Convert.ToInt32(Console.ReadLine());
                em.Add(new employee(name, role, ID));
                Console.Clear();
                displayData();
            }
            else
            {
                Console.WriteLine("Would you like to close the App? Y or N");
                if (Console.ReadLine() == "Y")
                {
                   
                    Console.Clear();
                    Environment.Exit(0);
                }
                else
                {
                    createEmployee();

                }
            }
        }


        static public void displayData()
        {
            for (int i = 0; i < em.Count; i++)
            {
                Console.WriteLine(em[i].ID + " " + em[i].Role + " " + em[i].Name);
            }
            createEmployee();
        }

    }
}
