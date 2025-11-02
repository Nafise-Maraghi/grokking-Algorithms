using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
	internal class RecursiveBinarySearch
	{
		public static int Run(int item, int[] numbers)
		{
			int low = 0;
			int high = numbers.Length - 1;
			int mid = (low + high) / 2;

			if (low > high)
			{
				return -1;
			}

			if (item > numbers[mid])
			{
				low = mid + 1;
			}
			else if (item < numbers[mid])
			{
				high = mid - 1;
			}
			else
			{
				return mid;
			}

			return Run(item, numbers[low..(high + 1)]) + low;
		}
	}
}
