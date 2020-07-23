using System;

namespace titan_of_industry
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoWorker swathi = new AutoWorker("Swathi Mukkamala"){
                DateHired = new DateTime(2020,04,01),
                PayRate = 20.15
            };

            FoodProcessor devin = new FoodProcessor("Devin Conroy"){
                DateHired = new DateTime(2020,05,25),
                PayRate = 19.45
            };

            SteelWorker dylan = new SteelWorker("Dylan Bishop"){
                DateHired = new DateTime(2020,04,05),
                PayRate = 20.15
            };

            AutomobileFactory griffithAutos = new AutomobileFactory{
                MinEmployeeCount = 3,
                MaxEmployeeCount = 9,
            };

            NuggetFactory griffithFoods = new NuggetFactory{
                MinEmployeeCount = 1,
                MaxEmployeeCount = 7,
            };

            SteelFactory griffithSteel = new SteelFactory{
                MinEmployeeCount = 2,
                MaxEmployeeCount = 8,
            };

            griffithAutos.HireEmployee(swathi);
            griffithFoods.HireEmployee(devin);
            griffithSteel.HireEmployee(dylan);



            Console.WriteLine();
        }
    }
}
