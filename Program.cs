Console.WriteLine("There are " + CountNumbersMoreThanZero(6) + " more than 0");

double[] coords = GetPoint();
Console.Write("Your point is: (" + coords[0] + ", " + coords[1] + ")");

int CountNumbersMoreThanZero(int m) {
    int res = 0;
    for(int i = 0; i < m; i++) {
        Console.Write("Please, input number: ");
        if(Int32.Parse(Console.ReadLine()) > 0) {
            res++;
        }
    }

    return res;
}

double[] GetPoint() {
    Console.WriteLine("You are going to input coefficients for 2 lines: y = k1 * x + b1 and y = k2 * x + b2");
    Console.Write("Please, input k1: ");
    double k1 = Double.Parse(Console.ReadLine());
    Console.Write("Please, input b1: ");
    double b1 = Double.Parse(Console.ReadLine());
    Console.Write("Please, input k2: ");
    double k2 = Double.Parse(Console.ReadLine());
    Console.Write("Please, input b2: ");
    double b2 = Double.Parse(Console.ReadLine());

    try {
        double x = (b1 - b2)/(k1 - k2);
        double y = k1 * x + b1;

        return new double[] {x, y};
    } catch(Exception e) {
        Console.WriteLine("There is no intersection point between 2 lines");
        throw e;
    }
}