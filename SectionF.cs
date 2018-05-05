using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_
{
    class Program
    {
        static void Main(string[] args)
        {
			//Section F
			//1
            Console.Write("Please enter a phrase:");
            string input = Console.ReadLine();
            int a = 0, e = 0, i = 0, o = 0, u = 0;
            int j;
            int length = input.Length;

            for (j = 0; j <= length-1; j++)
            {
                string s = input.Substring(j, 1);
                if ((s =="a")||(s=="A"))
                {
                    a = a + 1;
                }else if((s == "e") || (s == "E"))
                {
                    e = e + 1;
                }
                else if ((s == "i") || (s == "I"))
                {
                    i = i + 1;
                }
                else if ((s == "o") || (s == "O"))
                {
                    o = o + 1;
                }
                else if ((s == "u") || (s == "U"))
                {
                    u = u + 1;
                }
            }
            int totalvowels = a + e + i + o + u;
            Console.WriteLine("Total vowels:{0}", totalvowels);
            Console.WriteLine("A:" + a);
            Console.WriteLine("E:" + e);
            Console.WriteLine("I:" + i);
            Console.WriteLine("O:" + o);
            Console.WriteLine("U:" + u);
			
			//2
			Console.Write("Please enter a string:");
            string input2 = Console.ReadLine();
            int length = input2.Length;
            int i2 = 0;
            int j2 = length - 1;
            string f = input2.Substring(i2, 1);
            string b = input2.Substring(j2, 1);
            if (length % 2 == 0)
            {
                while (i2 != j2 + 1) 
                {
                    if (f == b)
                    {
                        i2++;
                        j2--;
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a palindrome.", input2);
                        break;
                    }
                }
                if (i2 == j2 + 1)
                {
                    Console.WriteLine("{0} is a palindrome.", input2);
                }
            }
            else//length%2!=0
            {
                while (i2 != j2)
                {
                    if (f == b)
                    {
                        i2++;
                        j2--;
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a palindrome.", input2);
                        break;
                    }
                }
                if (i2 == j2)
                {
                    Console.WriteLine("{0} is a palindrome.", input2);
                }
            }

			//3
			int i3;
            Console.Write("Please enter a string:");
            string input3 = Console.ReadLine();
            string input3__ = input3;

            //将输入的string变成全部小写、无标点符号、无空格的格式

            input3 = input3.Trim();
            input3 = input3.ToLower();
            
            string[] input3_= input3.Split('.');
            Console.WriteLine(input3_.Length);
            input3 = input3_[0];
            for (i3 = 1; i3 < input3_.Length; i3++)
            {
                input3 = input3 + input3_[i3];
            }
            Console.WriteLine(input3);
            

            input3_ = input3.Split(',');
            Console.WriteLine(input3_.Length);
            input3 = input3_[0];
            for (i3 = 1; i3 < input3_.Length; i3++)
            {
              
                input3 = input3 + input3_[i3];
            }
            Console.WriteLine(input3);


            input3_ = input3.Split(' ');
            Console.WriteLine(input3_.Length);
            input3 = input3_[0];
            for (i3 = 1; i3 < input3_.Length; i3++)
            {
               
                input3 = input3 + input3_[i3];
            }
            Console.WriteLine(input3);



            //判断是否对称字符
            int length = input3.Length;
            i3 = 0;
            int j3 = length - 1;
            string f = input3.Substring(i3, 1);
            string b = input3.Substring(j3, 1);
            if (length % 2 == 0)
            {
                while (i3 != j3+ 1)
                {
                    if (f == b)
                    {
                        i3++;
                        j3--;
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a palindrome.", input3__);
                        break;
                    }
                }
                if (i3 == j3 + 1)
                {
                    Console.WriteLine("{0} is a palindrome.", input3__);
                }
            }
            else//length%2!=0
            {
                while (i3 != j3)
                {
                    if (f == b)
                    {
                        i3++;
                        j3--;
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a palindrome.", input3__);
                        break;
                    }
                }
                if (i3 == j3)
                {
                    Console.WriteLine("{0} is a palindrome.", input3__);
                }
            }
			
			
			
			//4
			Console.Write("Please enter a sentence/phrase:");
            string input4 = Console.ReadLine();
            string[] input4_ = input4.Split(' ');
            for(int i4 = 0; i4 < input4_.Length; i4++)
            {
                input4_[i4] = (input4_[i4].Substring(0, 1)).ToUpper() + input4_[i4].Substring(1, input4_[i4].Length - 1);
            }
            Console.WriteLine(string.Join(" ", input4_));

			//4-v2
			Console.Write("Please enter a sentence/phrase:");
            string input4 = Console.ReadLine();
            string[] input4_ = input4.Split(' ');
            for (int i4 = 0; i4 < input4_.Length; i4++)
            {
                input4_[i4] = (input4_[i4].Substring(0, 1)).ToUpper() + input4_[i4].Substring(1);//xxx.Substring(int x);means get the string from xxx[1] to the end(xxx[xxx.Length])
            }
            Console.WriteLine(string.Join(" ", input4_));
			
			

			//5
			string[] name = new string[5] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = new int[5] { 63, 29, 75, 82, 55 };
            //a按成绩高-低
            int i5,j5;
            int[] marks_ = marks;
            string[] name_ = new string[5];
            Array.Sort(marks_);
            Array.Reverse(marks_);
            for(i5 = 0; i5 < 5; i5++)
            {
                j5=Array.IndexOf(marks, marks_[i5]);
                name_[i5] = name[j5];
            }
            for (i5 = 0; i5 < 5; i5++)
            {
                Console.WriteLine(name_[i5]+"\t"+marks_[i5]);
            }

            //b---按姓名
            string[] name__ = name;
            int[] marks__ = new int[5];
            Array.Sort(name__);
            for (i5 = 0; i5 < 5; i5++)
            {
                j5 = Array.IndexOf(name, name__[i5]);
                marks__[i5] = marks[j5];
            }
            for (i5 = 0; i5 < 5; i5++)
            {
                Console.WriteLine(name__[i5] + "\t" + marks__[i5]);
            }

			
			//6
			Console.Write("Enter a matriculation number:);
			string matriNum=Console.ReadLine();
			int num6=Int32.Parse(matriNum.Substring(1,5));
			int i6;
			int[]num=new int[5];
			for(i6=0;i6<5;i6++)
			{
			    num[i6]=num6.Substring(i6,1);
			}			
			int[]result=new int[5];
			int j6=6-i6;//放在for里？
			for(i6=0;i6<5;i6++)
			{
			    result[i6]=num[i6]*j6;
			}	
			int sum=0;
			for(i6=0;i6<5;i6++)
			{
			    sum=sum+result[i6];
			}	
			int remainder=sum%5;
			string Checksum;
			switch(remainder)
			{
				case 0:
				   Checksum=O;
				   break;
				case 1:
				   Checksum=P;
				   break;
				case 2:
				   Checksum=Q;
				   break;
				case 3:
				   Checksum=R;
				   break;
				case 4:
				   Checksum=S;
				   break;
			}
			if (matriNum.Substring(6,1)==Checksum)
			{
				Console.WriteLine("Valid");
			}else
			{				
		        Console.WriteLine("Invalid");
			}
			

        }

    }
    
}
