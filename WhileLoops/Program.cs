// While loops

var i = 0;


Console.WriteLine("Using a while loop print numbers and whether they are even or odd 😊\n");

// dont forget to increment the iterator or the loop will never end
while (i <= 25) {
	Console.WriteLine(i);
	if (i % 2 == 0) {
		Console.WriteLine("Number is even!\n");
		i++;
	}
	else {
		Console.WriteLine("Number is odd!\n");
		i++;
	}
}