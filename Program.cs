using System;
class Program
{
    // 1. Создание
    public static string CreatePhoneNumber(int[] numbers)
    {
        if (numbers.Length != 10)
        {
            return "Российский номер не выйдет";
        }

        string phonum = "8(" + numbers[0] + numbers[1] + numbers[2] + ") " +numbers[3] + numbers[4] + numbers[5] + "-" + numbers[6] + numbers[7] + numbers[8] + numbers[9];
        return phonum;
    }
    // 2. Обрезание
    public static string TrimString(string phr, int L)
    {
        if (L <= 3)
        {
            if (phr.Length > L)
            {
                return phr.Substring(0, L) + "...";
            }
            else
            {
                return phr;
            }
        }
        else
        {
            if (phr.Length > L)
            {
                return phr.Substring(0, L - 3) + "...";
            }
            else
            {
                return phr;
            }
        }
    }
    // 3. Квадраты
    public static long SquareDigits(long n)
    {
        string result = "";
        string number = n.ToString();

        for (int i = 0; i < number.Length; i++)
        {
            int digit = int.Parse(number[i].ToString());
            result += (digit * digit).ToString();
        }

        return long.Parse(result);
    }
    // 4. Лайки
    public static string Likes(string[] names)
    {
        if (names.Length == 0)
        {
            return "no one likes this";
        }
        else if (names.Length == 1)
        {
            return names[0] + " like this";
        }
        else if (names.Length == 2)
        {
            return names[0] + " and " + names[1] + " likes this";
        }
        else if (names.Length == 3)
        {
            return names[0] + ", " + names[1] + " and " + names[2] + " likes this";
        }
        else
        {
            return names[0] + ", " + names[1] + " and " + (names.Length - 2) + " others likes this";
        }
    }
    static void Main()
    {
        // 1.
        int[] phone = { 9, 1, 3, 8, 5, 1, 3, 4, 1, 7 };
        Console.WriteLine(CreatePhoneNumber(phone));
        // 2.
        Console.WriteLine(TrimString("Writing code is fun", 14));
        Console.WriteLine(TrimString("Hello world!", 7));
        Console.WriteLine(TrimString("THE WORLD", 8)); 
        // 3.
        Console.WriteLine(SquareDigits(9267));
        // 4.
        Console.WriteLine(Likes(new string[] { })); 
        Console.WriteLine(Likes(new string[] { "Karen" })); 
        Console.WriteLine(Likes(new string[] { "Bosco", "Miner" })); 
        Console.WriteLine(Likes(new string[] { "Konor", "Moron", "BMW" })); 
        Console.WriteLine(Likes(new string[] { "AUDI", "Javlon", "Moscow", "Magadan" })); 
    }
}