using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class SectionE
    {
        static void Main(string[] args)
        {
            //Section E
            //1(a)
            bool rightNum;
            int Num;
            do
            {
                Console.Write("Please enter a number:");
                string input = Console.ReadLine();
                rightNum = Int32.TryParse(input, out Num);
            } while (rightNum == false);

            string x;
            string factorial = "";
            int j = 0;
            for (int i = 1; i <= Num; i++)
            {
                if (Num % i == 0)
                {
                    j++;
                    x = Convert.ToString(i);
                    if (i != Num)
                    {
                        factorial = factorial + x + ",";
                    }
                    else
                    {
                        factorial = factorial + "and " + x + ".";
                    }
                }
            }
            Console.WriteLine("{0} has {1} factorials, which are {2}", Num, j, factorial);

            //1(b)
            bool rightNum1;
            int Num1;
            do
            {
                Console.Write("Please enter a number:");
                string input1 = Console.ReadLine();
                rightNum1 = Int32.TryParse(input1, out Num1);
            } while (rightNum1 == false);

            string x1;
            string factorial1 = "";
            int j1 = 0;
            for (int i1 = Num1; i1 >=1; i1--)
            {
                if (Num1 % i1 == 0)
                {
                    j1++;
                    x1 = Convert.ToString(i1);
                    if (i1 != 1)
                    {
                        factorial1 = factorial1 + x1 + ",";
                    }
                    else
                    {
                        factorial1 = factorial1 + "and " + x1 + ".";
                    }
                }
            }
            Console.WriteLine("{0} has {1} factorials, which are {2}", Num1, j1, factorial1);


            //2
            Console.WriteLine("NO\t INVERSE\tSQUARE ROOT\t SQUARE");
            for (double i = 1.0; i <= 10.0; i++)
            {
                double inverse = 1 / i;
                double sqrt = Math.Sqrt(i);
                double sqr = Math.Pow(i, 2);
                Console.WriteLine("{0:0.0}\t  {1:0.0##}\t\t {2:0.0##}\t          {3:0.0}", i, inverse, sqrt, sqr);
            }


            //3
            bool rightNum3;
            int num3;
            do
            {
                Console.Write("Please enter a integer:");
                string input3 = Console.ReadLine();
                rightNum3 = Int32.TryParse(input3, out num3);
            } while (rightNum3 == false || num3 <= 0);

            int j3 = 0;
            for (int i = 1; i <= num3; i++)
            {
                if (num3 % i == 0)
                {
                    j++;
                }

            }
            if (j3 == 2)
            {
                Console.WriteLine("Prime");
            }
            else Console.WriteLine("Not Prime");


            //4
            bool rightNum4;
            int num4;
            do
            {
                Console.Write("Please enter a integer:");
                string input4 = Console.ReadLine();
                rightNum4 = Int32.TryParse(input4, out num4);
            } while (rightNum4 == false || num4 <= 0);

            int factor = 0;
            int i4;
            for (i4 = 1; i4 <= num4; i4++)
            {
                if (num4 % i4 == 0)
                {
                    factor = factor + i4;
                }
            }
            int factor_ = factor - num4;
            if (num4 == factor)
            {
                Console.WriteLine("Perfcet number");
            }
            else
            {
                Console.WriteLine("not Perfcet number");
            }
            //string[] prime_ = prime.Split(' ');
            //int length = prime_.Length;
            ////如果各prime求和=num4，那么num4就是perfect number



            //5
            int j5;
            int factor5;
            for (int i5 = 5; i5 <= 10000; i5++)
            {
                j5 = 1;
                factor5 = 0;
                do
                {
                    if (i5 % j5 == 0)
                    {
                        factor5 = factor5 + 1;
                        j5++;
                    }
                    else j5++;
                } while (j5 <= i5);
                if (factor5 == 2)
                {
                    Console.WriteLine(i5);
                }
            }

			//6
			int j6;
			int perfect6=0;
            for (int i6 = 1; i6 <= 1000; i6++)
            {
				j6=1;
				while(j6<i6)
		        {	
                    if (i6 % j6 == 0)
                    {
                        perfect6 = perfect6 + j6;
			    		j6++;
                    }else j6++;
				}
				if (perfect6 == i6)
            
                Console.WriteLine(i6);
            }
            


            





        }
    }
}
