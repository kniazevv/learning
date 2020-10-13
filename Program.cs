using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindShortestWayArray
{
    class Program
    {

        readonly static int startPointx = 2;
        readonly static int startPointy = 4;
        readonly private static Random rnd;

        static Program()
        {
            rnd = new Random();
        }

        private static void Main(string[] args)
        {
            MultyDimArray();
  
        }

        private static void MultyDimArray()
        {
            string[,] myArray = new string[5, 5] 
            { 
                { "0", "1", "2", "3", "4" }, 
                { "0", "1", "2", "3", "4" }, 
                { "0", "1", "2", "3", "4" }, 
                { "0", "1", "2", "3", "4" }, 
                { "0", "1", "2", "3", "4" } 
            };


            int irndx = rnd.Next(myArray.GetLength(0));
            int irndy = rnd.Next(myArray.GetLength(0));

            Console.WriteLine("To Find : [{0} , {1}]", irndx, irndy);
            Console.WriteLine("Start Point : [{0} , {1}]", startPointx, startPointy);
            Console.WriteLine();

            myArray[irndx, irndy] = "||";

            if (startPointy < irndy)
            {
                for (int i = startPointy; i <= irndy; i++)
                {
                    myArray[startPointx, i] = "X";

                    if (irndx > startPointx)
                    {
                        for (int k = startPointx; k <= irndx; k++)
                        {
                            myArray[k, irndy] = "X";
                        }
                    }
                    else
                    {
                        for (int k = irndx; k <= startPointx; k++)
                        {
                            myArray[k, irndy] = "X";
                        }
                    }
                        
                }
            }
            else
            {
                for (int i = irndy; i <= startPointy; i++)
                {
                    myArray[startPointx, i] = "X";

                    if (irndx > startPointx)
                    {
                        for (int k = startPointx; k <= irndx; k++)
                        {
                            myArray[k, irndy] = "X";
                        }
                    }
                    else
                    {
                        for (int k = irndx; k <= startPointx; k++)
                        {
                            myArray[k, irndy] = "X";
                        }
                    }
                }
            }



            for (int i = 0; i < myArray.GetLength(0); i++)
            {

                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write($"\t{myArray[i, j]}");
                }
                Console.WriteLine();
            }

            

        Console.ReadLine();

        }
    }
}
 