using System;

class Program
{
    static void Main(string[] args)
    {
        // Вводим переменные
        Console.Write("Введите имеющиеся деньги: ");
        int money = int.Parse(Console.ReadLine());

        Console.Write("Введите цену за шоколадку: ");
        int price = int.Parse(Console.ReadLine());

        Console.Write("Введите количество обёрток, нужное, чтобы получить ещё одну шоколадку: ");
        int wrap = int.Parse(Console.ReadLine());

        // Считаем, сколько шоколадок можно купить за имеющиеся деньги
        int chocolates = money / price;

        // Вычисляем, сколько шоколадок можно получить за обертки
        int extraChocolates = chocolates / wrap;

        // Считаем, сколько остаточных оберток будет
        int remainingWraps = chocolates % wrap;

        // Добавляем шоколадки, получаемые за обертки,
        // и учитываем остаточные обертки
        chocolates += extraChocolates;
        remainingWraps += extraChocolates;

        while (remainingWraps >= wrap)
        {
            // Вычисляем, сколько шоколадок можно получить за остаточные обертки
            extraChocolates = remainingWraps / wrap;

            // Добавляем шоколадки, получаемые за остаточные обертки,
            // и учитываем новые остаточные обертки
            chocolates += extraChocolates;
            remainingWraps = remainingWraps % wrap + extraChocolates;
        }

        Console.WriteLine("Максимум шоколадок, которые можно получить: " + chocolates);
    }
}