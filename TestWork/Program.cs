using System;
using System.Collections.Generic;
using System.Linq;

namespace TestWork
{
    class Program
    {
        public static void Main(String[] args)
        {
            WorkWithArray workWithArray = new WorkWithArray();

            double[] test = {2,3,6,8};

            workWithArray.PrintArray(test, "Array");

            workWithArray.PrintArray(workWithArray.PasteBetweenElements(test), "Array with new elements");

            Arrays arrays = workWithArray.DivisionArray(test);

            workWithArray.PrintArray(arrays.FirstArray, "First part of the array");
            workWithArray.PrintArray(arrays.SecondtArray, "Second part of the array");

            Console.ReadLine();
        }
    }
}

      

