Console.WriteLine(Pow(PowPrompt()));

Console.WriteLine(GetDigitSum(DigitsPrompt()));

GetArray();

int[] PowPrompt() {
    Console.Write("Task25. Please, input number you want to raise to a power and power separated by comma: ");
    return Array.ConvertAll(Console.ReadLine().Split(","), num => int.Parse(num));
}

int Pow(int[] values) {
    int res = values[0];
    for(int i = 0; i < values[1] - 1; i++) {
        res *= values[0];
    }

    return res;
}

int DigitsPrompt() {
    Console.Write("Task27. Please, input your number: ");
    return int.Parse(Console.ReadLine());
}

int GetDigitSum(int num) {
    char[] digitArray = num.ToString().ToCharArray();
    int res = 0;

    for(int i = 0; i < digitArray.Length; i++) {
        res += digitArray[i] - '0';
    }

    return res;
}

void GetArray() {
    int[] values = new int[8];
    Console.Write("Task29. Please, input your numbers separated by commas: ");
    values = Array.ConvertAll(Console.ReadLine().Split(","), num => int.Parse(num));
    Console.WriteLine("[" + string.Join(", ", values) + "]");
}