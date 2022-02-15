using System;
using System.Text;

namespace HomeWork // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {          
            //Task 1
            Console.WriteLine("\n Task1");
            Console.Write("\nEnter a number between 1 and 100 : ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0 || number > 100)
            {
                Console.WriteLine("Error : number out of required range!!!");
            }
            else if ((number % 3 == 0) && (number % 5 == 0))
            {
                Console.WriteLine("Fizz and Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("Number = " + number);
            }


            //Task2
            //Ask user to input value
            Console.WriteLine("\n Task2");
            Console.Write("\nEnter value : ");
            int value = Convert.ToInt32(Console.ReadLine());

            //Ask user to input percentage
            Console.Write("Enter percentage : ");
            int percentage = Convert.ToInt32(Console.ReadLine());

            //output the percentage of value
            Console.WriteLine(percentage + " percentage of " + value + " = " + ((double) value * percentage / 100));
            
            
            //Task3
            Console.WriteLine("\n Task3");

            //ask user to enter four numbers
            Console.Write("\nEnter first number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            //creating string containing these digits
            String resultNumber = Convert.ToString(number1);

            Console.Write("Enter secomd number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            resultNumber = resultNumber + Convert.ToString(number1);

            Console.Write("Enter third number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            resultNumber = resultNumber + Convert.ToString(number1);

            Console.Write("Enter fourth number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            resultNumber = resultNumber + Convert.ToString(number1);

            //output the created number
            Console.WriteLine("Number created = " + resultNumber);
           


            //Task 4
            Console.WriteLine("\n Task4\n");

            //ask user to enter a six-digit number
            Console.WriteLine("Enter a six-digit number : ");
            int sixDigitNum = Convert.ToInt32(Console.ReadLine());

            if(sixDigitNum < 100000 || sixDigitNum > 999999)
            {
                Console.WriteLine("Error : you entered a wrong number!!!");
            }
            else
            {
                //ask usert to input digits for swaping
                Console.WriteLine("Enter first digit for swaping : ");
                int firstDigit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second digit for swaping : ");
                int secondDigit = Convert.ToInt32(Console.ReadLine());
                
                if (firstDigit < 1 || firstDigit > 6 || secondDigit < 1 || secondDigit > 6)
                {
                    Console.WriteLine("Index out of bounds exception! ");
                }
                else
                {
                    //converting int to string
                    String sixDigitStr = Convert.ToString(sixDigitNum);

                    //creating a StringBuilder object
                    StringBuilder sb = new StringBuilder(sixDigitStr);
                
                    //swaping digits
                    char aux = sixDigitStr[firstDigit-1];
                    sb[firstDigit-1] = sixDigitStr[secondDigit-1];
                    sb[secondDigit-1] = aux;

                    //getting value of new number from StringBuilder object to sixDigitNum and output the value
                    sixDigitNum = Convert.ToInt32( sb.ToString() );
                    Console.WriteLine("number  = " + sixDigitNum);
                }
            }

             

            //Task5
            Console.WriteLine("\n Task5\n");

            //ask user to input a date 
            Console.Write("Input date (e.g. 13/12/2022): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            //output season
            switch((int)date.Month)
            {
                case 12:
                case 1:
                case 2: 
                    Console.Write("Winter "); break;
                case 3:
                case 4:
                case 5:
                    Console.Write("Spring "); break;
                case 6:
                case 7:
                case 8:
                    Console.Write("Summer "); break;
                case 9:
                case 10:
                case 11:
                    Console.Write("Autumn "); break;
            }

            //output the day of week
            Console.Write(date.DayOfWeek);
            
            

            //Task6
            //ask user to input temperature grades
            Console.WriteLine("\n\n Task6\n");
            Console.WriteLine("Input temperature grades : ");
            double grades = double.Parse(Console.ReadLine());

            //ask user to choose option of convertiong
            Console.WriteLine("1 - convert to Fahrenheit / 2 - convert to celsius");
            char option = Convert.ToChar(Console.ReadKey(true).KeyChar);

            //convert and output temperature according to user's choice
            switch (option)
            {
                case '1':
                    Console.WriteLine(grades + " Celsius = " + (grades * 1.8 + 32) + " Fahrenheit"); break;
                case '2':
                    Console.WriteLine(grades + " Fahrenheit = " + ((grades -32) /1.8) + " Celsius"); break;
                default:
                    Console.WriteLine("Wrong option"); break;
            }

            

            //Task7
            //ask user to input the range 
            Console.WriteLine("\n Task7\n");
            Console.WriteLine("Insert start of range : ");
            int rangeStart = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert end of range : ");
            int rangeEnd = int.Parse(Console.ReadLine());

            //normalising the boundaries if  are set incorectly
            if(rangeStart > rangeEnd)
            {
                (rangeStart, rangeEnd) = (rangeEnd, rangeStart);
            }

            //show numbers in the specified range
            Console.WriteLine("Numbers in range : ");
            for(int i = rangeStart; i <= rangeEnd; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}