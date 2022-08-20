// Напишите программу, которая задаёт массив из N элементов и выводит их на экран


int[] numbers = new int[5]; // если вводим массив из другого ко-ва элементов 5 меняем на заданное число
FillArray(numbers);
PrintArray(numbers);

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,10);
    }
}

 void PrintArray(int[] array)
 {
 
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
 }
