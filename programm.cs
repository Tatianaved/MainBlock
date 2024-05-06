sing System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя ввод элементов массива через запятую
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();
        
        // Разделяем введенную строку на массив строк по запятой
        string[] array = input.Split(',');

        // Создаем новый массив для хранения строк длиной не более 3 символов
        string[] result = new string[array.Length]; // Максимальный размер массива
        int count = 0; // Счетчик элементов нового массива
       
        // Проходим по исходному массиву
        foreach (string str in array)
        {
            // Если длина текущей строки не превышает 3 символа, добавляем ее в новый массив
            if (str.Length <= 3)
            {
                result[count++] = str;
            }
        }

        // Создаем массив нужного размера и копируем в него результаты
        string[] finalResult = new string[count];
        Array.Copy(result, 0, finalResult, 0, count);
        
         // Выводим результат
        Console.Write("[");
        for (int i = 0; i < finalResult.Length; i++)
        {
            Console.Write("\"" + finalResult[i] + "\"");
            if (i < finalResult.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}

