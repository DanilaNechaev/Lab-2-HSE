namespace Lab2_2
{
    internal class Program
    {
        static void Main()
        {
            int count = 0;
            int l = -1;
            bool isCorrect;
            int number;
            do
            {
                do
                {
                    Console.WriteLine("Введите элемент последовательности");
                    string? inputNumber = Console.ReadLine();
                    isCorrect = int.TryParse(inputNumber, out number);
                    if (!isCorrect)
                    {
                        Console.WriteLine("Вы ввели некорректное значение. Введите целое число корректно");
                    }
                } while (!isCorrect);
                if (number % 2 == 0) { count++; }
                l++;
            } while (number != 0);
            if (l == 0)
            {
                Console.WriteLine("Последовательность пуста, в ней ноль четных чисел");
            }
            else
            {
                Console.WriteLine($"Количество четных чисел равно {count - 1}");
            }
        }
    }
}
