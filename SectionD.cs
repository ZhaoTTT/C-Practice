using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class SectionD
    {
        static void Main(string[] args)
        {
            //Section D
            //1
            int num;
            bool successfulInt;
            do
            {
                Console.WriteLine("Please enter an integer number:");
                string input = Console.ReadLine();
                successfulInt = Int32.TryParse(input, out num);
            } while (successfulInt == false || num != 88);
            Console.WriteLine("Lucky you...");



            //2
            int A, B, L, S;
            bool rightA = false;
            bool rightB = false;
            do
            {
                Console.WriteLine("Please enter two numbers:");
                Console.Write("A=");
                string a = Console.ReadLine();
                rightA = Int32.TryParse(a, out A);
                Console.Write("B=");
                string b = Console.ReadLine();
                rightB = Int32.TryParse(b, out B);
            } while (rightA == false || rightB == false);

            L = Math.Max(A, B);
            S = Math.Min(A, B);
            int SS = S;
            do
            {
                S = Math.Min(L, S);
                L = Math.Max(L, SS);

                int D = L - S;
                L = D;
                SS = S;
            } while (L != SS);
            int HCF = L;
            double LCM = A * B / HCF;
            Console.WriteLine("A={0},B={1},HCF={2},LCM={3}", A, B, HCF, LCM);

            
            //int A, B, L, S;
            //bool rightA = false;
            //bool rightB = false;
            //do
            //{
            //    do
            //    {
            //        Console.WriteLine("Please enter two numbers:");
            //        Console.Write("A=");
            //        string a = Console.ReadLine();
            //        rightA = Int32.TryParse(a, out A);
            //        Console.Write("B=");
            //        string b = Console.ReadLine();
            //        rightB = Int32.TryParse(b, out B);
            //    } while (rightA == false || rightB == false);

            //    L = Math.Max(A, B);
            //    S = Math.Min(A, B);

            //} while ((L - S) % S != 0);
            //do
            //{
            //    L = L - S;
            //} while (L != S);
            //int HCF = L;
            //double LCM = A * B / HCF;
            //Console.WriteLine("A={0},B={1},HCF={2},LCM={3}", A, B, HCF, LCM);

			//复习写的
			Console.Write("A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double l = Math.Max(a, b);
            double s = Math.Min(a, b);

			double ll;
            while (l != s)
            {
                ll = l;
                l = Math.Max(l, s)-Math.Min(l,s);
                s = Math.Min(ll, s);
            }
            double HCF = s;
            double LCM = (a * b) / HCF;
            Console.WriteLine("A = {0}\nB = {1}\nHCF = {2}\nLCM = {3}", a, b, HCF, LCM);


            //3(a)
            Random r = new Random();
            int secretNum = r.Next(0, 9);
            bool rightGuess;
            int guess;
            int i = 0;
            do
            {
                Console.Write("Please enter your guess:");
                string input3a = Console.ReadLine();
                rightGuess = Int32.TryParse(input3a, out guess);
                i++;
            } while (guess != secretNum);
            Console.WriteLine("Congratulations! You have tried {0} times.", i);
			
			//复习写的
			int num;
            Random r = new Random();
            num = r.Next(0, 10);
            int guess;
            int count = 0;
            do
            {
                Console.Write("guess a number(0-9): ");
                guess = Convert.ToInt32(Console.ReadLine());
                count += 1;

            } while (num != guess);
            Console.WriteLine("Congratulations! you have tried {0} times. ",count);


            //3(b)
            Random r_ = new Random();
            int secretNum_ = r_.Next(0, 9);
            bool rightGuess_;
            int guess_;
            int i_ = 0;
            do
            {
                if (i_ >= 1)
                {
                    Console.WriteLine("Try again");
                }
                Console.Write("Please enter your guess:");
                string input3b = Console.ReadLine();
                rightGuess_ = Int32.TryParse(input3b, out guess_);
                i_++;
            } while (guess_ != secretNum_);
			/*
			do
            {
                Console.Write("guess a number(0-9): ");
                guess = Convert.ToInt32(Console.ReadLine());
                count += 1;
                if (guess != num) Console.WriteLine("Try again.");

            } while (num != guess);
			*/
            Console.WriteLine("Congratulations! You have tried {0} times.", i_);
            if (i_ <= 2)
            {
                Console.Write("You are a Wizard!");
            }else if (i_ <= 5)
            {
                Console.Write("You are a good guess!");
            }
            else
            {
                Console.Write("You are Lousy!");
            }



            //4
            int N;
            int guess4;
            double G;
            bool rightN;
            bool rightG = false;

            do
            {
                do
                {
                    Console.Write("Please enter a number:");
                    string input4 = Console.ReadLine();
                    rightN = Int32.TryParse(input4, out N);
                } while (rightN == false || N < 0);

                Random r4 = new Random();
                guess4 = r4.Next(0, N);
                G = guess4;
                while (Math.Abs(N - G * G) > 0.00001)
                {
                    G = (G + N / G) / 2;
                }
                rightG = true;
            } while (rightG == false);
            Console.WriteLine("N is {0}, and its square root is about {1:#0.#00}.", N, G);





        }

    }
}
