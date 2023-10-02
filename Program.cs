Console.WriteLine(Pow(3, 5));
Console.WriteLine(Pow(2, 4) + '\n');

Console.WriteLine(GetDigitSum(82 ));
Console.WriteLine(GetDigitSum(452 ));
Console.WriteLine(GetDigitSum(9012 ) + "\n");

GetArray(1, 2, 5, 7, 19);
GetArray(6, 1, 33);


int Pow(int number, int power) {
    int res = number;
    for(int i = 0; i < power; i++) {
        res *= number;
    }

    return res;
}

int GetDigitSum(int num) {
    char[] digitArray = num.ToString().ToCharArray();
    int res = 0;

    for(int i = 0; i < digitArray.Length; i++) {
        res += digitArray[i] - '0';
    }

    return res;
}

void GetArray(params int[] arrayInitValues) {
    Console.WriteLine("[" + string.Join(", ", arrayInitValues) + "]");
}