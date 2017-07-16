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


            //List<string> favFoods = new List<string> { "Steak", "Fish", "Pizza", "Ice Cream", "Nachos" };

            //if (favFoods.Contains("Steak"))
            //    {
            //    Console.WriteLine("I like steak too!!!");
            //    }



            ////Create a list with the following numbers: 1 23 9 77 922 6 32 63 14 5
            ////use the contains method with the following values: 23 77 15
            ////Remove these elements: 23 77 32 and 6
            ////Use Contains() again on these values: 23 77 15
            //List<int> numbers = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            //Console.WriteLine(numbers.Contains(23)); //sequence contains 23 -TRUE
            //Console.WriteLine(numbers.Contains(77)); //conatins 77 - TRUE
            //Console.WriteLine(numbers.Contains(15)); //does NOT contain 15 - FALSE

            //numbers.Remove(23); //Removes 23 from sequence
            //numbers.Remove(77); //Removes 77
            //numbers.Remove(32); //Removes 32
            //numbers.Remove(6); //Removes 6

            //Console.WriteLine(numbers.Contains(23)); //23 was removed from the sequence so.. FALSE
            //Console.WriteLine(numbers.Contains(77)); //77 was removed - FALSE
            //Console.WriteLine(numbers.Contains(15)); //Never existed in the first place - FALSE




            //ask the user for a movie
            //if the movie is not in the list add it
            //inform the user that the movie has been added
            //if the user enters quit the program should exit
            //the user should be able to add as many movies as they would like
            //if the movie is in the list let the user know you have it

            List<string> moviesGet = new List<string> { "Batman", "Spiderman", "Superman", "Wonder Women", "Hulk", "Iron Man" };
            Console.WriteLine("What movie would you like to get?");
            string movie = Console.ReadLine();
            do
            {

                if (moviesGet.Contains(movie))
                {
                    Console.WriteLine("I'm sorry, we do not have that movie. But your selection will be added within 3-5 days!");
                    moviesGet.Add(movie);
                }
                else
                {
                    Console.WriteLine("Awesome! We have that movie for you!");
                }
            }
                while (movie == "Quit");
                Console.WriteLine("Thanks, come again!");
                return;
            
            
            













        }
    }
}
