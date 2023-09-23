Console.WriteLine(GetSecontDigit(658));
Console.WriteLine(GetSecontDigit(704) + "\n");

Console.WriteLine(GetThirdDigit(77118829));
Console.WriteLine(GetThirdDigit(2) + "\n");

Console.WriteLine(IsItAWeekday(4));
Console.WriteLine(IsItAWeekday(28));
Console.WriteLine(IsItAWeekday(15));
Console.WriteLine(IsItAWeekday(6));
Console.WriteLine(IsItAWeekday(7));


char GetSecontDigit(int number) {
    return number.ToString()[1];
}

char GetThirdDigit(int number) {
    try {
        return number.ToString()[2];
    } catch (Exception e) {
        Console.WriteLine("третьей цифры нет");
    }
    return '\0';
}

string IsItAWeekday(int num) {
    if ((num % 6 == 0) || (num % 7 == 0)) {
        return "да";
    }

    return "нет";
}
