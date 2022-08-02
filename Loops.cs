using System;

namespace CSharp1Exercises.ControlFlow
{
    public class Loops
    {
        /// <summary>
        /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
        /// Display the result on the console.
        /// </summary>
        // MY SOLUTION
        public void mySolution1()
        {
           var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if( i % 3 == 0)
                {
                    count++;    
                }
            }
            Console.WriteLine(count);
        }
        // SOLUTION
        public void Exercise1()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i%3 == 0)
                    count++;
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);
        }

        /// <summary>
        /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
        /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
        /// </summary>
        // MY SOLUTION
        public void mySolution2()
        {
             var sum = 0;
            var exit = true;
            while(exit)
            {
               
             if (Console.ReadLine() != "OK")
                {
                    Console.WriteLine("Enter a number or OK to exit");
                    sum += Convert.ToInt32(Console.ReadLine()); 
                }
                else
                {
                    exit = false;
                    break;
                }
            }
            Console.WriteLine("Sum : " + sum);
        }
         // SOLUTION
        public void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);
        }

        /// <summary>
        /// Write a program which takes a single argument from the console, computes the factorial and prints the 
        /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        /// and display it as 5! = 120.
        /// </summary>
         // MY SOLUTION
        public void mySolution3()
        {
             var factorial = 1;
            Console.Write("Enter a number: ");
           
            var number = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
                Console.WriteLine(i);
            }
           
            
            Console.WriteLine("{0}!={1}",number, factorial);
        }
        // SOLUTION
        public void Exercise3()
        {
            Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        /// <summary>
        /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
        /// If the user guesses the number, display “You won". Otherwise, display “You lost".
        /// </summary>
        // MY SOLUTION
        public void Exercise4()
        {
            var count = 1;  
            while (true)
            {   
                count++;
                Random ran = new Random();
                var random = ran.Next(1, 10);
                Console.WriteLine(random);
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if(number == random)
                {
                    Console.WriteLine("You Win");
                    break;
                }
                if (count > 4)
                {
                    Console.WriteLine("You Lose");
                    break;
                }
            }
        }
        // SOLUTION
        public void Exercise4()
        {
            var number = new Random().Next(1, 10);

            Console.WriteLine("Secret is " + number);
            for (var i = 0; i < 4; i++)
            {
                Console.Write("Guess the secret number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }

            Console.WriteLine("You lost!");
        }

        /// <summary>
        /// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
        /// numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
        /// display 8 on the console.
        /// </summary>
        // MY SOLUTION
          public void mySolution5()
        {
           Console.Write("Enter a series of numbers separated by , : ");
            var input = Console.ReadLine();
            string[] numbers = input.Split(",");
            var max = numbers[0];
            for (int i = 0; i < numbers.Length - 1 ; i++)    
            {

                if (Int16.Parse(numbers[i + 1]) > Int16.Parse(numbers[i]))
                {
                   max = numbers[i + 1];
                }
               
            }
            Console.WriteLine(max);

        }
        // Solution
        public void Exercise5()
        {
            Console.Write("Enter commoa separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            // Assume the first number is the max 
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);

        }
      
    }
}
