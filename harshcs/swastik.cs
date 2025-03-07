using System;

class SwastikaPattern
{
    // Function to print swastika pattern
    static void Swastika(int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                // checking if i < row/2
                if (i < row / 2)
                {
                    // checking if j < col/2
                    if (j < col / 2)
                    {
                        // print '*' if j = 0
                        if (j == 0)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                    // check if j = col/2 
                    else if (j == col / 2)
                        Console.Write("* ");
                    else
                    {
                        // if i=0 then first row 
                        // will have '*'
                        if (i == 0)
                            Console.Write("* ");
                    }
                }
                else if (i == row / 2)
                    Console.Write("* ");
                else
                {
                    // middle column and last column 
                    // will have '*' after i > row/2
                    if (j == col / 2 || j == col - 1)
                        Console.Write("* ");
                    // last row
                    else if (i == row - 1)
                    {
                        // last row will be have '*' if 
                        // j <= col/2 or if it is last column
                        if (j <= col / 2 || j == col - 1)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                    else
                        Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }

    // Driver code
    public static void Main()
    {
        Console.Write("Enter an odd number of rows: ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter an odd number of columns: ");
        int col = Convert.ToInt32(Console.ReadLine());

        // Ensure the values are odd
        if (row % 2 == 0 || col % 2 == 0)
        {
            Console.WriteLine("Please enter only odd numbers for rows and columns.");
            return;
        }

        // Function calling
        Swastika(row, col);
    }
}
