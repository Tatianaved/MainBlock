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
