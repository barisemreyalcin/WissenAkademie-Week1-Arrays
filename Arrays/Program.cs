#region Arrays
// DataType[] varName = { var1, var2, var3, ... }
// DataType[] varName = new DataType{ numberOfElements }

//string[] names = new string[3] {"Emre", "Enes", "Mustafa"};

//string[] names = {"Emre", "Enes", "Mustafa"};
//Console.WriteLine(names.Length);
//Console.WriteLine(names[0]);
//Console.WriteLine(names[5]); // IndexOutOfRangeException

//string[] players = new string[3];
//players[0] = "Kobe";
//players[1] = "Allen";
//players[2] = "Vince";

//foreach(string player in players)
//{
//    Console.WriteLine(player);
//}

//for (int i = 0; i < players.Length; i++)
//{
//    Console.WriteLine(players[i]);
//}

//string text = "I missed you";
//string[] words = text.Split(' ');
//foreach (string word in words)
//{
//    Console.WriteLine(word);
//}

//int[] numbers = { 10, 20, 5, 85, 32, 15, 23 };
//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}

//Array.Sort(numbers);
//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}

//Array.Reverse(numbers);
//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}

#endregion

#region HOMEWORK
// TASK: Kullanıcının gireceği adet kadar tam sayıları alıp bir dizi oluşturduktan sonra dizi elemanları küçükten büyüğe ve büyükten küçüğe sıralamasını yapıp ekrana yazdıran program
Console.Write("Enter the length of the array: ");
int count = int.Parse(Console.ReadLine());
int[] numbers = new int[count];
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Enter your array's {i + 1}. element: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

// Descending
for(int i = 0; i < numbers.Length - 1; i++)
{
    for(int j = 0; j < numbers.Length - 1 - i; j++)
    {
        if (numbers[j] < numbers[j + 1])
        {
            int temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }
}

Console.WriteLine("Descending order: ");
foreach(int number in numbers)
{
    Console.WriteLine(number);
}

// Ascending
for(int i = 0; i < numbers.Length - 1; i++)
{
    for(int j = 0; j < numbers.Length - 1 - i; j++)
    {
        if (numbers[j] > numbers[j + 1])
        {
            int temp = numbers[j];
            numbers[j] = numbers[j +1];
            numbers[j + 1] = temp;
        }
    }
}

Console.WriteLine("Ascending order: ");
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
#endregion