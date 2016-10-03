using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomeWork1
{




    class Program
    {
        static void Main(string[] args)
        {
            DoCalculateArea();

            LoopFun(5);
            // DisplayNumbers();
            // DisplayStuff(5);

            //int result = TotalSum(Num1, Num2);
            //Console.WriteLine("The total is " + result);

            int[] myArray = { 8, 2, 21, 45, 22, 5, 2, 4 };

            int result = FindtheMax(myArray);
            Console.WriteLine("The Max is  " + result);

            result = FindtheMin(myArray);
            Console.WriteLine("The Min is  " + result);


            decimal theResult = FindtheAverage(myArray);
            Console.WriteLine("The Average is  " + theResult);
            Console.ReadLine();
        }



        static int FindtheMax(int[] theArray)
        {
            int myMax = 0;
            for (int counter = 0; counter < theArray.Length; counter++)
            {
                if (myMax < theArray[counter])
                {
                    myMax = theArray[counter];

                }
                Console.Write(theArray[counter] + " ");
            }
            return myMax;



        }

        static int FindtheMin(int[] theArray)
        {
            int myMin = theArray[0];
            for (int counter = 0; counter < theArray.Length; counter++)
            {
                if (myMin > theArray[counter])
                {
                    myMin = theArray[counter];

                }
                Console.Write(theArray[counter] + " ");
            }
            return myMin;



        }

        static decimal FindtheAverage(int[] theArray)
        {
            int theTotal = 0;
            foreach (int num in theArray)
            {
                theTotal += num;
            }
            string Result = string.Format("Total {0} Number of elements {1}", theTotal, theArray.Length);
            Console.WriteLine(Result);
            return theTotal / theArray.Length;

        }


        static void DoCalculateArea()
        {

            int theHeight;
            int theWidth;
            theHeight = 20;
            theWidth = 17;
            int result = CalculateArea(theHeight, theWidth);
            Console.WriteLine("The total area of the square is " + result);


        }

        static int CalculateArea(int myHeight, int myWidth)
        {
            int TotalArea = myHeight * myWidth;
            return TotalArea;

        }


        static void DisplayStuff(int TotalNumber)
        {

            for (int OuterCounter = 1; OuterCounter <= TotalNumber; OuterCounter++)
            {
                for (int counter = 1; counter <= 5; counter++)
                {
                    Console.Write(counter * OuterCounter + "  ");
                }
                Console.WriteLine();
            }
        }










        #region Old code


        static int Max(int[] theArray)
        {
            int myMax = 0;

            for (int counter = 0; counter < theArray.Length; counter++)
            {
                if (myMax < theArray[counter])
                {
                    myMax = theArray[counter];
                }
                Console.Write(theArray[counter] + "  ");

            }
            return myMax;
        }


        static void DisplayNumbers()
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int counter = 1; counter <= 5; counter++)
                {
                    Console.Write(counter * i + "  ");

                }
                Console.WriteLine();
            }


        }


        static void LoopFun(int EndNumber)
        {
            for (int i = 1; i <= EndNumber; i++)
            {
                for (int counter = 1; counter <= 5; counter++)
                {

                    Console.Write(counter * i + "  ");

                }
                Console.WriteLine();
            }
        }
        static void DoTotalSum()
        {
            int Num1;
            int Num2;
            Num1 = 200;
            Num2 = 390;
            int result = TotalSum(Num1, Num2);
            Console.WriteLine("The total is " + result);
            Console.ReadLine();



        }




        static int TotalSum(int myNum1, int myNum2)
        {
            int Total = myNum1 + myNum2;
            return Total;
        }
        static int GetTotal(int myNum1, int myNum2)
        {
            int Total = myNum1 + myNum2;

            return Total;

        }
        static int AddItUp(int num1, int num2)
        {
            int Total = num1 + num2;

            return Total;

        }
        #endregion

    }
}
