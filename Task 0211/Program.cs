// Проверка на простое число: N = 13 -> "Это простое число"
//N = 12 -> “Это не простое число”
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
        if (number == 1)
        {    return;}

        for (int i = 2; i < number / 2 + 1; i++)
        {
            bool isPrime = (number % i == 0);

            if (isPrime)
            {
                Console.WriteLine("Число {0} не является простым", number);
                return;
            }
        }
        Console.WriteLine("Число {0} является простым", number);
