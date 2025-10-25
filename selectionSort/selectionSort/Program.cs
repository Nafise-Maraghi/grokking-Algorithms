static int Minimum(int[] numbers)
{
	int min = numbers[0];

	foreach (int n in numbers)
	{
		if (n < min)
		{
			min = n;
		}
	}
	return min;
}

static int[] SelectionSort(int[] numbers)
{
	int[] sortedNumbers = new int[numbers.Length];
	List<int> arrayCopy = new List<int>(numbers);

	for (int i=0; i < numbers.Length; i++)
	{
		int min = Minimum(arrayCopy.ToArray());
		sortedNumbers[i] = min;
		arrayCopy.Remove(min);
	}
	return sortedNumbers;
}


SelectionSort(new int[] { 5, 4, 3, 1, 2 }); // { 1, 2, 3, 4, 5 }
SelectionSort(new int[] { 10, 20, 10, 20, 30 }); // { 10, 10, 20, 20, 30 }