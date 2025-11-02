using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
	internal class BinarySearch
	{
		public static int Run(int item, int[] numbers)
		{
			int low = 0;
			int high = numbers.Length - 1;

			while (low <= high)
			{
				int mid = (low + high) / 2;
				if (item < numbers[mid])
				{
					high = mid - 1;
				}
				else if (item > numbers[mid])
				{
					low = mid + 1;
				}
				else
				{
					return mid;
				}
			}
			return -1;
		}
	}
}
