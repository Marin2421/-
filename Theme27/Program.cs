class Program
{
    static void Main(string[] args)
    {
        Console.Write("Укажите количество рублей: ");
        decimal rubles = decimal.Parse(Console.ReadLine()!);
        decimal rubleToDollar = Converter.ToDollars(rubles);
        decimal rubleToEuros = Converter.ToEuros(rubles);
        decimal rubleToZlotus = Converter.ToZlotus(rubles);
        decimal rubleToYuan = Converter.ToYuan(rubles);
        decimal rubleToRupes = Converter.ToRupes(rubles);
        Console.WriteLine($"В долларах: {rubleToDollar:F2}");
        Console.WriteLine($"В евро: {rubleToEuros:F2}");
        Console.WriteLine($"В злотах: {rubleToZlotus:F2}");
        Console.WriteLine($"В юанях: {rubleToYuan:F2}");
        Console.WriteLine($"В рупи: {rubleToRupes:F2}");
    }
}
class Converter
{
    public static decimal ToDollars(decimal rubles)
    {
        return rubles* 0.01138m;
    }
    public static decimal ToEuros(decimal rubles)
    {
        return rubles * 0.010406m;
    }
    public static decimal ToZlotus(decimal rubles)
    {
        return rubles * 0.044718m;
    }
    public static decimal ToYuan(decimal rubles)
    {
        return rubles * 0.083176m;
    }
    public static decimal ToRupes(decimal rubles)
    {
        return rubles * 0.951792m;
    }
}