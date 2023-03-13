using System;
using System.Collections.Generic;

namespace QueueTFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates the food queue
            Queue<string> food = new Queue<string>();

            //adding food
            food.Enqueue("Pizza");
            food.Enqueue("Taco");
            food.Enqueue("Spaghetti");
            food.Enqueue("Ice Cream");
            food.Enqueue("Steak");

            // counts the initial food in the queue
            Console.WriteLine($"There are {food.Count()} items in your food queue.");
            // displays the queue contents without removing anything
            Console.WriteLine("");

            Console.WriteLine("Would you like to search the queue for a specific food item?");
            string searchAnswer = Console.ReadLine();
            Console.WriteLine("");

            if (searchAnswer == "yes" ||  searchAnswer == "Yes")

            {
                Console.WriteLine("Please enter a food item name to see if it's in the queue:");
                string search = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine($"Is {search} in the food queue?");
                Console.WriteLine(food.Contains(search));
                Console.WriteLine("");

            }
          

            
            
            // views the first item in the queue and displays it to determine if the user wants to remove it
            string firstFood = food.Peek();
            Console.WriteLine($"Would you like to remove {firstFood} from the beginning of the queue (yes or no)?");
            string answer = Console.ReadLine();
            while (answer == "yes")
            {
                food.Dequeue(); // removes item from the top of the queue
                firstFood = food.Peek();
                Console.WriteLine($"Would you like to remove {firstFood} from the beginning of the queue (yes or no)?");
                answer = Console.ReadLine();
            }

            if (food.Peek() == null)
                Console.WriteLine("The queue is empty");
            else
                Console.WriteLine($"You have {food.Count} food items left in the queue");
            Console.WriteLine("");

            foreach (var m in food)
            {
                Console.WriteLine(m);
            }

        }
    }
}