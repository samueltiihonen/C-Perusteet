using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_tutorial_freecodecamp_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42,};
            string[] friends new string[5];
            friends[0] = "Jim";
            friends[1] = "Kelly";
            
            luckyNumbers[1] = 900;


            // Methods

            {
                SayHi("Mike", 33);
                SayHi("John", 56);
                SayHi("Tom", 12);

                Console.ReadLine();
            }
            
            
            static void SayHi(string name, int age) 
            {
                Console.WriteLine("Hello + name + " you are " + age);
            }

            // Return Statement

            {
                cube(5);

                int cubedNumber = cube(5);
                Console.WriteLine(cupedNumber);
                
                Console.ReadLine();
            }
            
            static double cube(int num)
            {
                int result = num * num * num;
                return result;
            }


            // If Statements


            {
                bool isMale = false;
                bool isTall = false;

                if (isMale && isTall)
                {
                    Console.WriteLine("You are a tall male");
                } else if (isMale && !isTall) {
                    Console.WriteLine("You are a short male");
                
                } else if (!isMale && isTall) {
                    Console.WriteLine("You are not a male but you are tall");


                } else
                {
                    Console.WriteLine("You are not male and not tall");

                }

            }

            // More If Statements


            Console.WriteLine(GetMax(20, 10));

            Console.ReadLine();



            static int GetMax(int num1, int num 2, int num3)
            {
                int result;
                if(num1 >= num2 && num1 >= num3)
                {
                    result = num1;
                } else if(num2 >= num1 && num2 >= num3)
                {
                    result = num2;
                }
                else
                {
                    result = num3;
                }

 

                return result; 
            }


            // Building a Better Calculator


            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();
            
            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+") ;
            {
                Console.WriteLine(num1 + num2);
            } else if(op == "-")
            {
                Console.WriteLine(num1 - num2);
            }

                Console.WriteLine(num1 / num2);
            else if (op == "/")

            {
             else if (op == "*")

                    Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }



            Console.WriteLine(num1 - num2);

            Console.ReadLine()




            // Switch Statements


            {
                Console.ReadLine();
            }

            static string GetDay(int dayNum) 
                string dayName;
                
               switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }
            
            
            return dayName;
                
                
                
            Console.ReadLine();


            // While Loops


            {
                int index = 1;
                while (index <= 5)
                {
                    Console.WriteLine(index);
                    index++;
                }
            }


            
            
            
            Console.WriteLine( luckyNumbers[1] );

            Console.ReadLine();
        }
    }
}
