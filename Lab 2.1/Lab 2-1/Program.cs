namespace Lab2_1
{
    internal class Program
    {
        static void Main()
        {
            int numberMin = int.MaxValue;
            int n;
            int number;
            int countMin = 1;
            bool isCorrect1;
            bool isCorrect2;
            do
            {
                Console.WriteLine("Введите количество чисел в последовательности");
                string? inputN = Console.ReadLine();
                isCorrect1 = int.TryParse(inputN, out n);
                if (!isCorrect1 || n < 0)
                {
                    Console.WriteLine("Вы ввели неподходящее значение n. Введите целое положительное число\n");
                }
                if (n == 0 && isCorrect1)
                {
                    Console.WriteLine("Длина последовательности равна нулю, в ней нет минимального элемента");
                }
            } while (!isCorrect1 || n < 0);

            for(int i = 0; i < n; i++)
            {
                do
                {
                    Console.WriteLine("Введите элемент последовательности - целое число");
                    string? inputNubmer = Console.ReadLine();
                    isCorrect2 = int.TryParse(inputNubmer, out number);
                    if (!isCorrect2)
                    {
                        Console.WriteLine("Вы ввели неподходящее значение элемента последовательности. Введите корректное целое число");
                    }
                } while (!isCorrect2);
                if(number < numberMin)
                {
                    numberMin = number;
                    countMin = i + 1;
                }
            } 
            if(n!=0)
            {
                Console.WriteLine($"Номер первого встреченного минимального элемента равен {countMin}");
            }
        }
    }
}
