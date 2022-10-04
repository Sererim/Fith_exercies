
int Main()
{

    ushort size = 5;
    
    int[] arr = new int [size];

    arr = Homework.GetMatrix(size);

    Homework.ShowMatrix(arr);

    Console.WriteLine();
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


}