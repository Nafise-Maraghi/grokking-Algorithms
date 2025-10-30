static int[] SelectionSort(int[] numbers)
{
	for (int i = 0; i < numbers.Length - 1; i++)
	{
		for (int j = i+1; j < numbers.Length; j++)
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


SelectionSort(new int[] { 5, 2, 3, 1, 4 }); // { 1, 2, 3, 4, 5 }
SelectionSort(new int[] { 10, 20, 10, 20, 30 }); // { 10, 10, 20, 20, 30 }