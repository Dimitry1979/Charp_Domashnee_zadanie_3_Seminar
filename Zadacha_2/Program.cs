// Задача 2: Задайте массив на 10 целых чисел. Напишите программу,
// которая определяет количество чётных чисел в массиве.

int[] myArray = new int[10];
// Задаем размер массива

Random rand = new Random();

for(int i = 0; i < 10; i++)
    myArray[i] = rand.Next(1, 99);
// Заполняем массив случайными цифрами от 1 до 99 циклом for

for(int i = 1; i < 10; i++)
   Console.Write(myArray[i] + " ");
 // Выводим массив

 int count = 0;
 for (int i = 1; i < 10; i++)
 {
  if ((myArray[i] % 2) == 0)
    count++;
   }
Console.WriteLine();
Console.WriteLine($"\n Количество чётных чисел в массиве: {(count)}");
