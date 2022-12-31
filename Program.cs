using static System.Console;
Clear();

string[] array = new string[] { "hello", "2", "world", ":-)" };
string[] array1 = new string[] { "1234", "1567", "-2", "computer science" };
string[] array2 = new string[] { "Russia", "Denmark", "Kazan" };

var resultArr = array.Where(x=>x.Length < 3).ToArray();
var resultArr1 = array1.Where(x=>x.Length < 3).ToArray();
var resultArr2 = array2.Where(x=>x.Length < 3).ToArray();

var str = string.Join(", ", resultArr);
var str1 = string.Join(", ", resultArr1);
var str2 = string.Join(", ", resultArr2);

WriteLine("Result first = " + str);
WriteLine("Result second = " + str1);
WriteLine("Result third = " + str2);