using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_5
{
    class SectionH

    {
        static void Main(string[] args)
        {
            //1---要求输入整数
            int num = SectionH.ReadInteger();


            //2---打印array
            int[] A2 = new int[num];
            Random r = new Random();
            int j = 0;
            for (j = 0; j < num; j++)
            {
                A2[j] = r.Next(1, 100);
            }
            SectionH.PrintArray(A2);

            //3---看s1里有没有s2
            Console.WriteLine("Please give us s1 and s2. We are going to check if s1 includes s2(regardless of capital letters).");
            Console.Write("Please enter s1:");
            string s1 = Console.ReadLine();
            Console.Write("Please enter s2:");
            string s2 = Console.ReadLine();
            SectionH.Instring(s1, s2);

            //4---显示s1中s2的开始位置
            SectionH.FindWord(s1, s2);

            //5---十六进制
            //使用第一题输入的num
            SectionH.hexadecimal(num);

            //6---c1代替c2
            Console.Write("Please enter a string:");
            string s = Console.ReadLine();
            Console.Write("Please enter the letter c1 which you want to be substituted:");
            string c1_ = Console.ReadLine();
            char c1 = Convert.ToChar(c1_);
            Console.Write("Please enter the letter which is to substitute c1 in the string:");
            string c2_ = Console.ReadLine();
            char c2 = Convert.ToChar(c2_);
            SectionH.Substitute(s,c1,c2);

            //7---将特定value值赋值给arr中的每个位置
            Random r7 = new Random();
            int[] array = new int[r7.Next(1, 10)];
            SectionH.SetArray(array, r7.Next(1, 10));
            SectionH.PrintArray(array);

            //8---变化原来array长度
            SectionH.ResizeArray(array, r7.Next(1, 10));

            //9---判断是否质数prime  并打印5-1000的质数
            int k;
            for (k = 5; k <= 1000; k++)
            {
                SectionH.IsPrime(k);
            }

            //10---矩阵相乘
            int[,] A = new int[r7.Next(1,10), r7.Next(1, 10)];
            int[,] B = new int[r7.Next(1, 10), r7.Next(1, 10)];
            SectionH.MatrixMultiply(A, B);

            //11



        }

        static int ReadInteger()
        {
            bool rightInt = false;
            int integer;
            do
            {
                Console.Write("Please enter an integer:");
                string input = Console.ReadLine();
                rightInt = Int32.TryParse(input, out integer);
            } while (rightInt == false);

            return integer;
        }



        static void PrintArray(int[] arr)
        {

            Console.WriteLine(string.Join(",", arr));
        }




        static bool Instring(string s1, string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            bool output = false;
            int i = 0;
            for (i = 0; i < s1.Length - s2.Length; i++)
            {
                if (s2 == s1.Substring(i, s2.Length))
                {
                    output = true;
                    break;
                }
                else
                {
                    output = false;
                };
            }
            Console.WriteLine(output);
            return output;
        }



        static int FindWord(string s1, string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            bool output = false;
            int i = 0;
            for (i = 0; i <= s1.Length - s2.Length; i++)
            {
                if (s2 == s1.Substring(i, s2.Length))
                {
                    output = true;
                    break;
                }
                else
                {
                    output = false;
                }
            }
            int startP = 0;
            if (output == true)
            {
                for (i = 0; i <= s1.Length - s2.Length; i++)
                {
                    if (s1.Substring(i, s2.Length) == s2)
                    {
                        startP = i;
                        break;
                    }
                }
            }
            else
            {
                startP = -1;
            }
            Console.WriteLine(startP);
            return startP;
        }

        static string hexadecimal(int input)//16进制
        {
            string hexadecimal = "";
            string[] hex = new string[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            int remainder;
            do
            {
                remainder = input % 16;
                input = input / 16;
                hexadecimal = hex[remainder] + hexadecimal;
            } while (input >= 16);
            hexadecimal = hex[input] + hexadecimal;
            Console.WriteLine(hexadecimal);
            return hexadecimal;
        }


        static string Substitute(string s, char c1, char c2)
        {
            string[] s_ = s.Split(c1);
            string c2_ = Convert.ToString(c2);
            string newS = string.Join(c2_, s_);
            Console.WriteLine(newS);
            return newS;
            //string c1_ = Convert.ToString(c1);
            //string c2_ = Convert.ToString(c2);
            //int i = 0;
            //for (i = 0; i < s.Length; i++)
            //{
            //    if (c1_ == s.Substring(i, 1))
            //    {

            //         = c2;
            //    }
            //}
        }

       static void SetArray(int[] arr,int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = value;
            }
        }


        static int[] ResizeArray(int[] arr,int newSize)
        {
            int[] newArray = new int[newSize];
            int i = 0;
            for (i = 0; i < newSize; i++)
            {
                if (i < arr.Length)
                {
                    newArray[i] = arr[i];
                }
                else
                {
                    newArray[i] = 0;
                }
            }
            Console.WriteLine(string.Join(",", newArray));
            return newArray;
        }


        static bool IsPrime(int n)
        {
            bool IsPrime;
            int count = 0;
            for(int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                IsPrime = true;
            }
            else { IsPrime = false; }
            if (IsPrime == true)
            {
                Console.WriteLine(n);
            }
            return IsPrime;
        }



        static int[,] MatrixMultiply(int[,] A, int[,] B)
        {
            int[,] X = new int[A.GetLength(0),B.GetLength(1)];
            if (A.GetLength(1) == B.GetLength(0))
            {
                for(int i=1; i< A.GetLength(0); i++) 
                {
                    for(int j = 1; j < B.GetLength(1); j++)
                    {
                        X[i, j] = A[i, j] * B[j, i];
                        Console.Write(X[i, j]+ ",");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("A and B cannnot multiply.");
            }

            return X;
        }


    }
}
