// Определите, является ли число степенью двойки:
//N = 16 -> "Является степень двойки"
//N = 12 -> “Не является степенью двойки”
 

 
class Program
{
    static void Main(string[] args)
    {Console.WriteLine("введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        if (step(a)) Console.WriteLine($"число {a} является степень двойки");
        else Console.WriteLine($"число {a} не является степенью двойки");
        Console.WriteLine();
    }
    public static bool step(int a)
    {
        if (a == 2) return true;
        else if (a % 2 == 0) return step(a / 2);
        else return false;
    }
}
