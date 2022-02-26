Console.WriteLine("Generate a random password! 🔐");
Console.WriteLine("How many characters do you want your password to be?");

int passwordLength = Convert.ToInt32(Console.ReadLine());

var random = new Random();

Console.WriteLine("\nThank you! 🤗 Here is your password:\n");

char[] randomPasswordArr = new char[passwordLength];

for (var i = 0; i < passwordLength; i++) {
	randomPasswordArr[i] = (char)('a' + random.Next(0, 26));
}

string randomPassword = new string(randomPasswordArr);

Console.WriteLine(randomPassword);