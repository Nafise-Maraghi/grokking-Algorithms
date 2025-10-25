static int BinarySearch(int item, int[] numbers)
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
		else // the item is found
		{
			return mid;
		}
	}

	// the item does not exist in the numbers
	return -1;
}


Console.WriteLine(BinarySearch(43, Enumerable.Range(0, 100).ToArray())); // 43
Console.WriteLine(BinarySearch(12, Enumerable.Range(1, 10).ToArray())); // -1