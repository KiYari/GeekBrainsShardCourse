PrintNaturalNumbersSince(5);
Console.WriteLine(GetNaturalSum(1, 15));
Console.WriteLine(GetNaturalSum(4, 8));

Console.WriteLine(Ackermann(2, 3));
Console.WriteLine(Ackermann(3, 2));

int PrintNaturalNumbersSince(int N) {
    if(N == 1) {
        System.Console.WriteLine(1);
        return 1;
    }
    System.Console.Write(N + ", ");
    return PrintNaturalNumbersSince(N -1);
}


int GetNaturalSum(int start, int stop) {
    if (stop == start) {
        return start;
    }
    return stop + GetNaturalSum(start, stop - 1);
}

int Ackermann(int m, int n) {
        if (m == 0) {
            return n + 1;
        } else if ((m > 0) && (n == 0)) {
            return Ackermann(m - 1, 1);
        } else if ((m > 0) && (n > 0)) {
            return Ackermann(m - 1, Ackermann(m, n - 1)); 
        } else {
            return n + 1;
        }
    }