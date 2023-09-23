GetMax(1, 2);
GetMax(124, 5);

Console.WriteLine(GetMaxOfThree(1, 2, 3) + "\n");
Console.WriteLine(GetMaxOfThree(1, 8, 3) + "\n");
Console.WriteLine(GetMaxOfThree(10, 2, 3) + "\n");

Console.WriteLine(IsEven(9) + "\n");
Console.WriteLine(IsEven(8) + "\n");

Array.ForEach(GetEvenNumbersUpToNumber(10), Console.WriteLine);
Console.WriteLine("\n");
Array.ForEach(GetEvenNumbersUpToNumber(21), Console.WriteLine);

void GetMax(int num1, int num2) {
    Console.WriteLine("max = " + Math.Max(num1, num2) + "\n");
}

int GetMaxOfThree(int num1, int num2, int num3) {
    return Math.Max(num1, (Math.Max(num2, num3)));
}

bool IsEven(int number) {
    return number % 2 == 0;
}

int[] GetEvenNumbersUpToNumber(int number) {
    int[] nums = new int[number/2 + 1];

    for (int i = 2; i < number; i = i + 2) {
        nums[i/2] = i;
    }

    return nums;
}

