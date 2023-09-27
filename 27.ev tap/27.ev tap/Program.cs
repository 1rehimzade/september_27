
Console.Write("Ededi daxil edin: ");
int eded = int.Parse(Console.ReadLine());

bool quvvvetIkdir = ikininustu(eded);

if (quvvvetIkdir)
{
    Console.WriteLine($"{eded} 2-nin quvvetidir.");
}
else
{
    Console.WriteLine($"{eded} 2-nin quvveti deyil.");
}

static bool ikininustu(int num)
{
    if (num <= 0)
    {
        return false;
    }

    return (num & (num - 1)) == 0;
}

//Task 2

//Console.Write("N-i daxil edin: ");
//int N = int.Parse(Console.ReadLine());

//Console.Write("Digit-i daxil edin: ");
//int digit = int.Parse(Console.ReadLine());

//int count = CountDigitsInRange(N, digit);

//Console.WriteLine($"1-den {N}-e qeder olan ededler arasında {digit} ededi {count} defe tekrarlanır.");


//static int CountDigitsInRange(int N, int digit)
//{
//    int count = 0;

//    for (int i = 1; i <= N; i++)
//    {
//        int num = i;

//        while (num > 0)
//        {
//            int lastDigit = num % 10;
//            if (lastDigit == digit)
//            {
//                count++;
//            }
//            num /= 10;
//        }
//    }

//    return count;
//}

//Task 3
//Console.Write("ededi daxil edin: ");
//int eded = int.Parse(Console.ReadLine());

//bool mukemmel = IsPerfectNumber(eded);

//Console.WriteLine($"Mükemmel edəd: {mukemmel}");


//    static bool IsPerfectNumber(int number)
//{
//    if (num <= 1)
//    {
//        return false;
//    }

//    int cemiBolenler = 1; // ededin özünü daxil etdik

//    for (int i = 2; i <= Math.Sqrt(num); i++)
//    {
//        if (num % i == 0)
//        {
//            if (i == (num / i))
//            {
//                cemiBolenler += i;
//            }
//            else
//            {
//                cemiBolenler += (i + num / i);
//            }
//        }
//    }

//    return cemiBolenler == num;
//}
//Task 4

//Console.Write("ededi daxil edin: ");
//int eded = int.Parse(Console.ReadLine());

//string binary = DecimalToBinary(eded);

//Console.WriteLine($"Ədədin 2-lik say sistemindəki qarşılığı: {binary}");


//    static string DecimalToBinary(int number)
//{
//    if (num == 0)
//    {
//        return "0";
//    }

//    string binary = "";

//    while (num > 0)
//    {
//        int remainder = num % 2;
//        binary = remainder + binary;
//        num /= 2;
//    }

//    return binary;

//}

//Task 5
//Console.Write("ededi daxil edin: ");
//int N = int.Parse(Console.ReadLine());

//int minDigit = FindMinDigit(N);
//int maxDigit = FindMaxDigit(N);

//int result = minDigit * maxDigit;

//Console.WriteLine($"en kiçik rəqəm: {minDigit}");
//Console.WriteLine($"en böyük rəqəm: {maxDigit}");
//Console.WriteLine($"Hasil: {result}");


//    static int FindMinDigit(int num)
//{
//    int minDigit = 9;

//    while (num > 0)
//    {
//        int digit = num % 10;
//        if (digit < minDigit)
//        {
//            minDigit = digit;
//        }
//        num /= 10;
//    }

//    return minDigit;
//}

//static int FindMaxDigit(int num)
//{
//    int maxDigit = 0;

//    while (num > 0)
//    {
//        int digit = num % 10;
//        if (digit > maxDigit)
//        {
//            maxDigit = digit;
//        }
//        num /= 10;
//    }

//    return maxDigit;
//}

//task 6
//Console.Write("N-i daxil edin: ");
//int N = int.Parse(Console.ReadLine());

//for (int i = 1; i <= N; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine(); 
//}