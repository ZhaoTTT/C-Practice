using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class SectionC
    {
        static void Main()
        {
            //SectionC
            //1
            Console.Write("Please enter your name:");
            string name = Console.ReadLine();
            Console.Write("Please enter your gender (M for Male,F for Female):");
            string gender = Console.ReadLine();
            if (gender == "M")
            {
                Console.WriteLine("Good Morning Mr.{0}", name);
            }
            else Console.WriteLine("Good Morning Ms.{0}", name);
			        //SAMPLE ANSWER
			    switch (gender.ToUpper())
            {
                case "M":
                    Console.Write("Good Morning Mr. " + name);
                    break;
                case "F":
                    Console.Write("Good Morning Ms. " + name);
                    break;
                default:
                    Console.WriteLine("Wrong gender");
                    break;
            }


            //2
            Console.Write("Please enter your name:");
            string name2 = Console.ReadLine();
            Console.Write("Please enter your gender (M for Male,F for Female):");
            string gender2 = Console.ReadLine();
            Console.Write("Please enter your age:");
            string age2 = Console.ReadLine();
            int age = Int32.Parse(age2);
            if (age >= 40)
                switch (gender2.ToUpper)
                {
                    case "M":
                        Console.WriteLine("Good Morning Uncle {0}", name2);
                        break;
                    case "F":
                        Console.WriteLine("Good Morning Aunty {0}", name2);
                        break;
				    default:
					    Console.WriteLine("wrong gender");
                        break;
                }
            else switch (gender2.ToUpper)
                {
                    case "M":
                        Console.WriteLine("Good Morning Mr.{0}", name2);
                        break;
                    case "F":
                        Console.WriteLine("Good Morning Ms.{0}", name2);
                        break;
					default:
					    Console.WriteLine("wrong gender");
                        break;
                }


            //3
            Console.Write("Please enter your mark(integer between 0 and 100):");
            string input = Console.ReadLine();
            int mark = Convert.ToInt32(input);
            if (mark <= 100 && mark >= 80) 
            {
                Console.WriteLine("You scored {0} marks which is A grade.", mark);
            }
            else if (mark <= 79 && mark >= 60)
            {
                Console.WriteLine("You scored {0} marks which is B grade.", mark);
            }
            else if (mark <= 59 && mark >= 40)
            {
                Console.WriteLine("You scored {0} marks which is C grade.", mark);
            }
            else if (mark <= 40 && mark >= 0)
            {
                Console.WriteLine("You scored {0} marks which is F grade.", mark);
            }
            else if (mark < 0||mark>100)
            {
                Console.WriteLine("**Error**");
            }//或者else Console.WriteLine("**Error**");

            /*
            Console.Write("Please enter your mark(integer between 0 and 100):");
            string input = Console.ReadLine();
            int mark = Convert.ToInt32(input);
            if (mark <= 100) 
            {
                if (mark <= 79)
                {
                    if (mark <= 59)
                    {
                        if (mark <= 40)
                        {
                            if (mark < 0)
                            {
                                Console.WriteLine("**Error**");
                            }
                            else Console.WriteLine("You scored {0} marks which is F grade.", mark);
                        }
                        else Console.WriteLine("You scored {0} marks which is C grade.", mark);
                    }
                    else Console.WriteLine("You scored {0} marks which is B grade.", mark);
                }
                else Console.WriteLine("You scored {0} marks which is A grade.", mark);
            }
            else Console.WriteLine("**Error**");

            */

			//复习做的
			    Console.Write("marks:");
                int marks = Convert.ToInt32(Console.ReadLine());
                string grade="";
                if (80 <= marks && marks <= 100)
                {
                    grade = "A";
                }else if(60 <= marks && marks <= 79)
                {
                    grade = "B";
                }
                else if (40 <= marks && marks <= 59)
                {
                    grade = "C";
                }
                else if (0 <= marks && marks <= 39)
                {
                    grade = "F";
                }
                else
                {
                    grade = "**Error**";
                }
                Console.WriteLine("You scored {0} marks which is {1} grade.", marks, grade);

            
            //4
            double min = 2.40;     //first 0.5 km no additional charges apply
            Console.Write("Please enter the distance you have travelled(km):");
            string input4 = Console.ReadLine();
            double distance = Double.Parse(input4);
            double D = Math.Round(distance, 1);
            //Console.WriteLine(D);
            if (D < distance)
            {
                D = D + 0.1;
            }
            double cost;
            if (D >= 0 && D <= 0.5) 
            {
                cost = min;
            }
            else if (D - 0.5 <= 8.5)
            {
                cost = min + (D - 0.5) / 0.1 * 0.04;
            }
            else if (D < 0)
            {
                cost = 0;
            }
            else cost = min + 8.5 / 0.1 * 0.04 + (D - 9) / 0.1 * 0.05;
            Console.WriteLine("$"+cost);


            //5
            Console.Write("Please enter a three-digit number:");
            string input5 = Console.ReadLine();
            int number = Int32.Parse(input5);
            if (number==Math.Pow(number/100,3)+ Math.Pow(number%100/10, 3)+ Math.Pow(number%100%10, 3))
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");
            /*
            Console.Write("Please enter a three-digit number:");
            string input5 = Console.ReadLine();
            int number = Int32.Parse(input5);
            Console.WriteLine(number == Math.Pow(number / 100, 3) + Math.Pow(number % 100 / 10, 3) + Math.Pow(number % 100 % 10, 3));
            */

        }
    }
}
