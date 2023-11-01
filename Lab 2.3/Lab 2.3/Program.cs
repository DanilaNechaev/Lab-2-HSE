namespace Lab2_3;
class Program
{
    static void Main()
    {
        int n;
        bool isCorrect;
        double sum = 0d;
        double sumN = 0d;
        do
        {
            Console.WriteLine("Введите значение n");
            string? inputNumber = Console.ReadLine();
            isCorrect = int.TryParse(inputNumber, out n);
            if (!isCorrect || n <= 0)
            {
                Console.WriteLine("Вы ввели некорректное значение. Введите целое положительное число");
            }
        } while (!isCorrect || n<= 0);

        for(int i = 1; i <= n; i++)
        {
            sumN = 1 / ((2 * (double)i + 1) * (2 * (double)i + 1));
            sum = sum + sumN;
        }
        Console.WriteLine($"Значение последовательности при заданном n равно {sum}");
    }
}
