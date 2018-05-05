using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4
{
    class SectionG
    {
        static void Main(string[] args)
        {
            //Section G
            //1
            int i1;
            string[] month = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            double[] sales = new double[12];
            for (i1 = 0; i1 < 12; i1++)
            {
                Console.Write("Please enter sales in {0}:", month[i1]);
                string input1 = Console.ReadLine();
                Double sale = Double.Parse(input1);
                sales[i1] = sale;
            }
            //将sales列表
            Console.WriteLine("month\tsales");
            for (i1 = 0; i1 < 12; i1++)
            {
                Console.WriteLine(month[i1] + "\t" + sales[i1]);
            }
            //整理并打印值
            double[] sales_ = new double[12];
            Array.Copy(sales, sales_, 12);
            Array.Sort(sales_);
            //打印最大值
            Console.WriteLine("max month:" + Array.IndexOf(sales, sales_[11]));
            //打印最小值
            Console.WriteLine("min month:" + Array.IndexOf(sales, sales_[0]));
            //打印均值
            double total = 0;
            for (i1 = 0; i1 < 12; i1++)
            {
                total = total + sales[i1];
            }
            double average = total / 12;
            Console.WriteLine("average sales:" + average);


            //2
            //生成随机序列
            //Random r2 = new Random();
            //int[] R2 = new int[5];
            //for (int j2 = 0; j2 < 5; j2++)
            //{
            //    int rd2 = r2.Next(1, 10);
            //    R2[j2] = rd2;
			//改成R2[j2]= r2.Next(1, 10);
            //}
            //int i2;
            ////打印随机序列
            //for (i2 = 0; i2 < 5; i2++)
            //{
            //    Console.Write(string.Join(",",R2));
            //}
            ////sort algorithm
            //for(int k2 = 1; k2 <= 4; k2++)
            //{
            //    for (i2 = 0; i2 < 5; i2++)
            //    {
            //        if (R2[i2] < R2[k2])
            //        {
            //            int temp2 = R2[i2];
            //            R2[i2] = R2[k2];
            //            R2[k2] = temp2;
            //        }
            //        Console.WriteLine(string.Join(",", R2));
            //    }
            //}


            //2----不挨个换
            ////生成随机序列
            //Random r2 = new Random();
            //int[] R2 = new int[5];
            //for (int j2 = 0; j2 < 5; j2++)
            //{
            //    int rd2 = r2.Next(1, 10);
            //    R2[j2] = rd2;
            //}
            int i2 = 0;
            ////打印随机序列

            //Console.WriteLine(string.Join(",", R2));


            //sort algorithm

            int[] R2 = new int[5] { 100, 90, 120, 80, 76 };
            int[] R2_ = new int[5];
            Array.Copy(R2, R2_, 5);


            for (i2 = 0; i2 < 5; i2++)
            {
                int min = R2_[i2];
                int k2;
                int temp2;
                for (k2 = i2 + 1; k2 <= 4; k2++)
                {
                    if (min > R2_[k2])
                    {

                        min = R2_[k2];
                    }
                    //else
                    //{

                    //}
                }
                int minIndex = Array.IndexOf(R2_, min);
                temp2 = R2_[i2];
                R2_[i2] = min;
                R2_[minIndex] = temp2;


                Console.WriteLine(string.Join(",", R2_));

            }


            //3有错，优化看SectionG-3
            int[,] marks = new int[12, 4]{
                { 56,84,68,29},
                { 94,73,31,96},
                { 41,63,36,90},
                { 99,9,18,17},
                { 62,3,65,75},
                { 40,96,53,23},
                { 81,15,27,30},
                { 21,70,100,22},
                { 88,50,13,12},
                { 48,54,52,78},
                { 64,71,67,25},
                { 16,93,46,72}
            };



            int i3, j3;

            //打印每个学生4个学科总成绩
            double[] everyStuTotal = new double[12];
            for (i3 = 0; i3 < marks.GetLength(0)/*12*/; i3++)
            {
                for (j3 = 0; j3 < marks.GetLength(1)/*4*/; j3++)
                {
                    everyStuTotal[i3] = everyStuTotal[i3] + marks[i3, j3];
                    Console.WriteLine(string.Join("\t", everyStuTotal[i3]));
                }
            }

            //打印每个人各科平均成绩
            double[] averageStu = new double[12];
            for (i3 = 0; i3 < marks.GetLength(0)/*12*/; i3++)
            {
                for (j3 = 0; j3 < marks.GetLength(1)/*4*/; j3++)
                {
                    averageStu[i3] = everyStuTotal[i3] / 4;
                    Console.WriteLine(string.Join("\t", averageStu[i3]));
                }
            }


            //打印各科成绩总和
            double[] everySubTotal = new double[4];
            for (j3 = 0; j3 < marks.GetLength(1)/*4*/; j3++)
            {
                for (i3 = 0; i3 < marks.GetLength(0)/*12*/; i3++)
                {
                    everySubTotal[j3] = everySubTotal[j3] + marks[i3, j3];
                    Console.WriteLine(string.Join("\t", everySubTotal[j3]));
                }
            }
            //打印各科平均成绩
            double[] average = new double[4];
            for (j3 = 0; j3 < marks.GetLength(1); j3++)
            {
                average[j3] = everySubTotal[j3] / 12;
            }
            everySubTotal[j3] = everySubTotal[j3] + marks[i3, j3];
            Console.WriteLine(string.Join("\t", everySubTotal[j3]));

            //打印各科成绩标准差
            double[,] D = new double[12, 4];
            double[,] D_2 = new double[12, 4];
            double[] sumD = new double[4];
            double[] SD = new double[4];
            for (j3 = 0; j3 < marks.GetLength(1)/*4*/; j3++)
            {
                for (i3 = 0; i3 < marks.GetLength(0)/*12*/; i3++)
                {
                    D[i3, j3] = marks[i3, j3] - average[j3];
                    D_2[i3, j3] = Math.Pow(D[i3, j3], 2);
                    sumD[j3] = sumD[j3] + D_2[i3, j3];
                }
                SD[j3] = sumD[j3] / 12;
            }
            Console.WriteLine(string.Join("\t", SD[j3]));

            //if we are not sure about the number of students or subjects?
            //见SectionG-3



            //new questions
            //4---to print the content of array--->int []A =new int[]{1,2,3}; Console.WriteLine(string.Join(",",A));
            int[] A = new int[10];
            for (int i4 = 9; i4 >= 0; i4--)
            {
                A[i4] = i4+1;
            }
            Console.WriteLine("[" + string.Join(",", A) + "]");

            int[] AA = new int[10];
            string array = "";
            for (int i4_ = 0; i4_ < 10; i4_++)
            {
                AA[i4_] = i4_+1;
                array = array + AA[i4_] + ",";
            }
            char[] c = new char[] { ',' };
            string array_ = array.TrimEnd(c);
            Console.WriteLine("[" + array_ + "]");



            //5
            //接第4题
            bool rightNum=false;
            string input;
            int num;
            do
            {
                Console.Write("Enter a number:");
                input = Console.ReadLine();
                rightNum = Int32.TryParse(input, out num);
            } while (rightNum == false);

            int i5;
            for(i5 = 0; i5 < 10; i5++)
            {
                if (num == A[i5])
                {
                    Console.WriteLine("Number {0} is found in the array at the element no{1}.", num, i5);
                    break;
                }
            }
            while (i5 == 10 && num != A[i5-1]) 
            {
                Console.WriteLine(-1);
                break;
            }
 


            //5--Array.IndexOf()
            //前面相同
            do
            {
                Console.Write("Enter a number:");
                input = Console.ReadLine();
                rightNum = Int32.TryParse(input, out num);
            } while (rightNum == false);
            //Console.WriteLine(Array.IndexOf(A, num));
            Console.WriteLine("Number {0} is found in the array at the element no{1}.", num, Array.IndexOf(A, num));


            //6
            //生成随机序列
            Random r = new Random();
            int[] R = new int[5];
            for (int j = 0; j < 5; j++)
            {
                int rd = r.Next(1, 10);
                R[j] = rd;
            }
            int i;
            //打印随机序列
            for (i = 0; i < 5; i++)
            {
                Console.Write(R[i] + "\t");
            }

            //sort algorithm小-大
            int i6;
            for (i6 = 0; i6 < 4; i6++)
            {
                int j6 = 1;
                do
                {
                    if (R[i6] >= R[i6 + j6])
                    {
                        int temp = R[i6];
                        R[i6] = R[i6 + j6];
                        R[i6 + j6] = temp;
                        j6++;
                    }
                    else
                    {
                        j6++;
                    }
                } while (i6 + j6 <= 4);

            }

            //打印整理好的序列
            Console.WriteLine();
            for (i6 = 0; i6 < 5; i6++)
            {
                Console.Write(R[i6] + "\t");
            }

            //6---Array.Sort();升序：从小到大
            Array.Sort(R);
            Console.WriteLine();

                //int i6;
            for (i6 = 0; i6 < R.Length; i6++)
            {
                Console.Write(R[i6] + "\t");
            }
            Console.WriteLine();
            //---Array.Reverse();反转--将升序改成降序：从大到小
            Array.Reverse(R);
            for (i6 = 0; i6 < R.Length; i6++)
            {
                Console.Write(R[i6] + "\t");
            }
            Console.WriteLine();


            //7
            Console.WriteLine("Name\tScore");
            string[] name = new string[7] { "Alice", "Bob", "Charlie", "Dennis", "Eli", "Frank", "Gina" };
            int[] score = new int[7] { 100, 90, 120, 80, 76, 66, 88 };
            string[] name1 = new string[7];
            Array.Copy(name, name1, 7);
            Array.Sort(name1);
            int i7, j7;
            for (i7 = 0; i7 <= 6; i7++)
            {
                j7 = Array.IndexOf(name1, name[i7]);
                Console.WriteLine(name1[i7] + "\t" + score[j7]);
            }

            //7---乱序再排
            //Console.WriteLine("Name\tScore");
            //string[] name = new string[7] { "Bob", "Alice", "Charlie", "Eli", "Dennis", "Frank", "Gina" };
            //int[] score = new int[7] { 90, 100, 120, 76, 80, 66, 88 };
            //string[] name1 = new string[7];
            //Array.Copy(name, name1, 7);
            //Array.Sort(name1);
            //int i7, j7;
            //for (i7 = 0; i7 <= 6; i7++)
            //{
            //    j7 = Array.IndexOf(name1, name[i7]);
            //    Console.WriteLine(name1[i7] + "\t" + score[j7]);
            //}



            //8
            int i8 = 0;
            int j8 = 0;
            int num8;
            int[,] num8_ = new int[3, 2] { { 7, 6 }, { 2, 1 }, { 5, 1 } };

            bool rightNum8 = false;
            do
            {
                Console.Write("Please enter a number:");
                string input8 = Console.ReadLine();
                rightNum8 = Int32.TryParse(input8, out num8);
            } while (rightNum8 == false);


            for (i8 = 0; i8 < 3; i8++)
            {
                for (j8 = 0; j8 < 2; j8++)
                {
                    if (num8 == num8_[i8, j8])
                    {
                        Console.WriteLine("Number {0} is found in the array at [{1},{2}]", num8, i8, j8);
                    }
                }
            }



        }
    }
}
