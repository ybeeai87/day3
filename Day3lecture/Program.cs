using System;
using System.Text;

namespace Day3lecture
{
    class Program
    {
        static void Main(string[] args)
        {     
            string myName = "Yoshi!!!";
            EditName(ref myName);

            string result = ReturnHelloUser("Yousif", 33);
            Console.WriteLine(result);

            string result1 = ReturnHelloUser("Yoshi", 33);
            Console.WriteLine(result1);

            string result2 = ReturnHelloUser("Yo");
            Console.WriteLine(result2);

            string result3 = ReturnHelloUser();
            Console.WriteLine(result3);

            //pass by out section
            int x = 0;
            int y = 0;

            x = getByOutExample(out y);
            Console.WriteLine(x);
            Console.WriteLine(y);

            //callSection
            stringSection();


            Console.WriteLine(getRandomNumber());
            theRandomNumber();

        }



        //get random built in to C#
        public static int getRandomNumber()
        {
            Random random = new Random();
            int number = random.Next(10, 14) + 1;// +1 to not get 0
            return number;
        }
        //Create a method with a void return and no parameters
        //        get a random number from 1 - 100
        //use that random number in a for loop.
        //Start that loop at 1 and count until you hit that random number
        //display each number as you loop
        public static void theRandomNumber()
        {
            Random random2 = new Random();
            int num2 = random2.Next(100) + 1;

            for (int i = 1; i <= num2; i++)
            {
                Console.WriteLine(i);
            }
        }






        // everything relating to strings
        //using void because dont plan to return anything
        public static void stringSection()
        {
            string x = "abc";
            string y = "ABC";

            if (x == y)
            {
                Console.WriteLine($"{x} is equal to {y} using ==");
            }
            else
            {
                Console.WriteLine($"{x} is not equal to {y} using ==");
            }

            //string.compare takes 2 strings and returns true or false
            if (string.Compare(x, y) == 0)
            {
                Console.WriteLine($"{x} and {y} are comparable.");
            }
            else
            {
                Console.WriteLine($"{x} and {y} are not comparable.");
            }

            // equals method (doesnt work right now)

            if (x.Equals(y))
            {
                Console.WriteLine($"{x} is equal to {y} using equals method. ");
            }
            else
            {
                Console.WriteLine($"{x} does not equal {y} using equals method.");
            }
            //.IndexOf
            Console.WriteLine($"{x} The letter b is in spot {x.IndexOf("b")}");

            //.LastIndexOf
            string z = "abcabcabc";
            Console.WriteLine($"{z} The letter b last appears in spot {z.LastIndexOf("b")}");

            //.EndsWith (bool)
            Console.WriteLine($"{z} Does this end in a d? {z.EndsWith("c")}");

            //.Replace
            string newZ = z.Replace("a", "J");
            Console.WriteLine(newZ);

            //.Split
            string sentence = "Welcome to my class.";
            string[] words = sentence.Split(" "); //splits at space
            foreach (string w in words)
            {
                Console.WriteLine(w);
            }
            //.Substring cuts off previous from point chosen.
            Console.WriteLine($"{sentence.Substring(8)}");

            //.ToUpper .ToLower converts string to all uppercase/lowercase

            Console.WriteLine($"{sentence.ToUpper()}");
            Console.WriteLine($"{sentence.ToLower()}");

            //.Trim omits leading and trailing whitespaces
            string messyString = "                Hello there             ";
            Console.WriteLine($"|{messyString}|");
            Console.WriteLine($"|{messyString.Trim()}|");

            //.Append adds to the end

            //String Builder Example (hover over StringBuilder and click using System.txt

            StringBuilder sb = new StringBuilder("Test!");
            sb.Append("\t Super!"); //opposite slash over enter key \,
                                    // (\t shortcut for tab key, \n shortcut for new line)
            Console.WriteLine(sb);
           

        }

        //pass by out
        public static int getByOutExample(out int result2)
        {
            result2 = 2;
            return 1;
        }

        //pass by ref
        public static void EditName(ref string name)
        {
            name = "FEEEEEEF";
        }

        public static string ReturnHelloUser (string name)
        {
            string greeting = $"Hello, {name}";
            return greeting;
        }

        public static string ReturnHelloUser()
        {
            string greeting = "Hello, buddy.";
            return greeting;
        }

        public static string ReturnHelloUser(string name, int age)
        {
            string greeting = $"Hello {name}. You are {age} years old.";
            return greeting;
        }



    }
}
