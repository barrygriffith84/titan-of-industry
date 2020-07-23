using System;

namespace titan_of_industry
{
    public class AutoWorker : Worker
    {
        public AutoWorker(string nameInput): base(nameInput){}  
        
        public void MakeCar(){
            Console.WriteLine("A new car rolls off the line.");
        }
    }

}