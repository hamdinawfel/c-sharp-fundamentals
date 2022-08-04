using System;
using System.Collections.Generic;

namespace CSharp1Exercises
{
    public class Strings
    {
        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>
        // MY SOLUTION
        public void mySolution1()
        {
            Console.Write("Enter a list numbers separated by a hyphen: ");
            var input = Console.ReadLine().Split("-");
            var i = 0;  
            while (true)
            {
                if ((Convert.ToInt32(input[i + 1]) - Convert.ToInt32(input[i])) > 1)
                {
                    Console.WriteLine("Not Consictive");
                    break;
                }
                i++;
                if (i == input.Length - 1)
                {
                    Console.WriteLine("Consictive");
                    break;
                }
            }
        }
        // SOLUTION
        public void Exercise1()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));                

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }

        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
        /// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
        /// any duplicates. If so, display "Duplicate" on the console.
        /// </summary>
        // MY SOLUTION
        public void mySolution2()
        {
             while (true)
            {
                Console.Write("Enter a list numbers separated by a hyphen: ");
                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    break;
                }
               var numbers = input.Replace("-","");
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers.IndexOf(numbers[i]) != numbers.LastIndexOf(numbers[i]))
                    {
                        Console.WriteLine("Diplacted");
                        break;
                    }
                }
            }
        }
        // SOLUTION
        public void Exercise2()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            var uniques = new List<int>();
            var includesDuplicates = false;
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }

            if (includesDuplicates)
                Console.WriteLine("Duplicate");
        }

        /// <summary>
        /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        /// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
        /// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
        /// </summary>
        // My SOLUTION
        public void mySolution3()
        {
            static void Main()
        {
            Console.Write("Enter a time value in the 24-hour time format (e.g. 19:00): ");
            var input = Console.ReadLine();
            if(String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid Time");
                
            }
            var valid = ValidateTime(input);
            if (valid)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }

        }
        
        public static bool ValidateTime(string time)
        {
            var valide = false;
            var minutes = Convert.ToInt32(time.Split(':')[0]);  
            var seconds = Convert.ToInt32(time.Split(':')[1]);

            if (minutes <= 24 && seconds <= 59)
            {
                valide = true;
            }

                return valide;
        }
        }
        // SOLUTION 3
        public void Exercise3()
        {
            Console.Write("Enter time: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            
            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }

        /// <summary>
        /// Write a program and ask the user to enter a few words separated by a space. Use the words to 
        /// create a variable name with PascalCase convention. For example, if the user types: 
        /// "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
        /// the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
        /// "NumberOfStudents". If the user doesn't supply any words, display "Error".
        /// </summary>
        public void Exercise4()
        {
            Console.Write("Enter a few words: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);
        }


        /// <summary>
        /// Write a program and ask the user to enter an English word. Count the number of vowels 
        /// (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 
        /// 6 on the console. Make sure the program calculates the number of vowels irrespective of the 
        /// casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).
        /// </summary>
        public void Exercise5()
        {
            Console.Write("Enter a word: ");
            // Note the ToLower() here. This is used to count for both A and a. 
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] {'a', 'e', 'o', 'u', 'i'});
            var vowelsCount = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            Console.WriteLine(vowelsCount);
        }
    }
}
