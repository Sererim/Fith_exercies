
int Main()
{

    ushort size = 5;
    ushort load = 0;
    
    int[] arr = new int [size];

    arr = Homework.GetMatrix(size);

    Homework.ShowMatrix(arr);

    Console.WriteLine($"~{Homework.GetEven(arr)}~");

    Console.WriteLine($"~{Homework.GetOddSum(arr)}~");

    Console.WriteLine($"~{Homework.SortAndGetMinAndMax(arr)}~");

    return 0;

}

Main();

class Homework{

    // Method for an array generation, because there are multiple arrays to be generated.
    // Still main will have only one array.
    public static int[] GetMatrix(ushort size)
    {
        int[] matrix = new int [size];
        Random rand = new Random();

        for(int i = 0; i < matrix.Length; i++)
            matrix[i] = rand.Next(-1000, 1000);

        return matrix;
    }

    // Method for showing an array.
    public static void ShowMatrix(int[] matrix)
    {
        for(int i = 0; i < matrix.Length; i++)
            Console.Write($"|{matrix[i]}| ");
        Console.WriteLine();
    }

    // Method for counting even numbers.
    public static ushort GetEven(int[] matrix)
    {
        ushort foo = 0;
        foreach(int i in matrix)
            if(i % 2 == 0)
                foo++;
        
        return foo;
    }

    // Method for finding a sum of numbers at odd positions.
    public static int GetOddSum(int[] matrix)
    {
        int foo = 0;
        for(int i = 0; i < matrix.Length; i++)
            if(i % 2 != 0)
                foo += matrix[i];
        
        return foo;
    }

    // Method for finding a difference between max and min elements in an array.
     public static int SortAndGetMinAndMax(int[] matrix)
    {
        int foo = matrix[0], bar = matrix[1];

        for(int i = 0; i < matrix.Length; i++)
        {
            if(foo < matrix[i])
                foo = matrix[i];

            if(bar > matrix[i])
                bar = matrix[i];
        }
        foo -= bar;
        return foo;
    }
}