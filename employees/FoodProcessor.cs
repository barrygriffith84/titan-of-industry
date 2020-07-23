using System;

namespace titan_of_industry
{
    public class FoodProcessor : Worker 
    {

         public FoodProcessor(string nameInput): base(nameInput){} 
         public void MakeChicken(){
            Console.WriteLine("Some fresh nugs are packaged and ready to ship.");
        }
    }

}