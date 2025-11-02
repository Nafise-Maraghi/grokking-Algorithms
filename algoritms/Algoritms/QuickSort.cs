using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
	internal class QuickSort
	{
		public static List<int> Run(List<int> numbers)
		{
			if (numbers.Count < 2)
			{
				return numbers;
			}
			int pivot = numbers[0];
			numbers.RemoveAt(0);
			List<int> lower = new List<int> { };
			List<int> higher = new List<int> { };

			foreach (int n in numbers)
			{
				if (n > pivot)
				{
					higher.Add(n);
				}
				else
				{
					lower.Add(n);
				}
			}
			return Run(lower).Concat(new List<int> { pivot }).Concat(Run(higher)).ToList();
		}
	}
}
