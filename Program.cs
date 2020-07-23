using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace titan_of_industry
{
    class Program
    {



        static void Main(string[] args)
        {
            AutoWorker swathi = new AutoWorker("Swathi Mukkamala")
            {
                DateHired = new DateTime(2020, 04, 01),
                PayRate = 20.15
            };

            FoodProcessor devin = new FoodProcessor("Devin Conroy")
            {
                DateHired = new DateTime(2020, 05, 25),
                PayRate = 19.45
            };

            SteelWorker dylan = new SteelWorker("Dylan Bishop")
            {
                DateHired = new DateTime(2020, 04, 05),
                PayRate = 20.15
            };

            AutomobileFactory griffithAutos = new AutomobileFactory
            {
                MinEmployeeCount = 3,
                MaxEmployeeCount = 9,
            };

            NuggetFactory griffithFoods = new NuggetFactory
            {
                MinEmployeeCount = 1,
                MaxEmployeeCount = 7,
            };

            SteelFactory griffithSteel = new SteelFactory
            {
                MinEmployeeCount = 2,
                MaxEmployeeCount = 8,
            };

            griffithAutos.HireEmployee(swathi);
            griffithFoods.HireEmployee(devin);
            griffithSteel.HireEmployee(dylan);



            int endNum = 1;

            while (endNum == 1)
            {

                int userInput = 0;
                int factorySelect = 0;
                double pay = 0;
                bool parseBool = false;
                Console.WriteLine("Welcome to Griffith Industries! \n 1. View employees at a factory \n 2. Hire a new employee");


                while (userInput != 1 && userInput != 2)
                {
                    Console.WriteLine("\nPlease select 1 or 2");
                    try
                    {
                        userInput = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("That is not a valid input.");
                    }
                }

                if (userInput == 1 || userInput == 2)
                {
                    while (factorySelect < 1 || factorySelect > 3)
                    {
                        Console.WriteLine("\n1. Griffith Autos \n2. Griffith Foods \n3. Griffith Steel");
                        try
                        {
                            factorySelect = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("That is not a valid input.");
                        }
                    }
                }

                if (userInput == 1 && factorySelect == 1)
                {
                    griffithAutos.Employees.ForEach(employee => Console.WriteLine(employee.FullName));
                }
                else if (factorySelect == 2)
                {
                    griffithFoods.Employees.ForEach(employee => Console.WriteLine(employee.FullName));
                }
                else if (factorySelect == 3)
                {
                    griffithSteel.Employees.ForEach(employee => Console.WriteLine(employee.FullName));
                }

                if (userInput == 2 && factorySelect == 1)
                {

                    Console.WriteLine("\nPlease enter the employee's full name");
                    string name = Console.ReadLine();

                    while (parseBool == false)
                        try
                        {
                            Console.WriteLine("\nPlease enter the employee's pay rate");
                            pay = double.Parse(Console.ReadLine());
                            parseBool = true;
                        }
                        catch
                        {
                            Console.WriteLine("That was the incorrect input");
                            parseBool = false;
                        }

                    AutoWorker newWorker = new AutoWorker(name)
                    {
                        PayRate = pay,
                        DateHired = DateTime.Now
                    };

                    griffithAutos.Employees.Add(newWorker);

                }
                else if (userInput == 2 && factorySelect == 2)
                {
                    Console.WriteLine("\nPlease enter the employee's full name");
                    string name = Console.ReadLine();


                    while (parseBool == false)
                        try
                        {
                            Console.WriteLine("\nPlease enter the employee's pay rate");
                            pay = double.Parse(Console.ReadLine());
                            parseBool = true;
                        }
                        catch
                        {
                            Console.WriteLine("That was the incorrect input");
                            parseBool = false;
                        }

                    FoodProcessor newWorker = new FoodProcessor(name)
                    {
                        PayRate = pay,
                        DateHired = DateTime.Now
                    };

                    griffithFoods.Employees.Add(newWorker);
                }
                else if (userInput == 2 && factorySelect == 3)
                {
                    Console.WriteLine("\nPlease enter the employee's full name");
                    string name = Console.ReadLine();


                    Console.WriteLine("\nPlease enter the employee's pay rate");
                    while (parseBool == false)
                        try
                        {
                            Console.WriteLine("\nPlease enter the employee's pay rate");
                            pay = double.Parse(Console.ReadLine());
                            parseBool = true;
                        }
                        catch
                        {
                            Console.WriteLine("That was the incorrect input");
                            parseBool = false;
                        }

                    SteelWorker newWorker = new SteelWorker(name)
                    {
                        PayRate = pay,
                        DateHired = DateTime.Now
                    };

                    griffithSteel.Employees.Add(newWorker);

                }

                Console.WriteLine("Would you like to continue?  Input 1 for 'yes' and 2 for 'No'");

                bool againBool = true;
                while (againBool == true)
                    try
                    {
                        endNum = int.Parse(Console.ReadLine());
                        againBool = false;
                    }
                    catch
                    {
                        Console.WriteLine("That was the incorrect input");
                        againBool = true;
                    }
            }


            Console.WriteLine();
        }
    }
}
