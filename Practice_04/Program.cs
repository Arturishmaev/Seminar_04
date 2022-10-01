string name = "Bob";
int age = 35;

System.Console.WriteLine("Имя: " + name + " возраст : " + age);
System.Console.WriteLine($"Имя: {name} возраст :  {age}");

string name1 = name + "!!!";
System.Console.WriteLine(name1);

string name2 = String.Concat(name, "!!!");
System.Console.WriteLine(name2);

string a = "abc";
string b = "fge";

if (a == b)
{
    System.Console.WriteLine("Yes");
}
else{System.Console.WriteLine("No");}

//Задача 24: Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
System.Console.WriteLine("Введите Ваше число :");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = 1; i <= num; i++)
{
    result = result + i;
}
System.Console.WriteLine(result);

// Задача 26: Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

 System.Console.WriteLine("Введите Ваше число :");
 int num1 = Convert.ToInt32(Console.ReadLine());
 int i = 0;
 while (num1 > 0)
 {
     num1 = num1 / 10;
     i++;

 }
 System.Console.WriteLine(i);


//  Задача 28: Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

System.Console.WriteLine("Введите Ваше число :");
int N = Convert.ToInt32(Console.ReadLine());
int result = 1;
int i = 1;
for (; i <= N; i++)
{
    result = result * i;
}
System.Console.WriteLine(result);

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненый нулями и единицами в случайном порядке.



int[] array = new int[8];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.Write($"  {col[position]}");
        position++;
    }
}
FillArray(array);
PrintArray(array);







