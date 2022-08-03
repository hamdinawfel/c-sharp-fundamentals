using System;
using System.Collections.Generic;

namespace CSharp1Exercises.ArraysAndLists
{
    public class Lists
    {
        /// <summary>
        /// Write a program and continuously ask the user to enter different names, until the user presses Enter 
        /// (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
        /// </summary>
        // MY SOLUTION
        public void mySolution1()
        {
             List<string> friendlist = new List<string>();
           
            while (true)
            {
                Console.Write("Enter a name (or click Enter to exit): ");
                var input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                else
                {
                    friendlist.Add(input);
                }
            }  
           Console.WriteLine(friendlist.Count);
            if(friendlist.Count == 1)
            {
              Console.WriteLine("{0} like your post", friendlist[0]);
            } 
            else if(friendlist.Count == 2)
            {
                Console.WriteLine("{0}, {1} likes your post", friendlist[0], friendlist[1]);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2} likes your post", friendlist[0], friendlist[1], friendlist.Count - 2);
            }
        }
        // SOLUTION
        public void Exercise1()
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Type a name (or hit ENTER to quit): ");

                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }

            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();
        }

        /// <summary>
        /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
        /// Display the reversed name on the console.
        /// </summary>
        // MY SOLUTION
        public void mySolution2()
        {
            
            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();
            var nameList = new List<char>();
            foreach(var charater in name)
            {
                nameList.Add(charater);
            }
             nameList.Reverse();
            foreach(var charater in nameList)
            {
                Console.Write(charater);
            }
        }
        // SOLUTION
        public void Exercise2()
        {
            Console.Write("What's your name? ");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);
        }

        /// <summary>
        /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
        /// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
        /// and display the result on the console.
        /// </summary>
        // MY SOLUTION
        public void mySolution3()
        {
            var numbersList = new List<int>();
            Console.Write("Enter 5 unique numbers: ");
            var input = Console.ReadLine();
            var repeat = true;
            while (repeat)
            {
                foreach (var character in input)
                {
                    if (numbersList.IndexOf(Int32.Parse(character.ToString())) == -1)
                    {
                        numbersList.Add(Int32.Parse(character.ToString()));
                    }
                    else
                    {
                        Console.WriteLine("Error");
                        repeat = false;
                        
                    }
                }
            }

            numbersList.Sort();
            foreach (var number in numbersList)
            {
                Console.Write(number);
            }
        }
        // Solution
        public void Exercise3()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }

                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var number in numbers)
                Console.WriteLine(number);
        }

        /// <summary>
        /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
        /// include duplicates. Display the unique numbers that the user has entered.
        /// </summary>
        // MY SOLUTION
        public void mySolution4()
        {
            var numbers = new List<string>();
           
            while (true)
            {
                Console.Write("Enter a number 'Quit' to exit: ");
                var input = Console.ReadLine();
                

                if (input == "Quit")
                {
                    break;
                }
                numbers.Add(input);
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers.LastIndexOf(numbers[i]) == i)
                    {
                        Console.Write(numbers[i]);
                    }
                }
            }
        }
        // SOLUTION
        public void Exercise4()
        {
            var numbers = new List<int>();
            
            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in uniques)
                Console.WriteLine(number);
        }

       
        /// <summary>
        /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
        /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
        /// the 3 smallest numbers in the list.
        /// 
        /// </summary>
        // My Solution
        public void mySolution5()
        {
           var numbers = new List<int>();
           
            while (true)
            {
                Console.Write("Enter a list of more than 5 numbers separated by , : ");
                var input = Console.ReadLine().Split(",") ;
                foreach (var number in input)
                {
                    numbers.Add(Int32.Parse(number.ToString()));
                }

                if (numbers.Count < 5 || numbers.Count == 0)
                {
                    Console.WriteLine("In valid list, try again!");
                    continue;
                }
                else
                {
                    numbers.Sort();
                    Console.WriteLine("The three smallest items are : {0}, {1}, {2}", numbers[0], numbers[1], numbers[2]);
                    numbers.Clear();
                }
               
            }
        }
        // SOLUTION
        public void Exercise5()
        {
            string[] elements;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }
    }
}
