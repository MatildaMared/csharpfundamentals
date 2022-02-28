

// IndexOf()
// LastIndexOf()

// Substring(startIndex)
// Substring(startIndex, length)

// Replace(oldValue, newValue)

// String.IsNullOrEmpty(str)
//String.IsNullOrWhiteSpace(str)

// str.Split()

// Converting strings to numbers
// int.Parse(str)
// Convert.ToInt32(str)

// ToLower()
// ToUpper()
// Trim()

using Strings;

var fullName = "Matilda Mared     ";
Console.WriteLine($"Trim: '{fullName.Trim()}'");
Console.WriteLine("ToUpper: {0}", fullName.ToUpper());
Console.WriteLine("ToLower: {0}", fullName.ToLower());

var indexOfWhiteSpace = fullName.IndexOf(' ');
var firstName = fullName.Substring(0, indexOfWhiteSpace);
var lastName = fullName.Substring(indexOfWhiteSpace + 1);
Console.WriteLine($"First name: {firstName}");
Console.WriteLine($"Last name: {lastName}");

var names = fullName.Split(' ');
Console.WriteLine("First name: " + names[0]);
Console.WriteLine("Last name: " + names[1]);

var replaced = fullName.Replace("Mat", "Ros");
Console.WriteLine("After replace: " + replaced);

var userInput = "25";
var age = Convert.ToInt32(userInput);

// Summarizing text

var sentence = "This is going to be a really really really super duper extra very long text.";
var summary = StringUtility.SummarizeText(sentence, 25);
Console.WriteLine(summary);
