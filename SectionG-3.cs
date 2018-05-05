using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5
{
    class test
    {
        static void Main(string[] args)
        {

            int i3 =0, j3=0;
            string input;

            int countStu = 0;
            Console.Write("Please enter the number of students:");//后期改do...while loop弥补输入字符错误
            int number_stu= Int32.Parse(Console.ReadLine());
            string[] name = new string[number_stu];
            for(countStu=0; countStu<number_stu; countStu++)
            {
                Console.Write("Please enter student's name:");
                input = Console.ReadLine();
                name[countStu] = input;
            }
 

            int countSub = 0;
            Console.Write("Please enter the number of subjects:");
            int number_sub = Int32.Parse(Console.ReadLine());
            string[] subject=new string[number_sub];
            for (countSub = 0; countSub < number_sub; countSub++)
            {
                Console.Write("Please enter subject's name:");
                input = Console.ReadLine();
                subject[countSub] = input;
            }


            //自动生成成绩
            Random r3 = new Random();
            double[,] marks = new double[countStu, countSub];
            for (i3 = 0; i3 < countStu; i3++)
            {
                for (j3 = 0; j3 < countSub; j3++)
                {
                    marks[i3, j3] = r3.Next(0, 100);
                    //Console.Write("Please enter student's marks in subject {0}:", j3);
                }
            }

            //打印表头（行一）
            Console.Write("\t Name\t");
            for (j3 = 0; j3 < countSub; j3++)
            {
                Console.Write("{0}\t", subject[j3]);
            }
            Console.WriteLine("Total\tAvg");

            //生成其他成绩
            //每个学生4个学科总成绩
            double[] everyStuTotal = new double[countStu];
            for (i3 = 0; i3 < countStu/*marks.GetLength(0)*/; i3++)
            {
                for (j3 = 0; j3 < countSub/*marks.GetLength(1)*/; j3++)
                {
                    everyStuTotal[i3] = everyStuTotal[i3] + marks[i3, j3];
                    //Console.WriteLine(everyStuTotal[i3]);
                }
            }

            //每个人各科平均成绩
            double[] averageStu = new double[countStu];
            for (i3 = 0; i3 < countStu; i3++)
            {
                for (j3 = 0; j3 < countSub; j3++)
                {
                    averageStu[i3] = Math.Round(everyStuTotal[i3] / countSub, 2);
                    //Console.Write(string.Join("\t", averageStu[i3]));
                }
            }

            //
            //打印后面成绩
            for (i3 = 0; i3 < countStu; i3++)
            {
                Console.Write("{0}\t{1} ", i3+1, name[i3]);
                for (j3 = 0; j3 < countSub; j3++)
                {
                    Console.Write("\t {0}", marks[i3, j3]);
                    if (j3 == countSub - 1)
                    {
                        //打印每个学生4个学科总成绩
                        Console.Write("\t" + everyStuTotal[i3]);
                        //打印每个人各科平均成绩
                        Console.WriteLine("\t"+ averageStu[i3]);
                    }

                }

            }


            Console.WriteLine("Per subject:");
            //打印各科成绩全班总和
            Console.Write("total marks");
            double[] everySubTotal = new double[countSub];
            for (j3 = 0; j3 < countSub; j3++)
            {
                for (i3 = 0; i3 < countStu; i3++)
                {
                    everySubTotal[j3] = everySubTotal[j3] + marks[i3, j3];
                }
                Console.Write("\t" + everySubTotal[j3]);
            }
            Console.WriteLine();


            //打印各科平均成绩
            Console.Write("average mark");
            double[] average = new double[countSub];
            for (j3 = 0; j3 < countSub; j3++)
            {
                average[j3] = everySubTotal[j3] / countStu;
                Console.Write("\t" + average[j3]);
            }
            Console.WriteLine();

            //打印各科成绩标准差
            Console.Write("standard dev");
            double[,] D = new double[countStu, countSub];
            double[,] D_2 = new double[countStu, countSub];
            double[] sumD = new double[countSub];
            double[] SD = new double[countSub];
            for (j3 = 0; j3 < countSub; j3++)
            {
                for (i3 = 0; i3 < countStu; i3++)
                {
                    D[i3, j3] = marks[i3, j3] - average[j3];
                    D_2[i3, j3] = Math.Pow(D[i3, j3], 2);
                    sumD[j3] = sumD[j3] + D_2[i3, j3];
                }
                SD[j3] = Math.Round(sumD[j3] / countStu, 2);
                Console.Write("\t"+ SD[j3]);
            }
            Console.WriteLine();











        }
    }
}
