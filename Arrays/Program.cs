var numbers = new int[] {3, 7, 9, 2, 14, 6};

// Length
Console.WriteLine("Length: " + numbers.Length);

// IndexOf()
var index = Array.IndexOf(numbers, 9);
Console.WriteLine("Index of 9 is: " + index);

// Clear
Array.Clear(numbers, 0, 2);

Console.WriteLine("\nEffect of clear:");
foreach (var number in numbers) {
	Console.Write(number + ", ");
}

// Copy()
Console.WriteLine("\n\nCopy of numbers:");
int[] another = new int[3];
Array.Copy(numbers, another, 3);

foreach (var number in another) {
	Console.Write(number + ", ");
}

// Sort()
Array.Sort(numbers);
Console.WriteLine("\n\nSorted numbers:");
foreach (var number in numbers) {
	Console.Write(number + ", ");
}

// Reverse()
Array.Reverse(numbers);
Console.WriteLine("\n\nReversed numbers:");
foreach (var number in numbers) {
	Console.Write(number + ", ");
}
