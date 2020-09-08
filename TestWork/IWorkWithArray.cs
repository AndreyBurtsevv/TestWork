using System;
using System.Collections.Generic;
using System.Text;

namespace TestWork
{
    interface IWorkWithArray
    {
        public void PrintArray(double[] nums, string msg);

        public Arrays DivisionArray(double[] nums);

        public double[] PasteBetweenElements(double[] nums);
    }
}
