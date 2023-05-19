class Program {
    static void Main(string[] args) {
        Console.Write("Enter the row number of Pascal's triangle: ");
        int rowNumber = int.Parse(Console.ReadLine());

        if (rowNumber < 0)
        {
            Console.WriteLine("Invalid Pascal's triangle row number.");
        }
        else
        {
            for (int row = 0; row <= rowNumber; row++)
            {
                for (int space = 0; space < rowNumber - row; space++)
                {
                    Console.Write("  "); 
                }

                for (int col = 0; col <= row; col++)
                {
                    int coefficient = CalculateCoefficient(row, col);
                    Console.Write($"{coefficient,-4} ");
                }

                Console.WriteLine();
            }
        }
    }

    static int CalculateCoefficient(int n, int k) {
        if (k == 0 || k == n)
        {
            return 1;
        }
        else
        {
            return CalculateCoefficient(n - 1, k - 1) + CalculateCoefficient(n - 1, k);
        }
    }
}