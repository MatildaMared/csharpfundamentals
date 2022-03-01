// Working with Files and directories

var path = @"/Users/matildamared/Documents/programming/c#/CSharpFundamentals/Files/test.txt";

File.Create(path);

var fileInfo = new FileInfo(path);

if (fileInfo.Exists) {
	Console.WriteLine("This file exists!");
}

var pathToProject = @"/Users/matildamared/Documents/programming/c#/CSharpFundamentals";

var directories = Directory.GetDirectories(pathToProject, "*.*", SearchOption.AllDirectories);

foreach (var directory in directories) {
	Console.WriteLine(directory);
}