using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
	internal class SelectionSort
	{
		public static int[] Run(int[] numbers)
		{
			for (int i = 0; i < numbers.Length - 1; i++)
			{
				for (int j = i + 1; j < numbers.Length; j++)
				{
					if (numbers[j] < numbers[i])
					{
						int a = numbers[i], b = numbers[j];
						numbers[i] = b;
						numbers[j] = a;
					}
				}
			}
			return numbers;
		}
	}
}
