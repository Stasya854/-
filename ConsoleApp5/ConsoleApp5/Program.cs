using System;

struct HockeyPlayer
{
    public string LastName;
    public int Age;
    public int GameCount;
    public int GoalsMissedCount;
}

class Program
{
    static void Main()
    {
        // Создаем массив хоккеистов
        HockeyPlayer[] players = new HockeyPlayer[5];

        // Вводим данные о хоккеистах
        for (int i = 0; i < players.Length; i++)
        {
            Console.WriteLine("Введите данные о хоккеисте №" + (i + 1));

            Console.Write("Фамилия: ");
            players[i].LastName = Console.ReadLine();

            Console.Write("Возраст: ");
            players[i].Age = int.Parse(Console.ReadLine());

            Console.Write("Количество игр: ");
            players[i].GameCount = int.Parse(Console.ReadLine());

            Console.Write("Количество пропущенных шайб: ");
            players[i].GoalsMissedCount = int.Parse(Console.ReadLine());

            Console.WriteLine();
        }

        // Считаем средний возраст хоккеистов
        double averageAge = 0;
        for (int i = 0; i < players.Length; i++)
        {
            averageAge += players[i].Age;
        }
        averageAge /= players.Length;

        // Выводим сведения о хоккеистах, возраст которых больше 25 лет
        Console.WriteLine("Средний возраст хоккеистов: " + averageAge);
        Console.WriteLine("Хоккеисты старше 25 лет:");
        for (int i = 0; i < players.Length; i++)
        {
            if (players[i].Age > 25)
            {
                Console.WriteLine("Фамилия: " + players[i].LastName);
                Console.WriteLine("Возраст: " + players[i].Age);
                Console.WriteLine("Количество игр: " + players[i].GameCount);
                Console.WriteLine("Количество пропущенных шайб: " + players[i].GoalsMissedCount);
                Console.WriteLine();
            }
        }

        Console.ReadLine();
    }
}
