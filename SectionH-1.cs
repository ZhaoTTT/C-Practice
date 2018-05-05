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
            int[] A = new int[num];
            SectionH.PrintArray(A);

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




        }

        static int ReadInteger()
        {
            bool rightInt=false;
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

            Console.WriteLine(string.Join(",",arr));
        }




        static bool Instring(string s1,string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            bool output=false;
            int i=0;
            for (i = 0; i < s1.Length - s2.Length; i++)
            {
                if (s2 == s1.Substring(i, s2.Length))
                {
                    output = true;
                    Console.WriteLine("True");
                    break;
                }
                else
                {
                    output = false;
                    Console.WriteLine("False");
                };
            }
            Console.WriteLine(output);
            return output;
        }



        static int FindWord(string s1,string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            bool output=false;
            int i = 0;
            for (i = 0; i <= s1.Length - s2.Length; i++)
            {
                if (s2 == s1.Substring(i, s2.Length))
                {
                    output = true;
                    Console.WriteLine("True");
                    break;
                }
                else
                {
                    output = false;
                    Console.WriteLine("False");
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
            string hexadecimal="";
            string num = Convert.ToString(input);
            string[] hex = new string[] {"0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F" };
            int b;
            int count = 0;
            int remainder;
            do
            {
                b = input / 16;
                remainder = input % 16;
                hexadecimal = hex[remainder] + hexadecimal;
                count++;
            } while (b >= 16);

            return hexadecimal;
        }






    }
}
