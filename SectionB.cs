using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class SectionB
    {
        static void Main()
        {
            //Section B
            //1
            Console.Write("Please enter a number:");
            string input1 = Console.ReadLine();
            double number = Convert.ToDouble(input1);
            //Console.WriteLine(Math.Sqrt(number));
			Console.WriteLine("{0:0.###}", Math.Sqrt(num));

            //2
            Console.Write("Please enter a number:");
            string input2 = Console.ReadLine();
            double number2 = Convert.ToDouble(input2);
            //Console.WriteLine("{0:#0.000}", Math.Sqrt(number2));
            Console.WriteLine("{0:0.000}", Math.Round(Math.Sqrt(x),3));//placeholder is just to show the format, instead of calculation
			
            //3
            Console.Write("Please enter your salary:");
            string input3 = Console.ReadLine();
            double salary = Convert.ToDouble(input3);
            double housing_allowance = salary * 0.1;//10%salary:%是求remainder
            double transport_allowance = salary * 0.03;//百分号能否直接用？不能，%代表求余数
            Double income = salary + housing_allowance + transport_allowance;
            //Console.WriteLine("your total income is ${0:#,#0.00}", income);//用C的话￥怎么消掉V。不消，用其他方式
			Console.WriteLine("{0:$#,0.00}",income);

            Console.WriteLine("{0:c}", salary * 1.13);

            //4
            Console.Write("Please enter the temperature:");
            string input4 = Console.ReadLine();
            double Centigrade = Convert.ToDouble(input4);
            double Fahrenheit=1.8*Centigrade + 32;
            Console.WriteLine(Fahrenheit);

            //5
            Console.Write("Please enter a number as x:");
            string input5 = Console.ReadLine();
            double x = Convert.ToDouble(input5);
            double y = 5 * Math.Pow(x, 2) - 4 * x + 3;
            Console.WriteLine(y);

            //6
            Console.WriteLine("Please enter the coordinates of two points in the following:");
            Console.WriteLine("x1\ty1\tx2\ty2");//同一行：x1   y1   x2   y2
            Console.Write("x1=");
            string ipx1 = Console.ReadLine();
            double x1 = Convert.ToDouble(ipx1);
            Console.Write("y1=");
            string ipy1 = Console.ReadLine();
            double y1 = Convert.ToDouble(ipy1);
            Console.Write("x2=");
            string ipx2 = Console.ReadLine();
            double x2 = Convert.ToDouble(ipx2);
            Console.Write("y2=");
            string ipy2 = Console.ReadLine();
            double y2 = Convert.ToDouble(ipy2);
            double distance = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
            Console.WriteLine(distance);
			
			//复习做的
				Console.Write("Please enter x1:");
                double x1 = Double.Parse(Console.ReadLine());
                Console.Write("Please enter y1:");
                double y1 = Double.Parse(Console.ReadLine());
                Console.Write("Please enter x2:");
                double x2 = Double.Parse(Console.ReadLine());
                Console.Write("Please enter y2:");
                double y2 = Double.Parse(Console.ReadLine());

                double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                Console.WriteLine(distance);	
			

            //7
            Console.Write("Please enter the distance:");
            string input7 = Console.ReadLine();
            double Travel_distance = Convert.ToDouble(input7);
            double min_fixed_charge=2.40;
            double total_fare = min_fixed_charge + Travel_distance * 0.4;
            Console.WriteLine("Your total fare is {0}",total_fare);
				//复习做的
			    double minFixedCharge = 2.4;
                Console.Write("Please enter your distance traveled:");
                double distance = Convert.ToDouble(Console.ReadLine());
                double fare = minFixedCharge + 0.4 * distance;
                Console.WriteLine(fare);

            //8-round
            Console.Write("Please enter the distance:");
            string input8 = Console.ReadLine();
            double Travel_distance8 = Convert.ToDouble(input8);
            //double min_fixed_charge = 2.40;
            double total_fare8 = min_fixed_charge + Travel_distance8 * 0.4;
            double TF = Math.Round(total_fare8, 1);
            Console.WriteLine("Your total fare is {0:#0.00}", TF);
			    //复习做的
			    double minFixedCharge = 2.4;
                Console.Write("Please enter your distance traveled:");
                double distance = Convert.ToDouble(Console.ReadLine());
                double fare = Math.Round(minFixedCharge + 0.4 * distance,1);
                Console.WriteLine("{0:#0.00}",fare);
								
			
			//9-ceiling（乘10再除以10）
            Console.Write("Please enter the distance:");
            string input9 = Console.ReadLine();
            double Travel_distance9 = Convert.ToDouble(input9);
            //double min_fixed_charge = 2.40;
            double total_fare9 = min_fixed_charge + Travel_distance9 * 0.4;
            double TF9 = Math.Ceiling(total_fare9*10);
            TF9=TF9/10;            
            Console.WriteLine("Your total fare is {0:#0.0}", TF9);
			    //复习做的        
                double minFixedCharge = 2.4;
                Console.Write("Please enter your distance traveled:");
                double distance = Convert.ToDouble(Console.ReadLine());
                double fare = minFixedCharge + 0.4 * distance;
                Console.WriteLine("{0:#0.0}", Math.Ceiling(fare*10)/10);

            //9-round
            Console.Write("Please enter the distance:");
            string input9 = Console.ReadLine();
            double Travel_distance9 = Convert.ToDouble(input9);
            //double min_fixed_charge = 2.40;
            double total_fare9 = min_fixed_charge + Travel_distance9 * 0.4;
            double TF9 = Math.Round(total_fare9, 1);
            if (TF9 < total_fare9)
            { TF9 = TF9 + 0.1; }
            Console.WriteLine("Your total fare is {0:#0.0}", TF9);

            //10
            Console.WriteLine("Please enter the lengths of three sides of a triangle:");
            Console.Write("a=");
            string A = Console.ReadLine();
            double a = Convert.ToDouble(A);
            Console.Write("b=");
            string B = Console.ReadLine();
            double b = Convert.ToDouble(B);
            Console.Write("c=");
            string C = Console.ReadLine();
            double c = Convert.ToDouble(C);
            //判断三边是否能够组成三角形
            if (a + b > c && a + c > b && b + c > a && Math.Abs(a - b) < c && Math.Abs(a - c) < b && Math.Abs(b - c) < a)
            {
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("The triangle's area is {0}", area);
            }
            else Console.WriteLine("NaN");

            /*  改良版
            Console.WriteLine("Please enter the lengths of three sides of a triangle:");
            Console.Write("a=");
            string A = Console.ReadLine();
            double a = Convert.ToDouble(A);
            Console.Write("b=");
            string B = Console.ReadLine();
            double b = Convert.ToDouble(B);
            Console.Write("c=");
            string C = Console.ReadLine();
            double c = Convert.ToDouble(C);
            //判断三边是否能够组成三角形
            if (a + b > c && a + c > b && b + c > a && Math.Abs(a - b) < c && Math.Abs(a - c) < b && Math.Abs(b - c) < a)
            {
                if(Math.Pow(a,2)+ Math.Pow(b, 2)== Math.Pow(c, 2))
                {
                    Console.WriteLine("The triangle is a right triangle.");
                }//判断钝角、锐角三角形？else if()利用三角函数用边求角再判断
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("The triangle's area is {0}", area);
            }
            else Console.WriteLine("a,b,c can not form a triangle.");
            */
			
			//MODIFICATION --SAMPLE ANSWER
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("c = ");
                double c = Convert.ToDouble(Console.ReadLine());

                double s = (a + b + c) / 2;
                double area;
                if (s-a<0||s-b<0||s-c<0)
                {
                    Console.WriteLine("NaN");
                }
                else
                {
                    area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                    Console.WriteLine(area);
                }
			
			

        }
    }
}
