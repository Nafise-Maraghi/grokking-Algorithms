using Algoritms;


BinarySearch.Run(43, Enumerable.Range(0, 100).ToArray()); // 43 
BinarySearch.Run(12, Enumerable.Range(1, 10).ToArray()); // -1

RecursiveBinarySearch.Run(12, Enumerable.Range(1, 10).ToArray()); // -1
RecursiveBinarySearch.Run(3, new int[] { 1, 3, 5, 7 }); // 1

SelectionSort.Run(new int[] { 5, 2, 3, 1, 4 }); // { 1, 2, 3, 4, 5 }

QuickSort.Run(new List<int> { 3, 5, 2, 1, 4 });  // { 1, 2, 3, 4, 5 }
