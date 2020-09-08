using System;
using System.Collections.Generic;
using System.Text;

namespace TestWork
{
    class Arrays
    {
        public double[] FirstArray;

        public double[] SecondtArray;

        public Arrays(int lengthForFirst, int lengthForSecond)
        {
            FirstArray = new double[lengthForFirst];
            SecondtArray = new double[lengthForSecond];
        }

        public Arrays(int length)
        {
            FirstArray = new double[length];
            SecondtArray = new double[length];
        }
    }
}
