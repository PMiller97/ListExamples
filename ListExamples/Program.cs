using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> favNumbers = new List<int>();
            //favNumbers.Add(7);
            //favNumbers.Add(25);
            //favNumbers.Add(30);

            //foreach(int number in favNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine(favNumbers.Count); //.Count is the same as .Length for Arrays



            ////Use the count property to get the length of the list
            //Console.WriteLine(favNumbers.Count);
            //List<string> books = new List<String> { "Cat in the hat", "Toad and frog", "Green Eggs and Ham" };
            //Console.WriteLine(books[0]);
            ////Inserts at the current index moving the previous element down one
            //books.Insert(0, "Horton hears a Who");
            //Console.WriteLine(books[0]);



            ////Create a List and add 5 animals using the .Add()
            ////Print each animal in the list
            //List<string> myAnimals = new List<string>();
            //myAnimals.Add("cat");
            //myAnimals.Add("dog");
            //myAnimals.Add("rabbit");
            //myAnimals.Add("mouse");
            //myAnimals.Add("horse");

            //foreach(string animals in myAnimals)
            //{
            //    Console.WriteLine(animals);
            //}
            ////OR you could have done a for loop
            //for(int i = 0; i<myAnimals.Count; i++)
            //{
            //    Console.WriteLine(myAnimals[i]);
            //}


            ////Create the following list:
            ////A bool list {true, false, false, true, false}
            ////Loop through each value
            ////if the value is true print "Better bring an umbrella!"
            ////if the value is false print "No rain today! Enjoy the sun."
            //List<bool> rainyDay = new List<bool> { true, false, false, true, false };
            //foreach (bool rain in rainyDay) 
            //{
            //    Console.WriteLine(rain);
            //    if (rain == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain today! Enjoy the sun.");
            //    }
            //}


            List<string> favFoods = new List<string> { "Steak", "Fish", "Pizza", "Ice Cream", "Nachos" };

            if (favFoods.Contains("Steak"))
                {
                Console.WriteLine("I like steak too!!!");
                }
          
           
                
           

            

            





        }
    }
}
