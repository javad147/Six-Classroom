//static string ReverseStr(string str) 
//{
//    string result = string.Empty;
//    for (var i = str.Length - 1; i >= 0; i--)
//    {
//        result += str[i];
//    }
//    return result;
//}

//Console.WriteLine(ReverseStr("Semed"));

//static string UpperStringFirstChar(string str) 
//{
//    string name = char.ToUpper(str[0]) + str.Substring(1);
//    return name;
//}
//Console.WriteLine(UpperStringFirstChar("ali"));

//static string UpperStringFirstChar(string str) => char.ToUpper(str[0]) + str.Substring(1);
//Console.WriteLine(UpperStringFirstChar("ali"));

//static string FirstElementToUpper(string str) 
//{
//    char[] charArray = str.ToCharArray();
//    string firstChar = charArray[0].ToString.ToUpper();
//    foreach (char c in charArray) 
//    {
//        Console.WriteLine(item);
//    }
//    return "";

//}
//FirstElementToUpper("semed");


//static string FirstElementToUpper(string str)
//{
//    char[] charArray = str.ToCharArray();
//    string firstChar = charArray[0].ToString.ToUpper();
//    charArray[0] = Console.ToChar(firstChar);
//    string result = string.Empty;
//    foreach (char item in charArray)
//    {
//        result += item;
//    }
//    return "";
//}
//Console.WriteLine(FirstElementToUpper("semed");

//using System.Text;

//StringBuilder stringBuilder = new StringBuilder("Azer");

//stringBuilder.Append("baycan");

//Console.WriteLine(stringBuilder.ToString());

//int[] ages = { 12, 13, 55 };

//int[] ages2 = new int[5];

//int[] ints = new int[5] { 1, 2, 3, 4, 5 };

using StringBuilder;
using System.Globalization;

int[] nums = { 1, 2, 3, 4, 5, 6 };
//Console.WriteLine(nums.Length);

//foreach (int num in nums)
//{
//    Console.WriteLine(item);
//}

//var result = nums.Sum(x => x);
//Console.WriteLine(result);

//using System.Globalization;

//var result = Array.Rank; 

//Array.Sort(nums);

//Array.Reverse(nums);

//var newArr = nums.Clone();

//int newArr = { 1, 2, 3 };

//nums.CopyTo().To(nums, 0);

//foreach (var item in nums) 
//{
//    Console.WriteLine(item);

//}


//int[] nums = { 10, 2, 3, 4, 5, 6 };

//int[] newArr = { 1, 2, 3 };

//int arrayCount = newArr.Length;
//Array.Resize(ref newArr, nums.Length + newArr.Length);

//nums.CopyTo(newArr, arrayCount);

//foreach (int item in newArr) 
//{
//    Console.WriteLine(item);

//}

//static int[] CopyToArray(int[] destination, int[] source) 
//{
//int destinationLenght = destination.Length;
//    Array.Resize(ref destination, source.Length + destinationLenght);
//    source.CopyTo(destination, destinationLenght);
//    return destination;

//}

//int[] arr1 = { 2, 3, 4, 5, };

//int[] arr2 = { 100, 200, 300 };

//var result = CopyToArray(arr1, arr2);

//foreach (int item in result)
//{
//    Console.WriteLine(item);
//}

//int[] numbers = { 2, 3, 4, 5, 6 };

//var result = Array.Exists(numbers, x => x % 2 == 1);
//var result = Array.Find(numbers,  x => x % 2 == 1);
//var result = Array.FindAll(numbers, x => x % 2 == 1);

//foreach (int item in result) 
//{
//    Console.WriteLine(item);

//}

//int[] numbers = { 2, 3, 4, 1, 5, 6, 1 };

//var result = numbers.OrderByDescending(x => x);
//foreach (int item in result) 
//{
//    Console.WriteLine(item);
//}

//var result = numbers.OrderByDescending(m => x m==3);
//Console.WriteLine(item);

//var result = numbers.Contains(5);

//var resul = numbers.Max();
//var resul = numbers.Max();

//var result = NumberStyles.Where(x => x % 2 == 0).Sum(m => m);

//foreach (item x in result) 
//{
//    Console.WriteLine(item);

//}

//var result = NumberStyles.Where(x=> x % 2 == 0)

//    foreach (var item in result)
//    {
//    Console.WriteLine(item);
//    }


//string name1 = "Tunzale";
//string surname1 = "Memmeodova";
//string email1 = "tunzale@gmail.com";

//string name2 = "Arzu";
//string surname2 = "Kerimova";
//string email2 = "arzu@gmail.com";

//string name3 = "Ilham";
//string surname3 = "Abbasli";
//string email3 = "ilham@gmail.com"

//    var stu1 = new
// {
//    name = "Tunzale",
//    surname = "Memmeodva",
//    email = "tunzale@gmail.com"
//  };

//var stu2 = new
//{
//    name = "Arzu",
//    surname = "Kerimova",
//    email = "arzu@gmail.com"
//};

//var stu3 = new
//{
//    name = "Ilham",
//    surname = "Abbasli",
//    email = "ilham@gmail.com"
//};


//using Object_Class;

//Student student = new Student();
//stu1.name = "Tofig";
//stu1.surname = "Nesibli";
//stu1.email = "tofig@gmail.com";
//stu1.age = "18"
//Console.WriteLine(stu1.name);

//Student stu2 = new Student();
//stu2 name= "Rufet";
//Console.WriteLine(stu2.name);

//Console.WriteLine(stu1.name + " " + stu1.surname);
//Console.WriteLine(stu2.name+ " " + stu2 surname);

//stu1.GetfullName();
//stu1.GetFullData();

//stu2.GetFullName();
//stu2.GetFullData();

//using Object_Class;



//Clalculate clalculate = new ();
//int sum = clalculate.Sum(10, 15);


//Console.WriteLine(sum);
