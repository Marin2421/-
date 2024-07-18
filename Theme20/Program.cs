Console.WriteLine("Введите число: ");
int num;
int.TryParse(Console.ReadLine(), out num);
Console.WriteLine("Выберите операцию:");
Console.WriteLine("1. Логическое побитовое умножение");
Console.WriteLine("2. Логическое побитовое сложение");
Console.WriteLine("3. Шифрование по ключу");
Console.WriteLine("4. Инверсия");
int choice = int.Parse(Console.ReadLine()!);
int Result()
{
    int BitwiseAnd(int a, int b)
    {
        return a & b;
    }

    int BitwiseOr(int a, int b)
    {
        return a | b;
    }

    int Encrypt(int a, int key)
    {
        return a ^ key;
    }

    int Invert(int a)
    {
        return ~a;
    }

    switch (choice)
    {
        case 1:
            Console.WriteLine("Введите второе число для побитового умножения:");
            int b1 = int.Parse(Console.ReadLine());
            return BitwiseAnd(num, b1);
        case 2:
            Console.WriteLine("Введите второе число для побитового сложения:");
            int b2 = int.Parse(Console.ReadLine());
            return BitwiseOr(num, b2);
        case 3:
            Console.WriteLine("Введите ключ для шифрования:");
            int key = int.Parse(Console.ReadLine());
            return Encrypt(num, key);
        case 4:
            return Invert(num);
        default:
            Console.WriteLine("Неверный выбор операции.");
            return 0;
    }
}
int result = Result();
Console.WriteLine($"Результат: {result}");
