using System;

namespace titan_of_industry
{
    public class SteelWorker : Worker
    {
        public SteelWorker(string nameInput) : base(nameInput) { }
        public void MakeSteel()
        {
            Console.WriteLine("A new bar of steel is produced.");
        }

    }

}