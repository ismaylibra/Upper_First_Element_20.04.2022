using System;

namespace Homework_task_20._04._2022_upperFirstElemet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cumle daxil edin: ");
            string sentence = Console.ReadLine(); 
            string[] words = sentence.Split(" ");
            Console.WriteLine("Berpa olunmus cumle: ");
            foreach (var word in words)
            { 
                Console.Write(word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower());
            }
            
           
          

            
     
        }
    }
}
