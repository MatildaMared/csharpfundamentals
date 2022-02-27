var numbers = new List<int>() {1, 2, 3, 4};

// Add
numbers.Add(1);

// Add range
numbers.AddRange(new int[3] {6, 7, 8});

Console.Write("Numbers list: ");
foreach (var number in numbers) {
	Console.Write(number + " ");
}

Console.WriteLine("\nIndex of 1: " + numbers.IndexOf(1));
Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));
Console.WriteLine("Count: " + numbers.Count);

for (var i = 0; i < numbers.Count; i++) {
	if (numbers[i] == 1) {
		numbers.Remove(numbers[i]);	
	}
}

Console.Write("Numbers after removing 1: ");
foreach (var number in numbers) {
	Console.Write(number + " ");
}
