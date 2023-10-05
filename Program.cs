Console.WriteLine(CountEven(CreateRandomArray(2, 5555, 7)));

Console.WriteLine(GetSumOnOddPositions(CreateRandomArray(100, 500, 10)));

Console.WriteLine(GetDifferenceBetweenMaxAndMin(CreateRandomDoubleArray(1, 200, 8)));

int[] CreateRandomArray(int min, int max, int size) {
    int[] result = new int[size];
    Random random = new Random();

    for(int i = 0; i < size; i++) {
        result[i] = random.Next(min, max);
    }

    return result;
}

double[] CreateRandomDoubleArray(double min, double max, int size) {
    double[] result = new double[size];
    Random random = new Random();

    for(int i = 0; i < size; i++) {
        result[i] = random.NextDouble() * (max - min) + min;
    }

    return result;
}

int CountEven(int[] numbers) {
    int result = 0;

    for(int i = 0; i < numbers.Length; i++) {
        if(numbers[i]%2==0) {
            result++;
        }
    }

    return result;
}

int GetSumOnOddPositions(int[] numbers) {
    int result = 0;

    for(int i = 0; i < numbers.Length; i++) {
        if(i%2==1) {
            result += numbers[i];
        }
    }

    return result;
}

double GetDifferenceBetweenMaxAndMin(double[] numbers) {
    double max = numbers[0];
    double min = numbers[0];

    for(int i = 0; i < numbers.Length; i++) {
        if(numbers[i] < min) {
            min = numbers[i];
        }

        if(numbers[i] > max) {
            max = numbers[i];
        }
    }

    return max - min;
}