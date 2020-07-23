using System;

namespace titan_of_industry
{
    public class Worker 
    {
        
        public Worker(string nameInput){
            FullName = nameInput;
        }
        public string FullName {get; set;}

        public DateTime DateHired {get; set;}

        public double PayRate {get; set;}

    }
}