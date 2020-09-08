using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestWork
{
    class WorkWithArray : IWorkWithArray
    {
        public Arrays DivisionArray(double[] nums)
        {
            #region CheckData
            if (nums == null)
            {
                throw new Exception("Array can`t be empty");
            }
            else if (nums.Length == 1)
            {
                return new Arrays(1) { FirstArray = nums, SecondtArray = nums };
            }
            #endregion CheckData

            Array.Sort(nums);

            int point = PointThatDivide(nums); 

            if (point != -1 && point != nums.Length) // Can be divided into 2 equal parts or not
            {
                Arrays arrays = new Arrays(point, nums.Length - point);

                arrays.FirstArray = nums.Take(point).ToArray();
                arrays.SecondtArray = nums.Skip(point).ToArray();

                return arrays;
            }
            else
                return GreedyAlgotithm(nums); // Else use greedy algorithm
        }

        static int PointThatDivide(double[] arr)
        {
            double leftSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                leftSum += arr[i];
            } 

            double rightSum = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                rightSum += arr[i];

                leftSum -= arr[i];

                if (rightSum == leftSum)
                {
                    return i;
                }                    
            }
            return -1;
        }

        private static Arrays GreedyAlgotithm(double[] nums)
        {
            Arrays arrays = new Arrays(nums.Length / 2);

            for (int i = 0, j = 0, k = 0; i < nums.Length; i++)
            {
                if (arrays.FirstArray.Sum() > arrays.SecondtArray.Sum())
                {
                    if (arrays.SecondtArray.Length <= j)
                    {
                        Array.Resize(ref arrays.SecondtArray, j + 1);
                    }
                    arrays.SecondtArray[j++] = nums[i];
                }
                else
                {
                    if (arrays.FirstArray.Length <= k)
                    {
                        Array.Resize(ref arrays.FirstArray, k + 1);
                    }
                    arrays.FirstArray[k++] = nums[i];
                }
            }

            return arrays;
        }

        public double[] PasteBetweenElements(double[] nums)
        {
            #region Check
            if (nums == null)
            {
                throw new Exception("Array can`t be empty");
            }
            else if (nums.Length == 1)
            {
                return nums;
            }
            #endregion Check

            double[] sumArray = new double[nums.Length - 1];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                sumArray[i] = (nums[i] + nums[i + 1]) / 2;
            }

            double[] newArray = new double[nums.Length + sumArray.Length];

            for (int q = 0, i = 0; q < nums.Length; ++q)
            {
                newArray[i++] = nums[q];

                if (q < sumArray.Length)
                {
                    newArray[i++] = sumArray[q];
                }
            }

            return newArray;
        }

        public void PrintArray(double[] nums, string msg)
        {
            Console.WriteLine(msg);
            foreach (var item in nums)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();
        }
    }
}
