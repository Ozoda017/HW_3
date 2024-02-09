// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.

while (true) 
{
Console.Write("Введите текс: ");
string text = Console.ReadLine();
if (text == "q")
{
break;
}
int number; 
if (int.TryParse(text, out number))
{
int sum = 0;
while(number > 0)
{
sum += number % 10; 
number /= 10; 
}
if (sum % 2 == 0)
{
break;
}
}
}


// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве

// [344 452 341 125] => 2

 int[] CreateArray(int size)//создаем массив
{
     int[] array = new int[size]; //массив на size элементов
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = new Random().Next(100, 1000); //массив с случайными трехзначными числами
    }
    return array;

}

 int CountEvenItems(int[] array)//массив с четными числами
 {
    int count = 0; 
    for (int i = 0; i < array.Length; i++)
     {
        
         if (array[i] % 2 == 0)
         {
             count++;
         }
    }
    return count;
}

Console.Write("Введите число: ");
int RandomNumbers = Convert.ToInt32(Console.ReadLine());
int[] result = CreateArray(RandomNumbers); // Создали массив из случайных элементов
Console.WriteLine($"Массив: [ {string.Join("; ", result)} ]");//созданный массив
Console.WriteLine($"Результат: {CountEvenItems(result)}");//нахождение четного числа в массиве


// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

int[] arrays = {1, 3, 5, 6, 7, 8}; 
int temp;
for (int i = 0; i < arrays.Length / 2; i++)
{
temp = arrays[i];
arrays[i] = arrays[arrays.Length - 1 - i];
arrays[arrays.Length - 1 - i] = temp;
}
Console.Write("Перевернутый массив: ");
foreach (int array in arrays)
{
Console.Write(array + " ");
}
