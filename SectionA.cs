using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_1
{
    class Program1
    {
        static void Main(string[] args)
        {
			//Section A
			//1
            Console.WriteLine("ZHAO TONGTONG");
            Console.WriteLine("e0283977@u.nus.edu");
			
			//2
			Console.Write("Please Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Good Morning "+name); //("Good Morning {0},name");
						
			//3
			Console.Write("Please Enter an Integer:");
            string input = Console.ReadLine();     //控制台输入一个整数(Q:能否控制只能输入数字，不能输入character？A:加if语句？B:用do...while,TryParse循环判断)
            int data = Convert.ToInt32(input);     //将输入转换成整数.or Int32.Parse(input)
			//Console.WriteLine(num*num);
            Console.WriteLine(Math.Pow(data,2));
			
			//4
			Console.Write("Please Enter a Double Precision Number:");
            string input = Console.ReadLine();     //控制台输入一个双精度(Q:能否控制只能输入数字，不能输入character？A:加if语句？)
            double data = Convert.ToDouble(input);     //将输入转换成双精度.or Double.Parse(input)
            Console.WriteLine(Math.Pow(data, 2));
			
			//5
			Console.Write("Please Enter a Double Precision Number:");
            string input = Console.ReadLine();
            double data = Convert.ToDouble(input);
            Console.WriteLine("{0:#0.00}", data);
			
			
			
        }
    }
}
